namespace bk
{
    partial class BkSetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancle_button = new System.Windows.Forms.Button();
            this.res_text = new System.Windows.Forms.TextBox();
            this.dst_text = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "备份源：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "备份到：";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(342, 144);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 3;
            this.ok_button.Text = "确定";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancle_button
            // 
            this.cancle_button.Location = new System.Drawing.Point(448, 144);
            this.cancle_button.Name = "cancle_button";
            this.cancle_button.Size = new System.Drawing.Size(75, 23);
            this.cancle_button.TabIndex = 4;
            this.cancle_button.Text = "取消";
            this.cancle_button.UseVisualStyleBackColor = true;
            this.cancle_button.Click += new System.EventHandler(this.cancle_button_Click_1);
            // 
            // res_text
            // 
            this.res_text.Location = new System.Drawing.Point(72, 39);
            this.res_text.Name = "res_text";
            this.res_text.Size = new System.Drawing.Size(367, 21);
            this.res_text.TabIndex = 5;
            this.res_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dst_text
            // 
            this.dst_text.Location = new System.Drawing.Point(72, 73);
            this.dst_text.Name = "dst_text";
            this.dst_text.Size = new System.Drawing.Size(367, 21);
            this.dst_text.TabIndex = 6;
            this.dst_text.TextChanged += new System.EventHandler(this.dst_text_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(457, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(457, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BkSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 190);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dst_text);
            this.Controls.Add(this.res_text);
            this.Controls.Add(this.cancle_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "BkSetForm";
            this.Text = "设置备份";
            this.Load += new System.EventHandler(this.BkSetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancle_button;
        private System.Windows.Forms.TextBox res_text;
        private System.Windows.Forms.TextBox dst_text;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}