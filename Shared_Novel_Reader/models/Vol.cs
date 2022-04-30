using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.models
{
    /// <summary>
    /// 分卷类
    /// </summary>
    internal class Vol
    {
        ILog log = LogManager.GetLogger(typeof(Vol));
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
                log.Info("将分卷 第" + Vol_Num + "卷 标记为最新--->失败");
                log.Info("预计标记最新章节数: " + this.Chapter_Array.Count + "\n实际标记最新章节数: " + size);
                return false;
            }
            log.Info("将分卷 第" + Vol_Num + "卷 标记为最新--->成功");
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
        /// 将新章节的内容保存在分卷中
        /// </summary>
        /// <param name="chapter"></param>
        public void Push_Chapter(Chapter chapter)
        {
            Chapter_Array.Add(chapter);
            Need_Upload++;
            Chapter_Total_Num++;
        }


        /// <summary>
        /// 比较 卷
        /// </summary>
        /// <param name="ExistVolList">已存在的卷列表</param>
        /// <param name="newVolList">新增的卷列表</param>
        /// <param name="CompareIndex">比较的下标</param>
        /// <returns></returns>
        public bool CompareVol(in Vol newVol)
        {
            /*
             Vol:
                Vol_Num
                Chapter_Total_Num
                Chapter_Array
                Need_Upload
                Exist_Upload
             */
            bool res = true;
            int CompareChapterNum = -1;// 需要比较的章节数
            // 如果章节数不存在则直接复制过来
            if (this.Chapter_Total_Num < newVol.Chapter_Total_Num)
            {
                // 将接下来要比较的卷数先记录下来
                CompareChapterNum = this.Chapter_Total_Num;

                // 开始把新增的卷直接加入
                for (int i = CompareChapterNum; i < newVol.Chapter_Total_Num; i++)
                {
                    if (!newVol.Chapter_Array[i].MarkChapter())
                    {
                        log.Info("新章节资源标记为最新资源失败");
                        continue;
                    }
                    this.Push_Chapter(newVol.Chapter_Array[i]);
                }

            }
            // 如果新卷的章节数数没有超过原卷,则所有章节都比较
            else if (this.Chapter_Total_Num >= newVol.Chapter_Total_Num)
            {
                CompareChapterNum = newVol.Chapter_Total_Num;
            }

            // 开始循环判断章节数
            for (int i = 0; i < CompareChapterNum; i++)
            {
                Chapter newChapter = newVol.Chapter_Array[i];
                if (!this.Chapter_Array[i].CompareChapter(newChapter))
                {
                    log.Info("第" + this.Vol_Num + "卷第" + newChapter.ChapNum + "章比较失败");
                    res = false;
                    continue;
                }
            }

            return res;
        }


        public void CheckUpload()
        {
            // 遍历每个章节
            this.Exist_Upload = 0;
            this.Need_Upload = 0;
            for (int i = 0; i < Chapter_Array.Count; i++)
            {
                // 如果章节没有内容说明是无效章节
                if (Chapter_Array[i].ContentList.Count <= 0)
                {
                    continue;
                }
                DateTime upload = DateTime.Parse(Chapter_Array[i].Upload_Time);
                DateTime update = DateTime.Parse(Chapter_Array[i].Update_Time);
                // 如果上传时间小于等于更新时间则说明无需上传更改
                if (upload >= update)
                {
                    this.Exist_Upload++;
                }
                else
                {
                    this.Need_Upload++;
                }
            }
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
