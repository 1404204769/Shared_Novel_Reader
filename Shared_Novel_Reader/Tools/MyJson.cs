using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.Tools
{
    internal class MyJson
    {
        private static Regex FileTypeRegex = new Regex(@"[^<>/\\\|:""\*\?]+\.(?<FileType>\w+)$");
        
        /// <summary>
        /// 从Json文件中解析Json对象
        /// </summary>
        /// <param name="obj">引用的Json对象，需要提前实例化</param>
        /// <param name="path">需要解析的文件的地址</param>
        /// <returns></returns>
        public static bool JsonFromFile(ref JObject obj, string path)
        {
            string err;
            ILog log = LogManager.GetLogger(typeof(MyJson));
            if (String.IsNullOrEmpty(path))
            {
                err = "要解析的文件路径为空,请重新选择文件";
                log.Info(err);
                return false;
            }
            Match match = FileTypeRegex.Match(path);
            if(!match.Success)
            {
                err = "要解析的文件路径错误,这不是规范的文件";
                log.Info(err);
                return false;
            }
            if(match.Groups["FileType"].Value != "json")
            {
                err = "要解析的文件路径错误,这不是Json文件";
                log.Info(err);
                return false;
            }

            try
            {
                FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(fs);

                obj = JObject.Parse(sr.ReadToEnd());

                sr.Close();// 关闭sr 释放资源
            }
            catch (SystemException ex)
            {
                err = "从文件解析Json发生SystemException异常";
                log.Info(err, ex);
                return false;
            }
            catch (Exception ex)
            {
                err = "从文件解析Json发生Exception异常";
                log.Info(err, ex);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 将Json对象写入文件中
        /// </summary>
        /// <param name="obj">要写入文件的Json对象</param>
        /// <param name="path">要写入的路径(类似 C:\xxx\yy.json 这种格式)</param>
        /// <returns></returns>
        public static bool JsonToFile(in JObject obj, string path)
        {
            string err;
            ILog log = LogManager.GetLogger(typeof(MyJson));
            if (String.IsNullOrEmpty(path))
            {
                err = "保存文件的路径为空,请重新输入保存路径";
                log.Info(err);
                return false;
            }
            Match match = FileTypeRegex.Match(path);
            if (!match.Success)
            {
                err = "保存文件的路径错误,这不是规范的(C:\\xxx\\yyy.json)路径";
                log.Info(err);
                return false;
            }
            if (match.Groups["FileType"].Value != "json")
            {
                err = "要保存的文件类型错误,这不是Json文件";
                log.Info(err);
                return false;
            }

            try
            {
                File.WriteAllText(path, obj.ToString(Newtonsoft.Json.Formatting.Indented, null), System.Text.Encoding.UTF8);//将内容写进json文件中
            }
            catch (SystemException ex)
            {
                err = "把Json写入文件发生SystemException异常";
                log.Info(err, ex);
                return false;
            }
            catch (Exception ex)
            {
                err = "把Json写入文件发生Exception异常";
                log.Info(err, ex);
                return false;
            }
            return true;
        }




        public static bool CheckColAndType(in JObject obj, string ColName,JTokenType tokenType)
        {
            string err;
            ILog log = LogManager.GetLogger(typeof(MyJson));
            JProperty jProperty = obj.Property(ColName);
            if (jProperty == null)
            {
                log.Warn( ColName + "字段不存在");
                return false;
            }
            JToken jToken = jProperty.Value;
            if (jToken.Type != tokenType)
            {
                err = ColName + "字段不是";
                switch (tokenType)
                {
                    case JTokenType.Object:
                        {
                            err += "Object类型";
                        }
                        break;
                    case JTokenType.Array:
                        {
                            err += "Array类型";
                        }
                        break;
                    case JTokenType.Float:
                        {
                            err += "Float类型";
                        }
                        break;
                    case JTokenType.Integer:
                        {
                            err += "Integer类型";
                        }
                        break;
                    case JTokenType.String:
                        {
                            err += "String类型";
                        }
                        break;
                    case JTokenType.Boolean:
                        {
                            err += "Boolean类型";
                        }
                        break;
                    case JTokenType.Date:
                        {
                            err += "Date类型";
                        }
                        break;
                }
                log.Warn(err);
                return false;
            }
            return true;
        }

        public static bool CheckColAndTypeFromMap(in JObject obj, in Dictionary<string, JTokenType> map)
        {
            foreach (var VK in map)
            {
                if(!CheckColAndType(in obj,VK.Key,VK.Value))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
