using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.models;
using Shared_Novel_Reader.Tools;

namespace Shared_Novel_Reader.MyForm.ResourceForm
{
    public partial class FormNoteComment : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormNoteComment));
        Comment comment = null;
        public FormNoteComment(JObject obj)
        {
            comment = new Comment(obj);
            InitializeComponent();
            this.LabelAgreeNum.Text = Convert.ToString(comment.Agree_Num);
            this.LabelContent.Text = comment.ContentStr;
            this.LabelUserID.Text = Convert.ToString(comment.User_ID);
            this.LabelCommentTime.Text = comment.Create_Time;
            ChangeType();
        }

        public async void ChangeType()
        {
            if (comment == null) return;
            // 给服务器发送请求
            JObject ReqJson = new JObject();
            ReqJson["Note_ID"] = comment.Note_ID;
            ReqJson["Floor_ID"] = comment.Floor_ID;
            // 发送请求
            Task<MyResponse> AgreeResult = Task<MyResponse>.Run(() => Tools.API.User.Note.SearchNoteCommentAgreeType(ReqJson));
            MyResponse res = await AgreeResult;

            /// 返回格式
            if (res == null || !res.Result)
            {
                // 清除残留数据
                log.Info("查询点赞状态失败");
                return;
            }
            else if (res.Data.ToString() == "")
            {
                log.Info("点赞状态数据为空");
                return;
            }
            if((bool)res.Data["Agree"])
            {
                this.LabelAgree.Text = "取消点赞";
            }else
            {
                this.LabelAgree.Text = "点赞";
            }
        }


        private void LabelReply_Click(object sender, EventArgs e)
        {
            FormNoteDetail FormNoteDetail = (FormNoteDetail)this.Parent.Parent;
            FormNoteDetail.FlowLayoutPanelReply.Visible = true;
            FormNoteDetail.LabelFloorValue.Text = Convert.ToString(comment.Floor_ID);
        }

        private async void labelAgree_Click(object sender, EventArgs e)
        {
            // 给服务器发送请求
            JObject ReqJson = new JObject();
            ReqJson["Note_ID"] = comment.Note_ID;
            ReqJson["Floor_ID"] = comment.Floor_ID;
            if (this.LabelAgree.Text == "点赞")
            {
                ReqJson["Agree_Result"] = true;
            }
            else
            {
                ReqJson["Agree_Result"] = false;
            }
            // 发送请求
            Task<MyResponse> AgreeResult = Task<MyResponse>.Run(() => Tools.API.User.Note.CommentAgree(ReqJson));
            MyResponse res = await AgreeResult;

            /// 返回格式
            if (res == null || !res.Result)
            {
                // 清除残留数据
                log.Info("查询点赞状态失败");
                return;
            }
            else if (res.Data.ToString() == "")
            {
                log.Info("点赞状态数据为空");
                return;
            }
            // 根据点赞结果改变点赞按钮
            int num = Convert.ToInt32(this.LabelAgreeNum.Text);
            if ((bool)res.Data["Status"])
            {
                this.LabelAgree.Text = "取消点赞";
                num++;
            }
            else
            {
                this.LabelAgree.Text = "点赞";
                num--;
            }
            this.LabelAgreeNum.Text = Convert.ToString(num);
        }
    }
}
