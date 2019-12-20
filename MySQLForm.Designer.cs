namespace ToolsManage
{
    partial class MySQLForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySQLForm));
            this.changeMySQLPasswordPanel = new System.Windows.Forms.GroupBox();
            this.changeMySQLPaswordBtn = new System.Windows.Forms.Button();
            this.changePasswordLabel = new System.Windows.Forms.Label();
            this.changePasswordText = new System.Windows.Forms.TextBox();
            this.mysqlManagementPanel = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changeMySQLPasswordPanel.SuspendLayout();
            this.mysqlManagementPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // changeMySQLPasswordPanel
            // 
            this.changeMySQLPasswordPanel.Controls.Add(this.changeMySQLPaswordBtn);
            this.changeMySQLPasswordPanel.Controls.Add(this.changePasswordLabel);
            this.changeMySQLPasswordPanel.Controls.Add(this.changePasswordText);
            this.changeMySQLPasswordPanel.Location = new System.Drawing.Point(12, 12);
            this.changeMySQLPasswordPanel.Name = "changeMySQLPasswordPanel";
            this.changeMySQLPasswordPanel.Size = new System.Drawing.Size(480, 120);
            this.changeMySQLPasswordPanel.TabIndex = 0;
            this.changeMySQLPasswordPanel.TabStop = false;
            this.changeMySQLPasswordPanel.Text = "修改密码";
            // 
            // changeMySQLPaswordBtn
            // 
            this.changeMySQLPaswordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.changeMySQLPaswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeMySQLPaswordBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.changeMySQLPaswordBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.changeMySQLPaswordBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.changeMySQLPaswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeMySQLPaswordBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.changeMySQLPaswordBtn.ForeColor = System.Drawing.Color.White;
            this.changeMySQLPaswordBtn.Location = new System.Drawing.Point(363, 66);
            this.changeMySQLPaswordBtn.Name = "changeMySQLPaswordBtn";
            this.changeMySQLPaswordBtn.Size = new System.Drawing.Size(93, 37);
            this.changeMySQLPaswordBtn.TabIndex = 2;
            this.changeMySQLPaswordBtn.Text = "修改密码";
            this.changeMySQLPaswordBtn.UseVisualStyleBackColor = false;
            this.changeMySQLPaswordBtn.Click += new System.EventHandler(this.changeMySQLPaswordBtn_Click);
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.AutoSize = true;
            this.changePasswordLabel.Location = new System.Drawing.Point(6, 30);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Size = new System.Drawing.Size(89, 12);
            this.changePasswordLabel.TabIndex = 1;
            this.changePasswordLabel.Text = "请输入新密码：";
            // 
            // changePasswordText
            // 
            this.changePasswordText.Location = new System.Drawing.Point(96, 27);
            this.changePasswordText.Name = "changePasswordText";
            this.changePasswordText.Size = new System.Drawing.Size(360, 21);
            this.changePasswordText.TabIndex = 0;
            // 
            // mysqlManagementPanel
            // 
            this.mysqlManagementPanel.Controls.Add(this.panel1);
            this.mysqlManagementPanel.Location = new System.Drawing.Point(12, 150);
            this.mysqlManagementPanel.Name = "mysqlManagementPanel";
            this.mysqlManagementPanel.Size = new System.Drawing.Size(480, 101);
            this.mysqlManagementPanel.TabIndex = 1;
            this.mysqlManagementPanel.TabStop = false;
            this.mysqlManagementPanel.Text = "MySQL管理工具";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.AdminerBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(8, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 51);
            this.panel1.TabIndex = 0;
            // 
            // AdminerBtn
            // 
            this.AdminerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.AdminerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(143)))));
            this.AdminerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(172)))));
            this.AdminerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(172)))));
            this.AdminerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminerBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AdminerBtn.ForeColor = System.Drawing.Color.White;
            this.AdminerBtn.Location = new System.Drawing.Point(351, 5);
            this.AdminerBtn.Name = "AdminerBtn";
            this.AdminerBtn.Size = new System.Drawing.Size(105, 41);
            this.AdminerBtn.TabIndex = 3;
            this.AdminerBtn.Text = "打开";
            this.AdminerBtn.UseVisualStyleBackColor = false;
            this.AdminerBtn.Click += new System.EventHandler(this.AdminerBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "MySQL管理工具";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据库管理工具(web)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ToolsManage.Properties.Resources.Adminer;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MySQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 276);
            this.Controls.Add(this.mysqlManagementPanel);
            this.Controls.Add(this.changeMySQLPasswordPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MySQLForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQLForm";
            this.changeMySQLPasswordPanel.ResumeLayout(false);
            this.changeMySQLPasswordPanel.PerformLayout();
            this.mysqlManagementPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox changeMySQLPasswordPanel;
        private System.Windows.Forms.Label changePasswordLabel;
        private System.Windows.Forms.TextBox changePasswordText;
        private System.Windows.Forms.Button changeMySQLPaswordBtn;
        private System.Windows.Forms.GroupBox mysqlManagementPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AdminerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}