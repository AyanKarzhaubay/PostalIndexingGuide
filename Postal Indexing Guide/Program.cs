using System;
using System.Windows.Forms;

namespace Postal_Indexing_Guide
{
    static class Program
    {
        public static bool isGuest = false;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
        }
    }
}
