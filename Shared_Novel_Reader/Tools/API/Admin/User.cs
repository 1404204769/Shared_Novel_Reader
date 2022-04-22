using log4net;
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
                MessageBox.Show("查询用户列表失败");
                return null;
            }

            if (res.Result == false)
            {
                MessageBox.Show(res.Message);
                return null;
            }

            if (res.Data == null)
            {
                MessageBox.Show("目前还没有用户注册");
                return null;
            }

            MessageBox.Show("查询用户列表成功");
            return res;
        }

        /// <summary>
        /// 查询所有用户信息
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
                MessageBox.Show("查询指定用户列表失败");
                return null;
            }

            if (res.Result == false)
            {
                MessageBox.Show(res.Message);
                return null;
            }

            if (res.Data == null)
            {
                MessageBox.Show("未找到指定用户");
                return null;
            }

            MessageBox.Show("查询用户列表成功");
            return res;
        }
    }
}
