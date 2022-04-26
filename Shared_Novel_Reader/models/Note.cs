using Newtonsoft.Json.Linq;

namespace Shared_Novel_Reader.models
{
    internal class Note
    {
        public int Comment_Count = 0;
        public int Note_ID = 0;
        public int User_ID = 0;
        public string Create_Time = "";
        public string Update_Time = "";
        public string Type = "";
        public string Title = "";
        public string Status = "";
        public JObject ContentObj = null;
        public int Book_ID = 0;
        public string Content = "";


        /// <summary>
        /// 从Json数据中读取数据
        /// </summary>
        /// <param name="obj">Json数据</param>
        public Note(in JObject obj)
        {
            if (obj.ContainsKey("Content"))
            {
                ContentObj = (JObject)obj["Content"];
            }

            if (ContentObj != null && ContentObj.ContainsKey("Content"))
            {
                Content = ((string)ContentObj["Content"]);
            }

            if (ContentObj != null && ContentObj.ContainsKey("Book_ID"))
            {
                Book_ID = ((int)ContentObj["Book_ID"]);
            }

            if (obj.ContainsKey("Create_Time"))
            {
                Create_Time = ((string)obj["Create_Time"]);
            }
            if (obj.ContainsKey("Update_Time"))
            {
                Update_Time = ((string)obj["Update_Time"]);
            }
            if (obj.ContainsKey("Status"))
            {
                Status = ((string)obj["Status"]);
            }
            if (obj.ContainsKey("Title"))
            {
                Title = ((string)obj["Title"]);
            }
            if (obj.ContainsKey("Type"))
            {
                Type = ((string)obj["Type"]);
            }
            if (obj.ContainsKey("Comment_Count"))
            {
                Comment_Count = ((int)obj["Comment_Count"]);
            }

            if (obj.ContainsKey("User_ID"))
            {
                User_ID = ((int)obj["User_ID"]);
            }

            if (obj.ContainsKey("Note_ID"))
            {
                Note_ID = ((int)obj["Note_ID"]);
            }
        }
    }
}
