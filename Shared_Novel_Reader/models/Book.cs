using log4net;
using Newtonsoft.Json;
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
    /// 图书类
    /// </summary>
    internal class Book
    {
        /// <summary>
        /// 图书名称
        /// </summary>
        public string Book_Name { get; set; }

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

        ILog log = LogManager.GetLogger(typeof(Book));


        public Book()
        {
            Book_Name = "";
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
                        MessageBox.Show("新卷资源标记为最新资源失败");
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
            for (int i = 0; i < CompareVolNum; i++)
            {
                Vol newVol = book.Vol_Array[i];
                if (!this.Vol_Array[i].CompareVol(in newVol))
                {
                    log.Info("第" + this.Vol_Array[i].Vol_Num + "卷比较失败");
                    return false;
                }
            }

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
            obj.Add("File_Path", JArray.FromObject(File_Path));
            obj.Add("Vol_Total_Num", Vol_Total_Num);
            obj.Add("Need_Upload", Need_Upload);
            obj.Add("Exist_Upload", Exist_Upload);
            obj.Add("Vol_Array", jArray);
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

    }
}
