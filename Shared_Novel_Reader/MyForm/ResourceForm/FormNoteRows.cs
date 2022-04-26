using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.models;
namespace Shared_Novel_Reader.MyForm.ResourceForm
{
    public partial class FormNoteRows : Form
    {
        Note note = null;

        public FormNoteRows(in JObject obj)
        {
            note = new Note(in obj);
            InitializeComponent();
            this.labelContent.Text = note.Content;
            this.labelTitle.Text = note.Title;
        }

        private void labelLink_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flow = (FlowLayoutPanel)this.Parent;
            FormNoteSearch search = (FormNoteSearch)flow.Parent;
            FormBookPlatform noteForm = (FormBookPlatform)search.ParentForm;
            noteForm.NoteDetail_Switch(note.Note_ID);
        }
    }
}
