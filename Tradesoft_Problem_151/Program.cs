using System;
using System.Windows.Forms;
using TP151_Repository.Classes;
using Tradesoft_Problem_151.Forms;

namespace Tradesoft_Problem_151
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

            Form form;
            //проверка на наличие БД
            if (!Repository.Connect())
                form = new FCreateDB(); //если нет, будет предложено создать БД
            else
                form = new FMain(); //если есть, откроется основная форма

            Application.Run(form);
        }
    }
}
