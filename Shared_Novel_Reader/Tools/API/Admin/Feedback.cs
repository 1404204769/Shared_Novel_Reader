using log4net;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace Shared_Novel_Reader.Tools.API.Admin
{
    internal class Feedback
    {
        private static ILog log = LogManager.GetLogger(typeof(Feedback));

        /// <summary>
        /// 查询所有用户信息
        /// </summary>
        /// <returns></returns>
        public static MyResponse FindFeedback(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });


            int num = 0;
            MyResponse res = MyClient.PushRequests("Admin/Examine/IdeaList", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("Admin/Examine/IdeaList", ReqJson.ToString());
            }

            if (res == null)
            {
                MessageBox.Show("查询用户意见失败");
                return null;
            }

            if (res.Result == false)
            {
                log.Info(res.Message);
                return null;
            }

            if (res.Data == null)
            {
                log.Info("目前还没有用户反馈意见");
                return null;
            }

            log.Info("查询用户意见成功");
            return res;
        }


        /// <summary>
        /// 审核用户意见反馈/举报
        /// </summary>
        /// <returns></returns>
        public static MyResponse ExamineFeedback(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });


            int num = 0;
            MyResponse res = MyClient.PushRequests("Admin/Examine/Idea/Examine", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("Admin/Examine/Idea/Examine", ReqJson.ToString());
            }

            if (res == null)
            {
                MessageBox.Show("查询用户意见失败");
                return null;
            }

            if (res.Result == false)
            {
                log.Info(res.Message);
                return null;
            }

            if (res.Data == null)
            {
                log.Info("目前还没有用户反馈意见");
                return null;
            }

            log.Info("查询用户意见成功");
            return res;
        }
    }
}
