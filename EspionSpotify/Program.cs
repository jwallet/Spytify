﻿using EspionSpotify.Enums;
using EspionSpotify.Properties;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace EspionSpotify
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmEspionSpotify());
        }
    }
}