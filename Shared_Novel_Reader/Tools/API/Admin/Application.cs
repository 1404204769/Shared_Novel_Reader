using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.Tools.API.Admin
{
    internal class Application
    {
        private static ILog log = LogManager.GetLogger(typeof(Application));

        /// <summary>
        /// 查询所有用户信息
        /// </summary>
        /// <returns></returns>
        public static MyResponse FindApplicationList(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });


            int num = 0;
            MyResponse res = MyClient.PushRequests("Admin/Examine/Upload/Search/List", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("Admin/Examine/Upload/Search/List", ReqJson.ToString());
            }

            if (res == null)
            {
                log.Info("查询用户申请失败");
                return null;
            }

            if (res.Result == false)
            {
                log.Info(res.Message);
                return null;
            }

            if (res.Data == null)
            {
                log.Info("目前还没有用户申请");
                return null;
            }

            log.Info("查询用户申请成功");
            return res;
        }


        /// <summary>
        /// 查询所有用户信息
        /// </summary>
        /// <returns></returns>
        public static MyResponse FindApplicationID(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });


            int num = 0;
            MyResponse res = MyClient.PushRequests("Admin/Examine/Upload/Search/ID", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("Admin/Examine/Upload/Search/ID", ReqJson.ToString());
            }

            if (res == null)
            {
                log.Info("查询指定用户申请失败");
                return null;
            }

            if (res.Result == false)
            {
                log.Info(res.Message);
                return null;
            }

            if (res.Data == null)
            {
                log.Info("目前还没有指定用户申请");
                return null;
            }

            log.Info("查询指定用户申请成功");
            return res;
        }
    }
}
