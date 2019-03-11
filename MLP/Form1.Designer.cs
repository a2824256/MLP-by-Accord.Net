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
            this.select_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.test_button = new System.Windows.Forms.Button();
            this.content_box = new System.Windows.Forms.TextBox();
            this.TrainingRows = new System.Windows.Forms.TextBox();
            this.TestRows = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Accuracy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Epoch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gw = new System.Windows.Forms.Label();
            this.momentum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lr = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GetRules = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nodes = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(288, 72);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(10, 20);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(288, 37);
            this.select_button.TabIndex = 5;
            this.select_button.Text = "Select File";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(6, 20);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(151, 32);
            this.load_button.TabIndex = 6;
            this.load_button.Text = "Load and Train";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(6, 68);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(151, 32);
            this.test_button.TabIndex = 8;
            this.test_button.Text = "Test";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // content_box
            // 
            this.content_box.Location = new System.Drawing.Point(390, 180);
            this.content_box.Multiline = true;
            this.content_box.Name = "content_box";
            this.content_box.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.content_box.Size = new System.Drawing.Size(303, 165);
            this.content_box.TabIndex = 9;
            // 
            // TrainingRows
            // 
            this.TrainingRows.Location = new System.Drawing.Point(189, 83);
            this.TrainingRows.Name = "TrainingRows";
            this.TrainingRows.Size = new System.Drawing.Size(156, 21);
            this.TrainingRows.TabIndex = 10;
            this.TrainingRows.Text = "240000";
            // 
            // TestRows
            // 
            this.TestRows.Location = new System.Drawing.Point(188, 128);
            this.TestRows.Name = "TestRows";
            this.TestRows.Size = new System.Drawing.Size(157, 21);
            this.TestRows.TabIndex = 11;
            this.TestRows.Text = "10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "Training rows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "Test rows";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "Accuracy:";
            // 
            // Accuracy
            // 
            this.Accuracy.Location = new System.Drawing.Point(188, 36);
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.ReadOnly = true;
            this.Accuracy.Size = new System.Drawing.Size(156, 21);
            this.Accuracy.TabIndex = 30;
            this.Accuracy.Text = "0%";
            this.Accuracy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(185, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 31;
            this.label13.Text = "Epoch number";
            // 
            // Epoch
            // 
            this.Epoch.Location = new System.Drawing.Point(187, 177);
            this.Epoch.Name = "Epoch";
            this.Epoch.Size = new System.Drawing.Size(157, 21);
            this.Epoch.TabIndex = 32;
            this.Epoch.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nodes);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.gw);
            this.groupBox1.Controls.Add(this.momentum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lr);
            this.groupBox1.Controls.Add(this.Epoch);
            this.groupBox1.Controls.Add(this.load_button);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.test_button);
            this.groupBox1.Controls.Add(this.Accuracy);
            this.groupBox1.Controls.Add(this.TestRows);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TrainingRows);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 258);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Part One : Artificial Neural Networks";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 231);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 21);
            this.textBox3.TabIndex = 38;
            this.textBox3.Text = "0.1";
            // 
            // gw
            // 
            this.gw.AutoSize = true;
            this.gw.Location = new System.Drawing.Point(4, 216);
            this.gw.Name = "gw";
            this.gw.Size = new System.Drawing.Size(101, 12);
            this.gw.TabIndex = 37;
            this.gw.Text = "Gaussian Weights";
            // 
            // momentum
            // 
            this.momentum.Location = new System.Drawing.Point(6, 177);
            this.momentum.Name = "momentum";
            this.momentum.Size = new System.Drawing.Size(157, 21);
            this.momentum.TabIndex = 36;
            this.momentum.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "Momentum";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 21);
            this.textBox2.TabIndex = 34;
            this.textBox2.Text = "0.1";
            // 
            // lr
            // 
            this.lr.AutoSize = true;
            this.lr.Location = new System.Drawing.Point(4, 113);
            this.lr.Name = "lr";
            this.lr.Size = new System.Drawing.Size(83, 12);
            this.lr.TabIndex = 33;
            this.lr.Text = "Learning Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "Output:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GetRules);
            this.groupBox2.Location = new System.Drawing.Point(12, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 61);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Part Two : Pattern Discovery";
            // 
            // GetRules
            // 
            this.GetRules.Location = new System.Drawing.Point(33, 20);
            this.GetRules.Name = "GetRules";
            this.GetRules.Size = new System.Drawing.Size(288, 32);
            this.GetRules.TabIndex = 6;
            this.GetRules.Text = "Get rules";
            this.GetRules.UseVisualStyleBackColor = true;
            this.GetRules.Click += new System.EventHandler(this.GetRules_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.select_button);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(390, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 149);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Load File";
            // 
            // nodes
            // 
            this.nodes.Location = new System.Drawing.Point(187, 231);
            this.nodes.Name = "nodes";
            this.nodes.Size = new System.Drawing.Size(157, 21);
            this.nodes.TabIndex = 40;
            this.nodes.Text = "15,15";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(185, 216);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(113, 12);
            this.lb.TabIndex = 39;
            this.lb.Text = "Hidden layer nodes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 366);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.content_box);
            this.Name = "Form1";
            this.Text = "Investigation of dataset and MLP training by Accord.Net - Author Alex Leung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button select_button;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button test_button;
        private System.Windows.Forms.TextBox content_box;
        private System.Windows.Forms.TextBox TrainingRows;
        private System.Windows.Forms.TextBox TestRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Accuracy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Epoch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button GetRules;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lr;
        private System.Windows.Forms.TextBox momentum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label gw;
        private System.Windows.Forms.TextBox nodes;
        private System.Windows.Forms.Label lb;
    }
}

