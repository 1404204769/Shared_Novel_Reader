using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Novel_Reader.models
{
    /// <summary>
    /// 书架类-静态类型
    /// </summary>
    internal static class LocalBookShelf
    {
        static private string LocalResPath = Properties.Settings.Default.Local_Res_Path + "\\LocalRes.json";
        static private List<Book> BookList = new List<Book>();
        static private JObject LocalRes = new JObject();
        static private JArray LocalResArray = new JArray();

        /// <summary>
        /// 打开并初始化本地书架
        /// </summary>
        /// <returns></returns>
        static public bool open()
        {
            ILog log = LogManager.GetLogger(typeof(LocalBookShelf));
            if (!File.Exists(LocalResPath))
            {

                log.Info(LocalResPath + "文件不存在,即将开始初始化");
                if (!Config_init())
                {
                    log.Info(LocalResPath + "文件初始化失败");
                    return false;
                }
                return true;
            }

            if(!Tools.MyJson.JsonFromFile(ref LocalRes, LocalResPath))
            {
                log.Info(LocalResPath + "文件解析失败");
                return false;
            }

            if(!Verify())
            {
                log.Info(LocalResPath + "文件校验失败");
                return false;
            }

            LocalResArray = (JArray)LocalRes["Book_Array"];
            return true;
        }

        /// <summary>
        /// 关闭并保存书架图书
        /// </summary>
        /// <returns></returns>
        static public bool close()
        {
            ILog log = LogManager.GetLogger(typeof(LocalBookShelf));
            LocalRes["Book_Array"] = LocalResArray;
            if (!Tools.MyJson.JsonToFile(in LocalRes, LocalResPath))
            {
                log.Info("书架关闭时,保存图书数据失败");
                return false;
            }
            return true;
        }

        /// <summary>
        /// 如果资源索引不存在则初始化一个
        /// </summary>
        /// <returns></returns>
        static private bool Config_init()
        {
            JObject jobject = new JObject();
            JArray Book_Array = new JArray();
            jobject.Add("Book_Array", Book_Array);
            return Tools.MyJson.JsonToFile(in jobject,LocalResPath);
        }

        /// <summary>
        /// 校验书架数据是否正确
        /// </summary>
        /// <returns></returns>
        static private bool Verify()
        {
            ILog log = LogManager.GetLogger(typeof(LocalBookShelf));
            /*
                "Book_Array":[
                    {
                        "Book_Name": "",
                        "File_Path": [
                            "",
                            ""
                        ], // 记录曾经解析过哪些
                        "Link_Nun":0,
                        "Valid":true,//是否有效
                    }
                ] 
            */
            if (!Tools.MyJson.CheckColAndType(in LocalRes, "Book_Array" , JTokenType.Array))
            {
                log.Warn("本地资源索引中Book_Array字段检查发生错误");
                return false;
            }

            // 获取数组内容
            var books = from book in LocalRes["Book_Array"] select JObject.FromObject(book);

            // 设置校验条件
            Dictionary<string, JTokenType> map = new Dictionary<string, JTokenType>();
            map.Add("Book_Name", JTokenType.String);
            map.Add("File_Path", JTokenType.Array);
            map.Add("Link_Nun", JTokenType.Integer);
            map.Add("Valid", JTokenType.Boolean); 
            map.Add("IsChanged", JTokenType.Boolean);
            foreach (var book in books)
            {
                if(!Tools.MyJson.CheckColAndTypeFromMap(in book, in map))
                {
                    log.Info("书架内的数据异常::"+book.ToString());
                    return false;
                }
            }
            return true;
        }
        static public bool AddToBookshelf(in Book book)
        {
            //SelectToken with LINQ
            // $...name  意思是从当前接口文档的1,2,3级中查找name，并返回结果
            JObject jobj = new JObject();
            JObject jBook = book.toJson();
            jobj.Add("Book_Name", book.Book_Name);
            jobj.Add("File_Path", JArray.FromObject(book.File_Path));
            int booksize = LocalResArray.Count + 1;
            jobj.Add("Link_Nun", booksize );
            jobj.Add("Valid", true);
            jobj.Add("IsChanged", false);

            // 保存解析的图书到本地
            Tools.MyJson.JsonToFile(in jBook, Properties.Settings.Default.Local_Res_Path + "\\" + booksize + ".json");

            // 将数据添加到内存中,等
            LocalResArray.Add(jobj);

            // JToken oldBook = LocalRes.SelectToken("$.Book_Array[?(@.name=='张三')]");
            return true;
        }


    }
}
