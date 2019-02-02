namespace MLP
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.select_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.test_button = new System.Windows.Forms.Button();
            this.content_box = new System.Windows.Forms.TextBox();
            this.TrainingRows = new System.Windows.Forms.TextBox();
            this.TestRows = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(479, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Step:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.Coral;
            this.status.Location = new System.Drawing.Point(54, 13);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(65, 12);
            this.status.TabIndex = 4;
            this.status.Text = "waiting...";
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(15, 39);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(126, 32);
            this.select_button.TabIndex = 5;
            this.select_button.Text = "Select File";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(166, 39);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(124, 32);
            this.load_button.TabIndex = 6;
            this.load_button.Text = "Load and Train";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(15, 107);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(126, 32);
            this.test_button.TabIndex = 8;
            this.test_button.Text = "Test";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // content_box
            // 
            this.content_box.Location = new System.Drawing.Point(166, 107);
            this.content_box.Multiline = true;
            this.content_box.Name = "content_box";
            this.content_box.Size = new System.Drawing.Size(622, 316);
            this.content_box.TabIndex = 9;
            // 
            // TrainingRows
            // 
            this.TrainingRows.Location = new System.Drawing.Point(15, 199);
            this.TrainingRows.Name = "TrainingRows";
            this.TrainingRows.Size = new System.Drawing.Size(126, 21);
            this.TrainingRows.TabIndex = 10;
            // 
            // TestRows
            // 
            this.TestRows.Location = new System.Drawing.Point(15, 272);
            this.TestRows.Name = "TestRows";
            this.TestRows.Size = new System.Drawing.Size(126, 21);
            this.TestRows.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "Training rows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "Test rows";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TestRows);
            this.Controls.Add(this.TrainingRows);
            this.Controls.Add(this.content_box);
            this.Controls.Add(this.test_button);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "MLP by Accord - Author Alex Leung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button select_button;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button test_button;
        private System.Windows.Forms.TextBox content_box;
        private System.Windows.Forms.TextBox TrainingRows;
        private System.Windows.Forms.TextBox TestRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

