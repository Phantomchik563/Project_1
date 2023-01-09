using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Roguelite_for_project
{
    internal class Program
    {
        static public Random rand = new Random();
        static public string[] settings = File.ReadAllLines("C:\\Users\\User\\source\\repos\\Hunger-games\\Hunger-games\\bin\\Debug\\Settings.cfg");

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }        
    }

    public class Settings
    {
        public int screenWidht;

    }
}