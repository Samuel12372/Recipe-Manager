namespace FoodRecipeManager2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            
            
            

            if (args.Length != 2)
            {
                Console.WriteLine("Error Please enter in the format 'FoodRecipeManager2.exe a b' ");
                Application.Exit();
            }
            if (args[0] == "sam" && args[1] == "knowles")
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Exit();
            }

        }
    }
}