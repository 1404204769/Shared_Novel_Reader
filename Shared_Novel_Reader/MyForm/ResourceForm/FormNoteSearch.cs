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
        string SearchMode = string.Empty;
        string SearchKey = "";
        string SearchType = "";
        public FormNoteSearch()
        {
            InitializeComponent();
            this.ComboBoxNoteType.SelectedIndex = 0;

            // 默认显示最新求助帖
            SearchMode = "Help";
            // 给服务器发送请求

            JObject ReqJson = new JObject();
            ReqJson["Note_Type"] = "Help";
            MyRefresh(ReqJson);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        { 
            if(SearchKey.Trim() == "")
            {
                MessageBox.Show("搜索关键字不能为空");
                return;
            }

            // 给服务器发送请求

            JObject ReqJson = new JObject();
            ReqJson["Note_KeyWord"] = SearchKey;
            ReqJson["Note_Type"] = SearchType;

            SearchMode = string.Empty;
            MyRefresh(ReqJson);
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

        private async void BtnCreate_Click(object sender, EventArgs e)
        {
            ToolForm.FormNote formNote = new ToolForm.FormNote();
            DialogResult DiaRes = formNote.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;

            // 给服务器发送请求
            /*           
                {
                    "Note_Content"  :   {
                        "Content"   :   "测试发布Help帖2"
                    },
                    "Note_Title"    :   "测试发布Help帖2",
                    "Note_Type"     :   
                }
            */

            JObject ReqJson = new JObject();
            JObject ContentJson = new JObject();
            ReqJson["Note_Title"] = formNote.TextTitle.Text.Trim();
            ContentJson["Content"] = formNote.TextContent.Text.Trim();
            ReqJson["Note_Content"] = ContentJson;
            ReqJson["Note_Type"] = "Help";
            // 发送请求
            var CreateNoteRes = Task<MyResponse>.Run(() => Tools.API.User.Note.CreateNote(ReqJson));

            MyResponse res = await CreateNoteRes;
            /// 返回格式
            if (res == null)
            {
                // 清除残留数据
                MessageBox.Show("网络异常，请重试");
            }
            else if(!res.Result)
            {
                MessageBox.Show(res.Message);
            }
            else if (res.Data.ToString() == "")
            {
                MessageBox.Show("发布求助帖数据异常");
            }
            else
            {
                MessageBox.Show("发布求助帖成功");
            }
        }

        private void View_New_Help_Top_Click(object sender, EventArgs e)
        {
            SearchMode = "Help";
            // 给服务器发送请求

            JObject ReqJson = new JObject();
            ReqJson["Note_Type"] = "Help";
            MyRefresh(ReqJson);
        }

        private void View_New_Res_Top_Click(object sender, EventArgs e)
        {
            SearchMode = "Resource";
            JObject ReqJson = new JObject();
            ReqJson["Note_Type"] = "Resource";
            MyRefresh(ReqJson);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            JObject ReqJson = new JObject();
            if (SearchMode != string.Empty)
            {
                ReqJson["Note_Type"] = SearchMode;
            }
            else
            {
                if (SearchKey.Trim() == "")
                {
                    MessageBox.Show("搜索关键字不能为空");
                    return;
                }

                // 给服务器发送请求
                ReqJson["Note_KeyWord"] = SearchKey;
                ReqJson["Note_Type"] = SearchType;
            }
            MyRefresh(ReqJson);
        }

        private async void MyRefresh(JObject ReqJson)
        {
            MyResponse res = null;
            this.FlowLayoutPanelNote.Controls.Clear();

            if (SearchMode != string.Empty)
            {
                // 发送请求
                var NoteRes = Task<MyResponse>.Run(() => Tools.API.User.Note.SearchTopNote(ReqJson));
                res = await NoteRes;
            }
            else
            {
                // 发送请求
                var MenuResult = Task<MyResponse>.Run(() => Tools.API.User.Note.SearchNote(ReqJson));
                res = await MenuResult;
            }

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
    }
}
