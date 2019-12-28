namespace ToolsManage
{
    partial class TestPortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestPortForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TestingPort = new System.Windows.Forms.TextBox();
            this.TestingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入想要测试的端口号：";
            // 
            // TestingPort
            // 
            this.TestingPort.Location = new System.Drawing.Point(175, 28);
            this.TestingPort.Name = "TestingPort";
            this.TestingPort.Size = new System.Drawing.Size(282, 21);
            this.TestingPort.TabIndex = 1;
            // 
            // TestingBtn
            // 
            this.TestingBtn.BackColor = System.Drawing.Color.Transparent;
            this.TestingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.TestingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.TestingBtn.Location = new System.Drawing.Point(351, 84);
            this.TestingBtn.Name = "TestingBtn";
            this.TestingBtn.Size = new System.Drawing.Size(106, 35);
            this.TestingBtn.TabIndex = 2;
            this.TestingBtn.Text = "点击测试";
            this.TestingBtn.UseVisualStyleBackColor = false;
            this.TestingBtn.Click += new System.EventHandler(this.TestingBtn_Click);
            // 
            // TestPortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 160);
            this.Controls.Add(this.TestingBtn);
            this.Controls.Add(this.TestingPort);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestPortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试端口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TestingPort;
        private System.Windows.Forms.Button TestingBtn;
    }
}