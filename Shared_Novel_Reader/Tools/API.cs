﻿using log4net;
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
            MyResponse res = MyClient.NoTokenRequests("Gpi/Login", ReqJson.ToString(), CancelLogin);
            while ((res == null) && (num < 10) && !CancelLogin.IsCancellationRequested)
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.NoTokenRequests("Gpi/Login",ReqJson.ToString(), CancelLogin);
            }

            if (res == null)
            {
                MessageBox.Show("登入失败");
                return false;
            }

            if (res.Data == null)
            {
                MessageBox.Show("用户不存在,请注册");
                return false;
            }

            MyClient.Token = res.Data["Token"].ToString();
            MessageBox.Show("登入成功");
            if (!models.User.Init((JObject)res.Data["User_Data"]))
            {
                MessageBox.Show("用户初始化失败");
                return false;
            }
            MessageBox.Show("用户初始化成功");
            return true;
        }


        public static bool Register(in int User_ID, in string User_Pwd, in string User_Name, in string User_Sex,in CancellationToken CancelLogin)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });

            JObject ReqJson = new JObject();
            ReqJson.Add("User_ID", User_ID);
            ReqJson.Add("User_Name", User_Name);
            ReqJson.Add("User_Sex", User_Sex);
            ReqJson.Add("User_Pwd", User_Pwd);

            int num = 0;
            MyResponse res = MyClient.NoTokenRequests("Gpi/Register", ReqJson.ToString(), CancelLogin);
            while ((res == null) && (num < 10) && !CancelLogin.IsCancellationRequested)
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.NoTokenRequests("Gpi/Register", ReqJson.ToString(), CancelLogin);
            }

            if (res == null)
            {
                MessageBox.Show("服务器连接异常,注册失败");
                return false;
            }

            if (res.Result == false)
            {
                MessageBox.Show(res.Message);
                return false;
            }


            if (res.Data == null)
            {
                MessageBox.Show("服务器异常,请重试");
                return false;
            }

            MessageBox.Show("注册成功");
            return true;
        }
    }
}
