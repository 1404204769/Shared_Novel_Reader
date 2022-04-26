using log4net;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm.ResourceForm
{
    public partial class FormNoteSearch : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormNoteSearch));
        string SearchKey = "";
        string SearchType = "";
        public FormNoteSearch()
        {
            InitializeComponent();
            this.ComboBoxNoteType.SelectedIndex = 0;
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        { 
            if(SearchKey == "")
            {
                log.Info("搜索关键字不能为空");
                return;
            }

            this.FlowLayoutPanelNote.Controls.Clear();
            // 给服务器发送请求

            JObject ReqJson = new JObject();
            ReqJson["Note_KeyWord"] = SearchKey;
            ReqJson["Note_Type"] = SearchType;
            // 发送请求
            var MenuResult = Task<MyResponse>.Run(() => Tools.API.User.Note.SearchNote(ReqJson));

            MyResponse res = await MenuResult;
            /// 返回格式
            if (res == null || !res.Result)
            {
                // 清除残留数据
                log.Info("搜索帖子失败");
            }
            else if (res.Data["Note_List"].ToString() == "")
            {
                log.Info("搜索的帖子为空");
            }
            else
            {
                JArray NoteListJson = (JArray)res.Data["Note_List"];
                foreach (JObject note in NoteListJson)
                {
                    FormNoteRows noteView = new FormNoteRows(note);
                    noteView.TopLevel = false;
                    this.FlowLayoutPanelNote.Controls.Add(noteView);
                    noteView.Show();
                }
            }

        }

        private void ComboBoxNoteType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = this.ComboBoxNoteType.SelectedItem.ToString();
            Console.WriteLine("选择的项 ： " + type);
            if(type == "求助帖")
            {
                SearchType = "Help";
            }
            else if(type == "资源贴")
            {
                SearchType = "Resource";
            }
            else
            {
                SearchType = "";
            }
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            SearchKey = this.TextSearch.Text;
        }
    }
}
