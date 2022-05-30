using log4net;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.MyForm;
using System;
using System.IO;
using System.Windows.Forms;
namespace Shared_Novel_Reader
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //Application.Run(new MyForm.FormRootControl());
        }
    }
}
