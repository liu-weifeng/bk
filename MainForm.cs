using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace bk
{
    public partial class MainForm : Form
    {
        private string res;
        private string dst;
        public MainForm()
        {
            InitializeComponent();
            string fileName = "./cnf.txt";
            try
            {
                StreamReader sr = File.OpenText(fileName);
                this.res = sr.ReadLine();
                this.dst = sr.ReadLine();
                sr.Close();
            }
            catch (IOException e) {
                this.res = "";
                this.dst = "";
            }
            backupInfo.Text = "备份目录："+this.res+"\n备份位置：" + this.dst;
            //MessageBox.Show(this.res);
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 备份设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cur_path = System.IO.Directory.GetCurrentDirectory();
            BkSetForm bsf = new BkSetForm(this.res,this.dst);
            if (bsf.ShowDialog()==DialogResult.OK){
                this.res = bsf.res;
                this.dst = bsf.dst;
                backupInfo.Text = "备份目录：" + this.res + "\n备份位置：" + this.dst;
            }
            //MessageBox.Show(this.res+':'+this.dst);
            StreamWriter sr = new StreamWriter("./cnf.txt");
            sr.WriteLine(this.res);
            sr.WriteLine(this.dst);
            sr.Close();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string getFileMd5(string fileName)
        {
            try
            {
                FileStream file = new FileStream(fileName, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
            
        }

        private ArrayList GetAll(DirectoryInfo dir, ArrayList FileList)
        {
            //ArrayList FileList = new ArrayList();

            FileInfo[] allFile = dir.GetFiles();
            foreach (FileInfo fi in allFile)
            {
                FileList.Add(Path.Combine(fi.DirectoryName,fi.Name));
            }

            DirectoryInfo[] allDir = dir.GetDirectories();
            foreach (DirectoryInfo d in allDir)
            {
                GetAll(d, FileList);
            }
            return FileList;
        }
        private bool backup() {
            ArrayList resFileList = new ArrayList();
            GetAll(new DirectoryInfo(this.res), resFileList);
            ArrayList dstFileList = new ArrayList();
            GetAll(new DirectoryInfo(this.dst), dstFileList);

            foreach (string path in resFileList) {
                string dstpath = this.dst + path.Substring(this.res.Length);
                string fileName = path.Substring(path.LastIndexOf("\\")+1);
                if (File.Exists(dstpath))
                {
                    if (!(getFileMd5(path) == getFileMd5(dstpath))) {
                        updateMsg("文件："+fileName+" 有更新，更新此文件的备份");
                        File.Copy(path, dstpath,true);
                    }
                }
                else {
                    string dstdir = dstpath.Substring(0,dstpath.LastIndexOf("\\"));
                    
                    if (!Directory.Exists(dstdir)) {
                        updateMsg("创建目录："+dstdir);
                        Directory.CreateDirectory(dstdir);
                    }
                    updateMsg("发现新文件：" + fileName);
                    updateMsg("备份文件：" + fileName);
                    File.Copy(path,dstpath,false);
                }
            }

            return true;
        }

        private void updateMsg(string newline) {
            backupMessageTextBox.Text += newline + Environment.NewLine;
            backupMessageTextBox.Refresh();
        }
        private void 备份ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.res.Length == 0 || this.dst.Length == 0)
            {
                MessageBox.Show("还没有配置备份！");
            }
            else { 
                // 开始备份
                updateMsg("开始备份");
                bool flag = backup();
                if (flag)
                {
                    //MessageBox.Show("备份成功！");
                    updateMsg("备份成功");
                    
                }
                else
                {
                    updateMsg("备份失败！");
                    MessageBox.Show("备份失败！");
                    
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void backupInfo_Click(object sender, EventArgs e)
        {

        }

        private void backupMessageTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
