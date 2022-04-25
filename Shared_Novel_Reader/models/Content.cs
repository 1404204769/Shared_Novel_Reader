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
    /// 章节内容类
    /// </summary>
    internal class Content
    {

        /// <summary>
        /// 章节内容列表
        /// </summary>
        public List<string> ContentArray { get; set; }

        /// <summary>
        /// 最新版标记,默认为false
        /// </summary>
        public bool Best_New { set; get; }


        /// <summary>
        /// 新建实体时BestNew为false
        /// </summary>
        public Content()
        {
            ContentArray = new List<string>();
            Best_New = false;
        }

        public Content(JObject obj)
        {
            ContentArray = new List<string>();
            Best_New = false;
            FromJson(ref obj);
        }
        public Content(List<string> contentArray,  bool best_New = false )
        {
            ContentArray = contentArray;
            Best_New = best_New;
        }

        /// <summary>
        /// 复制实体时将BestNew复制过来
        /// </summary>
        /// <param name="content"></param>
        public Content(Content content)
        {
            ContentArray = new List<string>();
            foreach (string s in content.ContentArray)
            {
                ContentArray.Add(s);
            }
            Best_New = content.Best_New;
        }



        /// <summary>
        /// 比较 内容
        /// </summary>
        /// <param name="newContent">已存在的内容</param>
        /// <returns>true 表示内容存在差异，false表示内容相同</returns>
        public bool CompareContent(ref Content newContent)
        {

            // 如果内容行数不一样，说明内容不一样
            if (this.ContentArray.Count != newContent.ContentArray.Count)
            {
                newContent.Best_New = false;
                return true;
            }

            // 否则开始比较内容
            for (int i = 0; i < this.ContentArray.Count; i++)
            {
                if (ContentArray[i] != newContent.ContentArray[i])
                {
                    newContent.Best_New = false;
                    return true;
                }
            }

            return false;
        }



        /// <summary>
        /// 返回Json格式的Content
        /// </summary>
        /// <returns>Json数据</returns>
        public JObject toJson()
        {
            JObject obj = new JObject();
            JArray jArray = JArray.FromObject(ContentArray);
            obj.Add("ContentArray", jArray);
            obj.Add("Best_New", Best_New);
            return obj;
        }

        /// <summary>
        /// 从Json数据中读取Content数据
        /// </summary>
        /// <param name="obj">Json数据</param>
        public void FromJson(ref JObject obj)
        {
            if (obj.ContainsKey("ContentArray"))
            {
                //JToken token = obj["ContentArray"];
                //ContentArray = token.ToList<string>();
                //var names = from staff in obj["ContentArray"].Children() select (string)staff;
                this.ContentArray.Clear();
                var names = obj.SelectToken("ContentArray").Select(p => (string)p).ToList();
                foreach (var name in names)
                {
                    this.ContentArray.Add(name);
                }
            }
            if(obj.ContainsKey("Best_New"))
            {
                this.Best_New = ((bool)obj["Best_New"]);
            }
        }
    }
    
}
