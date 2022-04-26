using log4net;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.Tools;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm.ResourceForm
{
    public partial class FormNoteDetail : Form
    {
        FormNovelReader FormNovelReader =null;
        ILog log = LogManager.GetLogger(typeof(FormNoteDetail));
        public int NoteID = 0;
        models.Note note = null;
        public FormNoteDetail(int noteid)
        {
            InitializeComponent();
            this.labelViewBook.Visible = false;
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
            Regex BookNameRegex = new Regex(@"(?<BookName>.*)\(.*\)");

            Match match = BookNameRegex.Match(note.Title);
            if(!match.Success)
            {
                log.Info("帖子标题无法提取出图书名称");
                return;
            }
            string bookname = match.Groups["BookName"].ToString();
            if (FormNovelReader != null)
            {
                FormNovelReader.Dispose();
            }
            FormNovelReader = new FormNovelReader(bookname,note.Book_ID, false);
            FormNovelReader.Show();
        }
    }
}
