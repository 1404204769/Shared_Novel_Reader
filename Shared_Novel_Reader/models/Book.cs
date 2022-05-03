using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.models
{
    /// <summary>
    /// 图书类
    /// </summary>
    internal class Book
    {
        ILog log = LogManager.GetLogger(typeof(Book));

        public bool IsDownload { get; set; }

        /// <summary>
        /// 图书名称
        /// </summary>
        public string Book_Name { get; set; }

        /// <summary>
        /// 图书作者
        /// </summary>
        public string Book_Author { get; set; }

        /// <summary>
        /// 图书出版商
        /// </summary>
        public string Book_Publisher { get; set; }

        /// <summary>
        /// 图书简介
        /// </summary>
        public string Book_Synopsis { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        public List<string> File_Path { get; set; }

        /// <summary>
        /// 分卷总数
        /// </summary>
        public int Vol_Total_Num;
        /// <summary>
        /// 需要上传的章节
        /// </summary>
        public int Need_Upload { get; set; }

        /// <summary>
        /// 已经上传的章节
        /// </summary>
        public int Exist_Upload { get; set; }

        /// <summary>
        /// 此书的分卷集合
        /// </summary>
        public List<Vol> Vol_Array { get; set; }


        public Book()
        {
            Book_Name = "";
            Book_Author = string.Empty;
            Book_Publisher = string.Empty;
            Book_Synopsis = string.Empty;
            IsDownload = false;
            File_Path = new List<string>();
            Vol_Total_Num = Need_Upload = Exist_Upload = 0;
            Vol_Array = new List<Vol>();
        }

        /// <summary>
        /// 从Json文件中读取
        /// </summary>
        /// <param name="obj"></param>
        public Book(JObject obj)
        {
            Book_Name = "";
            Book_Author = string.Empty;
            Book_Publisher = string.Empty;
            Book_Synopsis = string.Empty;
            IsDownload = false;
            File_Path = new List<string>();
            Vol_Total_Num = Need_Upload = Exist_Upload = 0;
            Vol_Array = new List<Vol>();
            FromJson(ref obj);
        }

        /// <summary>
        /// 比较后者是否在前者中存在
        /// </summary>
        /// <param name="FilePath">新书的文件地址</param>
        /// <returns>true 代表 后者存在于前者中</returns>
        public bool CompareFilePath(in string FilePath)
        {
            return File_Path.IndexOf(FilePath) >= 0;
        }

        /// <summary>
        /// 保存新卷
        /// </summary>
        /// <param name="obj"></param>
        public void Push_Vol(Vol obj)
        {
            Vol_Array.Add(obj);
            Vol_Total_Num++;
            Need_Upload += obj.Need_Upload;
            Exist_Upload += obj.Exist_Upload;
        }

        /// <summary>
        /// 将图书标记为最新
        /// </summary>
        /// <returns></returns>
        public bool MarkBook()
        {
            int size = this.Vol_Array.Count;
            for (int i = 0; i < Vol_Array.Count; i++)
            {
                if (!Vol_Array[i].MarkVol())
                {
                    --size;
                }
            }
            if (size != this.Vol_Array.Count)
            {
                log.Info("将图书 " + Book_Name + " 标记为最新--->失败");
                log.Info("预计标记最新卷数: " + this.Vol_Array.Count + "\n实际标记最新卷数: " + size);
                return false;
            }
            log.Info("将图书 " + Book_Name + " 标记为最新--->成功");
            return true;
        }

        public void CheckUpload()
        {
            // 遍历每个分卷
            this.Exist_Upload = 0;
            this.Need_Upload = 0;
            for (int i = 0; i < Vol_Array.Count ; i++)
            {
                Vol_Array[i].CheckUpload();
                this.Exist_Upload += Vol_Array[i].Exist_Upload;
                this.Need_Upload += Vol_Array[i].Need_Upload;
            }
        }


        /// <summary>
        /// 比较解析图书,将新书的内容整合到旧书中
        /// </summary>
        /// <param name="oldBook"></param>
        /// <param name="newBook"></param>
        /// <returns></returns>
        public bool CompareBook(in models.Book book)
        {
            // BookList[TargetBook]
            /*
             Book:
                Book_Name
                File_Path
                Exist_Upload
                Need_Upload
                Vol_Array
                Vol_Total_Num
             */
            int CompareVolNum = -1;// 需要比较的卷数
            // 如果卷数不存在则直接将对应的新卷复制到原有的图书内
            if (this.Vol_Total_Num < book.Vol_Total_Num)
            {
                // 将接下来要比较的卷数先记录下来
                CompareVolNum = this.Vol_Total_Num;

                // 开始把新增的卷直接加入
                for (int i = CompareVolNum; i < book.Vol_Total_Num; i++)
                {
                    if (!book.Vol_Array[i].MarkVol())
                    {
                        log.Info("新卷资源标记为最新资源失败");
                        return false;
                    }
                    this.Push_Vol(book.Vol_Array[i]);
                }

            }
            // 如果新书的卷数没有超过原书,则所有卷都比较
            else if (this.Vol_Total_Num >= book.Vol_Total_Num)
            {
                CompareVolNum = book.Vol_Total_Num;
            }

            // 开始循环判断卷数
            bool res = true;
            for (int i = 0; i < CompareVolNum; i++)
            {
                Vol newVol = book.Vol_Array[i];
                if (!this.Vol_Array[i].CompareVol(in newVol))
                {
                    log.Info("第" + this.Vol_Array[i].Vol_Num + "卷比较失败");
                    res = false;
                    continue;
                }
            }
            if (!res)
                MessageBox.Show("图书资源部分整合失败");
            return true;
        }




        /// <summary>
        /// 返回Json格式的Book
        /// </summary>
        /// <returns>Json数据</returns>
        public JObject toJson()
        {
            JObject obj = new JObject();
            JArray jArray = new JArray();
            foreach (var item in Vol_Array)
            {
                jArray.Add(item.toJson());
            }
            obj.Add("Book_Name", Book_Name);
            obj.Add("Book_Author", Book_Author);
            obj.Add("Book_Publisher", Book_Publisher);
            obj.Add("Book_Synopsis", Book_Synopsis);
            obj.Add("File_Path", JArray.FromObject(File_Path));
            obj.Add("Vol_Total_Num", Vol_Total_Num);
            obj.Add("Need_Upload", Need_Upload);
            obj.Add("Exist_Upload", Exist_Upload);
            obj.Add("Vol_Array", jArray);
            obj.Add("IsDownload", IsDownload);
            return obj;
        }

        /// <summary>
        /// 从Json数据中读取Book数据
        /// </summary>
        /// <param name="obj">Json数据</param>
        public void FromJson(ref JObject obj)
        {
            if (obj.ContainsKey("Vol_Array"))
            {
                //JToken token = obj["ContentArray"];
                //ContentArray = token.ToList<string>();
                //var names = from staff in obj["ContentArray"].Children() select (string)staff;
                Vol_Array.Clear();
                var Vols = obj.SelectToken("Vol_Array").Select(p => (JObject)p).ToList();
                foreach (var vol in Vols)
                {
                    // ContentList.Add(name);
                    Vol_Array.Add(new models.Vol(vol));
                }
            }
            if (obj.ContainsKey("Book_Name"))
            {
                Book_Name = ((string)obj["Book_Name"]);
            }
            if (obj.ContainsKey("Book_Author"))
            {
                Book_Author = ((string)obj["Book_Author"]);
            }
            if (obj.ContainsKey("Book_Publisher"))
            {
                Book_Publisher = ((string)obj["Book_Publisher"]);
            }
            if (obj.ContainsKey("Book_Synopsis"))
            {
                Book_Synopsis = ((string)obj["Book_Synopsis"]);
            }
            if (obj.ContainsKey("IsDownload"))
            {
                IsDownload = ((bool)obj["IsDownload"]);
            }
            if (obj.ContainsKey("File_Path"))
            {
                File_Path = JsonConvert.DeserializeObject<List<string>>(obj["File_Path"].ToString());
            }
            if (obj.ContainsKey("Vol_Total_Num"))
            {
                Vol_Total_Num = ((int)obj["Vol_Total_Num"]);
            }
            if (obj.ContainsKey("Need_Upload"))
            {
                Need_Upload = ((int)obj["Need_Upload"]);
            }
            if (obj.ContainsKey("Exist_Upload"))
            {
                Exist_Upload = ((int)obj["Exist_Upload"]);
            }
        }


        /// <summary>
        /// 减少章节冲突，选择最新的版本，其余版本删除
        /// </summary>
        /// <param name="volNum">分卷数</param>
        /// <param name="chapNum">章节数</param>
        /// <param name="version">版本号</param>
        /// <returns></returns>
        public bool ReduceChapterConflicts(int volNum, int chapNum, int version = 0)
        {
            if (Vol_Array.Count < volNum)
            {
                log.Info("目标分卷数不存在");
                return false;
            }
            Vol vol = Vol_Array[volNum - 1];

            if (vol.Chapter_Array.Count < chapNum)
            {
                log.Info("目标章节数不存在");
                return false;
            }
            Chapter chap = vol.Chapter_Array[chapNum - 1];

            if(chap.ContentList.Count < version)
            {
                log.Info("目标版本不存在");
                return false;
            }

            // 取消旧版标记
            foreach(var content in chap.ContentList)
            {
                content.Best_New = false;
            }

            // 打上新的标记
            chap.ContentList[version].Best_New = true;

            // 将其他的删除
            for (int i = 0;i< chap.ContentList.Count; i++)
            {
                if(!chap.ContentList[i].Best_New)
                {
                    chap.ContentList.RemoveAt(i);
                }
            }
            // 保存回去

            return true;
        }

        /// <summary>
        /// 给图书添加章节
        /// </summary>
        /// <param name="volnum">章节所在分卷数</param>
        /// <param name="chapnum">章节数</param>
        /// <param name="chaptitle">章节名</param>
        /// <param name="content">章节内容</param>
        /// <returns></returns>
        public bool InsertNewChapter(int volnum,int chapnum,string chaptitle,List<string>content)
        {
            if(Vol_Array.Count < volnum)
            {
                // 如果此卷不存在则新建卷
                for(int i = Vol_Array.Count;i < volnum; i++)
                {
                    Vol newvol = new Vol();
                    newvol.Vol_Num = i + 1;
                    Push_Vol(newvol);
                }
            }

            Vol vol = Vol_Array[volnum - 1];
            if (vol.Chapter_Array.Count < chapnum)
            {
                // 如果此章节不存在则新建章节
                for (int i = vol.Chapter_Array.Count; i < chapnum; i++)
                {
                    Chapter newchap = new Chapter(i + 1);
                    if (i+1 == chapnum)
                    {
                        newchap.ChapTitle = chaptitle;
                    }
                    vol.Push_Chapter(newchap);
                }
            }
            else
            {
                // 如果此章节存在则判断是否存在标题
                if(vol.Chapter_Array[chapnum - 1].ChapTitle == "")
                {
                    vol.Chapter_Array[chapnum - 1].ChapTitle = chaptitle;
                }
                
            }

            Chapter chap = vol.Chapter_Array[chapnum - 1];
            if(chap.ContentList.Count == 0)
            {
                chap.ContentList.Add(new Content(content,true) );
            }
            else
            {
                if(chap.ChapTitle != chaptitle)
                {
                    DialogResult result = MessageBox.Show("新增章节名与原有的不一样,是否使用原有的或者放弃插入新内容？", "插入新章节", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("放弃插入新内容");
                        return false;
                    }
                    MessageBox.Show("使用原有的章节名:"+chap.ChapTitle);
                }
                if(chap.ContentList[chap.ContentList.Count - 1].ContentArray.Count == 1 && chap.ContentList[chap.ContentList.Count - 1].ContentArray[0] == "")
                {
                    MessageBox.Show("此章节已存在新添加的待编辑的内容");
                    return false;
                }
                else
                {
                    chap.ContentList.Add(new Content(content, false));
                }
            }
            return true;
        }


        public bool RemoveChapter(int volNum, int chapNum, int version = 0)
        {

            if (Vol_Array.Count < volNum)
            {
                log.Info("目标分卷数不存在");
                return false;
            }
            Vol vol = Vol_Array[volNum - 1];

            if (vol.Chapter_Array.Count < chapNum)
            {
                log.Info("目标章节数不存在");
                return false;
            }
            Chapter chap = vol.Chapter_Array[chapNum - 1];

            if (chap.ContentList.Count < version)
            {
                log.Info("目标版本不存在");
                return false;
            }


            chap.ContentList.RemoveAt(version);

            return true;
        }

        public bool ChangeChapterTitle(int volNum, int chapNum, string title,int version = 0)
        {
            if (Vol_Array.Count < volNum)
            {
                log.Info("目标分卷数不存在");
                return false;
            }
            Vol vol = Vol_Array[volNum - 1];

            if (vol.Chapter_Array.Count < chapNum)
            {
                log.Info("目标章节数不存在");
                return false;
            }
            Chapter chap = vol.Chapter_Array[chapNum - 1];

            if (chap.ContentList.Count < version)
            {
                log.Info("目标版本不存在");
                return false;
            }

            chap.ChapTitle = title;

            return true;
        }

        /// <summary>
        /// 上传所有新资源  UploadTime==Mini
        /// </summary>
        public async void UploadAllNew()
        {
            /*  以此作为API数据模板         
                {
                "Book_Author":"",//作者
                "Book_Name":"", // 书名
                "Book_Publisher":"",// 签约平台
                "Book_Synopsis":"", // 提要
                "Chapter_List":[
                    {
                        "Vol_Num":1,
                        "Chapter_Num":2,
                        "Chapter_Title": "企鹅：用心创造快乐",
                        "Content_Array": [
                            "“%……&amp;%@”"
                        ]
                    }
                ]
            }
            */
            // 遍历所有章节造就模板
            JObject ReqJson = new JObject();
            ReqJson["Book_Author"] = this.Book_Author;
            ReqJson["Book_Name"] = this.Book_Name;
            ReqJson["Book_Publisher"] = this.Book_Publisher;
            ReqJson["Book_Synopsis"] = this.Book_Synopsis;
            JArray ReqArray = new JArray();
            for (int i = 0; i < Vol_Array.Count; i++)
            {
                if (Vol_Array[i].Need_Upload == 0) continue;
                for(int j = 0; j < Vol_Array[i].Chapter_Array.Count; j++)
                {
                    // 如果没有数据则跳过
                    if(Vol_Array[i].Chapter_Array[j].ContentList.Count == 0)
                    {
                        continue;
                    }
                    // 说明存在冲突
                    if (Vol_Array[i].Chapter_Array[j].ContentList.Count > 1)
                    {
                        MessageBox.Show("此图书待上传资源存在冲突内容，请先解决冲突", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        return;
                    }
                    DateTime upload = DateTime.Parse(Vol_Array[i].Chapter_Array[j].Upload_Time);
                    DateTime update = DateTime.Parse(Vol_Array[i].Chapter_Array[j].Update_Time);
                    // 如果上传时间大于等于更新时间则说明无需上传更改
                    if (upload >= update)
                    {
                        continue;
                    }
                    // 说明曾经上传过，需要调用的是更新接口
                    if(upload != DateTime.MinValue)
                    {
                        continue;
                    }
                    // 更新时间
                    JObject ChapJson = new JObject();
                    ChapJson["Vol_Num"] = Vol_Array[i].Vol_Num;
                    ChapJson["Chapter_Num"] = Vol_Array[i].Chapter_Array[j].ChapNum;
                    ChapJson["Chapter_Title"] = Vol_Array[i].Chapter_Array[j].ChapTitle;
                    JArray ContentArray = new JArray();
                    foreach (var contentstr in Vol_Array[i].Chapter_Array[j].ContentList[0].ContentArray)
                    {
                        ContentArray.Add(contentstr);
                    }
                    ChapJson["Content_Array"] = ContentArray;

                    ReqArray.Add(ChapJson);
                }
            }
            ReqJson["Chapter_List"] = ReqArray;


            // 发送请求
            var UploadResult = Task<MyResponse>.Run(() => Tools.API.User.Resource.UploadNew(ReqJson));

            MyResponse res = await UploadResult;

            if (res == null || !res.Result)
            {
                // 清除残留数据
                log.Info("用户上传资源失败");
            }
            else if (res.Data["Chapter_List"].ToString() == "")
            {
                log.Info("用户上传结果为空");
            }
            else
            {
                JArray UploadResArrayJson = (JArray)res.Data["Chapter_List"];
                // log.Info(ApplicationListJson.ToString());
                foreach(JObject obj in UploadResArrayJson)
                {
                    Vol_Array[(int)obj["Vol_Num"] - 1].Chapter_Array[(int)obj["Chapter_Num"] - 1].Upload_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    if (!(bool)obj["Result"])
                    {
                        log.Info("第" + obj["Vol_Num"] + "卷" + " 第" + obj["Chapter_Num"] + "章 上传失败");
                    }
                    else
                        log.Info("第" + obj["Vol_Num"] + "卷" + " 第" + obj["Chapter_Num"] + "章 上传成功");
                }
                log.Info("用户上传资源成功");
            }
        }



        /// <summary>
        /// 申请更改部分章节
        /// </summary>
        public async void UploadSomeOld(List<Tuple<int,int>> ChooseChapterList)
        {
            /*  以此作为API数据模板         
            {
                "Book_Author":"",//作者
                "Book_Name":"", // 书名
                "Book_Publisher":"",
                "Chapter_List":[
                    {
                        "Vol_Num":  1,
                        "Chapter_Num":1,
                        "Chapter_Title": "",
                        "Content_Array": [""]
                    }
                ]
            }
            */
            // 遍历所有章节造就模板
            JObject ReqJson = new JObject();
            ReqJson["Book_Author"] = this.Book_Author;
            ReqJson["Book_Name"] = this.Book_Name;
            ReqJson["Book_Publisher"] = this.Book_Publisher;
            JArray ReqArray = new JArray();

            foreach(Tuple<int,int> choose in ChooseChapterList)
            {
                if (choose.Item1 > Vol_Array.Count)
                {
                    log.Info("选择的章节(第" + choose.Item1 + "卷 第" + choose.Item2 + "章)所在的分卷不存在");
                    continue;
                }

                if (choose.Item2 > Vol_Array[choose.Item1 - 1].Chapter_Array.Count)
                {
                    log.Info("选择的章节(第" + choose.Item1 + "卷 第" + choose.Item2 + "章)不存在");
                    continue;
                }
                // 如果没有数据则跳过
                if (Vol_Array[choose.Item1 - 1].Chapter_Array[choose.Item2 - 1].ContentList.Count == 0)
                {
                    log.Info("选择的章节(第" + choose.Item1 + "卷 第" + choose.Item2 + "章)不存在有效内容");
                    continue;
                }

                // 说明存在冲突
                if (Vol_Array[choose.Item1 - 1].Chapter_Array[choose.Item2 - 1].ContentList.Count > 1)
                {
                    MessageBox.Show("选择的章节(第" + choose.Item1 + "卷 第" + choose.Item2 + "章)存在冲突内容，请先解决冲突", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    return;
                }


                DateTime upload = DateTime.Parse(Vol_Array[choose.Item1 - 1].Chapter_Array[choose.Item2 - 1].Upload_Time);
                DateTime update = DateTime.Parse(Vol_Array[choose.Item1 - 1].Chapter_Array[choose.Item2 - 1].Update_Time);
                // 如果上传时间大于等于更新时间则说明无需上传更改
                if (upload >= update)
                {
                    continue;
                }
                // 说明不曾上传过，需要调用的是新资源接口
                if (upload == DateTime.MinValue)
                {
                    continue;
                }

                // 更新时间
                JObject ChapJson = new JObject();
                ChapJson["Vol_Num"] = Vol_Array[choose.Item1 - 1].Vol_Num;
                ChapJson["Chapter_Num"] = Vol_Array[choose.Item1 - 1].Chapter_Array[choose.Item2 - 1].ChapNum;
                ChapJson["Chapter_Title"] = Vol_Array[choose.Item1 - 1].Chapter_Array[choose.Item2 - 1].ChapTitle;
                JArray ContentArray = new JArray();
                foreach (var contentstr in Vol_Array[choose.Item1 - 1].Chapter_Array[choose.Item2 - 1].ContentList[0].ContentArray)
                {
                    ContentArray.Add(contentstr);
                }
                ChapJson["Content_Array"] = ContentArray;

                ReqArray.Add(ChapJson);

            }
            ReqJson["Chapter_List"] = ReqArray;

            // 发送请求
            var UploadResult = Task<MyResponse>.Run(() => Tools.API.User.Resource.UploadChange(ReqJson));

            MyResponse res = await UploadResult;

            if (res == null || !res.Result)
            {
                // 清除残留数据
                log.Info("用户申请更改资源失败");
            }
            else if (res.Data["Chapter_List"].ToString() == "")
            {
                log.Info("用户申请更改结果为空");
            }
            else
            {
                JArray UploadResArrayJson = (JArray)res.Data["Chapter_List"];
                // log.Info(ApplicationListJson.ToString());
                foreach (JObject obj in UploadResArrayJson)
                {
                    Vol_Array[(int)obj["Vol_Num"] - 1].Chapter_Array[(int)obj["Chapter_Num"] - 1].Upload_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    if (!(bool)obj["Result"])
                    {
                        log.Info("第" + obj["Vol_Num"] + "卷" + " 第" + obj["Chapter_Num"] + "章 申请更改失败");
                    }
                    else
                        log.Info("第" + obj["Vol_Num"] + "卷" + " 第" + obj["Chapter_Num"] + "章 申请更改成功");
                }
                log.Info("用户申请更改资源成功");
            }
        }


    }

}
