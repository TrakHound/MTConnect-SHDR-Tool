namespace MTConnect.Applications.SHDR_Tool
{
    internal static class Program
    {
        public static MainForm MainForm { get; set; }


        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var mainForm = new MainForm();
            MainForm = mainForm;
            Application.Run(mainForm);
        }
    }
}