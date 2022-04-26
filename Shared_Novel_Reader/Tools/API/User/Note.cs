﻿using log4net;
using Newtonsoft.Json.Linq;

namespace Shared_Novel_Reader.Tools.API.User
{
    internal class Note
    {
        private static ILog log = LogManager.GetLogger(typeof(Note));

        /// <summary>
        /// 查询图书资源的目录
        /// </summary>
        /// <param name="ResJson"></param>
        /// <returns></returns>
        public static MyResponse SearchNote(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });


            int num = 0;
            MyResponse res = MyClient.PushRequests("User/Resource/Search", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("User/Resource/Search", ReqJson.ToString());
            }

            if (res == null)
            {
                log.Info("查询帖子资源失败");
                return null;
            }

            if (res.Result == false)
            {
                log.Info(res.Message);
                return null;
            }

            if (res.Data == null)
            {
                log.Info("目前还没有帖子资源");
                return null;
            }

            log.Info("查询帖子资源成功");
            return res;

        }



        /// <summary>
        /// 查询帖子评论
        /// </summary>
        /// <param name="ResJson"></param>
        /// <returns></returns>
        public static MyResponse SearchNoteComment(in JObject ReqJson)
        {
            // client.OptionsAsync(new RestRequest() { RequestFormat = DataFormat.Json, });


            int num = 0;
            MyResponse res = MyClient.PushRequests("User/Resource/Search/Comment", ReqJson.ToString());
            while ((res == null) && (num < 10))
            {
                log.Info("第" + (++num) + "次重试");
                res = MyClient.PushRequests("User/Resource/Search/Comment", ReqJson.ToString());
            }

            if (res == null)
            {
                log.Info("查询帖子评论失败");
                return null;
            }

            if (res.Result == false)
            {
                log.Info(res.Message);
                return null;
            }

            if (res.Data == null)
            {
                log.Info("目前还没有帖子评论");
                return null;
            }

            log.Info("查询帖子评论成功");
            return res;

        }
    }
}
