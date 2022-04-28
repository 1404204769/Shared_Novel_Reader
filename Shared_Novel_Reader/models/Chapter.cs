using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Novel_Reader.models
{
    /// <summary>
    /// 章节类
    /// </summary>
    internal class Chapter
    {
        ILog log = LogManager.GetLogger(typeof(Chapter));
        /// <summary>
        /// 章节标题
        /// </summary>
        public string ChapTitle { get; set; }

        /// <summary>
        /// 章节数,默认为0
        /// </summary>
        public int ChapNum { get; set; }

        /// <summary>
        /// 章节内容
        /// </summary>
        public List<models.Content> ContentList;

        /// <summary>
        /// 创建时间,默认为当前时间
        /// </summary>
        public string Create_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        /// <summary>
        /// 更改时间,默认为当前时间
        /// </summary>
        public string Update_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        /// <summary>
        /// 上传时间,默认为时间最小值
        /// </summary>
        public string Upload_Time = DateTime.MinValue.ToString("yyyy-MM-dd HH:mm:ss");


        /// <summary>
        /// 章节类 初始化
        /// </summary>
        public Chapter()
        {
            ChapNum = 0;
            ChapTitle = "";
            Create_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Update_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Upload_Time = DateTime.MinValue.ToString("yyyy-MM-dd HH:mm:ss");
            ContentList = new List<models.Content>();
        }

        /// <summary>
        /// 章节类 初始化
        /// </summary>
        public Chapter(int num)
        {
            ChapNum = num;
            ChapTitle = "";
            Create_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Update_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Upload_Time = DateTime.MinValue.ToString("yyyy-MM-dd HH:mm:ss");
            ContentList = new List<models.Content>();
        }


        /// <summary>
        /// 将章节标记为最新
        /// </summary>
        /// <returns></returns>
        public bool MarkChapter()
        {
            if (ContentList.Count != 1)
            {
                log.Info("将 第"+ ChapNum + "章\t"+ ChapTitle + "\t标记为最新--->失败");
                return false;
            }
            ContentList[0].Best_New = true;
            log.Info("将 第" + ChapNum + "章\t" + ChapTitle + "\t标记为最新--->成功");
            return true;
        }

        /// <summary>
        /// 根据Json数据初始化
        /// </summary>
        /// <param name="obj"></param>
        public Chapter(JObject obj)
        {
            ChapNum = 0;
            ChapTitle = "";
            ContentList = new List<models.Content>();
            Create_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Update_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Upload_Time = DateTime.MinValue.ToString("yyyy-MM-dd HH:mm:ss");
            FromJson(ref obj);
        }


        /// <summary>
        /// 将章节内容保存
        /// </summary>
        /// <param name="content"></param>
        public void Push_Content(Content content)
        {
            ContentList.Add(content);
        }


        /// <summary>
        /// 比较 章节
        /// </summary>
        /// <param name="newChapter">新增的章节</param>
        /// <returns></returns>
        public bool CompareChapter(in Chapter newChapter)
        {
            /*
             Chapter:
                ContentList
                ChapTitle
                ChapNum
             */

            // 比较章节 标题是否一致
            if (this.ChapNum != newChapter.ChapNum)
            {
                log.Info("章节数不同,无法比较(ExistChapNum : " + this.ChapNum + ",newChapNum : " + newChapter.ChapNum + ")");
                return false;
            }
            if (this.ChapTitle != newChapter.ChapTitle)
            {
                log.Info("章节标题不同,无法比较(ExistChapTitle : " + this.ChapTitle + ",newChapTitle : " + newChapter.ChapTitle + ")");
                return false;
            }

            int Target = -1;// 标记目标位置

            // 开始循环搜索ContentList,找到基准内容(Best_New=true)
            for (int i = 0; i < this.ContentList.Count; i++)
            {
                if (this.ContentList[i].Best_New)
                {
                    Target = i;
                    break;
                }
            }

            // 没找到基准内容
            if (Target == -1)
            {
                log.Info("没找到基准内容");
                return false;
            }

            Content newContent = newChapter.ContentList[0];
            // 开始比较当前内容是否一致
            if (!this.ContentList[Target].CompareContent(ref newContent))
            {
                log.Info("章节(第" + this.ChapNum + "章 : " + this.ChapTitle + ")内容相同");
                return true;
            }

            ContentList.Add(newContent);

            return true;
        }






        /// <summary>
        /// 返回Json格式的Chapter
        /// </summary>
        /// <returns>Json数据</returns>
        public JObject toJson()
        {
            JObject obj = new JObject();
            JArray jArray = new JArray();
            foreach (var item in ContentList)
            {
                jArray.Add(item.toJson());
            }
            obj.Add("ContentList", jArray);
            obj.Add("ChapTitle", ChapTitle);
            obj.Add("ChapNum", ChapNum);
            obj.Add("Create_Time", Create_Time);
            obj.Add("Update_Time", Update_Time);
            obj.Add("Upload_Time", Upload_Time);
            return obj;
        }

        /// <summary>
        /// 从Json数据中读取Chapter数据
        /// </summary>
        /// <param name="obj">Json数据</param>
        public void FromJson(ref JObject obj)
        {
            if (obj.ContainsKey("ContentList"))
            {
                //JToken token = obj["ContentArray"];
                //ContentArray = token.ToList<string>();
                //var names = from staff in obj["ContentArray"].Children() select (string)staff;
                ContentList.Clear();
                var contents = obj.SelectToken("ContentList").Select(p => (JObject)p).ToList();
                foreach (var content in contents)
                {
                    // ContentList.Add(name);
                    ContentList.Add(new models.Content(content));
                }
            }
            if (obj.ContainsKey("ChapTitle"))
            {
                ChapTitle = ((string)obj["ChapTitle"]);
            }
            if (obj.ContainsKey("ChapNum"))
            {
                ChapNum = ((int)obj["ChapNum"]);
            }
            if (obj.ContainsKey("Create_Time"))
            {
                this.Create_Time = ((string)obj["Create_Time"]);
            }
            if (obj.ContainsKey("Update_Time"))
            {
                this.Update_Time = ((string)obj["Update_Time"]);
            }
            if (obj.ContainsKey("Upload_Time"))
            {
                this.Upload_Time = ((string)obj["Upload_Time"]);
            }
        }
    }
}
