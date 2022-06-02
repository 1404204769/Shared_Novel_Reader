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
            // reset();
            init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            // Application.Run(new MyForm.FormRootControl());
        }


        static void init()
        {
            ILog log = LogManager.GetLogger(typeof(Program));
            if (Properties.Settings.Default.Local_Res_Path == "")
            {
                DirectoryInfo directory = new DirectoryInfo(Application.StartupPath);
                Properties.Settings.Default.Local_Res_Path = directory.Parent.Parent.FullName + "\\Book";
                Properties.Settings.Default.Save();
                log.Info("文件资源路径初始化为 : " + Properties.Settings.Default.Local_Res_Path);
            }
            else
            {
                log.Info("文件资源路径为 : " + Properties.Settings.Default.Local_Res_Path);
            }

            if (Properties.Settings.Default.App_Path == "")
            {
                DirectoryInfo directory = new DirectoryInfo(Application.StartupPath);
                Properties.Settings.Default.App_Path = directory.Parent.Parent.FullName;
                Properties.Settings.Default.Save();
                log.Info("项目根目录初始化为 : " + Properties.Settings.Default.App_Path);
            }
            else
            {
                log.Info("项目根目录为 : " + Properties.Settings.Default.App_Path);
            }

            if (Properties.Settings.Default.TipString.Length == 0)
            {
                string TipStr = "免责声明:\n"
            + "1.本软件书籍信息全部来自于用户上传或管理员修改，本软件不会修改任何书籍信息。\n"
            + "2.书籍版本属于原作者，本软件只提供信息存储服务，任何信息均由用户自主上传，若侵犯了您的权益，请联系我们删除此信息。\n"
            + "3.因本服务搜索结果根据您键入的关键字自动搜索其余用户上传的内容，不代表本软件赞成用户上传的所有信息。\n"
            + "4.您应对使用搜索的结果自行承担风险。\n"
            + "本软件不做任何形式的保证：不保证搜索结果满足您的要求，不保证搜索服务不中断，不保证搜索结果的安全性、准确性、及时性、合法性。\n"
            + "因网络状况、通讯故障、第三方网站等任何原因而导致您不能正常使用本服务的，本软件不承担任何法律责任。";
                Properties.Settings.Default.TipString = TipStr;
                Properties.Settings.Default.Save();
                log.Info("免责声明初始化为 : \n" + Properties.Settings.Default.TipString);
            }
            else
            {
                log.Info("免责声明如下 : \n" + Properties.Settings.Default.TipString);
            }
        }
        static void reset()
        {
            Properties.Settings.Default.Local_Res_Path = "";
            Properties.Settings.Default.App_Path = "";
            Properties.Settings.Default.Save();
        }

    }
}
