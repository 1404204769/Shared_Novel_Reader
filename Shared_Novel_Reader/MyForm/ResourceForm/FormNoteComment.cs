using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.models;
namespace Shared_Novel_Reader.MyForm.ResourceForm
{
    public partial class FormNoteComment : Form
    {
        Comment comment = null;
        public FormNoteComment(JObject obj)
        {
            comment = new Comment(obj);
            InitializeComponent();
            this.LabelAgreeNum.Text = Convert.ToString(comment.Agree_Num);
            this.LabelContent.Text = comment.ContentStr;
            this.LabelUserID.Text = Convert.ToString(comment.User_ID);
            this.LabelCommentTime.Text = comment.Create_Time;
        }

    }
}
