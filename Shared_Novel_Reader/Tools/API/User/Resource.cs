using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Shared_Novel_Reader.Tools.API.User
{
    internal class Resource
    {
        private static ILog log = LogManager.GetLogger(typeof(Resource));

        /// <summary>
        /// 查询图书资源的目录
        /// </summary>
        /// <param name="ResJson"></param>
        /// <returns></returns>
        public static MyResponse SearchMenu(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });


            int num = 0;
            MyResponse res = MyClient.PushRequests("User/Resource/Search/Menu", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("User/Resource/Search/Menu", ReqJson.ToString());
            }

            return res;

        }

        /// <summary>
        /// 查询图书章节内容
        /// </summary>
        /// <param name="ResJson"></param>
        /// <returns></returns>
        public static MyResponse SearchContent(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });


            int num = 0;
            MyResponse res = MyClient.PushRequests("User/Resource/Search/Content", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("User/Resource/Search/Content", ReqJson.ToString());
            }

            return res;
        }

        /// <summary>
        /// 上传新内容
        /// </summary>
        /// <param name="ResJson"></param>
        /// <returns></returns>
        public static MyResponse UploadNew(in JObject ReqJson)
        {
            return MyClient.PushRequests("User/Resource/Upload/List/New", ReqJson.ToString());
        }

        /// <summary>
        /// 上传申请更改的内容
        /// </summary>
        /// <param name="ResJson"></param>
        /// <returns></returns>
        public static MyResponse UploadChange(in JObject ReqJson)
        {
            return MyClient.PushRequests("User/Resource/Upload/List/Old", ReqJson.ToString());
        }

    }
}
