﻿using log4net;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace Shared_Novel_Reader.Tools.API.Admin
{
    internal class User
    {
        private static ILog log = LogManager.GetLogger(typeof(User));

        /// <summary>
        /// 查询所有用户信息
        /// </summary>
        /// <returns></returns>
        public static MyResponse AllUserList()
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });

            JObject ReqJson = new JObject();

            int num = 0;
            MyResponse res = MyClient.PushRequests("Admin/User/List", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("Admin/User/List", ReqJson.ToString());
            }

            if (res == null)
            {
                log.Info("查询用户列表失败");
                return null;
            }

            if (res.Result == false)
            {
                log.Info(res.Message);
                return null;
            }

            if (res.Data == null)
            {
                log.Info("目前还没有用户注册");
                return null;
            }

            log.Info("查询用户列表成功");
            return res;
        }

        /// <summary>
        /// 查询部分用户信息
        /// </summary>
        /// <returns></returns>
        public static MyResponse SomeUserList(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });

            int num = 0;
            MyResponse res = MyClient.PushRequests("Admin/User/Search", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("Admin/User/Search", ReqJson.ToString());
            }

            if (res == null)
            {
                log.Info("查询指定用户列表失败");
                return null;
            }

            if (res.Result == false)
            {
                log.Info(res.Message);
                return null;
            }

            if (res.Data == null)
            {
                log.Info("未找到指定用户");
                return null;
            }

            log.Info("查询用户列表成功");
            return res;
        }

        /// <summary>
        /// 批量修改用户信息
        /// </summary>
        /// <returns></returns>
        public static MyResponse UpdateUserList(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });

            int num = 0;
            MyResponse res = MyClient.PushRequests("Admin/User/Update", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("Admin/User/Update", ReqJson.ToString());
            }

            if (res == null)
            {
                log.Info("网络异常");
                return null;
            }

            if (res.Result == false || res.Data == null)
            {
                log.Info("修改用户信息失败 : " + res.Message);
                return null;
            }

            log.Info("修改用户信息成功");
            return res;
        }


        /// <summary>
        /// 修改用户积分数据
        /// </summary>
        /// <returns></returns>
        public static MyResponse UpdateUserIntegral(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });

            int num = 0;
            MyResponse res = MyClient.PushRequests("Admin/User/Change_User_Integral", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("Admin/User/Change_User_Integral", ReqJson.ToString());
            }

            if (res == null)
            {
                log.Info("网络异常");
                return null;
            }

            if (res.Result == false || res.Data == null)
            {
                log.Info("修改用户信息失败 : " + res.Message);
                return null;
            }

            log.Info("修改用户信息成功");
            return res;
        }

        /// <summary>
        /// 修改用户状态数据
        /// </summary>
        /// <returns></returns>
        public static MyResponse UpdateUserStatus(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });

            int num = 0;
            MyResponse res = MyClient.PushRequests("Admin/User/Change_User_Status", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("Admin/User/Change_User_Status", ReqJson.ToString());
            }
            return res;
        }



    }
}
