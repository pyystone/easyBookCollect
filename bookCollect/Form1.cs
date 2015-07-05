using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookCollect
{
    public partial class Form1 : Form
    {

        private int minCount;
        private int maxCount;

        public delegate void FromDataCallBack(List<BookData> datas, String loadProcess);

        private List<BookData> listBookData = new List<BookData>();
        private IntroductionForm form;
        private AddRexForm form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            initData();
            startDownLoadData();
        }


        private void startDownLoadData()
        {
            listBookData.Clear();
            var controller = new BookCollectController(minCount, maxCount, "neturl.csv", callBack);
            Labelprocess.Text = "开始下载资源";
        }

        private void callBack(List<BookData> datas, String loadProcess)
        {
            bookList.Invoke(new FromDataCallBack(refreshListView), datas, loadProcess);
        }

        private void refreshListView(List<BookData> datas, string loadProcess)
        {
            foreach (BookData bookData in datas)
            {
                var item = new ListViewItem(bookData.bookType);
                var subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = bookData.bookName;
                item.SubItems.Add(subItem);
                subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = bookData.lastPage;
                item.SubItems.Add(subItem);
                bookList.Items.Add(item);
            }
            Labelprocess.Text = loadProcess;
            listBookData.AddRange(datas);
        }

        private void initData()
        {
            minCount = Convert.ToInt32(textBox1.Text);
            maxCount = Convert.ToInt32(textBox2.Text);
        }

        private void bookList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var position = bookList.SelectedItems[0].Index;
            if (String.IsNullOrEmpty(listBookData[position].bookUrl))
            {
                MessageBox.Show("此书的地址解析出错！");
            }
            else
            {
                System.Diagnostics.Process.Start(listBookData[position].bookUrl);
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 软件介绍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form == null)
            {
                form = new IntroductionForm();
            }
            form.Show();
        }

        private void 添加规则ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form2 == null)
            {
                form2 = new AddRexForm();
            }
            form2.Show();
        }
    }
}
