﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Inventory_ImportPartesHBD.Views;

namespace Inventory_ImportPartesHBD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EntradaProducto_Form());
        }
    }
}