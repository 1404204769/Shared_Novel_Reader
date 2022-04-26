using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Novel_Reader.models
{
    internal class Comment
	{
		public int User_ID = 0;
        public int Reply_Floor_ID = 0;
        public int Note_ID = 0;
        public int Floor_ID = 0;
        public int Comment_ID = 0;
        public int Agree_Num = 0;
        public string Create_Time = string.Empty;
        public string ContentStr = string.Empty;
        public int Book_ID = 0;
        public JObject Content = null;


        /// <summary>
        /// 从Json数据中读取数据
        /// </summary>
        /// <param name="obj">Json数据</param>
        public Comment(JObject obj)
        {

            if (obj.ContainsKey("Comment_Content"))
            {
                Content = (JObject)obj["Comment_Content"];
            }

            if (Content != null && Content.ContainsKey("Content"))
            {
                ContentStr = ((string)Content["Content"]);
            }

            if (Content != null && Content.ContainsKey("Book_ID"))
            {
                Book_ID = ((int)Content["Book_ID"]);
            }

            if (obj.ContainsKey("Create_Time"))
            {
                Create_Time = ((string)obj["Create_Time"]);
            }

            if (obj.ContainsKey("User_ID"))
            {
                User_ID = ((int)obj["User_ID"]);
            }

            if (obj.ContainsKey("Reply_Floor_ID"))
            {
                Reply_Floor_ID = ((int)obj["Reply_Floor_ID"]);
            }

            if (obj.ContainsKey("Note_ID"))
            {
                Note_ID = ((int)obj["Note_ID"]);
            }

            if (obj.ContainsKey("Floor_ID"))
            {
                Floor_ID = ((int)obj["Floor_ID"]);
            }

            if (obj.ContainsKey("Comment_ID"))
            {
                Comment_ID = ((int)obj["Comment_ID"]);
            }

            if (obj.ContainsKey("Agree_Num"))
            {
                Agree_Num = ((int)obj["Agree_Num"]);
            }
        }
    }
}
