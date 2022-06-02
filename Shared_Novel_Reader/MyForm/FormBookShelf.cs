using System;
using System.Windows.Forms;
using log4net;
using Shared_Novel_Reader.models;
using Shared_Novel_Reader.MyForm.ResourceForm;
using Shared_Novel_Reader.MyForm.ToolForm;

namespace Shared_Novel_Reader.MyForm
{
    public partial class FormBookShelf : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormBookShelf));
        public bool IsInternetBookShelfOpen = false;
        public FormNovelReader FormNovelReader = null;
        public FormBookShelf()
        {
            log.Info("调用了FormBookShelf的构造函数");
            InitializeComponent();
            this.tabPageInternetBook.Parent = null;
            LoadLocalRes();
            OpenInternetBookShelf();
        }


        private void FormBookShelf_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.Info("调用了FormBookShelf_FormClosed函数");
        }

        /// <summary>
        /// 只有用户登入且网络书架关闭的情况下才会初始化网络书架
        /// </summary>
        public void OpenInternetBookShelf()
        {
            if (User.IsInit && !IsInternetBookShelfOpen)
            {
                this.tabPageInternetBook.Parent = this.tabControl1;
                LoadInternetRes();
                IsInternetBookShelfOpen = true;
            }
        }

        /// <summary>
        /// 用户退出时关闭网络书架
        /// </summary>
        public void closeInternetBookShelf()
        {
            if (!InternetBookShelf.close())
            {
                MessageBox.Show("网络书架关闭失败");
            }
            else
            {
                log.Info("网络书架关闭成功");
            }
            this.tabPageInternetBook.Parent = null;
            IsInternetBookShelfOpen = false;
        }

        /// <summary>
        /// 关闭本地书架
        /// </summary>
        public void closeLocalBookShelf()
        {
            if (!LocalBookShelf.close())
            {
                log.Info("本地书架关闭失败");
            }
            else
            {
                log.Info("本地书架关闭成功");
            }
        }


        public void LoadLocalRes()
        {
            if (!models.LocalBookShelf.open())
            {
                log.Info("本地书架打开失败");
                return;
            }
            log.Info("本地书架打开成功");
            this.DataGridViewLocal.Rows.Clear();
            foreach (var book in LocalBookShelf.LocalResArray)
            {
                string[] col = new string[5];
                col[0] = (string)book["Book_Name"];
                col[1] = (string)book["Link_Num"];

                col[2] = Convert.ToString(book["PartNum"]);
                col[3] = Convert.ToString(book["ChapterNum"]);
                int tempPartNum = Convert.ToInt32(Convert.ToString(book["PartNum"]));
                int tempChapterNum = Convert.ToInt32(Convert.ToString(book["ChapterNum"]));

                if (tempPartNum == 0 && tempChapterNum == 0)
                {
                    col[4] = "还未阅读过此书";
                }
                else
                {
                    col[4] = "上次阅读到第" + tempPartNum + "卷第" + tempChapterNum + "章";
                }
                this.DataGridViewLocal.Rows.Add(col);
            }
            log.Info("本地书架加载成功");
        }

        /// <summary>
        /// 加载网络图书
        /// </summary>
        public void LoadInternetRes()
        {
            if (!User.IsInit) return;
            if (!InternetBookShelf.open())
            {
                log.Info("网络书架打开失败");
                return;
            }
            log.Info("网络书架打开成功");
            this.DataGridViewInternet.Rows.Clear();
            foreach (var book in InternetBookShelf.InternetResArray)
            {
                string[] col = new string[5];
                col[0] = (string)book["Book_Name"];
                col[1] = Convert.ToString(book["Book_ID"]);

                col[2] = Convert.ToString(book["PartNum"]);
                col[3] = Convert.ToString(book["ChapterNum"]);
                int tempPartNum = Convert.ToInt32(Convert.ToString(book["PartNum"]));
                int tempChapterNum = Convert.ToInt32(Convert.ToString(book["ChapterNum"]));

                if (tempPartNum == 0 && tempChapterNum == 0)
                {
                    col[4] = "还未阅读过此书";
                }
                else
                {
                    col[4] = "上次阅读到第"+tempPartNum+"卷第"+tempChapterNum+"章";
                }
                this.DataGridViewInternet.Rows.Add(col);
            }
            log.Info("网络书架加载成功");
        }

        private void DataGridViewLocal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FormNovelReader != null)
            {
                FormNovelReader.Dispose();
            }
            int keynum = Convert.ToInt32(this.DataGridViewLocal.Rows[e.RowIndex].Cells[1].Value.ToString());
            string bookname = this.DataGridViewLocal.Rows[e.RowIndex].Cells[0].Value.ToString();

            for (int i = 0; i < LocalBookShelf.LocalResArray.Count; i++)
            {
                if (Convert.ToInt32(LocalBookShelf.LocalResArray[i]["Link_Num"]) == keynum)
                {
                    this.DataGridViewLocal.Rows[e.RowIndex].Cells[2].Value = 
                        Convert.ToInt32(LocalBookShelf.LocalResArray[i]["PartNum"]);
                    this.DataGridViewLocal.Rows[e.RowIndex].Cells[3].Value =
                        Convert.ToInt32(LocalBookShelf.LocalResArray[i]["ChapterNum"]);
                    break;
                }
            }
            FormNovelReader = new FormNovelReader(bookname, keynum,
                Convert.ToInt32(this.DataGridViewLocal.Rows[e.RowIndex].Cells[2].Value.ToString()),
                Convert.ToInt32(this.DataGridViewLocal.Rows[e.RowIndex].Cells[3].Value.ToString()),true);
            //FormNovelReader = new FormNovelReader("次元论坛", 17, false);
            FormNovelReader.Owner = this;
            FormNovelReader.Show();

        }


        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == this.tabPageInternetBook)
            {
                this.DataGridViewInternet.Rows.Clear();
                foreach (var book in InternetBookShelf.InternetResArray)
                {
                    string[] col = new string[5];
                    col[0] = (string)book["Book_Name"];
                    col[1] = Convert.ToString(book["Book_ID"]);

                    col[2] = Convert.ToString(book["PartNum"]);
                    col[3] = Convert.ToString(book["ChapterNum"]);
                    int tempPartNum = Convert.ToInt32(Convert.ToString(book["PartNum"]));
                    int tempChapterNum = Convert.ToInt32(Convert.ToString(book["ChapterNum"]));

                    if (tempPartNum == 0 && tempChapterNum == 0)
                    {
                        col[4] = "还未阅读过此书";
                    }
                    else
                    {
                        col[4] = "上次阅读到第" + tempPartNum + "卷第" + tempChapterNum + "章";
                    }
                    this.DataGridViewInternet.Rows.Add(col);
                }
                log.Info("网络书架刷新成功");
            }
            else if (e.TabPage == this.tabPageLocalBook)
            {
                this.DataGridViewLocal.Rows.Clear();
                foreach (var book in LocalBookShelf.LocalResArray)
                {
                    string[] col = new string[5];
                    col[0] = (string)book["Book_Name"];
                    col[1] = (string)book["Link_Num"];


                    col[2] = Convert.ToString(book["PartNum"]);
                    col[3] = Convert.ToString(book["ChapterNum"]);
                    int tempPartNum = Convert.ToInt32(Convert.ToString(book["PartNum"]));
                    int tempChapterNum = Convert.ToInt32(Convert.ToString(book["ChapterNum"]));

                    if (tempPartNum == 0 && tempChapterNum == 0)
                    {
                        col[4] = "还未阅读过此书";
                    }
                    else
                    {
                        col[4] = "上次阅读到第" + tempPartNum + "卷第" + tempChapterNum + "章";
                    }
                    this.DataGridViewLocal.Rows.Add(col);
                }
                log.Info("本地书架刷新成功");
            }
        }

        /// <summary>
        /// 打开在线阅读器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewInternet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (FormNovelReader != null)
            {
                FormNovelReader.Dispose();
            }
            int keynum = Convert.ToInt32(this.DataGridViewInternet.Rows[e.RowIndex].Cells[1].Value.ToString());
            string bookname = this.DataGridViewInternet.Rows[e.RowIndex].Cells[0].Value.ToString();

            for (int i = 0; i < InternetBookShelf.InternetResArray.Count; i++)
            {
                if (Convert.ToInt32(InternetBookShelf.InternetResArray[i]["Book_ID"]) == keynum)
                {
                    this.DataGridViewInternet.Rows[e.RowIndex].Cells[2].Value =
                        Convert.ToInt32(InternetBookShelf.InternetResArray[i]["PartNum"]);
                    this.DataGridViewInternet.Rows[e.RowIndex].Cells[3].Value =
                        Convert.ToInt32(InternetBookShelf.InternetResArray[i]["ChapterNum"]);
                    break;
                }
            }
            FormNovelReader = new FormNovelReader(bookname,keynum,
                Convert.ToInt32(this.DataGridViewInternet.Rows[e.RowIndex].Cells[2].Value.ToString()),
                Convert.ToInt32(this.DataGridViewInternet.Rows[e.RowIndex].Cells[3].Value.ToString()), false);
            //FormNovelReader = new FormNovelReader("次元论坛", 17, false);

            FormNovelReader.Owner = this;
            FormNovelReader.Show();
        }

        private void AddLocalRes_Click(object sender, EventArgs e)
        {
            if (!models.LocalBookShelf.open())
            {
                log.Info("书架打开失败");
                return;
            }
            else
            {
                log.Info("书架打开成功");
            }
            string path = string.Empty;
            //首先，实例化对话框类实例
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "文本文件|*.txt";
            //然后，判断如果当前用户在对话框里点击的是OK按钮的话。
            if (DialogResult.OK == openDialog.ShowDialog())
            {
                //将打开文件对话框的FileName属性传递到你的字符串进行处理
                path = openDialog.FileName;
            }
            if (path == string.Empty) return;
            //其实，这个对话框控件还支持对打开文件类型的过滤等等属性。

            models.Book Book;
            Tools.Novel_Analysis.Analysis_Local_Resource(out Book, path);
            if (Book != null)
                models.LocalBookShelf.AddToBookshelf(Book);
            else
                return;
            // 刷新书架
            this.DataGridViewLocal.Rows.Clear();
            foreach (var book in LocalBookShelf.LocalResArray)
            {
                string[] col = new string[5];
                col[0] = (string)book["Book_Name"];
                col[1] = (string)book["Link_Num"];


                col[2] = Convert.ToString(book["PartNum"]);
                col[3] = Convert.ToString(book["ChapterNum"]);
                int tempPartNum = Convert.ToInt32(Convert.ToString(book["PartNum"]));
                int tempChapterNum = Convert.ToInt32(Convert.ToString(book["ChapterNum"]));

                if (tempPartNum == 0 && tempChapterNum == 0)
                {
                    col[4] = "还未阅读过此书";
                }
                else
                {
                    col[4] = "上次阅读到第" + tempPartNum + "卷第" + tempChapterNum + "章";
                }
                this.DataGridViewLocal.Rows.Add(col);
            }
            log.Info("本地书架刷新成功");
        }

        private void UploadNew_Click(object sender, EventArgs e)
        {
            string bookname = this.DataGridViewLocal.CurrentRow.Cells[0].Value.ToString();
            int linknum = Convert.ToInt32(this.DataGridViewLocal.CurrentRow.Cells[1].Value.ToString());
            int index = -1;
            // 开始在内存中查找图书信息
            index = LocalBookShelf.FindBookInMemoryByName(bookname);

            // 如果没找到说明不在内存里,则需要从Resources文件夹内加载到内存里
            if (index == -1)
            {
                // 文件加载失败
                if (!LocalBookShelf.LoadBookByNum(linknum))
                {
                    MessageBox.Show("图书加载失败");

                    return;
                }
                index = LocalBookShelf.FindBookInMemoryByName(bookname);
                if (index == -1)
                {
                    MessageBox.Show("图书资源不存在");

                    return;
                }
            }
            LocalBookShelf.BookList[index].CheckUpload();
            if(LocalBookShelf.BookList[index].Need_Upload == 0)
            {
                MessageBox.Show("这个资源已经全部上传过了哦，请添加或修改此资源，或者点击【申请更改章节】");
                return;
            }

            ToolForm.FormBookTitle formBookTitle = new ToolForm.FormBookTitle();
            formBookTitle.setBookAuthor(LocalBookShelf.BookList[index].Book_Author);
            formBookTitle.setBookName(LocalBookShelf.BookList[index].Book_Name);
            formBookTitle.setBookPublisher(LocalBookShelf.BookList[index].Book_Publisher);
            formBookTitle.setBookSynopsis(LocalBookShelf.BookList[index].Book_Synopsis);
            DialogResult res =  formBookTitle.ShowDialog();
            if(res == DialogResult.OK)
            {
                // 说明被修改了
                if(formBookTitle.IsEdit)
                {
                    LocalBookShelf.BookList[index].Book_Author = formBookTitle.newBookAuthor;
                    LocalBookShelf.BookList[index].Book_Name = formBookTitle.newBookName;
                    LocalBookShelf.BookList[index].Book_Publisher = formBookTitle.newBookPublisher;
                    LocalBookShelf.BookList[index].Book_Synopsis = formBookTitle.newBookSynopsis;
                }
            }
            else
            {
                log.Info("用户取消上传");
                return;
            }

            LocalBookShelf.BookList[index].UploadAllNew();
        }

        private void UploadChange_Click(object sender, EventArgs e)
        {
            string bookname = this.DataGridViewLocal.CurrentRow.Cells[0].Value.ToString();
            int linknum = Convert.ToInt32(this.DataGridViewLocal.CurrentRow.Cells[1].Value.ToString());
            FormUploadChange FormUploadChange = new FormUploadChange(bookname, linknum);
            //FormNovelReader = new FormNovelReader("次元论坛", 17, false);
            if (FormUploadChange.IsDisposed)
                return;
            DialogResult res = FormUploadChange.ShowDialog();
            if (res == DialogResult.Cancel)
                return;
            // 允许到这一步 此资源一定在内存中
            FormUploadChange.Hide();
            int index = LocalBookShelf.FindBookInMemoryByName(bookname);
            LocalBookShelf.BookList[index].UploadSomeOld(FormUploadChange.SelectList);
            FormUploadChange.Dispose();
        }

        private void DataGridViewLocal_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.DataGridViewLocal.Rows[e.RowIndex].Selected = true;
                this.ContextMenuStripLocal.Items[0].Visible = true;
                this.ContextMenuStripLocal.Items[1].Visible = true;
                this.ContextMenuStripLocal.Items[5].Visible = true;
                // 必须在线才能上传
                if (User.IsInit)
                {
                    this.ContextMenuStripLocal.Items[2].Visible = true;
                    this.ContextMenuStripLocal.Items[3].Visible = true;
                }
            }
        }

        private void EditBookData_Click(object sender, EventArgs e)
        {
            string bookname = this.DataGridViewLocal.CurrentRow.Cells[0].Value.ToString();
            int linknum = Convert.ToInt32(this.DataGridViewLocal.CurrentRow.Cells[1].Value.ToString());
            int index = -1;
            // 开始在内存中查找图书信息
            index = LocalBookShelf.FindBookInMemoryByName(bookname);

            // 如果没找到说明不在内存里,则需要从Resources文件夹内加载到内存里
            if (index == -1)
            {
                // 文件加载失败
                if (!LocalBookShelf.LoadBookByNum(linknum))
                {
                    MessageBox.Show("图书加载失败");

                    return;
                }
                index = LocalBookShelf.FindBookInMemoryByName(bookname);
                if (index == -1)
                {
                    MessageBox.Show("图书资源不存在");

                    return;
                }
            }

            ToolForm.FormBookTitle formBookTitle = new ToolForm.FormBookTitle();
            formBookTitle.setBookAuthor(LocalBookShelf.BookList[index].Book_Author);
            formBookTitle.setBookName(LocalBookShelf.BookList[index].Book_Name);
            formBookTitle.setBookPublisher(LocalBookShelf.BookList[index].Book_Publisher);
            formBookTitle.setBookSynopsis(LocalBookShelf.BookList[index].Book_Synopsis);
            DialogResult res = formBookTitle.ShowDialog();
            if (res == DialogResult.OK)
            {
                // 说明被修改了
                if (formBookTitle.IsEdit)
                {
                    LocalBookShelf.BookList[index].Book_Author = formBookTitle.newBookAuthor;
                    LocalBookShelf.BookList[index].Book_Name = formBookTitle.newBookName;
                    LocalBookShelf.BookList[index].Book_Publisher = formBookTitle.newBookPublisher;
                    LocalBookShelf.BookList[index].Book_Synopsis = formBookTitle.newBookSynopsis;
                }
            }
        }

        private void DownloadResourse_Click(object sender, EventArgs e)
        {
            string bookname = this.DataGridViewInternet.CurrentRow.Cells[0].Value.ToString();
            int bookid = Convert.ToInt32(this.DataGridViewInternet.CurrentRow.Cells[1].Value.ToString());
            InternetBookShelf.DownloadBook(bookname, bookid);
        }

        private void CreateRes_Click(object sender, EventArgs e)
        {
            FormBookTitle FormBookTitle = new FormBookTitle();
            FormBookTitle.OpenEdit();
            DialogResult res = FormBookTitle.ShowDialog();
            if (res == DialogResult.Cancel)
                return;
            Book book = new Book();
            book.Book_Author = FormBookTitle.newBookAuthor;
            book.Book_Name = FormBookTitle.newBookName;
            book.Book_Publisher = FormBookTitle.newBookPublisher;
            book.Book_Synopsis = FormBookTitle.newBookSynopsis;
            if (book.Book_Name == string.Empty)
            {
                MessageBox.Show("图书名称不可为空");
                return;
            }
            if (book.Book_Author == string.Empty)
            {
                MessageBox.Show("作者名称不可为空");
                return;
            }
            LocalBookShelf.AddToBookshelf(book);
            // 刷新书架
            this.DataGridViewLocal.Rows.Clear();
            foreach (var obj in LocalBookShelf.LocalResArray)
            {
                string[] col = new string[5];
                col[0] = (string)obj["Book_Name"];
                col[1] = (string)obj["Link_Num"];


                col[2] = Convert.ToString(obj["PartNum"]);
                col[3] = Convert.ToString(obj["ChapterNum"]);
                int tempPartNum = Convert.ToInt32(Convert.ToString(obj["PartNum"]));
                int tempChapterNum = Convert.ToInt32(Convert.ToString(obj["ChapterNum"]));

                if (tempPartNum == 0 && tempChapterNum == 0)
                {
                    col[4] = "还未阅读过此书";
                }
                else
                {
                    col[4] = "上次阅读到第" + tempPartNum + "卷第" + tempChapterNum + "章";
                }
                this.DataGridViewLocal.Rows.Add(col);
            }
            log.Info("本地书架刷新成功");
        }

        private void DeleteRes_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.DataGridViewLocal.Rows)
            {
                if(row.Selected)
                {

                    string bookname = row.Cells[0].Value.ToString();
                    DialogResult result = MessageBox.Show("确定要删除此资源("+ bookname + ")吗？", "删除资源", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    bool res = LocalBookShelf.RemoveFromBookshelf(bookname);
                    if (res)
                    {
                        MessageBox.Show("图书移除成功");
                        // 刷新书架
                        this.DataGridViewLocal.Rows.Clear();
                        foreach (var obj in LocalBookShelf.LocalResArray)
                        {
                            string[] col = new string[5];
                            col[0] = (string)obj["Book_Name"];
                            col[1] = (string)obj["Link_Num"];

                            col[2] = Convert.ToString(obj["PartNum"]);
                            col[3] = Convert.ToString(obj["ChapterNum"]);
                            int tempPartNum = Convert.ToInt32(Convert.ToString(obj["PartNum"]));
                            int tempChapterNum = Convert.ToInt32(Convert.ToString(obj["ChapterNum"]));

                            if (tempPartNum == 0 && tempChapterNum == 0)
                            {
                                col[4] = "还未阅读过此书";
                            }
                            else
                            {
                                col[4] = "上次阅读到第" + tempPartNum + "卷第" + tempChapterNum + "章";
                            }
                            this.DataGridViewLocal.Rows.Add(col);
                        }
                        log.Info("本地书架刷新成功");
                    }
                    else
                    {
                        MessageBox.Show("图书移除失败");
                    }
                    return;
                }
            }
            MessageBox.Show("不存在选中项");
        }

        private void RemoveInternetBookShelf_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in this.DataGridViewLocal.Rows)
            {
                if (row.Selected)
                {
                    string bookname = row.Cells[0].Value.ToString();
                    DialogResult result = MessageBox.Show("确定要删除此资源(" + bookname + ")移出书架吗？", "移出书架", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    RemoveInternetBook(bookname);
                    return;
                }
            }
            MessageBox.Show("不存在选中项");
        }

        /// <summary>
        /// 移除在线书架
        /// </summary>
        /// <param name="bookName"></param>
        /// <returns></returns>
        public bool RemoveInternetBook(string bookName)
        {
            bool res = InternetBookShelf.RemoveFromBookshelf(bookName);
            if (res)
            {
                MessageBox.Show("图书移除成功");
                // 刷新书架
                this.DataGridViewInternet.Rows.Clear();
                foreach (var obj in InternetBookShelf.InternetResArray)
                {
                    string[] col = new string[5];
                    col[0] = (string)obj["Book_Name"];
                    col[1] = (string)obj["Book_ID"];

                    col[2] = Convert.ToString(obj["PartNum"]);
                    col[3] = Convert.ToString(obj["ChapterNum"]);
                    int tempPartNum = Convert.ToInt32(Convert.ToString(obj["PartNum"]));
                    int tempChapterNum = Convert.ToInt32(Convert.ToString(obj["ChapterNum"]));

                    if (tempPartNum == 0 && tempChapterNum == 0)
                    {
                        col[4] = "还未阅读过此书";
                    }
                    else
                    {
                        col[4] = "上次阅读到第" + tempPartNum + "卷第" + tempChapterNum + "章";
                    }
                    this.DataGridViewInternet.Rows.Add(col);
                }
                log.Info("在线书架刷新成功");
            }
            else
            {
                MessageBox.Show("图书移除失败");
            }
            return res;
        }
    }

}
