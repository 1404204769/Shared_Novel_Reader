using System;
using System.Windows.Forms;
using Shared_Novel_Reader.MyForm.ResourceForm;
namespace Shared_Novel_Reader.MyForm
{
    public partial class FormBookPlatform : Form
    {
        public FormBookPlatform()
        {
            InitializeComponent();
            NoteSearch_Switch();
        }

        /// <summary>
        /// 切换回帖子搜索界面
        /// </summary>
        public void NoteSearch_Switch()
        {
            Form TagFrom = this.PanelNote.Tag as Form;
             
            if (TagFrom != null)
                TagFrom.Hide();

            FormNoteSearch FormNoteSearch = null;
            Control[] controls = this.PanelNote.Controls.Find("FormNoteSearch", false);
            if (controls.Length == 0)
            {
                Console.WriteLine("控件中不存在FormNoteSearch");
                Console.WriteLine("开始准备导入FormNoteSearch");
                FormNoteSearch = new FormNoteSearch();
                FormNoteSearch.TopLevel = false;
                this.PanelNote.Controls.Add(FormNoteSearch);
                controls = this.PanelNote.Controls.Find("FormNoteSearch", false);
                if (controls.Length == 0)
                {
                    Console.WriteLine("导入FormNoteSearch失败");
                    return;
                }
                Console.WriteLine("导入FormNoteSearch成功");
            }
            else
                FormNoteSearch = controls[0] as FormNoteSearch;

            FormNoteSearch.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.PanelNote.Tag = FormNoteSearch;
            FormNoteSearch.Show();
        }


        /// <summary>
        /// 切换到帖子详情界面
        /// </summary>
        public void NoteDetail_Switch(int noteid)
        {
            Form TagFrom = this.PanelNote.Tag as Form;
            // 如果不是查询界面则说明是详情界面，如果详情界面存在则释放资源
            if (TagFrom != null)
                TagFrom.Hide();

            FormNoteDetail FormNoteDetail = null;
            Control[] controls = this.PanelNote.Controls.Find("FormNoteDetail", false);
            // 如果详情界面不存在则新建
            if (controls.Length == 0)
            {
                Console.WriteLine("控件中不存在FormNoteDetail");
                Console.WriteLine("开始准备导入FormNoteDetail");
                FormNoteDetail = new FormNoteDetail(noteid);
                FormNoteDetail.TopLevel = false;
                this.PanelNote.Controls.Add(FormNoteDetail);
                controls = this.PanelNote.Controls.Find("FormNoteDetail", false);
                if (controls.Length == 0)
                {
                    Console.WriteLine("导入FormNoteDetail失败");
                    return;
                }
                Console.WriteLine("导入FormNoteDetail成功");
            }
            // 如果存在则判断是否是需要的界面
            else
            {
                // 如果缓存的界面就是需要的界面则直接显示出来即可
                if(FormNoteDetail.NoteID == noteid)
                {
                    FormNoteDetail = controls[0] as FormNoteDetail;
                    FormNoteDetail.Refresh();
                }
                // 否则释放原有的界面
                else
                {
                    this.PanelNote.Controls.RemoveByKey("FormNoteDetail");
                    FormNoteDetail = new FormNoteDetail(noteid);
                    FormNoteDetail.TopLevel = false;
                    this.PanelNote.Controls.Add(FormNoteDetail);
                    controls = this.PanelNote.Controls.Find("FormNoteDetail", false);
                    if (controls.Length == 0)
                    {
                        Console.WriteLine("新建FormNoteDetail失败");
                        return;
                    }
                    Console.WriteLine("新建FormNoteDetail成功");
                }
            }

            FormNoteDetail.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.PanelNote.Tag = FormNoteDetail;
            FormNoteDetail.Show();

        }
    }
}
