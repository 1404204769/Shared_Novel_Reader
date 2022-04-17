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
        /// <summary>
        /// 章节类 初始化
        /// </summary>
        public Chapter()
        {
            ChapNum = 0;
            ChapTitle = "";
            ContentList = new List<models.Content>();
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
            FromJson(ref obj);
        }

        /// <summary>
        /// 章节内容
        /// </summary>
        private List<models.Content> ContentList;
        public void Push_Content(Content obj)
        {
            ContentList.Add(obj);
        }

        /// <summary>
        /// 章节标题
        /// </summary>
        public string ChapTitle { get; set; }

        /// <summary>
        /// 章节数,默认为0
        /// </summary>
        public int ChapNum { get; set; }

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
        }
    }
}
