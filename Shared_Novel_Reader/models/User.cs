using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Novel_Reader.models
{
    internal class User
    {
        private static ILog log = LogManager.GetLogger(typeof(User));
        
        public static bool IsInit = false;
        
        public static int User_ID;
        public static string Name;
        public static string Password;
        public static string Status;
        public static string Sex;
        public static int Level;
        public static int Power;
        public static int Integral;
        public static int Total_Integral;

        public static bool Init(in JObject userJson)
        {
            // 设置校验条件
            Dictionary<string, JTokenType> map = new Dictionary<string, JTokenType>();
            map.Add("User_ID", JTokenType.Integer);
            map.Add("Name", JTokenType.String);
            map.Add("Password", JTokenType.String);
            map.Add("Status", JTokenType.String);
            map.Add("Sex", JTokenType.String);
            map.Add("Level", JTokenType.Integer);
            map.Add("Power", JTokenType.Integer);
            map.Add("Integral", JTokenType.Integer);
            map.Add("Total_Integral", JTokenType.Integer);
            bool CheckAns = Tools.MyJson.CheckColAndTypeFromMap(userJson, map);
            if(!CheckAns)
            {
                log.Info("用户初始化失败");
                return false;
            }
            User_ID = (int)userJson["User_ID"];
            Level = (int)userJson["Level"];
            Power = (int)userJson["Power"];
            Integral = (int)userJson["Integral"];
            Total_Integral = (int)userJson["Total_Integral"];
            Name = (string)userJson["Name"];
            Password = (string)userJson["Password"];
            Status = (string)userJson["Status"];
            Sex = (string)userJson["Sex"];

            IsInit = true;
            return true;
        }
        public static string show()
        {
            if(!IsInit)
            {
                return "用户初始化失败";
            }
            string showStr = "";
            showStr += "账户ID : " + User_ID;
            showStr += "\n姓名 : " + Name;
            showStr += "\n密码 : " + Password;
            showStr += "\n性别 : " + Sex;
            showStr += "\n等级 : " + Level;
            showStr += "\n权限 : " + Power;
            showStr += "\n积分 : " + Integral;
            showStr += "\n总积分 : " + Total_Integral;
            showStr += "\n账户状态 : " + Status;
            return showStr;
        }
    }
}
