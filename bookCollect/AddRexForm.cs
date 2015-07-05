using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pyystone;

namespace bookCollect
{
    public partial class AddRexForm : Form
    {
        public AddRexForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rexString = "";
            rexString += textBox1.Text + ",";
            rexString += textBox2.Text + ",";
            rexString += textBox3.Text + ",";
            rexString += textBox4.Text + ",";
            rexString += textBox5.Text + ",";
            rexString += textBox6.Text + ",";
            rexString += "\n";
            var wr = FileLS.FileWrite("neturl.csv", "utf-8", true);
            wr.Write(rexString);
            wr.Flush();
            wr.Close();
        }
    }
}
