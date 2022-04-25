using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Novel_Reader.models
{
    /// <summary>
    /// 分卷类
    /// </summary>
    internal class Vol
    {
        ILog log = LogManager.GetLogger(typeof(Vol));
        /// <summary>
        /// 分卷类 初始化
        /// </summary>
        public Vol()
        {
            Vol_Num = 0;
            Chapter_Total_Num = 0;
            Need_Upload = 0;
            Exist_Upload = 0;
            Chapter_Array = new List<Chapter>();
        }

        /// <summary>
        /// 将章节内容标记为最新
        /// </summary>
        /// <returns></returns>
        public bool MarkVol()
        {
            int size = this.Chapter_Array.Count;
            for(int i = 0;i < Chapter_Array.Count;i++)
            {
                if(!Chapter_Array[i].MarkChapter())
                {
                    --size;
                }
            }
            if(size != this.Chapter_Array.Count)
            {
                log.Info("将 第" + Vol_Num + "卷 标记为最新--->失败");
                log.Info("预计标记最新章节数: " + this.Chapter_Array.Count + "\n实际标记最新章节数: " + size);
                return false;
            }
            log.Info("将 第" + Vol_Num + "卷 标记为最新--->成功");
            return true;
        }

        /// <summary>
        /// 根据Json数据初始化
        /// </summary>
        /// <param name="obj"></param>
        public Vol(JObject obj)
        {
            Vol_Num = 0;
            Chapter_Total_Num = 0;
            Need_Upload = 0;
            Exist_Upload = 0;
            Chapter_Array = new List<Chapter>();
            FromJson(ref obj);
        }

        /// <summary>
        /// 分卷数
        /// </summary>
        public int Vol_Num { get; set; }

        /// <summary>
        /// 章节总数
        /// </summary>
        public int Chapter_Total_Num { get; set; }


        /// <summary>
        /// 需要上传的章节数
        /// </summary>
        public int Need_Upload { get; set; }

        /// <summary>
        /// 已经上传的章节数
        /// </summary>
        public int Exist_Upload { get; set; }

        /// <summary>
        /// 分卷下的章节集合
        /// </summary>
        public List<Chapter> Chapter_Array;
        public void Push_Chapter(Chapter obj)
        {
            Chapter_Array.Add(obj);
            Need_Upload++;
            Chapter_Total_Num++;
        }

        /// <summary>
        /// 返回Json格式的Vol
        /// </summary>
        /// <returns>Json数据</returns>
        public JObject toJson()
        {
            JObject obj = new JObject();
            JArray jArray = new JArray();
            foreach (var item in Chapter_Array)
            {
                jArray.Add(item.toJson());
            }
            obj.Add("Vol_Num", Vol_Num);
            obj.Add("Chapter_Array", jArray);
            obj.Add("Need_Upload", Need_Upload);
            obj.Add("Exist_Upload", Exist_Upload);
            obj.Add("Chapter_Total_Num", Chapter_Total_Num);
            return obj;
        }

        /// <summary>
        /// 从Json数据中读取Vol数据
        /// </summary>
        /// <param name="obj">Json数据</param>
        public void FromJson(ref JObject obj)
        {
            if (obj.ContainsKey("Chapter_Array"))
            {
                //JToken token = obj["ContentArray"];
                //ContentArray = token.ToList<string>();
                //var names = from staff in obj["ContentArray"].Children() select (string)staff;
                Chapter_Array.Clear();
                var Chapters = obj.SelectToken("Chapter_Array").Select(p => (JObject)p).ToList();
                foreach (var chapter in Chapters)
                {
                    // ContentList.Add(name);
                    Chapter_Array.Add(new models.Chapter(chapter));
                }
            }
            if (obj.ContainsKey("Vol_Num"))
            {
                Vol_Num = ((int)obj["Vol_Num"]);
            }
            if (obj.ContainsKey("Need_Upload"))
            {
                Need_Upload = ((int)obj["Need_Upload"]);
            }
            if (obj.ContainsKey("Exist_Upload"))
            {
                Exist_Upload = ((int)obj["Exist_Upload"]);
            }
            if (obj.ContainsKey("Chapter_Total_Num"))
            {
                Chapter_Total_Num = ((int)obj["Chapter_Total_Num"]);
            }
        }
    }
}
