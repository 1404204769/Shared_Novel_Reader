using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Novel_Reader.models;
namespace Shared_Novel_Reader.models
{
    /// <summary>
    /// 网络资源书架类-静态类型
    /// </summary>
    internal class InternetBookShelf
    {
        static ILog log = LogManager.GetLogger(typeof(InternetBookShelf));
        static private string InternetResPath = Properties.Settings.Default.Local_Res_Path + "\\InternetRes.json";
        /// <summary>
        /// 网络记录本地总记录
        /// </summary>
        static public JObject InternetRes = new JObject();
        /// <summary>
        /// 网络记录的所有用户记录
        /// </summary>
        static public JArray InternetResUserArray = new JArray();
        /// <summary>
        /// 当前用户的网络记录
        /// </summary>
        static public JArray InternetResArray = new JArray();

        /// <summary>
        /// 如果资源索引不存在则初始化一个
        /// </summary>
        /// <returns></returns>
        static private bool Config_init()
        {
            JObject jobject = new JObject();
            JArray User_Array = new JArray();
            jobject.Add("User_Array", User_Array);
            return Tools.MyJson.JsonToFile(in jobject, InternetResPath);
        }


        /// <summary>
        /// 校验书架数据是否正确
        /// </summary>
        /// <returns></returns>
        static private bool Verify()
        {
            /*
                "User_Array":
                [
                    {
                        UserID:911220:
                        BookArray:
                        [
                            {
                                BookName:"",
                                BookID:123123
                            }
                        ]
                    }
                ] 
            */
            if (!Tools.MyJson.CheckColAndType(in InternetRes, "User_Array", JTokenType.Array))
            {
                log.Warn("用户资源索引中User_Array字段检查发生错误");
                return false;
            }

            // 设置校验条件
            Dictionary<string, JTokenType> usermap = new Dictionary<string, JTokenType>();
            usermap.Add("UserID", JTokenType.Integer);
            usermap.Add("BookArray", JTokenType.Array);
            // 设置校验条件
            Dictionary<string, JTokenType> map = new Dictionary<string, JTokenType>();
            map.Add("Book_Name", JTokenType.String);
            map.Add("BookID", JTokenType.Integer);

            // 获取数组内容
            var users = from user in InternetRes["User_Array"] select JObject.FromObject(user);
            foreach (var user in users)
            {
                if (!Tools.MyJson.CheckColAndTypeFromMap(in user, in usermap))
                {
                    log.Info("网络书架内的用户数据异常::" + user.ToString());
                    return false;
                }

                var books = from book in user["BookArray"] select JObject.FromObject(book);
                foreach(var book in books)
                {
                    if (!Tools.MyJson.CheckColAndTypeFromMap(in book, in map))
                    {
                        log.Info("网络书架内的用户数据异常::" + user.ToString());
                        log.Info("网络书架内的用户图书数据异常::" + book.ToString());
                        return false;
                    }
                }
            }
            InternetResUserArray = (JArray)InternetRes["User_Array"];
            return true;
        }


        /// <summary>
        /// 打开并初始化网络书架
        /// </summary>
        /// <returns></returns>
        static public bool open()
        {
            if (!File.Exists(InternetResPath))
            {
                log.Info(InternetResPath + "文件不存在,即将开始初始化");
                if (!Config_init())
                {
                    log.Info(InternetResPath + "文件初始化失败");
                    return false;
                }
                return true;
            }

            if (!Tools.MyJson.JsonFromFile(ref InternetRes, InternetResPath))
            {
                log.Info(InternetResPath + "文件解析失败");
                return false;
            }

            if (!Verify())
            {
                log.Info(InternetResPath + "文件校验失败");
                return false;
            }

            if (!User.IsInit)
            {
                log.Info("用户还未登入，网络书架初始化失败");
                return false;
            }
            // 获取数组内容
            var users = from user in InternetResUserArray select JObject.FromObject(user);
            foreach(var user in users)
            {
                if(Convert.ToInt32( user["UserID"] ) == User.User_ID)
                {
                    InternetResArray = (JArray)user["BookArray"];
                    return true;
                }
            }
            log.Info("用户网络书架未找到,开始初始化网络书架");
            JObject newUser = new JObject();
            newUser["UserID"] = User.User_ID;
            newUser["BookArray"] = new JArray();
            InternetResUserArray.Add(newUser);
            InternetResArray = new JArray();
            return true;
        }

        /// <summary>
        /// 关闭并保存书架图书
        /// </summary>
        /// <returns></returns>
        static public bool close()
        {
            int index = 0;
            for (; index < InternetResUserArray.Count; index++)
            {
                if (Convert.ToInt32(InternetResUserArray[index]["UserID"]) != User.User_ID)
                    continue;
                //保存书架信息
                InternetResUserArray[index]["BookArray"] = InternetResArray;
                break;
            }

            if (index == InternetResUserArray.Count)
            {
                log.Info("用户网络书架保存失败 : " + InternetResArray.ToString());
                return false;
            }

            InternetRes["User_Array"] = InternetResUserArray;
            if (!Tools.MyJson.JsonToFile(in InternetRes, InternetResPath))
            {
                log.Info("书架关闭时,保存网络图书索引数据失败");
                return false;
            }
            return true;
        }


        /// <summary>
        /// 将网络图书记录保存到网络书架中
        /// </summary>
        /// <param name="bookname">图书名称</param>
        /// <param name="bookid">图书ID</param>
        /// <returns></returns>
        static public bool AddToBookshelf(in string bookname,in int bookid)
        {
            if(!User.IsInit)
            {
                log.Info("用户还未登入，请先登入");
                return false;
            }

            // 检查图书是否已存在此纪录
            foreach (var book in InternetResArray)
            {
                if(Convert.ToInt32( book["BookID"]) == bookid )
                {
                    log.Info("此网络图书已在用户书架中");
                    return false;
                }
            }

            JObject jBook = new JObject();
            jBook.Add("BookName", bookname);
            jBook.Add("BookID", bookid);

            // 将图书记录保存到数组中
            InternetResArray.Add(jBook);

            // JToken oldBook = LocalRes.SelectToken("$.Book_Array[?(@.name=='张三')]");
            return true;
        }








    }
}
