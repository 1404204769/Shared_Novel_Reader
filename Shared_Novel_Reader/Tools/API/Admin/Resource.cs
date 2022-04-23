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
        private static ILog log = LogManager.GetLogger(typeof(Feedback));

        /// <summary>
        /// 查询所有用户信息
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
                MessageBox.Show("查询资源失败");
                return null;
            }

            if (res.Result == false)
            {
                MessageBox.Show(res.Message);
                return null;
            }

            if (res.Data == null)
            {
                MessageBox.Show("目前还没有资源");
                return null;
            }

            MessageBox.Show("查询资源成功");
            return res;
        }
    }
}
