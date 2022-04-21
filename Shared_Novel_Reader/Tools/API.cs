using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.Tools
{
    /// <summary>
    /// API接口
    /// </summary>
    internal class API
    {
        private static ILog log = LogManager.GetLogger(typeof(Tools.API));
        public static bool Login(in int User_ID, in string User_Pwd,in CancellationToken CancelLogin)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });

            JObject ReqJson = new JObject();
            ReqJson.Add("User_ID", User_ID);
            ReqJson.Add("User_Pwd", User_Pwd);

            int num = 0;
            JObject res = MyClient.LoginRequests(ReqJson.ToString(), CancelLogin);
            while ((res == null) && (num < 10) && !CancelLogin.IsCancellationRequested)
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.LoginRequests(ReqJson.ToString(), CancelLogin);
            }

            if (res == null)
            {
                MessageBox.Show("登入失败");
                return false;
            }

            if (!MyJson.CheckColAndType(res, "Token", JTokenType.String))
            {
                MessageBox.Show("用户不存在,请注册");
                return false;
            }

            MyClient.Token = res["Token"].ToString();
            MessageBox.Show("登入成功");
            if (!models.User.Init((JObject)res["User_Data"]))
            {
                MessageBox.Show("用户初始化失败");
                return false;
            }
            MessageBox.Show("用户初始化成功");
            return true;
        }
    }
}
