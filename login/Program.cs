namespace Login
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new labelCadastrar());
=======
            Application.Run(new FormLogin());
>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
        }
    }
}