namespace HistorySocket
{
    partial class HistorySocketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label13 = new System.Windows.Forms.Label();
            this.rbTick = new System.Windows.Forms.RadioButton();
            this.rbVolume = new System.Windows.Forms.RadioButton();
            this.rbTime = new System.Windows.Forms.RadioButton();
            this.btnGetData = new System.Windows.Forms.Button();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtDatapointsPerSend = new System.Windows.Forms.TextBox();
            this.txtEndFilterTime = new System.Windows.Forms.TextBox();
            this.txtBeginFilterTime = new System.Windows.Forms.TextBox();
            this.txtEndDateTime = new System.Windows.Forms.TextBox();
            this.txtBeginDateTime = new System.Windows.Forms.TextBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtDatapoints = new System.Windows.Forms.TextBox();
            this.cboHistoryType = new System.Windows.Forms.ComboBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lstData = new System.Windows.Forms.ListView();
            this.status = new System.Windows.Forms.StatusStrip();
            this.tssMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssRight = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGetHistory = new System.Windows.Forms.Button();
            this.txtSymbolRoot = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.numLastYear = new System.Windows.Forms.NumericUpDown();
            this.numFirstYear = new System.Windows.Forms.NumericUpDown();
            this.txtHistoricalFolder = new System.Windows.Forms.TextBox();
            this.btnWriteToFile = new System.Windows.Forms.Button();
            this.chkDaily = new System.Windows.Forms.CheckBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLastYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstYear)).BeginInit();
            this.SuspendLayout();
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(507, 10);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(90, 17);
            this.Label13.TabIndex = 111;
            this.Label13.Text = "Interval Type";
            // 
            // rbTick
            // 
            this.rbTick.AutoSize = true;
            this.rbTick.Location = new System.Drawing.Point(668, 31);
            this.rbTick.Margin = new System.Windows.Forms.Padding(4);
            this.rbTick.Name = "rbTick";
            this.rbTick.Size = new System.Drawing.Size(55, 21);
            this.rbTick.TabIndex = 110;
            this.rbTick.Text = "Tick";
            this.rbTick.UseVisualStyleBackColor = true;
            // 
            // rbVolume
            // 
            this.rbVolume.AutoSize = true;
            this.rbVolume.Location = new System.Drawing.Point(580, 31);
            this.rbVolume.Margin = new System.Windows.Forms.Padding(4);
            this.rbVolume.Name = "rbVolume";
            this.rbVolume.Size = new System.Drawing.Size(76, 21);
            this.rbVolume.TabIndex = 109;
            this.rbVolume.Text = "Volume";
            this.rbVolume.UseVisualStyleBackColor = true;
            // 
            // rbTime
            // 
            this.rbTime.AutoSize = true;
            this.rbTime.Checked = true;
            this.rbTime.Location = new System.Drawing.Point(511, 31);
            this.rbTime.Margin = new System.Windows.Forms.Padding(4);
            this.rbTime.Name = "rbTime";
            this.rbTime.Size = new System.Drawing.Size(60, 21);
            this.rbTime.TabIndex = 108;
            this.rbTime.TabStop = true;
            this.rbTime.Text = "Time";
            this.rbTime.UseVisualStyleBackColor = true;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(814, 13);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(125, 58);
            this.btnGetData.TabIndex = 107;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.SystemColors.Control;
            this.Label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label12.Location = new System.Drawing.Point(519, 62);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label12.Size = new System.Drawing.Size(143, 21);
            this.Label12.TabIndex = 106;
            this.Label12.Text = "Datapoints Per Send";
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.SystemColors.Control;
            this.Label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label11.Location = new System.Drawing.Point(391, 62);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(123, 21);
            this.Label11.TabIndex = 105;
            this.Label11.Text = "End Filter Time";
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.SystemColors.Control;
            this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label10.Location = new System.Drawing.Point(265, 62);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(123, 21);
            this.Label10.TabIndex = 104;
            this.Label10.Text = "Begin Filter Time";
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.SystemColors.Control;
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(139, 62);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(123, 21);
            this.Label9.TabIndex = 103;
            this.Label9.Text = "End Date Time";
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.SystemColors.Control;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(8, 62);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(123, 21);
            this.Label8.TabIndex = 102;
            this.Label8.Text = "Begin Date Time";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(735, 62);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(74, 17);
            this.Label7.TabIndex = 101;
            this.Label7.Text = "RequestID";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(661, 62);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(64, 17);
            this.Label6.TabIndex = 100;
            this.Label6.Text = "Direction";
            // 
            // txtRequestID
            // 
            this.txtRequestID.Location = new System.Drawing.Point(720, 82);
            this.txtRequestID.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.Size = new System.Drawing.Size(88, 22);
            this.txtRequestID.TabIndex = 99;
            // 
            // txtDirection
            // 
            this.txtDirection.Location = new System.Drawing.Point(672, 82);
            this.txtDirection.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(36, 22);
            this.txtDirection.TabIndex = 98;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(427, 10);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(54, 17);
            this.Label5.TabIndex = 97;
            this.Label5.Text = "Interval";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(376, 10);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(40, 17);
            this.Label4.TabIndex = 96;
            this.Label4.Text = "Days";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(291, 10);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(76, 17);
            this.Label3.TabIndex = 95;
            this.Label3.Text = "Datapoints";
            // 
            // txtDatapointsPerSend
            // 
            this.txtDatapointsPerSend.Location = new System.Drawing.Point(521, 82);
            this.txtDatapointsPerSend.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatapointsPerSend.Name = "txtDatapointsPerSend";
            this.txtDatapointsPerSend.Size = new System.Drawing.Size(137, 22);
            this.txtDatapointsPerSend.TabIndex = 94;
            // 
            // txtEndFilterTime
            // 
            this.txtEndFilterTime.Location = new System.Drawing.Point(393, 82);
            this.txtEndFilterTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndFilterTime.Name = "txtEndFilterTime";
            this.txtEndFilterTime.Size = new System.Drawing.Size(119, 22);
            this.txtEndFilterTime.TabIndex = 93;
            // 
            // txtBeginFilterTime
            // 
            this.txtBeginFilterTime.Location = new System.Drawing.Point(265, 82);
            this.txtBeginFilterTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtBeginFilterTime.Name = "txtBeginFilterTime";
            this.txtBeginFilterTime.Size = new System.Drawing.Size(119, 22);
            this.txtBeginFilterTime.TabIndex = 92;
            // 
            // txtEndDateTime
            // 
            this.txtEndDateTime.Location = new System.Drawing.Point(137, 82);
            this.txtEndDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndDateTime.Name = "txtEndDateTime";
            this.txtEndDateTime.Size = new System.Drawing.Size(119, 22);
            this.txtEndDateTime.TabIndex = 91;
            this.txtEndDateTime.Text = "20170712";
            // 
            // txtBeginDateTime
            // 
            this.txtBeginDateTime.Location = new System.Drawing.Point(9, 82);
            this.txtBeginDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtBeginDateTime.Name = "txtBeginDateTime";
            this.txtBeginDateTime.Size = new System.Drawing.Size(119, 22);
            this.txtBeginDateTime.TabIndex = 90;
            this.txtBeginDateTime.Text = "20100101";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(425, 31);
            this.txtInterval.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(56, 22);
            this.txtInterval.TabIndex = 89;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(380, 31);
            this.txtDays.Margin = new System.Windows.Forms.Padding(4);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(36, 22);
            this.txtDays.TabIndex = 88;
            this.txtDays.Text = "1";
            // 
            // txtDatapoints
            // 
            this.txtDatapoints.Location = new System.Drawing.Point(295, 31);
            this.txtDatapoints.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatapoints.Name = "txtDatapoints";
            this.txtDatapoints.Size = new System.Drawing.Size(76, 22);
            this.txtDatapoints.TabIndex = 87;
            // 
            // cboHistoryType
            // 
            this.cboHistoryType.BackColor = System.Drawing.SystemColors.Window;
            this.cboHistoryType.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboHistoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHistoryType.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHistoryType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboHistoryType.Location = new System.Drawing.Point(11, 31);
            this.cboHistoryType.Margin = new System.Windows.Forms.Padding(4);
            this.cboHistoryType.Name = "cboHistoryType";
            this.cboHistoryType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboHistoryType.Size = new System.Drawing.Size(149, 24);
            this.cboHistoryType.TabIndex = 84;
            this.cboHistoryType.SelectedIndexChanged += new System.EventHandler(this.cboHistoryType_SelectedIndexChanged);
            // 
            // txtSymbol
            // 
            this.txtSymbol.AcceptsReturn = true;
            this.txtSymbol.BackColor = System.Drawing.SystemColors.Window;
            this.txtSymbol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSymbol.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbol.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSymbol.Location = new System.Drawing.Point(168, 31);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.txtSymbol.MaxLength = 0;
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSymbol.Size = new System.Drawing.Size(117, 23);
            this.txtSymbol.TabIndex = 83;
            this.txtSymbol.Text = "VIX.XO";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(7, 10);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(44, 21);
            this.Label2.TabIndex = 86;
            this.Label2.Text = "Type:";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(164, 10);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(69, 21);
            this.Label1.TabIndex = 85;
            this.Label1.Text = "Symbol:";
            // 
            // lstData
            // 
            this.lstData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstData.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstData.Location = new System.Drawing.Point(12, 114);
            this.lstData.Margin = new System.Windows.Forms.Padding(4);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(797, 578);
            this.lstData.TabIndex = 112;
            this.lstData.UseCompatibleStateImageBehavior = false;
            this.lstData.View = System.Windows.Forms.View.Details;
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMain,
            this.tssRight});
            this.status.Location = new System.Drawing.Point(0, 724);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(951, 40);
            this.status.TabIndex = 113;
            this.status.Text = "statusStrip1";
            // 
            // tssMain
            // 
            this.tssMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssMain.Font = new System.Drawing.Font("Courier New", 9F);
            this.tssMain.Name = "tssMain";
            this.tssMain.Size = new System.Drawing.Size(786, 35);
            this.tssMain.Spring = true;
            this.tssMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssMain.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tssRight
            // 
            this.tssRight.AutoSize = false;
            this.tssRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssRight.Font = new System.Drawing.Font("Courier New", 9F);
            this.tssRight.Name = "tssRight";
            this.tssRight.Size = new System.Drawing.Size(150, 35);
            this.tssRight.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // btnGetHistory
            // 
            this.btnGetHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetHistory.Location = new System.Drawing.Point(814, 462);
            this.btnGetHistory.Name = "btnGetHistory";
            this.btnGetHistory.Size = new System.Drawing.Size(125, 51);
            this.btnGetHistory.TabIndex = 114;
            this.btnGetHistory.Text = "Get History";
            this.btnGetHistory.UseVisualStyleBackColor = true;
            this.btnGetHistory.Click += new System.EventHandler(this.btnGetHistory_Click);
            // 
            // txtSymbolRoot
            // 
            this.txtSymbolRoot.AcceptsReturn = true;
            this.txtSymbolRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSymbolRoot.BackColor = System.Drawing.SystemColors.Window;
            this.txtSymbolRoot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSymbolRoot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbolRoot.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSymbolRoot.Location = new System.Drawing.Point(813, 413);
            this.txtSymbolRoot.Margin = new System.Windows.Forms.Padding(4);
            this.txtSymbolRoot.MaxLength = 0;
            this.txtSymbolRoot.Name = "txtSymbolRoot";
            this.txtSymbolRoot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSymbolRoot.Size = new System.Drawing.Size(125, 30);
            this.txtSymbolRoot.TabIndex = 116;
            this.txtSymbolRoot.Text = "@ES";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(817, 384);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(117, 25);
            this.label14.TabIndex = 117;
            this.label14.Text = "Symbol Root:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(817, 313);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(117, 25);
            this.label15.TabIndex = 119;
            this.label15.Text = "Last Year:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.label16.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(817, 247);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(117, 25);
            this.label16.TabIndex = 121;
            this.label16.Text = "First Year:";
            // 
            // numLastYear
            // 
            this.numLastYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numLastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLastYear.Location = new System.Drawing.Point(816, 341);
            this.numLastYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numLastYear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numLastYear.Name = "numLastYear";
            this.numLastYear.Size = new System.Drawing.Size(125, 30);
            this.numLastYear.TabIndex = 122;
            this.numLastYear.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // numFirstYear
            // 
            this.numFirstYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numFirstYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFirstYear.Location = new System.Drawing.Point(814, 275);
            this.numFirstYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numFirstYear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numFirstYear.Name = "numFirstYear";
            this.numFirstYear.Size = new System.Drawing.Size(125, 30);
            this.numFirstYear.TabIndex = 123;
            this.numFirstYear.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // txtHistoricalFolder
            // 
            this.txtHistoricalFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHistoricalFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoricalFolder.Location = new System.Drawing.Point(13, 699);
            this.txtHistoricalFolder.Name = "txtHistoricalFolder";
            this.txtHistoricalFolder.Size = new System.Drawing.Size(795, 23);
            this.txtHistoricalFolder.TabIndex = 124;
            this.txtHistoricalFolder.Text = "B:\\Users\\mhatmaker\\Dropbox\\ALVIN\\data\\DF_DATA";
            // 
            // btnWriteToFile
            // 
            this.btnWriteToFile.Location = new System.Drawing.Point(814, 76);
            this.btnWriteToFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnWriteToFile.Name = "btnWriteToFile";
            this.btnWriteToFile.Size = new System.Drawing.Size(125, 35);
            this.btnWriteToFile.TabIndex = 125;
            this.btnWriteToFile.Text = "Write to File";
            this.btnWriteToFile.UseVisualStyleBackColor = true;
            this.btnWriteToFile.Click += new System.EventHandler(this.btnWriteToFile_Click);
            // 
            // chkDaily
            // 
            this.chkDaily.AutoSize = true;
            this.chkDaily.Location = new System.Drawing.Point(837, 519);
            this.chkDaily.Name = "chkDaily";
            this.chkDaily.Size = new System.Drawing.Size(61, 21);
            this.chkDaily.TabIndex = 126;
            this.chkDaily.Text = "Daily";
            this.chkDaily.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(837, 651);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(94, 26);
            this.btnTest.TabIndex = 127;
            this.btnTest.Text = "(test)";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // HistorySocketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 764);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.chkDaily);
            this.Controls.Add(this.btnWriteToFile);
            this.Controls.Add(this.txtHistoricalFolder);
            this.Controls.Add(this.numFirstYear);
            this.Controls.Add(this.numLastYear);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSymbolRoot);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnGetHistory);
            this.Controls.Add(this.status);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.rbTick);
            this.Controls.Add(this.rbVolume);
            this.Controls.Add(this.rbTime);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtRequestID);
            this.Controls.Add(this.txtDirection);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtDatapointsPerSend);
            this.Controls.Add(this.txtEndFilterTime);
            this.Controls.Add(this.txtBeginFilterTime);
            this.Controls.Add(this.txtEndDateTime);
            this.Controls.Add(this.txtBeginDateTime);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtDatapoints);
            this.Controls.Add(this.cboHistoryType);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HistorySocketForm";
            this.Text = "C# History Socket";
            this.Load += new System.EventHandler(this.HistorySocketForm_Load);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLastYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.RadioButton rbTick;
        internal System.Windows.Forms.RadioButton rbVolume;
        internal System.Windows.Forms.RadioButton rbTime;
        internal System.Windows.Forms.Button btnGetData;
        public System.Windows.Forms.Label Label12;
        public System.Windows.Forms.Label Label11;
        public System.Windows.Forms.Label Label10;
        public System.Windows.Forms.Label Label9;
        public System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtRequestID;
        internal System.Windows.Forms.TextBox txtDirection;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtDatapointsPerSend;
        internal System.Windows.Forms.TextBox txtEndFilterTime;
        internal System.Windows.Forms.TextBox txtBeginFilterTime;
        internal System.Windows.Forms.TextBox txtEndDateTime;
        internal System.Windows.Forms.TextBox txtBeginDateTime;
        internal System.Windows.Forms.TextBox txtInterval;
        internal System.Windows.Forms.TextBox txtDays;
        internal System.Windows.Forms.TextBox txtDatapoints;
        public System.Windows.Forms.ComboBox cboHistoryType;
        public System.Windows.Forms.TextBox txtSymbol;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ListView lstData;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel tssMain;
        private System.Windows.Forms.ToolStripStatusLabel tssRight;
        private System.Windows.Forms.Button btnGetHistory;
        public System.Windows.Forms.TextBox txtSymbolRoot;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numLastYear;
        private System.Windows.Forms.NumericUpDown numFirstYear;
        private System.Windows.Forms.TextBox txtHistoricalFolder;
        internal System.Windows.Forms.Button btnWriteToFile;
        private System.Windows.Forms.CheckBox chkDaily;
        private System.Windows.Forms.Button btnTest;
    }
}

