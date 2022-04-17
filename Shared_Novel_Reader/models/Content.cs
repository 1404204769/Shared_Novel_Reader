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
        public Content()
        {
            ContentArray = new List<string>();
            Version = 0;
            Upload_Mark = Best_New = Personal_Make = false;
            Create_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Update_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Upload_Time = DateTime.MinValue.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public Content(JObject obj)
        {
            ContentArray = new List<string>();
            Version = 0;
            Upload_Mark = Best_New = Personal_Make = false;
            Create_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Update_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Upload_Time = DateTime.MinValue.ToString("yyyy-MM-dd HH:mm:ss");
            FromJson(ref obj);
        }
        public Content(List<string> contentArray,int version = 0, bool upload_Mark = false, bool best_New = false, bool personal_Make = false)
        {
            ContentArray = contentArray;
            Version = version;
            Upload_Mark = upload_Mark;
            Best_New = best_New;
            Personal_Make = personal_Make;
            Create_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Update_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Upload_Time = DateTime.MinValue.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// 章节内容列表
        /// </summary>
        public List<string> ContentArray { get; set; }

        /// <summary>
        /// 版本号,默认为0
        /// </summary>
        public int Version { set; get; }

        /// <summary>
        /// 上传标记,默认为false
        /// </summary>
        public bool Upload_Mark { set; get; }

        /// <summary>
        /// 最新版标记,默认为false
        /// </summary>
        public bool Best_New { set; get; }

        /// <summary>
        /// 自定义标记,默认为false
        /// </summary>
        public bool Personal_Make { set; get; }

        /// <summary>
        /// 创建时间,默认为当前时间
        /// </summary>
        private string Create_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        /// <summary>
        /// 更改时间,默认为当前时间
        /// </summary>
        private string Update_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        /// <summary>
        /// 上传时间,默认为时间最小值
        /// </summary>
        private string Upload_Time = DateTime.MinValue.ToString("yyyy-MM-dd HH:mm:ss");

       
        /// <summary>
        /// 返回Json格式的Content
        /// </summary>
        /// <returns>Json数据</returns>
        public JObject toJson()
        {
            JObject obj = new JObject();
            JArray jArray = JArray.FromObject(ContentArray);
            obj.Add("ContentArray", jArray);
            obj.Add("Version", Version);
            obj.Add("Create_Time", Create_Time);
            obj.Add("Update_Time", Update_Time);
            obj.Add("Upload_Time", Upload_Time);
            obj.Add("Upload_Mark", Upload_Mark);
            obj.Add("Best_New", Best_New);
            obj.Add("Personal_Make", Personal_Make);
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
            if (obj.ContainsKey("Version"))
            {
                this.Version = ((int)obj["Version"]);
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
            if(obj.ContainsKey("Upload_Mark"))
            {
                this.Upload_Mark = ((bool)obj["Upload_Mark"]);
            }
            if(obj.ContainsKey("Best_New"))
            {
                this.Best_New = ((bool)obj["Best_New"]);
            }
            if (obj.ContainsKey("Personal_Make"))
            {
                this.Personal_Make = ((bool)obj["Personal_Make"]);
            }
        }
    }
    
}
