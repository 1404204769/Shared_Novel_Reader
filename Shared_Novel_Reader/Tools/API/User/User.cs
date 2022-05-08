using log4net;
using Newtonsoft.Json.Linq;

namespace Shared_Novel_Reader.Tools.API.User
{
    internal class User
    {
        private static ILog log = LogManager.GetLogger(typeof(User));
        /// <summary>
        /// 修改个人资料
        /// </summary>
        /// <returns></returns>
        public static MyResponse ChangeUserData(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });
            int num = 0;
            MyResponse res = MyClient.PushRequests("User/PersonalData/Update", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("User/PersonalData/Update", ReqJson.ToString());
            }

            if (res == null)
            {
                log.Info("修改个人资料失败");
                return null;
            }

            if (res.Result == false || res.Data == null)
            {
                log.Info(res.Message);
                return null;
            }

            log.Info("修改个人资料成功");
            return res;
        }
        /// <summary>
        /// 意见反馈
        /// </summary>
        /// <returns></returns>
        public static MyResponse Feedback(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });
            int num = 0;
            MyResponse res = MyClient.PushRequests("User/Feedback", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("User/Feedback", ReqJson.ToString());
            }

            if (res == null)
            {
                log.Info("网络异常，请重试");
                return null;
            }

            if (res.Result == false || res.Data == null)
            {
                log.Info("意见反馈失败("+res.Message+")");
                return null;
            }

            log.Info("意见反馈成功");
            return res;
        }


        /// <summary>
        /// 举报
        /// </summary>
        /// <returns></returns>
        public static MyResponse Report(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });
            int num = 0;
            MyResponse res = MyClient.PushRequests("User/Report", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("User/Report", ReqJson.ToString());
            }

            if (res == null)
            {
                log.Info("网络异常，请重试");
                return null;
            }

            if (res.Result == false || res.Data == null)
            {
                log.Info("举报失败(" + res.Message + ")");
                return null;
            }

            log.Info("举报成功");
            return res;
        }
    }
}
