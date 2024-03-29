﻿using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.Tools.API.Admin
{
    internal class Resource
    {
        private static ILog log = LogManager.GetLogger(typeof(Resource));

        /// <summary>
        /// 管理员查询所有资源信息
        /// </summary>
        /// <returns></returns>
        public static MyResponse FindResource(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });


            int num = 0;
            MyResponse res = MyClient.PushRequests("Admin/Resource/Search", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("Admin/Resource/Search", ReqJson.ToString());
            }

            if (res == null)
            {
                log.Info("查询资源失败");
                return null;
            }

            if (res.Result == false)
            {
                log.Info(res.Message);
                return null;
            }

            if (res.Data == null)
            {
                log.Info("目前还没有资源");
                return null;
            }

            log.Info("查询资源成功");
            return res;
        }


        /// <summary>
        /// 管理员查询所有资源信息
        /// </summary>
        /// <returns></returns>
        public static MyResponse SelectChapterVersion(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });


            int num = 0;
            MyResponse res = MyClient.PushRequests("Admin/Resource/Update/Chapter/Valid", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("Admin/Resource/Update/Chapter/Valid", ReqJson.ToString());
            }

            if (res == null)
            {
                log.Info("指定版本生效失败");
                return null;
            }

            log.Info("查询资源成功");
            return res;
        }


        /// <summary>
        /// 管理员修改图书资源状态信息
        /// </summary>
        /// <returns></returns>
        public static MyResponse UpdateBookStatus(in int Book_ID,in string Status,in string Explain)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });

            JObject ReqJson = new JObject();
            ReqJson["Book_ID"] = Book_ID;
            ReqJson["Status"] = Status;
            ReqJson["Explain"] = Explain;

            int num = 0;
            MyResponse res = MyClient.PushRequests("Admin/Resource/Update/Book/Status", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("Admin/Resource/Update/Book/Status", ReqJson.ToString());
            }

            if (res == null)
            {
                log.Info("网络异常,请重试");
                return null;
            }

            log.Info("图书资源资源状态更新成功");
            return res;
        }


    }
}
