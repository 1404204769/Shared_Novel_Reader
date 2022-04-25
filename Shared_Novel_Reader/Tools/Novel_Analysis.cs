using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Shared_Novel_Reader.Tools
{
    internal class Novel_Analysis
    {
        private static Tools.Dependence.ChineseNumberConvert.ChineseNumberConverter CNC = new Tools.Dependence.ChineseNumberConvert.ChineseNumberConverter();
        
        private static Regex TitleRegex = new Regex(@"(?:^\s*|^\s*第.*?)(第[^\s,.，。]*?[章篇]\s?.*)");
        private static Regex PartRegex = new Regex(@"(第[^\s,.，。]*?卷)");
        private static Regex ChapterRegex = new Regex(@"(第([^\s,.，。]*?)[章篇])");
        private static Regex ChineseNumRegex = new Regex(@"([一二三四五六七八九十百千万亿]+)");
        private static Regex AlabNumRegex = new Regex(@"([0-9]+)");
        private static Regex BookNameRegex = new Regex(@"(?<BookName>[^<>/\\\|:""\*\?]+)\.\w+$");
        private static String Text { get; set; }// 内容




        //定义一个函数，返回字符串中的汉字个数

        public static int GetHanNumFromString(string str)
        {
            int count = 0;
            Regex regex = new Regex(@"^[\u4E00-\u9FA5]{0,}$");
            for (int i = 0; i < str.Length; i++)
            {
                if (regex.IsMatch(str[i].ToString()))
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// 加载本地资源文件并解析
        /// </summary>
        /// <param name="path">要解析的文件的地址</param>
        public static bool Analysis_Local_Resource(out models.Book newBook, String path)
        {
            string err;
            ILog log = LogManager.GetLogger(typeof(Novel_Analysis));
            if (String.IsNullOrEmpty(path))
            {
                newBook = null;
                err = "要解析的文件路径为空,请重新选择文件";
                log.Info(err);
                return false;
            }
            try
            {
                FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(fs);
                if (sr.CurrentEncoding == Encoding.UTF8)
                {
                    var chArr = new char[1024];
                    sr.Read(chArr, 0, chArr.Length);
                    var buffer1 = Encoding.UTF8.GetBytes(chArr);// 将chArr转化为UTF8编码的字节数组，单个字节处理
                    var buffer2 = new byte[buffer1.Length];
                    fs.Position = 0;
                    fs.Read(buffer2, 0, buffer2.Length);
                    var same = true;// 循环比较是否是UTF8编码，若不是则用GBK重新读取
                    for (int i = 0; i < buffer1.Length; i++)
                    {
                        if (buffer1[i] != buffer2[i])
                        {
                            same = false;
                            break;
                        }
                    }
                    if (!same)
                    {
                        fs.Position = 0;
                        sr = new StreamReader(fs, Encoding.GetEncoding("GBK"));
                    }
                    else
                    {
                        fs.Position = 0;
                        sr = new StreamReader(fs);
                    }
                }
                String line;
                // 读取txt文件并分段保存，将章节名标记为isHeader

                int num = 0, vol = 1;// 设置全局章节/卷标记
                // 初始化新书
                newBook = new models.Book();
                newBook.File_Path.Add(fs.Name);
                Match match = BookNameRegex.Match(fs.Name);
                newBook.Book_Name = match.Groups["BookName"].ToString();
            

                // 初始化卷
                models.Vol newVol = new models.Vol();
                newVol.Vol_Num = vol;


                // 初始化章节
                models.Chapter newChapter = new models.Chapter();


                // 初始化章节内容
                models.Content newContent = new models.Content();

                while ((line = sr.ReadLine()) != null)
                {
                    if (!String.IsNullOrWhiteSpace(line))// 读取新的一行
                    {
                        Text = line.Trim();// 格式化段落

                        Match matchResult = TitleRegex.Match(Text);

                        if (matchResult.Success)
                        {
                            Console.WriteLine(Text);
                            // 如果是章节名,保存之前章节的数据并新建一个章节
                            long chapnum = Novel_Analysis.GetNum(Text);
                            if(num > 0)
                            {
                                newChapter.Push_Content(newContent);// 保存章节内容到Chapter中
                                newContent = new models.Content();// 初始化章节内容
                                newVol.Push_Chapter(newChapter);// 保存章节信息到卷中
                                newChapter = new models.Chapter();// 初始化章节信息
                            }
                            newChapter.ChapTitle = Text;// 设置标题
                            newChapter.ChapNum = (int)chapnum;// 记录章节数
                            if (chapnum == 1 && num > 0)
                            {
                                // 说明开了新的一卷
                                newBook.Push_Vol(newVol);// 保存卷信息到书中
                                newVol = new models.Vol();// 初始化卷信息
                                newVol.Vol_Num = ++vol;// 设置卷数为最新
                            }
                            num++;
                        }
                        else
                        {
                            // 不是章节名说明是章节内容，则保存到章节中
                            newContent.ContentArray.Add(Text);// 保存段落内容到章节内容空间中
                        }
                    }
                }
                newChapter.Push_Content(newContent);// 保存章节内容到Chapter中
                newVol.Push_Chapter(newChapter);// 保存章节信息到卷中
                newBook.Push_Vol(newVol);// 保存卷信息到书中
                sr.Dispose();// 关闭sr 释放资源
            }
            catch (SystemException ex)
            {
                newBook = null;
                err = "解析本地资源发生异常";
                log.Info(err,ex);
                return false;
            }
            catch (Exception ex)
            {
                newBook = null;
                err = "解析本地资源发生异常";
                log.Info(err,ex);
                return false;
            }
            return true;
        }


        
        /// <summary>
        /// 返回标题的第一个匹配项
        /// </summary>
        /// <param name="text"> 匹配对象 </param>
        /// <returns></returns>
        public static Match GetTitle(string text)
        {
            return TitleRegex.Match(text);
        }

        /// <summary>
        /// 根据传入的字符串(全是中文数字/全是阿拉伯数字)返回整形阿拉伯数字
        /// </summary>
        /// <param name="text">要解析的字符串数字</param>
        /// <returns>解析后的整形数字</returns>
        public static long GetNum(string strNum)
        {
            Match ArabMatch = AlabNumRegex.Match(strNum);
            if(ArabMatch.Success)
            {
                return Convert.ToInt64(ArabMatch.Value);
            }
            Match ChineseMatch = ChineseNumRegex.Match(strNum);
            if (ChineseMatch.Success)
            {
                return CNC.Convert(ChineseMatch.Value);
            }
            return -1;
        }


        /// <summary>
        /// 比较 内容
        /// </summary>
        /// <param name="ExistContentList">已存在的内容列表</param>
        /// <param name="newContentList">新增的章节列表</param>
        /// <returns></returns>
        public static bool CompareContent(ref List<models.Content> ExistContentList, in List<models.Content> newContentList)
        {
            ILog log = LogManager.GetLogger(typeof(Novel_Analysis));
            // 开始循环搜索ContentList,找到基准内容(Temp_Make=false)

            int Target = -1;// 标记目标位置
            for(int i=0;i<ExistContentList.Count;i++)
            {
                if(ExistContentList[i].Best_New)
                {
                    Target = i;
                    break;
                }
            }

            // 没找到基准内容
            if(Target == -1)
            {
                log.Info("没找到基准内容");
                return false;
            }


            // 开始比较内容
            List<string> ExistContentArray = ExistContentList[Target].ContentArray;
            List<string> NewContentArray = newContentList[0].ContentArray;

            // 如果内容行数不一样，说明内容不一样
            if(ExistContentArray.Count != NewContentArray.Count)
            {
                newContentList[0].Best_New = false;
                models.Content newContent = new models.Content(newContentList[0]);
                ExistContentList.Add(newContent);
                return true;
            }

            // 否则开始比较内容
            bool Same = true;
            for(int i = 0; i < ExistContentArray.Count; i++)
            {
                if(ExistContentArray[i] != NewContentArray[i])
                {
                    Same = false;
                    break;
                }
            }

            // 说明内容不一样，则记录
            if (!Same)
            {
                newContentList[0].Best_New = false;
                models.Content newContent = new models.Content(newContentList[0]);
                ExistContentList.Add(newContent);
                return true;
            }
            return true;
        }


        /// <summary>
        /// 比较 章节
        /// </summary>
        /// <param name="ExistChapterList">已存在的章节列表</param>
        /// <param name="newChapterList">新增的章节列表</param>
        /// <param name="CompareIndex">比较的下标</param>
        /// <returns></returns>
        public static bool CompareChapter(ref List<models.Chapter> ExistChapterList, in List<models.Chapter> newChapterList, in int CompareIndex)
        {
            ILog log = LogManager.GetLogger(typeof(Novel_Analysis));
            /*
             Chapter:
                ContentList
                ChapTitle
                ChapNum
             */
            
            // 比较章节 标题是否一致
            if(ExistChapterList[CompareIndex].ChapNum != newChapterList[CompareIndex].ChapNum)
            {
                log.Info("章节数不同,无法比较(ExistChapNum : "+ ExistChapterList[CompareIndex].ChapNum + ",newChapNum : "+ newChapterList[CompareIndex].ChapNum + ")");
                return false;
            }
            if (ExistChapterList[CompareIndex].ChapTitle != newChapterList[CompareIndex].ChapTitle)
            {
                log.Info("章节标题不同,无法比较(ExistChapTitle : " + ExistChapterList[CompareIndex].ChapTitle + ",newChapTitle : " + newChapterList[CompareIndex].ChapTitle + ")");
                return false;
            }

            List<models.Content> existContentList = ExistChapterList[CompareIndex].ContentList;
            List<models.Content> newContentList = newChapterList[CompareIndex].ContentList;
            // 开始比较当前内容是否一致
            if (!CompareContent(ref existContentList, in newContentList))
            {
                log.Info("章节(第" + ExistChapterList[CompareIndex].ChapNum + "章 : " + ExistChapterList[CompareIndex].ChapTitle + ")内容比较失败");
                return false;
            }


            return true;
        }


        /// <summary>
        /// 比较 卷
        /// </summary>
        /// <param name="ExistVolList">已存在的卷列表</param>
        /// <param name="newVolList">新增的卷列表</param>
        /// <param name="CompareIndex">比较的下标</param>
        /// <returns></returns>
        public static bool CompareVol(ref List<models.Vol> ExistVolList, in List<models.Vol> newVolList, in int CompareIndex)
        {
            ILog log = LogManager.GetLogger(typeof(Novel_Analysis));
            /*
             Vol:
                Vol_Num
                Chapter_Total_Num
                Chapter_Array
                Need_Upload
                Exist_Upload
             */
            int CompareChapterNum = -1;// 需要比较的章节数
            // 如果章节数不存在则直接复制过来
            if (ExistVolList[CompareIndex].Chapter_Total_Num < newVolList[CompareIndex].Chapter_Total_Num)
            {
                // 将接下来要比较的卷数先记录下来
                CompareChapterNum = ExistVolList[CompareIndex].Chapter_Total_Num;

                // 开始把新增的卷直接加入
                for (int i = CompareChapterNum; i < newVolList[CompareIndex].Chapter_Total_Num; i++)
                {
                    if (!newVolList[CompareIndex].Chapter_Array[i].MarkChapter())
                    {
                        MessageBox.Show("新章节资源标记为最新资源失败");
                        return false;
                    }
                    ExistVolList[CompareIndex].Push_Chapter(newVolList[CompareIndex].Chapter_Array[i]);
                }

            }
            // 如果新卷的章节数数没有超过原卷,则所有章节都比较
            else if (ExistVolList[CompareIndex].Chapter_Total_Num >= newVolList[CompareIndex].Chapter_Total_Num)
            {
                CompareChapterNum = newVolList[CompareIndex].Chapter_Total_Num;
            }

            // 开始循环判断章节数
            for (int i = 0; i < CompareChapterNum; i++)
            {
                List<models.Chapter> existChapterList = ExistVolList[CompareIndex].Chapter_Array;
                List<models.Chapter> newChapterList = newVolList[CompareIndex].Chapter_Array;
                if (!CompareChapter(ref existChapterList, in newChapterList, in i))
                {
                    log.Info("第" + (CompareIndex + 1) + "卷第" + (i + 1) + "章比较失败");
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 比较解析图书,将新书的内容整合到旧书中
        /// </summary>
        /// <param name="oldBook"></param>
        /// <param name="newBook"></param>
        /// <returns></returns>
        public static bool CompareBook(ref List<models.Book> BookList,in int TargetBook,in models.Book book)
        {
            ILog log = LogManager.GetLogger(typeof(Novel_Analysis));
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
            if (BookList[TargetBook].Vol_Total_Num < book.Vol_Total_Num)
            {
                // 将接下来要比较的卷数先记录下来
                CompareVolNum = BookList[TargetBook].Vol_Total_Num;

                // 开始把新增的卷直接加入
                for(int i = CompareVolNum; i < book.Vol_Total_Num; i++)
                {
                    if (!book.Vol_Array[i].MarkVol())
                    {
                        MessageBox.Show("新卷资源标记为最新资源失败");
                        return false;
                    }
                    BookList[TargetBook].Push_Vol(book.Vol_Array[i]);
                }

            }
            // 如果新书的卷数没有超过原书,则所有卷都比较
            else if(BookList[TargetBook].Vol_Total_Num >= book.Vol_Total_Num)
            {
                CompareVolNum = book.Vol_Total_Num;
            }

            // 开始循环判断卷数
            for(int i = 0; i < CompareVolNum;i++)
            {
                List<models.Vol> existVolList = BookList[TargetBook].Vol_Array;
                List<models.Vol> newVolList = book.Vol_Array; 
                if(!CompareVol(ref existVolList, in newVolList,in i))
                {
                    log.Info("第" + (i + 1) + "卷比较失败");
                    return false;
                }
            }
            
            return true;
        }








    }
}
