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
            // JsonTest();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            // reset();
            // init();
            /* LoginTest();
            MessageBox.Show(models.User.show());
            JObject obj = new JObject();
            JObject res = Tools.MyClient.PushRequests("show", obj.ToString());
            if (res == null)
            {
                MessageBox.Show("发生错误");
            }
            else
            {
                MessageBox.Show(res.ToString());
            }*/
            // Booktest();
        }

        static void reset()
        {
            Properties.Settings.Default.Local_Res_Path = "";
            Properties.Settings.Default.App_Path = "";
            Properties.Settings.Default.Save();
        }
        static void init()
        {
            ILog log = LogManager.GetLogger(typeof(Program));
            if(Properties.Settings.Default.Local_Res_Path == "")
            {
                DirectoryInfo directory = new DirectoryInfo(Application.StartupPath);
                Properties.Settings.Default.Local_Res_Path  = directory.Parent.Parent.FullName + "\\Book";
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
        }
        static void Booktest()
        {
            if (!models.LocalBookShelf.open())
            {
                MessageBox.Show("书架打开失败");
            }
            else
            {
                MessageBox.Show("书架打开成功");
            }

            models.Book book;
            string path = "C:\\Users\\LZC\\Desktop\\测试文件\\2\\次元论坛.txt";
            Tools.Novel_Analysis.Analysis_Local_Resource(out book,path);
            models.LocalBookShelf.AddToBookshelf(book);

            if (!models.LocalBookShelf.close())
            {
                MessageBox.Show("书架关闭失败");
            }
            else
            {
                MessageBox.Show("书架关闭成功");
            }
        }
    
        static void LoginTest()
        {
            ILog log = LogManager.GetLogger(typeof(Program));
            // Tools.API.Login(911220, "chentonlei");

        }
        
        static void JsonTest()
        {
            string json =
"{\"Data\":{\"Token\":\"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJMb2dpbl9TdGF0dXMiOiJ1c2VyIiwiVXNlcl9JRCI6IjkxMTIyMCJ9.zkRERegP0WiSKTI6eWe1Bj4I_atu3oCfpQH6SZrlFLk\",\"User_Data\":{\"Integral\":1043,\"Level\":1,\"Name\":\"陈彤磊\",\"Password\":\"chentonlei\",\"Power\":1,\"Sex\":\"男\",\"Status\":\"Normal\",\"Total_Integral\":1043,\"User_ID\":911220}},\"Message\":\"登入成功\",\"Result\":true}";

            JObject res = JObject.Parse(json);
            MessageBox.Show(res.ToString());
        }

    }
}
