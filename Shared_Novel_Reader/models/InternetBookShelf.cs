using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Novel_Reader.models;
using System.Windows.Forms;
using Shared_Novel_Reader.Tools;
using Shared_Novel_Reader.MyForm.ToolForm;
using System.Threading;

namespace Shared_Novel_Reader.models
{
    /// <summary>
    /// 网络资源书架类-静态类型
    /// </summary>
    internal class InternetBookShelf
    {
        static public bool IsInit = false;
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
            usermap.Add("User_ID", JTokenType.Integer);
            usermap.Add("Book_Array", JTokenType.Array);
            // 设置校验条件
            Dictionary<string, JTokenType> map = new Dictionary<string, JTokenType>();
            map.Add("Book_Name", JTokenType.String);
            map.Add("Book_ID", JTokenType.Integer);

            // 获取数组内容
            var users = from user in InternetRes["User_Array"] select JObject.FromObject(user);
            foreach (var user in users)
            {
                if (!Tools.MyJson.CheckColAndTypeFromMap(in user, in usermap))
                {
                    log.Info("网络书架内的用户数据异常::" + user.ToString());
                    return false;
                }

                var books = from book in user["Book_Array"] select JObject.FromObject(book);
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
            if (IsInit) return true;
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
                if(Convert.ToInt32( user["User_ID"] ) == User.User_ID)
                {
                    InternetResArray = (JArray)user["Book_Array"];
                    IsInit = true;
                    return true;
                }
            }
            log.Info("用户网络书架未找到,开始初始化网络书架");
            JObject newUser = new JObject();
            newUser["User_ID"] = User.User_ID;
            newUser["Book_Array"] = new JArray();
            InternetResUserArray.Add(newUser);
            InternetResArray = new JArray();
            IsInit = true;
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
                if (Convert.ToInt32(InternetResUserArray[index]["User_ID"]) != User.User_ID)
                    continue;
                //保存书架信息
                InternetResUserArray[index]["Book_Array"] = InternetResArray;
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
            IsInit = false;
            InternetResUserArray.Clear();
            InternetRes.RemoveAll();
            InternetResArray.Clear();
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
                if(Convert.ToInt32( book["Book_ID"]) == bookid )
                {
                    log.Info("此网络图书已在用户书架中");
                    return false;
                }
            }

            JObject jBook = new JObject();
            jBook.Add("Book_Name", bookname);
            jBook.Add("Book_ID", bookid);

            // 将图书记录保存到数组中
            InternetResArray.Add(jBook);
            log.Info("网络图书加入用户书架成功");

            // JToken oldBook = LocalRes.SelectToken("$.Book_Array[?(@.name=='张三')]");
            return true;
        }


        static async public void DownloadBook(string bookname,int bookid)
        {

            // 如果还未加入书架则加入书架
            if (!User.IsInit)
            {
                log.Info("用户还未登入，请先登入");
                return;
            }
            AddToBookshelf(bookname,bookid);

            // 弹出提示框，询问是否覆盖原先已缓存的数据
            bool overload = false;
            DialogResult result = MessageBox.Show("是否覆盖原先已缓存的数据？", "下载资源", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                overload = true;
            }

            // 1.根据图书id向后端请求图书目录
            // 2.根据目录循环获取内容
            // 3.传入图书ID，分卷数，章节数逐一获取内容
            JObject ReqJson = new JObject();
            ReqJson["Book_Name"] = bookname;
            ReqJson["Book_ID"] = bookid;
            // 发送请求
            var MenuResult = Task<MyResponse>.Run(() => Tools.API.User.Resource.SearchMenu(ReqJson));

            MyResponse res = await MenuResult;
            /// 返回格式
            if (res == null || !res.Result)
            {
                // 清除残留数据
                log.Info("在线图书章节列表查询失败");
                return;
            }
            else if (res.Data["ChapterList"].ToString() == "")
            {
                log.Info("在线图书章节为空");
                return;
            }
            JArray ChapterListJson = (JArray)res.Data["ChapterList"];

            // 查询/建立本地资源

            if (!models.LocalBookShelf.open())
            {
                log.Info("本地书架打开失败");
                return;
            }
            log.Info("本地书架打开成功");
            // 现在本地资源找此书
            int index = -1;// 在内存中的位置
            foreach (var name in LocalBookShelf.LocalResArray)
            {
                if ((string)name["Book_Name"] == bookname)
                {
                    // 开始在内存中查找图书信息
                    index = LocalBookShelf.FindBookInMemoryByName(bookname);

                    // 如果没找到说明不在内存里,则需要从Resources文件夹内加载到内存里
                    if (index == -1)
                    {
                        // 文件加载失败
                        if (!LocalBookShelf.LoadBookByNum((int)name["Link_Num"]))
                        {
                            log.Info("图书加载失败");
                            break;
                        }
                        index = LocalBookShelf.FindBookInMemoryByName(bookname);
                    }

                    break;
                }
            }
            // 开始在内存中查找图书信息
            // 说明图书资源不存在，新建图书资源
            if(index == -1)
            {
                models.Book book = new Book();
                book.Book_Name = bookname;
                book.Book_Author = res.Data["BookData"]["Author"].ToString();
                book.Book_Publisher = res.Data["BookData"]["Publisher"].ToString();
                book.Book_Synopsis = res.Data["BookData"]["Synopsis"].ToString();
                models.LocalBookShelf.AddToBookshelf(book);
            }
            /// 能运行到这里说明在index位置就是需要的图书资源
            index = LocalBookShelf.FindBookInMemoryByName(bookname);
            if (index == -1)
            {
                log.Info("图书资源加载失败");
                return;
            }
            log.Info("本地图书加载成功");


            // 初始化进度条
            FormProcessbar FormProcessbar = new FormProcessbar();
            FormProcessbar.Text = "下载《" + bookname + "》中";
            FormProcessbar.ProgressBar.Maximum = ChapterListJson.Count();
            int FZ = 0, FM = ChapterListJson.Count();
            FormProcessbar.LabelFM.Text = Convert.ToString(FM);
            FormProcessbar.LabelFZ.Text = Convert.ToString(FZ);
            FormProcessbar.ProgressBar.Value = FZ;
            FormProcessbar.Show();
            foreach (var chapter in ChapterListJson)
            {
                ReqJson.RemoveAll();
                ReqJson["Book_ID"] = bookid;
                ReqJson["Part_Num"] = chapter["VolNum"];
                ReqJson["Chapter_Num"] = chapter["ChapterNum"];
                ReqJson["Type"] = "Download";


                // 发送请求
                var ContentResult = Task<MyResponse>.Run(() => Tools.API.User.Resource.SearchContent(ReqJson));

                res = await ContentResult;
                /// 返回格式
                if (res == null)
                {
                    // 清除残留数据
                    log.Info("网络异常，跳过");
                    continue;
                }
                else if(!res.Result)
                {
                    log.Info("获取失败:"+res.Message);
                    if(res.Message == "积分扣除失败:积分不足，请充值")
                    {
                        MessageBox.Show(res.Message);
                        FormProcessbar.Hide();
                        FormProcessbar.Close();
                        FormProcessbar.Dispose();
                        return;
                    }
                }
                else if (res.Data["ChapterContent"].ToString() == "")
                {
                    log.Info("在线图书章节内容为空");
                    continue;
                }

                List<string> ContentList = new List<string>();
                res.Data["ChapterContent"].ToList().ForEach(item => ContentList.Add(item.ToString()));

                JObject UserData = res.Data["User_Data"] as JObject;
                // 设置校验条件
                Dictionary<string, JTokenType> usermap = new Dictionary<string, JTokenType>();
                usermap.Add("Integral", JTokenType.Integer);
                usermap.Add("TotalIntegral", JTokenType.Integer);
                usermap.Add("Level", JTokenType.Integer);
                MyJson.CheckColAndTypeFromMap(UserData, usermap);
                User.Level = Convert.ToInt32(UserData["Level"].ToString());
                User.Integral = Convert.ToInt32(UserData["Integral"].ToString());
                User.Total_Integral = Convert.ToInt32(UserData["TotalIntegral"].ToString());

                /*JArray ContentArray = (JArray)res.Data["ChapterContent"];
                ContentArray.ToList().ForEach(x => ContentList.Add(x.ToString()));*/
                bool overloadRes = LocalBookShelf.BookList[index].OverloadChapter(Convert.ToInt32(chapter["VolNum"]), Convert.ToInt32(chapter["ChapterNum"]), chapter["ChapterTitle"].ToString(), ContentList, overload);
                if (!overloadRes)
                    return;
                // 更改进度条
                FZ++;
                FormProcessbar.LabelFZ.Text = Convert.ToString(FZ);
                FormProcessbar.ProgressBar.Value = FZ;
            }
            FormProcessbar.Hide();
            FormProcessbar.Close();
            FormProcessbar.Dispose();
            if (FZ!=FM)
            {
                MessageBox.Show("部分章节下载失败,请重试");
            }
            return;
        }





    }
}
