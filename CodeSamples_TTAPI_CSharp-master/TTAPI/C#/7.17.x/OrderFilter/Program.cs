﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TTAPI_Samples
{
    using TradingTechnologies.TTAPI;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // confirm TTAPI installation archetecture
            AboutDTS.TTAPIArchitectureCheck();

            // Create and attach a UI Dispatcher to the main Form
            // When the form exits, this scoping block will auto-dispose of the Dispatcher
            using (var disp = Dispatcher.AttachUIDispatcher())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Create an instance of TTAPI.
                frmOrderFilter orderFilter = new frmOrderFilter();
                ApiInitializeHandler handler = new ApiInitializeHandler(orderFilter.ttApiInitHandler);
                TTAPI.CreateXTraderModeTTAPI(disp, handler);

                Application.Run(orderFilter);
            }
        }
    }
}
