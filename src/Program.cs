using System;
using System.Windows.Forms;

namespace MTConnect.Applications.SHDR_Tool
{
    internal static class Program
    {
        public static MainForm MainForm { get; set; }


        [STAThread]
        static void Main()
        {
#if NET5_0_OR_GREATER
            ApplicationConfiguration.Initialize();
#endif

            var mainForm = new MainForm();
            MainForm = mainForm;
            Application.Run(mainForm);
        }
    }
}