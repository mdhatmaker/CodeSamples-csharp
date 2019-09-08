//-----------------------------------------------------------
//-----------------------------------------------------------
//
//             System: IQFeed
//       Program Name: HistorySocket_VC#.exe
//        Module Name: HistorySocketForm.cs
//
//-----------------------------------------------------------
//
//            Proprietary Software Product
//
//                    Telvent DTN
//           9110 West Dodge Road Suite 200
//               Omaha, Nebraska  68114
//
//          Copyright (c) by Schneider Electric 2015
//                 All Rights Reserved
//
//
//-----------------------------------------------------------
// Module Description: Implementation of History via Sockets
//         References: None
//           Compiler: Microsoft Visual Studio Version 2010
//             Author: Steven Schumacher
//        Modified By: 
//
//-----------------------------------------------------------
//-----------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// added for access to RegistryKey
using Microsoft.Win32;
// added for access to socket classes
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Linq;
using System.IO;
using IQ_Config_Namespace;
using System.Diagnostics;

namespace HistorySocket
{
    public partial class HistorySocketForm : Form
    {
        public delegate void UpdateDataHandler(string sMessage);            // delegate for updating the data display

        HistorySocketThread m_historyThread = new HistorySocketThread();

        string m_protocol = "";

        /// <summary>
        /// Constructor for the form
        /// </summary>
        public HistorySocketForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the form load event.  
        ///     It controls updating the form controls and initializing the connection to IQFeed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistorySocketForm_Load(object sender, EventArgs e)
        {
            //IQ_Config config = new IQ_Config();
            lstData.Columns.Add("Data received", -2);
            lstData.Columns[0].Width -= System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;

            // populate the request type dropdown   
            cboHistoryType.Items.Add("Tick Datapoints");
            cboHistoryType.Items.Add("Tick Days");
            cboHistoryType.Items.Add("Tick Timeframe");
            cboHistoryType.Items.Add("Interval Datapoints");
            cboHistoryType.Items.Add("Interval Days");
            cboHistoryType.Items.Add("Interval Timeframe");
            cboHistoryType.Items.Add("Daily Datapoints");
            cboHistoryType.Items.Add("Daily Timeframe");
            cboHistoryType.Items.Add("Weekly Datapoints");
            cboHistoryType.Items.Add("Monthly Datapoints");

            cboHistoryType.SelectedIndex = 7;
        }

        /// <summary>
        /// We want to be able to update the winform status listbox from within the AsyncSocket Callback 
        /// so we need a delagate to resolve cross-threading issues.
        /// </summary>
        /// <param name="sData"></param>
        public void UpdateListview(string sData)
        {
            try
            {
                // check if we need to invoke the delegate
                if (lstData.InvokeRequired)
                {
                    // call this function again using a delegate
                    this.Invoke(new UpdateDataHandler(UpdateListview), sData);
                }
                else
                {
                    // delegate not required, just update the list box.
            List<String> lstMessages = new List<string>(sData.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
                    lstData.BeginUpdate();
            lstMessages.ForEach(delegate(String sLine)
            {
                lstData.Items.Add(sLine);
            });
                    lstData.EndUpdate();

                    tssRight.Text = lstData.Items.Count.ToString();
                }
            }
            catch (ObjectDisposedException)
            {
                // The list view object went away, ignore it since we're probably exiting.
            }
        }

        /// <summary>
        /// Event handler for when the user clicks the GetData button.  It forms the request that will be sent to
        ///     IQFeed based upon user input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetData_Click(object sender, EventArgs e)
        {
            // clear previous request data
            string sRequest = "";

            // format request string based upon user input
            if (cboHistoryType.Text.Equals("Tick Datapoints"))
            {
                // request in the format:
                // HTX,SYMBOL,NUMDATAPOINTS,DIRECTION,REQUESTID,DATAPOINTSPERSEND<CR><LF>
                sRequest = String.Format("HTX,{0},{1},{2},{3},{4}\r\n", txtSymbol.Text, txtDatapoints.Text, txtDirection.Text, txtRequestID.Text, txtDatapointsPerSend.Text);
            }
            else if (cboHistoryType.Text.Equals("Tick Days"))
            {
                // request in the format:
                // HTD,SYMBOL,NUMDAYS,MAXDATAPOINTS,BEGINFILTERTIME,ENDFILTERTIME,DIRECTION,REQUESTID,DATAPOINTSPERSEND<CR><LF>
                sRequest = String.Format("HTD,{0},{1},{2},{3},{4},{5},{6},{7}\r\n", txtSymbol.Text, txtDays.Text, txtDatapoints.Text, txtBeginFilterTime.Text, txtEndFilterTime.Text, txtDirection.Text, txtRequestID.Text, txtDatapointsPerSend.Text);
            }
            else if (cboHistoryType.Text.Equals("Tick Timeframe"))
            {
                // request in the format:
                // HTT,SYMBOL,BEGINDATE BEGINTIME,ENDDATE ENDTIME,MAXDATAPOINTS,BEGINFILTERTIME,ENDFILTERTIME,DIRECTION,REQUESTID,DATAPOINTSPERSEND<CR><LF>
                sRequest = String.Format("HTT,{0},{1},{2},{3},{4},{5},{6},{7},{8}\r\n", txtSymbol.Text, txtBeginDateTime.Text, txtEndDateTime.Text, txtDatapoints.Text, txtBeginFilterTime.Text, txtEndFilterTime.Text, txtDirection.Text, txtRequestID.Text, txtDatapointsPerSend.Text);
            }
            else if (cboHistoryType.Text.Equals("Interval Datapoints"))
            {
                // validate interval type
                string sIntervalType = "s";
                if (rbVolume.Checked)
                {
                    sIntervalType = "v";
                }
                else if (rbTick.Checked)
                {
                    sIntervalType = "t";
                }

                // request in the format:
                // HIX,SYMBOL,INTERVAL,NUMDATAPOINTS,DIRECTION,REQUESTID,DATAPOINTSPERSEND,INTERVALTYPE<CR><LF>
                sRequest = String.Format("HIX,{0},{1},{2},{3},{4},{5},{6}\r\n", txtSymbol.Text, txtInterval.Text, txtDatapoints.Text, txtDirection.Text, txtRequestID.Text, txtDatapointsPerSend.Text, sIntervalType);
            }
            else if (cboHistoryType.Text.Equals("Interval Days"))
            {
                // validate interval type
                string sIntervalType = "s";
                if (rbVolume.Checked)
                {
                    sIntervalType = "v";
                }
                else if (rbTick.Checked)
                {
                    sIntervalType = "t";
                }

                // request in the format:
                // HID,SYMBOL,INTERVAL,NUMDAYS,MAXDATAPOINTS,BEGINFILTERTIME,ENDFILTERTIME,DIRECTION,REQUESTID,DATAPOINTSPERSEND,INTERVALTYPE<CR><LF>
                sRequest = String.Format("HID,{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}\r\n", txtSymbol.Text, txtInterval.Text, txtDays.Text, txtDatapoints.Text, txtBeginFilterTime.Text, txtEndFilterTime.Text, txtDirection.Text, txtRequestID.Text, txtDatapointsPerSend.Text, sIntervalType);
            }
            else if (cboHistoryType.Text.Equals("Interval Timeframe"))
            {
                // validate interval type
                string sIntervalType = "s";
                if (rbVolume.Checked)
                {
                    sIntervalType = "v";
                }
                else if (rbTick.Checked)
                {
                    sIntervalType = "t";
                }

                // request in the format:
                // HIT,SYMBOL,INTERVAL,BEGINDATE BEGINTIME,ENDDATE ENDTIME,MAXDATAPOINTS,BEGINFILTERTIME,ENDFILTERTIME,DIRECTION,REQUESTID,DATAPOINTSPERSEND,INTERVALTYPE<CR><LF>
                sRequest = String.Format("HIT,{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}\r\n", txtSymbol.Text, txtInterval.Text, txtBeginDateTime.Text, txtEndDateTime.Text, txtDatapoints.Text, txtBeginFilterTime.Text, txtEndFilterTime.Text, txtDirection.Text, txtRequestID.Text, txtDatapointsPerSend.Text, sIntervalType);
            }
            else if (cboHistoryType.Text.Equals("Daily Datapoints"))
            {
                // request in the format:
                // HDX,SYMBOL,NUMDATAPOINTS,DIRECTION,REQUESTID,DATAPOINTSPERSEND<CR><LF>
                sRequest = String.Format("HDX,{0},{1},{2},{3},{4}\r\n", txtSymbol.Text, txtDatapoints.Text, txtDirection.Text, txtRequestID.Text, txtDatapointsPerSend.Text);
            }
            else if (cboHistoryType.Text.Equals("Daily Timeframe"))
            {
                // request in the format:
                // HDT,SYMBOL,BEGINDATE,ENDDATE,MAXDATAPOINTS,DIRECTION,REQUESTID,DATAPOINTSPERSEND<CR><LF>
                sRequest = String.Format("HDT,{0},{1},{2},{3},{4},{5},{6}\r\n", txtSymbol.Text, txtBeginDateTime.Text, txtEndDateTime.Text, txtDatapoints.Text, txtDirection.Text, txtRequestID.Text, txtDatapointsPerSend.Text);
            }
            else if (cboHistoryType.Text.Equals("Weekly Datapoints"))
            {
                // request in the format:
                // HWX,SYMBOL,NUMDATAPOINTS,DIRECTION,REQUESTID,DATAPOINTSPERSEND<CR><LF>
                sRequest = String.Format("HDX,{0},{1},{2},{3},{4}\r\n", txtSymbol.Text, txtDatapoints.Text, txtDirection.Text, txtRequestID.Text, txtDatapointsPerSend.Text);
            }
            else if (cboHistoryType.Text.Equals("Monthly Datapoints"))
            {
                // request in the format:
                // HMX,SYMBOL,NUMDATAPOINTS,DIRECTION,REQUESTID,DATAPOINTSPERSEND<CR><LF>
                sRequest = String.Format("HDX,{0},{1},{2},{3},{4}\r\n", txtSymbol.Text, txtDatapoints.Text, txtDirection.Text, txtRequestID.Text, txtDatapointsPerSend.Text);
            }
            else
            {
                // something unexpected happened
                sRequest = "Error Processing Request.";
            }

            // verify we have formed a request string
            if (!sRequest.StartsWith("H"))
            {
                string sError = String.Format("{0}\r\nRequest type selected was: {1}", sRequest, cboHistoryType.Text);
                UpdateListview(sError);
                return;
            }

            display(sRequest);
            Clipboard.SetText(sRequest);
            SendRequest(sRequest);

            ListResults();
        }

        /// <summary>
        /// Handles when the user changes the data in the request type combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboHistoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // grab the text from the newly selected value
            string sSelection = ((ComboBox)sender).Text;

            // disable all the controls.  we will re-enable them depending on the request type selected
            DisableForm();

            // enable controls that are used for every request
            lstData.Enabled = true;
            btnGetData.Enabled = true;
            txtSymbol.Enabled = true;
            cboHistoryType.Enabled = true;
            txtRequestID.Enabled = true;
            txtDirection.Enabled = true;
            txtDatapointsPerSend.Enabled = true;
            txtDatapoints.Enabled = true;
            rbTick.Enabled = false;
            rbTime.Enabled = false;
            rbVolume.Enabled = false;
            btnGetHistory.Enabled = true;

            if ((sSelection.Equals("Tick Datapoints")) || (sSelection.Equals("Interval Datapoints"))
                || (sSelection.Equals("Daily Datapoints")) || (sSelection.Equals("Weekly Datapoints"))
                || (sSelection.Equals("Monthly Datapoints")))
            {
                // for interval datapoints request, we also need the interval
                if (sSelection.Equals("Interval Datapoints"))
                {
                    txtInterval.Enabled = true;
                    rbTick.Enabled = true;
                    rbTime.Enabled = true;
                    rbVolume.Enabled = true;
                }
            }
            else if (sSelection.Equals("Tick Days"))
            {
                // enable controls available for tick days request
                txtDays.Enabled = true;
                txtBeginFilterTime.Enabled = true;
                txtEndFilterTime.Enabled = true;
            }
            else if (sSelection == "Tick Timeframe")
            {
                // enable controls available for tick timeframe request
                txtBeginDateTime.Enabled = true;
                txtEndDateTime.Enabled = true;
                txtBeginFilterTime.Enabled = true;
                txtEndFilterTime.Enabled = true;
            }
            else if (sSelection == "Interval Days")
            {
                // enable controls available for Interval days request
                txtInterval.Enabled = true;
                txtDays.Enabled = true;
                txtBeginFilterTime.Enabled = true;
                txtEndFilterTime.Enabled = true;
                rbTick.Enabled = true;
                rbTime.Enabled = true;
                rbVolume.Enabled = true;
            }
            else if (sSelection == "Interval Timeframe")
            {
                // enable controls available for Interval timeframe request
                txtInterval.Enabled = true;
                txtBeginDateTime.Enabled = true;
                txtEndDateTime.Enabled = true;
                txtBeginFilterTime.Enabled = true;
                txtEndFilterTime.Enabled = true;
                rbTick.Enabled = true;
                rbTime.Enabled = true;
                rbVolume.Enabled = true;
            }
            else if (sSelection == "Daily Timeframe")
            {
                // enable controls available for Daily timeframe request
                txtBeginDateTime.Enabled = true;
                txtEndDateTime.Enabled = true;
            }
        }

        /// <summary>
        /// Disables all the controls on the form.
        /// </summary>
        private void DisableForm()
        {
            // Disable this for now
            return;

            foreach (Control c in this.Controls)
            {
                if (!(c is Label))
                {
                    c.Enabled = false;
                }
            }
        }


        private void AfterHistoryReceived()
        {
            tssMain.Text = "Done.";

            string exe_path = System.Reflection.Assembly.GetEntryAssembly().Location;
            string filename = System.IO.Path.Combine(exe_path, "my_output.txt");

            /*
            foreach (string msg in m_receivedData)
            {
                System.Console.WriteLine(msg);
            }*/
        }


        private void ExecuteThread(ThreadStart work)
        {
            m_historyThread.WaitingForData = true;
            new Thread(work).Start();

            while (m_historyThread.WaitingForData == true)
            {
                Thread.Sleep(100);
            }

            Console.WriteLine("m_historyThread thread has finished");
        }

        private void SendRequest(string sRequest)
        {
            ThreadStart work = delegate {
                m_historyThread.SendRequest(sRequest);
            };

            ExecuteThread(work);
        }

        private void GetHistory(string symbol, int dayCount)
        {
            ThreadStart work = delegate {
                m_historyThread.GetHistory(symbol, dayCount);
                //var result = m_historyThread.GetHistory("QHON17", 1);
                // push result somewhere; might involve a UI
                // thread switch
            };

            ExecuteThread(work);
        }

        private void GetDailyHistory(string symbol, DateTime dtStart, DateTime dtEnd)
        {
            string startDate = G.GetIQDate(dtStart);
            string endDate = G.GetIQDate(dtEnd);
            string sRequest = string.Format("HDT,{0},{1},{2},,,,", symbol, startDate, endDate);
            SendRequest(sRequest);
        }

        private void GetIntervalHistory(string symbol, Interval interval, DateTime dtStart, DateTime dtEnd)
        {
            GetIntervalHistory(symbol, (int)interval, dtStart, dtEnd);
        }

        private void GetIntervalHistory(string symbol, int intervalSeconds, DateTime dtStart, DateTime dtEnd)
        {
            string startDateTime = G.GetIQDateTime(dtStart);
            string endDateTime = G.GetIQDateTime(dtEnd);
            string sRequest = string.Format("HIT,{0},{1},{2},{3},,,,,,,s", symbol, intervalSeconds, startDateTime, endDateTime);
            SendRequest(sRequest);
        }

        private void ListResults()
        {
            lstData.Items.Clear();
            Application.DoEvents();
            foreach (string msg in m_historyThread.ReceivedData)
            {
                UpdateListview(msg);
            }
        }

        private void btnGetHistory_Click(object sender, EventArgs e)
        {
            lstData.Items.Clear();
            Application.DoEvents();

            //string folder = @"B:\Users\mhatmaker\Dropbox\alvin\data\DF_DATA";
            string folder = txtHistoricalFolder.Text.Trim();

            string symbol_root = txtSymbolRoot.Text.Trim().ToUpper();  // "QHO";
            int y1 = (int) numFirstYear.Value;
            int y2 = (int) numLastYear.Value;

            var today = DateTime.Now;
            //int mnow = today.Month;
            //int ynow = today.Year;
            //int mend = 3;
            //int yend = 2018;

            //GetHistory("QHO#C", 1);
            //GetHistory("QHOQ17", 1);
            //GetDailyHistory("QHO#C", new DateTime(2017, 1, 1), DateTime.Now);
            //GetIntervalHistory("QHOQ17", Interval.Hour, new DateTime(2017, 1, 1), DateTime.Now);
            //GetIntervalHistory("QHOQ17", Interval.Minute, new DateTime(2017, 7, 1), DateTime.Now);

            //Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            for (int y = y1; y <= y2; ++y)
            {
                for (int m = 1; m <= 12; ++m)
                {
                    //if (y >= yend && m > mend) break;

                    string symbol = symbol_root + G.GetmYY(m, y);

                    var dt2 = new DateTime(y, m, 1);
                    dt2 = dt2.AddMonths(1);
                    dt2 = dt2.AddDays(-1);              // last day of expiration month
                    var dt1 = dt2.AddDays(-365);        // start of historical data from one year earlier

                    display(symbol + " Working...");
                    string filename;
                    string output_columns;
                    if (chkDaily.Checked)
                    {
                        GetDailyHistory(symbol, dt1, dt2);
                        filename = symbol + " (Daily).csv";
                        //output_columns = "Date,Open,High,Low,Close,Volume";
                        output_columns = "DateTime,Open,High,Low,Close,Volume";
                    }
                    else
                    {
                        GetIntervalHistory(symbol, Interval.Minute, dt1, dt2);
                        filename = symbol + " (1 Minute).csv";
                        output_columns = "DateTime,Open,High,Low,Close,Volume";
                    }
                    display("Done.");
                    //UpdateListview(m_historyThread.ReceivedData.Last());
                    int count = m_historyThread.ReceivedData.Count;
                    if (count > 0 && m_historyThread.ReceivedData[0].Contains("CURRENT PROTOCOL"))
                    {
                        m_protocol = m_historyThread.ReceivedData[0];
                        m_historyThread.ReceivedData.RemoveAt(0);
                        count--;
                    }
                    UpdateListview(string.Format("{0}   count: {1}", symbol, count));
                    Application.DoEvents();
                    // TODO: here is where we need to store the retrieved data to a text file

                    if (count > 0)
                    {
                        string pathname = Path.Combine(folder, filename);
                        var data = m_historyThread.ReceivedData;
                        //data[0] = "DateTime,Open,High,Low,Close,Volume";
                        using (StreamWriter file = new StreamWriter(pathname))
                        {
                            file.WriteLine(output_columns);
                            for (int i = data.Count - 1; i > 1; --i)
                            {
                                var columns = data[i].Split(new char[] { ',' });
                                // TODO: convert time from exchange time to local time
                                // If we have Date (rather than DateTime), add a "00:00:00" to make it DateTime
                                /*if (columns[0].Length < 11)
                                {
                                    columns[0] += " 00:00:00";
                                }*/
                                string line = string.Format("{0},{1},{2},{3},{4},{5}", columns[0], columns[1], columns[2], columns[3], columns[4], columns[6]);
                                file.WriteLine(line);
                            }
                        }
                    }

                    //dict[symbol] = (List<string>)m_historyThread.ReceivedData.Clone();
                }
            }

            /*foreach (var k in data.Keys)
            {
                UpdateListview(string.Format("{0}   count: {1}", k, data[k].Count));
            }*/

            //ListResults();
        }

        private void btnDisplayHistory_Click(object sender, EventArgs e)
        {
            ListResults();
        }

        private void display(string msg)
        {
            tssMain.Text = msg;
            Application.DoEvents();
        }

        private void WriteToFile(string filename)
        {
            string folder = txtHistoricalFolder.Text.Trim();
            string pathname = Path.Combine(folder, filename);
            List<string> data = lstData.Items.Cast<ListViewItem>()
                                 .Select(item => item.Text)
                                 .ToList();
            using (StreamWriter file = new StreamWriter(pathname))
            {
                file.WriteLine("DateTime,Open,High,Low,Close,Volume");
                for (int i = data.Count - 1; i > 1; --i)
                {
                    var columns = data[i].Split(new char[] { ',' });
                    // TODO: convert time from exchange time to local time
                    string line = string.Format("{0},{1},{2},{3},{4},{5}", columns[0], columns[1], columns[2], columns[3], columns[4], columns[6]);
                    file.WriteLine(line);
                }
            }

            display("Output to file '" + filename + "'.");
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            if (cboHistoryType.SelectedItem.ToString().StartsWith("Daily"))
            {
                string symbol = txtSymbol.Text.Trim().ToUpper();
                string filename = symbol + " (Daily).csv";
                WriteToFile(filename);
            }
            else
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Python.CallScript(@"B:\Users\mhatmaker\Dropbox\alvin\python\misc\sum.py");
        }
    } // end of class
} // end of namespace





/*
Thread oThread = new Thread(new ThreadStart(m_historyThread.GetHistory));

// Start the thread
oThread.Start();

// Spin for a while waiting for the started thread to become
// alive:
while (!oThread.IsAlive) ;

// Put the Main thread to sleep for 1000 milliseconds to allow oThread
// to do some work:
Thread.Sleep(1000);

// Request that oThread be stopped
oThread.Abort();

// Wait until oThread finishes. Join also has overloads
// that take a millisecond interval or a TimeSpan object.
oThread.Join();
*/
