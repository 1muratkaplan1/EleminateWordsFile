// Copyright (c) 2010 mk-Engineering
// License: Code Project Open License


using System;
using System.Windows.Forms;

namespace mkEng.SwiftWords
{
    static class Program
    {
        public static EleminateWordsFrm DOUBLESRT_CLASS_FORM; 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DOUBLESRT_CLASS_FORM = new EleminateWordsFrm();
            Application.Run(DOUBLESRT_CLASS_FORM);
        }
    }
}
