using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Novel_Reader.Tools.API.Root
{
    internal class System
    {
        private static ILog log = LogManager.GetLogger(typeof(System));
        /// <summary>
        /// 查看系统日志级别
        /// </summary>
        /// <returns></returns>
        public static MyResponse SearchSysOutLevel()
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });
            JObject ReqJson = new JObject();
            ReqJson["Level"] = "";
            int num = 0;
            MyResponse res = MyClient.PushRequests("Root/SysOutLevel/Search", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("Root/SysOutLevel/Search", ReqJson.ToString());
            }
            if(res == null)
            {
                log.Info("网络异常，请重试");
                return null;
            }
            return res;
        }

        /// <summary>
        /// 修改系统日志级别
        /// </summary>
        /// <returns></returns>
        public static MyResponse UpdateSysOutLevel(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });
            return MyClient.PushRequests("Root/SysOutLevel/Update", ReqJson.ToString());
        }

        /// <summary>
        /// 发送系统指令
        /// </summary>
        /// <returns></returns>
        public static MyResponse Instructions(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });
            return MyClient.PushRequests("Root/Instructions", ReqJson.ToString());
        }
    }
}
