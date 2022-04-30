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
        
        private static Regex TitleRegex = new Regex(@"(?:^\s*|^\s*第.*?)(第[^\s,.，。]*?[章篇]\s?(?<ChapterTitle>.*))");
        private static Regex PartRegex = new Regex(@"(第[^\s,.，。]*?卷)");
        private static Regex ChapterRegex = new Regex(@"(第([^\s,.，。]*?)[章篇])");
        private static Regex ChineseNumRegex = new Regex(@"([零一二三四五六七八九十百千万亿]+)");
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
/*
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
                            newChapter.ChapTitle = matchResult.Groups["ChapterTitle"].ToString();// 设置标题
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
*/

                int num = 0, volnum = 0,chapnum = 0;// 设置全局章节/卷标记
                // 初始化新书
                newBook = new models.Book();
                newBook.File_Path.Add(fs.Name);
                Match match = BookNameRegex.Match(fs.Name);
                newBook.Book_Name = match.Groups["BookName"].ToString();

                // 初始化章节内容
                string title = string.Empty;
                List<string>Content = new List<string>();

                while ((line = sr.ReadLine()) != null)
                {
                    if (!String.IsNullOrWhiteSpace(line))// 读取新的一行
                    {
                        Text = line.Trim();// 格式化段落

                        // 识别标题
                        Match matchResult = TitleRegex.Match(Text);

                        if (matchResult.Success)
                        {
                            Console.WriteLine(Text);
                            // 章节大于0 保存 去除了非章节的内容
                            if (num > 0)
                            {
                                newBook.InsertNewChapter(volnum, chapnum, title, Content);
                            }
                            // 清空之前的数据
                            Content = new List<string> {};
                            title = matchResult.Groups["ChapterTitle"].ToString();// 设置标题
                            Match matchChapResult = ChapterRegex.Match(Text);
                            // 如果是章节名,保存之前章节的数据并新建一个章节
                            chapnum = (int)Novel_Analysis.GetNum(matchChapResult.Value);
                            // 如果是第一章 判断标题中是否存在卷数
                            if (chapnum == 1)
                            {
                                // 说明开了新的一卷
                                Match matchVolResult = PartRegex.Match(Text);
                                if(matchVolResult.Success)
                                    volnum = (int)Novel_Analysis.GetNum(matchVolResult.Value);
                                else
                                    volnum++;
                            }
                            else
                            {
                                // 如果没有明确的卷信息
                                if(volnum == 0)
                                {
                                    // 判断是那一卷
                                    Match matchVolResult = PartRegex.Match(Text);
                                    if (matchVolResult.Success)
                                        volnum = (int)Novel_Analysis.GetNum(matchVolResult.Value);
                                    else
                                        volnum = 1;// 标为第一卷
                                }
                            }
                            num++;
                        }
                        else
                        {
                            // 不是章节名说明是章节内容，则保存到章节中
                            Content.Add(Text);// 保存段落内容到章节内容空间中
                        }
                    }
                }
                newBook.InsertNewChapter(volnum, chapnum, title, Content);
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



    }
}
