using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bk
{
    public partial class BkSetForm : Form
    {
        public String res;
        public String dst;
        public BkSetForm(string res,string dst)
        {
            InitializeComponent();
            if (res.Length!=0) {
                res_text.Text = res;
            }else
                res_text.Text = System.IO.Directory.GetCurrentDirectory();
            if (dst.Length != 0)
                dst_text.Text = dst;
            else
                dst_text.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            res = res_text.Text;
            dst = dst_text.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void dst_text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderDialog openFolder = new FolderDialog();
            if (openFolder.DisplayDialog() == DialogResult.OK){
                res_text.Text = openFolder.Path.ToString();
            }
            else
                MessageBox.Show("你没有选择目录"); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderDialog openFolder = new FolderDialog();
            if (openFolder.DisplayDialog() == DialogResult.OK)
            {
                dst_text.Text = openFolder.Path.ToString();
            }
            else
                MessageBox.Show("你没有选择目录"); 
        }

        private void BkSetForm_Load(object sender, EventArgs e)
        {

        }

        private void cancle_button_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
