namespace ToolsManage
{
    partial class MavenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MavenForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.setRepository = new System.Windows.Forms.GroupBox();
            this.save_repository = new System.Windows.Forms.Button();
            this.select_maven_repository = new System.Windows.Forms.Button();
            this.maven_repository = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mavenFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.setRepository.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "Maven信息：",
            "    版本：3.6.1",
            "    属于：开源组织Apache下的一个开源项目"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(448, 76);
            this.listBox1.TabIndex = 3;
            // 
            // setRepository
            // 
            this.setRepository.BackColor = System.Drawing.SystemColors.Control;
            this.setRepository.Controls.Add(this.save_repository);
            this.setRepository.Controls.Add(this.select_maven_repository);
            this.setRepository.Controls.Add(this.maven_repository);
            this.setRepository.Controls.Add(this.label1);
            this.setRepository.Location = new System.Drawing.Point(12, 109);
            this.setRepository.Name = "setRepository";
            this.setRepository.Size = new System.Drawing.Size(448, 110);
            this.setRepository.TabIndex = 2;
            this.setRepository.TabStop = false;
            this.setRepository.Text = "设置Maven仓库";
            // 
            // save_repository
            // 
            this.save_repository.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(235)))));
            this.save_repository.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_repository.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(176)))));
            this.save_repository.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(255)))), ((int)(((byte)(214)))));
            this.save_repository.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(255)))), ((int)(((byte)(214)))));
            this.save_repository.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_repository.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.save_repository.Location = new System.Drawing.Point(335, 62);
            this.save_repository.Name = "save_repository";
            this.save_repository.Size = new System.Drawing.Size(105, 30);
            this.save_repository.TabIndex = 3;
            this.save_repository.Text = "保存";
            this.save_repository.UseVisualStyleBackColor = false;
            this.save_repository.Click += new System.EventHandler(this.save_repository_Click);
            // 
            // select_maven_repository
            // 
            this.select_maven_repository.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.select_maven_repository.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select_maven_repository.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(218)))), ((int)(((byte)(177)))));
            this.select_maven_repository.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(203)))));
            this.select_maven_repository.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(203)))));
            this.select_maven_repository.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_maven_repository.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.select_maven_repository.Location = new System.Drawing.Point(365, 18);
            this.select_maven_repository.Name = "select_maven_repository";
            this.select_maven_repository.Size = new System.Drawing.Size(75, 23);
            this.select_maven_repository.TabIndex = 2;
            this.select_maven_repository.Text = "浏览";
            this.select_maven_repository.UseVisualStyleBackColor = false;
            this.select_maven_repository.Click += new System.EventHandler(this.select_maven_repository_Click);
            // 
            // maven_repository
            // 
            this.maven_repository.Location = new System.Drawing.Point(89, 19);
            this.maven_repository.Name = "maven_repository";
            this.maven_repository.ReadOnly = true;
            this.maven_repository.Size = new System.Drawing.Size(270, 21);
            this.maven_repository.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择地址：";
            // 
            // mavenFolder
            // 
            this.mavenFolder.Description = "选择maven仓库目录";
            // 
            // MavenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 248);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.setRepository);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MavenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MavenForm";
            this.setRepository.ResumeLayout(false);
            this.setRepository.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox setRepository;
        private System.Windows.Forms.Button save_repository;
        private System.Windows.Forms.Button select_maven_repository;
        private System.Windows.Forms.TextBox maven_repository;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog mavenFolder;
    }
}