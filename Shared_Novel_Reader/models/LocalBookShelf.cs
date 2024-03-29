﻿using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.models
{
    /// <summary>
    /// 本地资源书架类-静态类型
    /// </summary>
    internal static class LocalBookShelf
    {
        static ILog log = LogManager.GetLogger(typeof(LocalBookShelf));
        static bool IsInit = false;
        static private string LocalResPath = Properties.Settings.Default.Local_Res_Path + "\\LocalRes.json";

        /// <summary>
        /// 内存加载
        /// </summary>
        static public List<Book> BookList = new List<Book>();

        /// <summary>
        /// 本地书架保存对象
        /// </summary>
        static public JObject LocalRes = new JObject();

        /// <summary>
        /// 本地书架目录
        /// </summary>
        static public JArray LocalResArray = new JArray();

        /// <summary>
        /// 打开并初始化本地书架
        /// </summary>
        /// <returns></returns>
        static public bool open()
        {
            if (IsInit) return true;
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
            IsInit = true;
            return true;
        }

        /// <summary>
        /// 关闭并保存书架图书
        /// </summary>
        /// <returns></returns>
        static public bool close()
        {
            if(!IsInit) return true;
            foreach (var name in LocalResArray)
            {
                if (!closeBook((string)name["Book_Name"], (int)name["Link_Num"]))
                {
                    log.Info("目标图书("+ (string)name["Book_Name"] + ")保存失败");
                    return false;
                }
            }

            LocalRes["Book_Array"] = LocalResArray;
            if (!Tools.MyJson.JsonToFile(in LocalRes, LocalResPath))
            {
                log.Info("书架关闭时,保存图书索引数据失败");
                return false;
            }
            IsInit = false;
            return true;
        }

        /// <summary>
        /// 根据图书名字将图书从内存中保存到硬盘中
        /// </summary>
        /// <param name="BookName">图书名称</param>
        /// <param name="LinkNum">文件名</param>
        /// <returns></returns>
        static public bool closeBook(string BookName,int LinkNum)
        {
            ILog log = LogManager.GetLogger(typeof (LocalBookShelf));
            int removeNum = FindBookInMemoryByName(BookName);
            if (removeNum < 0)
            {
                log.Info("目标图书不在内存中");
                return true;
            }
            JObject JBook = BookList[removeNum].toJson();
            if(!Tools.MyJson.JsonToFile(in JBook, Properties.Settings.Default.Local_Res_Path + "\\" + LinkNum + ".json"))
            {
                log.Info("图书保存失败");
                return false;
            }
            BookList.RemoveAt(removeNum);
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
            /*
                "Book_Array":[
                    {
                        "Book_Name": "",
                        "File_Path": [
                            "",
                            ""
                        ], // 记录曾经解析过哪些
                        "Link_Num":0,
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
            map.Add("Link_Num", JTokenType.Integer);
            map.Add("PartNum", JTokenType.Integer);
            map.Add("ChapterNum", JTokenType.Integer);
            map.Add("ContentNum", JTokenType.Integer);
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

        /// <summary>
        /// 在BookList中根据书名查找图书资源
        /// </summary>
        /// <param name="bookname">书名</param>
        /// <returns>返回索引,没找到则返回-1</returns>
        static public int FindBookInMemoryByName(in string bookname)
        {
            int size = BookList.Count;
            for(int i = 0; i < size; i++)
            {
                if(bookname == BookList[i].Book_Name)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// 根据文件编号加载文件
        /// </summary>
        /// <returns></returns>
        static public bool LoadBookByNum(in int num)
        {
            string path = Properties.Settings.Default.Local_Res_Path + "\\" + num + ".json";
            JObject jobj = new JObject();
            if (!Tools.MyJson.JsonFromFile(ref jobj, path))
            {
                log.Info("从Resources文件夹内加载文件 "+ num + ".json 失败");
                return false;
            }
            Book existBook = new Book(jobj);
            BookList.Add(existBook);
            return true;
        }



        /// <summary>
        /// 将解析后的图书加入到书架中
        /// </summary>
        /// <param name="book">解析后的图书</param>
        /// <returns></returns>
        static public bool AddToBookshelf(in Book book)
        {
            // 在保存数据前，应该先校验数据
            int TargetBook = -1;// 说明目标不曾解析过
            foreach (var name in LocalResArray)
            {
                if ((string)name["Book_Name"] == book.Book_Name)
                {
                    // 开始在内存中查找图书信息
                    int index = FindBookInMemoryByName(book.Book_Name);

                    // 如果没找到说明不在内存里,则需要从Resources文件夹内加载到内存里
                    if(index == -1)
                    {
                        // 文件加载失败
                        if(!LoadBookByNum((int)name["Link_Num"]))
                        {
                            log.Info("图书加载失败");
                            return false;
                        }
                        index = FindBookInMemoryByName(book.Book_Name);
                    }

                    /// 能运行到这里说明在index位置就是需要的图书资源
                    TargetBook = index;
                    break;
                }
            }

            // 如果匹配到了说明此书曾被解析过同名文件，需检查解析历史
            if(TargetBook != -1)
            {
                /// 检查此文件是否被解析过
                if (BookList[TargetBook].CompareFilePath(book.File_Path[0]))
                {
                    MessageBox.Show("此图书文件曾被解析过");
                    return false;
                }


                // 说明此图书不曾被解析过，需要解析后加入原有的图书中
                if (!BookList[TargetBook].CompareBook(in book))
                {
                    MessageBox.Show("图书资源整合失败");
                    return false;
                }
                BookList[TargetBook].File_Path.Add(book.File_Path[0]);
                // 资源整合成功后,直接返回
                return true;
            }
            log.Info("此图书未被解析过");

            // 否则说明是完全的新书,则赋予新的书架ID并保存到本地即可
            //SelectToken with LINQ
            // $...name  意思是从当前接口文档的1,2,3级中查找name，并返回结果
            // 如果资源没有目录，则创建一个默认的章节
            if(book.Vol_Array.Count == 0)
            {
                List<string> content = new List<string>();
                content.Add("默认章节内容");
                book.InsertNewChapter(1, 1, "默认章节", content);
            }
            JObject jobj = new JObject();
            JObject jBook = book.toJson();
            jobj.Add("Book_Name", book.Book_Name);
            int booksize = LocalResArray.Count + 1;
            jobj.Add("Link_Num", booksize );
            jobj.Add("PartNum", 0);
            jobj.Add("ChapterNum", 0);
            jobj.Add("ContentNum", 0);
            jobj.Add("Valid", true);
            jobj.Add("IsChanged", false);

            // 保存解析的图书到本地
            Tools.MyJson.JsonToFile(in jBook, Properties.Settings.Default.Local_Res_Path + "\\" + booksize + ".json");

            // 将数据添加到内存中
            LocalResArray.Add(jobj);
            if(!book.MarkBook())
            {
                log.Info("图书资源初始化标记为最新资源失败");
                return false;
            }
            BookList.Add(book);

            // JToken oldBook = LocalRes.SelectToken("$.Book_Array[?(@.name=='张三')]");
            return true;
        }


        /// <summary>
        /// 将指定图书从书架中删除
        /// </summary>
        /// <param name="BookName"></param>
        /// <returns></returns>
        static public bool RemoveFromBookshelf(in string BookName)
        {
            for (int i = 0; i <  LocalResArray.Count; i++)
            {
                if ((string)LocalResArray[i]["Book_Name"] == BookName)
                {
                    // 开始在内存中查找图书信息
                    int index = FindBookInMemoryByName(BookName);

                    // 如果找到说明在内存里,需要从内存里移除
                    if (index != -1)
                    {
                        BookList.RemoveAt(index);
                    }

                    // 运行到这里说明内存中已经移除，现在需要从目录中移除
                    LocalResArray.RemoveAt(i);
                    return true;
                }
            }

            for (int i = 0; i < LocalResArray.Count; i++)
            {
                if ((string)LocalResArray[i]["Book_Name"] == BookName)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
