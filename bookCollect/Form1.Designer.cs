namespace bookCollect
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.bookList = new System.Windows.Forms.ListView();
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastPage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.order = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Labelprocess = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.软件介绍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加规则ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(881, 43);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "采集";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // bookList
            // 
            this.bookList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.type,
            this.name,
            this.lastPage,
            this.order});
            this.bookList.FullRowSelect = true;
            this.bookList.GridLines = true;
            this.bookList.Location = new System.Drawing.Point(27, 82);
            this.bookList.MultiSelect = false;
            this.bookList.Name = "bookList";
            this.bookList.Size = new System.Drawing.Size(965, 492);
            this.bookList.TabIndex = 1;
            this.bookList.UseCompatibleStateImageBehavior = false;
            this.bookList.View = System.Windows.Forms.View.Details;
            this.bookList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.bookList_MouseDoubleClick);
            // 
            // type
            // 
            this.type.Text = "类型";
            this.type.Width = 146;
            // 
            // name
            // 
            this.name.Text = "书名";
            this.name.Width = 270;
            // 
            // lastPage
            // 
            this.lastPage.Text = "最新章节";
            this.lastPage.Width = 418;
            // 
            // order
            // 
            this.order.Text = "作者";
            this.order.Width = 222;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "章节数范围";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "20";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(287, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "进度:";
            // 
            // Labelprocess
            // 
            this.Labelprocess.AutoSize = true;
            this.Labelprocess.Location = new System.Drawing.Point(67, 586);
            this.Labelprocess.Name = "Labelprocess";
            this.Labelprocess.Size = new System.Drawing.Size(0, 15);
            this.Labelprocess.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.软件介绍ToolStripMenuItem,
            this.添加规则ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 软件介绍ToolStripMenuItem
            // 
            this.软件介绍ToolStripMenuItem.Name = "软件介绍ToolStripMenuItem";
            this.软件介绍ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.软件介绍ToolStripMenuItem.Text = "软件介绍";
            this.软件介绍ToolStripMenuItem.Click += new System.EventHandler(this.软件介绍ToolStripMenuItem_Click);
            // 
            // 添加规则ToolStripMenuItem
            // 
            this.添加规则ToolStripMenuItem.Name = "添加规则ToolStripMenuItem";
            this.添加规则ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.添加规则ToolStripMenuItem.Text = "添加规则";
            this.添加规则ToolStripMenuItem.Click += new System.EventHandler(this.添加规则ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 620);
            this.Controls.Add(this.Labelprocess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookList);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "小说采集";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListView bookList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Labelprocess;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader lastPage;
        private System.Windows.Forms.ColumnHeader order;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 软件介绍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加规则ToolStripMenuItem;
    }
}

