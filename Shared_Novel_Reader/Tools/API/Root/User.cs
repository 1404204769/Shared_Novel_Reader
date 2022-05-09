using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Novel_Reader.Tools.API.Root
{
    internal class User
    {
        private static ILog log = LogManager.GetLogger(typeof(User));
        /// <summary>
        /// 修改用户状态数据
        /// </summary>
        /// <returns></returns>
        public static MyResponse AdminControl(in int UserID)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });
            JObject ReqJson = new JObject();
            ReqJson["User_ID"] = UserID;
            return MyClient.PushRequests("Root/AdminControl", ReqJson.ToString());
        }
    }
}
