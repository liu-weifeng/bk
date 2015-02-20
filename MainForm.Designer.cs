namespace bk
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupInfo = new System.Windows.Forms.Label();
            this.backupMessageTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.备份ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(412, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.fileToolStripMenuItem.Text = "文件";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 备份ToolStripMenuItem
            // 
            this.备份ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.备份设置ToolStripMenuItem,
            this.备份ToolStripMenuItem1});
            this.备份ToolStripMenuItem.Name = "备份ToolStripMenuItem";
            this.备份ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.备份ToolStripMenuItem.Text = "备份";
            // 
            // 备份设置ToolStripMenuItem
            // 
            this.备份设置ToolStripMenuItem.Name = "备份设置ToolStripMenuItem";
            this.备份设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.备份设置ToolStripMenuItem.Text = "备份设置";
            this.备份设置ToolStripMenuItem.Click += new System.EventHandler(this.备份设置ToolStripMenuItem_Click);
            // 
            // 备份ToolStripMenuItem1
            // 
            this.备份ToolStripMenuItem1.Name = "备份ToolStripMenuItem1";
            this.备份ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.备份ToolStripMenuItem1.Text = "备份";
            this.备份ToolStripMenuItem1.Click += new System.EventHandler(this.备份ToolStripMenuItem1_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // backupInfo
            // 
            this.backupInfo.AutoSize = true;
            this.backupInfo.Location = new System.Drawing.Point(12, 44);
            this.backupInfo.Name = "backupInfo";
            this.backupInfo.Size = new System.Drawing.Size(41, 12);
            this.backupInfo.TabIndex = 1;
            this.backupInfo.Text = "label1";
            this.backupInfo.Click += new System.EventHandler(this.backupInfo_Click);
            // 
            // backupMessageTextBox
            // 
            this.backupMessageTextBox.Location = new System.Drawing.Point(12, 90);
            this.backupMessageTextBox.Multiline = true;
            this.backupMessageTextBox.Name = "backupMessageTextBox";
            this.backupMessageTextBox.ReadOnly = true;
            this.backupMessageTextBox.Size = new System.Drawing.Size(386, 210);
            this.backupMessageTextBox.TabIndex = 2;
            this.backupMessageTextBox.TextChanged += new System.EventHandler(this.backupMessageTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 322);
            this.Controls.Add(this.backupMessageTextBox);
            this.Controls.Add(this.backupInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "文档备份";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Label backupInfo;
        private System.Windows.Forms.TextBox backupMessageTextBox;
    }
}

