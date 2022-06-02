using log4net;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.models;
using Shared_Novel_Reader.Tools;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm.ResourceForm
{
    public partial class FormNoteDetail : Form
    {
        string BookName = string.Empty;
        FormNovelReader FormNovelReader =null;
        ILog log = LogManager.GetLogger(typeof(FormNoteDetail));
        public int NoteID = 0;
        models.Note note = null;
        public FormNoteDetail(int noteid)
        {
            InitializeComponent();
            this.labelViewBook.Visible = false;
            this.LabelJoin.Visible = false;
            NoteID = noteid;
            Interface_Rendering(); 
        }

        /// <summary>
        /// 重构刷新函数
        /// </summary>
        public override void Refresh()
        {
            base.Refresh();
            Interface_Rendering();
        }

        /// <summary>
        /// 界面渲染,向服务器请求数据并显示在界面上
        /// </summary>
        public async void Interface_Rendering()
        {

            if (NoteID == 0)
            {
                MessageBox.Show("帖子ID不能为0");
                return;
            }

            this.FlowLayoutPanelNoteComment.Controls.Clear();
            // 给服务器发送请求

            JObject ReqJson = new JObject();
            ReqJson["Note_ID"] = NoteID;
            // 发送请求
            var CommentListResult = Task<MyResponse>.Run(() => Tools.API.User.Note.SearchNoteComment(ReqJson));

            MyResponse res = await CommentListResult;

            /// 返回格式
            if (res == null || !res.Result)
            {
                // 清除残留数据
                MessageBox.Show("搜索帖子失败");
            }
            else if (res.Data["Note_Data"].ToString() == "")
            {
                MessageBox.Show("搜索的帖子为空");
            }
            else
            {
                note = new models.Note((JObject)res.Data["Note_Data"]);
                this.labelTitle.Text = note.Title;
                this.labelContent.Text = note.Content;
                if(note.Type == "Resource")
                {
                    this.labelViewBook.Visible = true;
                    this.LabelJoin.Visible = true;
                }
            }



            /// 返回格式
            if (res == null || !res.Result)
            {
                // 清除残留数据
                MessageBox.Show("搜索帖子评论失败");
            }
            else if (res.Data["Comment_List"].ToString() == "")
            {
                MessageBox.Show("搜索的帖子评论为空");
            }
            else
            {
                JArray CommentListJson = (JArray)res.Data["Comment_List"];
                foreach (JObject comment in CommentListJson)
                {
                    FormNoteComment commentView = new FormNoteComment(comment);
                    commentView.TopLevel = false;
                    this.FlowLayoutPanelNoteComment.Controls.Add(commentView);
                    commentView.Show();
                }
            }
        }

        private void labelViewBook_Click(object sender, System.EventArgs e)
        {
            if(BookName == string.Empty)
            {
                Regex BookNameRegex = new Regex(@"(?<BookName>.*)\(.*\)");

                Match match = BookNameRegex.Match(note.Title);
                if (!match.Success)
                {
                    log.Info("帖子标题无法提取出图书名称");
                    return;
                }
                BookName = match.Groups["BookName"].ToString();
            }
            if (FormNovelReader != null)
            {
                FormNovelReader.Dispose();
            }
            FormNovelReader = new FormNovelReader(BookName, note.Book_ID,-1,-1, false);
            FormNovelReader.Show();
        }

        private void LabelJoin_Click(object sender, System.EventArgs e)
        {
            if (!InternetBookShelf.open())
            {
                log.Info("网络书架打开失败");
                return;
            }

            if (BookName == string.Empty)
            {
                Regex BookNameRegex = new Regex(@"(?<BookName>.*)\(.*\)");

                Match match = BookNameRegex.Match(note.Title);
                if (!match.Success)
                {
                    log.Info("帖子标题无法提取出图书名称");
                    return;
                }
                BookName = match.Groups["BookName"].ToString();
            }

            bool res = InternetBookShelf.AddToBookshelf(BookName, note.Book_ID);
            if(res)
            {
                MessageBox.Show("图书加入书架成功");
            }
            else
            {
                MessageBox.Show("图书加入书架失败");
            }

        }

        private void PictureBoxReturn_Click(object sender, System.EventArgs e)
        {
            FormBookPlatform formBookPlatform = (FormBookPlatform)this.Parent.Parent;
            formBookPlatform.NoteSearch_Switch();
        }

        private async void ButtonReport_Click(object sender, System.EventArgs e)
        {
            string comment = this.TextComment.Text.Trim();
            if(comment.Length <= 5)
            {
                MessageBox.Show("评论不能少于五个字");
                return;
            }

            if (NoteID == 0)
            {
                MessageBox.Show("帖子ID不能为0");
                return;
            }

            // 给服务器发送请求
            JObject ReqJson = new JObject();
            JObject ContentJson = new JObject();
            ReqJson["Note_ID"] = NoteID;
            ContentJson["Content"] = comment;
            ReqJson["Comment_Content"] = ContentJson;
            // 发送请求
            MyResponse res = null;
            if (this.FlowLayoutPanelReply.Visible)
            {
                // 说明是回复别人的评论
                ReqJson["Reply_Floor_ID"] = Convert.ToInt32(this.LabelFloorValue.Text);
                Task<MyResponse> ReportResult = Task<MyResponse>.Run(() => Tools.API.User.Note.ReportNoteReply(ReqJson));
                res = await ReportResult;
            }
            else
            {
                // 说明是自己发表评论
                Task<MyResponse> ReportResult = Task<MyResponse>.Run(() => Tools.API.User.Note.ReportNoteComment(ReqJson));
                res = await ReportResult;
            }


            /// 返回格式
            if (res == null || !res.Result)
            {
                // 清除残留数据
                MessageBox.Show("发表评论失败");
            }
            else if (res.Data.ToString() == "")
            {
                MessageBox.Show("发表评论数据为空");
            }
            JObject Comment = (JObject)res.Data;
            FormNoteComment commentView = new FormNoteComment(Comment);
            commentView.TopLevel = false;
            this.FlowLayoutPanelNoteComment.Controls.Add(commentView);
            commentView.Show();

            this.FlowLayoutPanelReply.Visible = false;
            this.TextComment.Text = String.Empty;
        }

        private void PictureBoxRefresh_Click(object sender, System.EventArgs e)
        {
            Refresh();
        }

        private void LabelCancelReply_Click(object sender, System.EventArgs e)
        {
            this.FlowLayoutPanelReply.Visible = false;
        }
    }
}
