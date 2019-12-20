namespace DevelopmentToolList
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开hostToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Cmd_MySQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd操作redisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开cmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作MySQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作redisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件位置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySQLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tomcatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mavenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jDKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.软件根目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.软件站点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.github仓库地址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作者GitHub主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tomcat = new System.Windows.Forms.Button();
            this.mysql = new System.Windows.Forms.Button();
            this.redis = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuLine = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.JDK = new System.Windows.Forms.Button();
            this.Maven = new System.Windows.Forms.Button();
            this.left_line = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.backColor = new System.Windows.Forms.Label();
            this.logGroup = new System.Windows.Forms.GroupBox();
            this.printButtom = new System.Windows.Forms.Button();
            this.logInfo = new System.Windows.Forms.TextBox();
            this.runInfo = new System.Windows.Forms.GroupBox();
            this.tips3 = new System.Windows.Forms.Label();
            this.tips2 = new System.Windows.Forms.Label();
            this.tips1 = new System.Windows.Forms.Label();
            this.green = new System.Windows.Forms.Panel();
            this.yellow = new System.Windows.Forms.Panel();
            this.red = new System.Windows.Forms.Panel();
            this.redis_status = new System.Windows.Forms.Panel();
            this.tomcat_status = new System.Windows.Forms.Panel();
            this.mysql_status = new System.Windows.Forms.Panel();
            this.Tomcat_label = new System.Windows.Forms.Label();
            this.redis_label = new System.Windows.Forms.Label();
            this.mysql_label = new System.Windows.Forms.Label();
            this.operationButtom = new System.Windows.Forms.GroupBox();
            this.current_select = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.服务管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重启全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveLog = new System.Windows.Forms.SaveFileDialog();
            this.topMenu.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.logGroup.SuspendLayout();
            this.runInfo.SuspendLayout();
            this.operationButtom.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.Color.White;
            this.topMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.数据库ToolStripMenuItem,
            this.打开文件位置ToolStripMenuItem,
            this.软件站点ToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(566, 23);
            this.topMenu.TabIndex = 3;
            this.topMenu.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开hostToolStripMenuItem1,
            this.Cmd_MySQLToolStripMenuItem,
            this.cmd操作redisToolStripMenuItem,
            this.打开cmdToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.b_bookmark;
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.文件FToolStripMenuItem.Text = "文件";
            // 
            // 打开hostToolStripMenuItem1
            // 
            this.打开hostToolStripMenuItem1.Image = global::ToolsManage.Properties.Resources.b_sbrowse;
            this.打开hostToolStripMenuItem1.Name = "打开hostToolStripMenuItem1";
            this.打开hostToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.打开hostToolStripMenuItem1.Text = "打开hosts";
            this.打开hostToolStripMenuItem1.Click += new System.EventHandler(this.打开hostToolStripMenuItem1_Click);
            // 
            // Cmd_MySQLToolStripMenuItem
            // 
            this.Cmd_MySQLToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.cmd;
            this.Cmd_MySQLToolStripMenuItem.Name = "Cmd_MySQLToolStripMenuItem";
            this.Cmd_MySQLToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.Cmd_MySQLToolStripMenuItem.Text = "cmd操作MySQL";
            this.Cmd_MySQLToolStripMenuItem.Click += new System.EventHandler(this.Cmd_MySQLToolStripMenuItem_Click);
            // 
            // cmd操作redisToolStripMenuItem
            // 
            this.cmd操作redisToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.cmd;
            this.cmd操作redisToolStripMenuItem.Name = "cmd操作redisToolStripMenuItem";
            this.cmd操作redisToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cmd操作redisToolStripMenuItem.Text = "cmd操作redis";
            this.cmd操作redisToolStripMenuItem.Click += new System.EventHandler(this.cmd操作redisToolStripMenuItem_Click);
            // 
            // 打开cmdToolStripMenuItem
            // 
            this.打开cmdToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.terminal;
            this.打开cmdToolStripMenuItem.Name = "打开cmdToolStripMenuItem";
            this.打开cmdToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.打开cmdToolStripMenuItem.Text = "打开cmd";
            this.打开cmdToolStripMenuItem.Click += new System.EventHandler(this.打开cmdToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.b_drop;
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.退出XToolStripMenuItem.Text = "退出程序";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 数据库ToolStripMenuItem
            // 
            this.数据库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作MySQLToolStripMenuItem,
            this.操作redisToolStripMenuItem});
            this.数据库ToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.database;
            this.数据库ToolStripMenuItem.Name = "数据库ToolStripMenuItem";
            this.数据库ToolStripMenuItem.Size = new System.Drawing.Size(72, 19);
            this.数据库ToolStripMenuItem.Text = "数据库";
            // 
            // 操作MySQLToolStripMenuItem
            // 
            this.操作MySQLToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.mysql1;
            this.操作MySQLToolStripMenuItem.Name = "操作MySQLToolStripMenuItem";
            this.操作MySQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.操作MySQLToolStripMenuItem.Text = "操作MySQL";
            this.操作MySQLToolStripMenuItem.Click += new System.EventHandler(this.操作MySQLToolStripMenuItem_Click);
            // 
            // 操作redisToolStripMenuItem
            // 
            this.操作redisToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.redis;
            this.操作redisToolStripMenuItem.Name = "操作redisToolStripMenuItem";
            this.操作redisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.操作redisToolStripMenuItem.Text = "操作redis";
            this.操作redisToolStripMenuItem.Click += new System.EventHandler(this.操作redisToolStripMenuItem_Click);
            // 
            // 打开文件位置ToolStripMenuItem
            // 
            this.打开文件位置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mySQLToolStripMenuItem1,
            this.redisToolStripMenuItem1,
            this.tomcatToolStripMenuItem1,
            this.mavenToolStripMenuItem,
            this.jDKToolStripMenuItem,
            this.软件根目录ToolStripMenuItem});
            this.打开文件位置ToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.bottom;
            this.打开文件位置ToolStripMenuItem.Name = "打开文件位置ToolStripMenuItem";
            this.打开文件位置ToolStripMenuItem.Size = new System.Drawing.Size(108, 19);
            this.打开文件位置ToolStripMenuItem.Text = "打开文件位置";
            // 
            // mySQLToolStripMenuItem1
            // 
            this.mySQLToolStripMenuItem1.Image = global::ToolsManage.Properties.Resources.mysql1;
            this.mySQLToolStripMenuItem1.Name = "mySQLToolStripMenuItem1";
            this.mySQLToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.mySQLToolStripMenuItem1.Text = "MySQL";
            this.mySQLToolStripMenuItem1.Click += new System.EventHandler(this.mySQLToolStripMenuItem1_Click);
            // 
            // redisToolStripMenuItem1
            // 
            this.redisToolStripMenuItem1.Image = global::ToolsManage.Properties.Resources.redis;
            this.redisToolStripMenuItem1.Name = "redisToolStripMenuItem1";
            this.redisToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.redisToolStripMenuItem1.Text = "redis";
            this.redisToolStripMenuItem1.Click += new System.EventHandler(this.redisToolStripMenuItem1_Click);
            // 
            // tomcatToolStripMenuItem1
            // 
            this.tomcatToolStripMenuItem1.Image = global::ToolsManage.Properties.Resources.Tomcat;
            this.tomcatToolStripMenuItem1.Name = "tomcatToolStripMenuItem1";
            this.tomcatToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.tomcatToolStripMenuItem1.Text = "Tomcat";
            this.tomcatToolStripMenuItem1.Click += new System.EventHandler(this.tomcatToolStripMenuItem1_Click);
            // 
            // mavenToolStripMenuItem
            // 
            this.mavenToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.maven;
            this.mavenToolStripMenuItem.Name = "mavenToolStripMenuItem";
            this.mavenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.mavenToolStripMenuItem.Text = "Maven";
            this.mavenToolStripMenuItem.Click += new System.EventHandler(this.mavenToolStripMenuItem_Click);
            // 
            // jDKToolStripMenuItem
            // 
            this.jDKToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.jdk;
            this.jDKToolStripMenuItem.Name = "jDKToolStripMenuItem";
            this.jDKToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.jDKToolStripMenuItem.Text = "JDK";
            this.jDKToolStripMenuItem.Click += new System.EventHandler(this.jDKToolStripMenuItem_Click);
            // 
            // 软件根目录ToolStripMenuItem
            // 
            this.软件根目录ToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.btn_lastorigin_press_wpp;
            this.软件根目录ToolStripMenuItem.Name = "软件根目录ToolStripMenuItem";
            this.软件根目录ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.软件根目录ToolStripMenuItem.Text = "软件根目录";
            this.软件根目录ToolStripMenuItem.Click += new System.EventHandler(this.软件根目录ToolStripMenuItem_Click);
            // 
            // 软件站点ToolStripMenuItem
            // 
            this.软件站点ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.github仓库地址ToolStripMenuItem,
            this.作者GitHub主页ToolStripMenuItem});
            this.软件站点ToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.marker_gold;
            this.软件站点ToolStripMenuItem.Name = "软件站点ToolStripMenuItem";
            this.软件站点ToolStripMenuItem.Size = new System.Drawing.Size(84, 19);
            this.软件站点ToolStripMenuItem.Text = "软件站点";
            // 
            // github仓库地址ToolStripMenuItem
            // 
            this.github仓库地址ToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.github;
            this.github仓库地址ToolStripMenuItem.Name = "github仓库地址ToolStripMenuItem";
            this.github仓库地址ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.github仓库地址ToolStripMenuItem.Text = "GitHub仓库地址";
            this.github仓库地址ToolStripMenuItem.Click += new System.EventHandler(this.github仓库地址ToolStripMenuItem_Click);
            // 
            // 作者GitHub主页ToolStripMenuItem
            // 
            this.作者GitHub主页ToolStripMenuItem.Image = global::ToolsManage.Properties.Resources._34062997;
            this.作者GitHub主页ToolStripMenuItem.Name = "作者GitHub主页ToolStripMenuItem";
            this.作者GitHub主页ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.作者GitHub主页ToolStripMenuItem.Text = "作者GitHub主页";
            this.作者GitHub主页ToolStripMenuItem.Click += new System.EventHandler(this.作者GitHub主页ToolStripMenuItem_Click);
            // 
            // Tomcat
            // 
            this.Tomcat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(164)))), ((int)(((byte)(27)))));
            this.Tomcat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tomcat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Tomcat.FlatAppearance.BorderSize = 0;
            this.Tomcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tomcat.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tomcat.ForeColor = System.Drawing.Color.Black;
            this.Tomcat.Location = new System.Drawing.Point(0, 80);
            this.Tomcat.Name = "Tomcat";
            this.Tomcat.Size = new System.Drawing.Size(95, 40);
            this.Tomcat.TabIndex = 6;
            this.Tomcat.Text = "Tomcat";
            this.Tomcat.UseVisualStyleBackColor = false;
            this.Tomcat.Click += new System.EventHandler(this.Tomcat_Click);
            // 
            // mysql
            // 
            this.mysql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(92)))), ((int)(((byte)(134)))));
            this.mysql.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mysql.FlatAppearance.BorderSize = 0;
            this.mysql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mysql.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mysql.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(137)))), ((int)(((byte)(22)))));
            this.mysql.Location = new System.Drawing.Point(0, 0);
            this.mysql.Name = "mysql";
            this.mysql.Size = new System.Drawing.Size(95, 40);
            this.mysql.TabIndex = 4;
            this.mysql.Text = "MySQL";
            this.mysql.UseVisualStyleBackColor = false;
            this.mysql.Click += new System.EventHandler(this.mysql_Click);
            // 
            // redis
            // 
            this.redis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(38)))), ((int)(((byte)(19)))));
            this.redis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redis.FlatAppearance.BorderSize = 0;
            this.redis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redis.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redis.ForeColor = System.Drawing.Color.White;
            this.redis.Location = new System.Drawing.Point(0, 40);
            this.redis.Name = "redis";
            this.redis.Size = new System.Drawing.Size(95, 40);
            this.redis.TabIndex = 5;
            this.redis.Text = "redis";
            this.redis.UseVisualStyleBackColor = false;
            this.redis.Click += new System.EventHandler(this.redis_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.topMenu);
            this.menuPanel.Controls.Add(this.menuLine);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(566, 25);
            this.menuPanel.TabIndex = 7;
            // 
            // menuLine
            // 
            this.menuLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuLine.Location = new System.Drawing.Point(0, 23);
            this.menuLine.Name = "menuLine";
            this.menuLine.Size = new System.Drawing.Size(566, 2);
            this.menuLine.TabIndex = 9;
            this.menuLine.Text = "label1";
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.JDK);
            this.leftPanel.Controls.Add(this.Maven);
            this.leftPanel.Controls.Add(this.left_line);
            this.leftPanel.Controls.Add(this.mysql);
            this.leftPanel.Controls.Add(this.Tomcat);
            this.leftPanel.Controls.Add(this.redis);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 25);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(96, 425);
            this.leftPanel.TabIndex = 8;
            // 
            // JDK
            // 
            this.JDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(129)))), ((int)(((byte)(153)))));
            this.JDK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JDK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.JDK.FlatAppearance.BorderSize = 0;
            this.JDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JDK.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JDK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(123)))), ((int)(((byte)(35)))));
            this.JDK.Location = new System.Drawing.Point(0, 160);
            this.JDK.Name = "JDK";
            this.JDK.Size = new System.Drawing.Size(95, 40);
            this.JDK.TabIndex = 8;
            this.JDK.Text = "JDK";
            this.JDK.UseVisualStyleBackColor = false;
            this.JDK.Click += new System.EventHandler(this.JDK_Click);
            // 
            // Maven
            // 
            this.Maven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.Maven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maven.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Maven.FlatAppearance.BorderSize = 0;
            this.Maven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maven.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(104)))), ((int)(((byte)(14)))));
            this.Maven.Location = new System.Drawing.Point(0, 120);
            this.Maven.Name = "Maven";
            this.Maven.Size = new System.Drawing.Size(95, 40);
            this.Maven.TabIndex = 7;
            this.Maven.Text = "Maven";
            this.Maven.UseVisualStyleBackColor = false;
            this.Maven.Click += new System.EventHandler(this.Maven_Click);
            // 
            // left_line
            // 
            this.left_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.left_line.Dock = System.Windows.Forms.DockStyle.Right;
            this.left_line.Location = new System.Drawing.Point(94, 0);
            this.left_line.Name = "left_line";
            this.left_line.Size = new System.Drawing.Size(2, 425);
            this.left_line.TabIndex = 0;
            this.left_line.Text = "label1";
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.Control;
            this.rightPanel.Controls.Add(this.backColor);
            this.rightPanel.Controls.Add(this.logGroup);
            this.rightPanel.Controls.Add(this.runInfo);
            this.rightPanel.Controls.Add(this.operationButtom);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(96, 25);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(470, 425);
            this.rightPanel.TabIndex = 9;
            // 
            // backColor
            // 
            this.backColor.AutoSize = true;
            this.backColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.backColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.backColor.Location = new System.Drawing.Point(86, 329);
            this.backColor.Name = "backColor";
            this.backColor.Size = new System.Drawing.Size(41, 12);
            this.backColor.TabIndex = 3;
            this.backColor.Text = "label1";
            this.backColor.Visible = false;
            // 
            // logGroup
            // 
            this.logGroup.Controls.Add(this.printButtom);
            this.logGroup.Controls.Add(this.logInfo);
            this.logGroup.Location = new System.Drawing.Point(186, 122);
            this.logGroup.Name = "logGroup";
            this.logGroup.Size = new System.Drawing.Size(272, 291);
            this.logGroup.TabIndex = 2;
            this.logGroup.TabStop = false;
            this.logGroup.Text = "日志信息";
            // 
            // printButtom
            // 
            this.printButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.printButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButtom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.printButtom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.printButtom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.printButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButtom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.printButtom.Location = new System.Drawing.Point(186, 251);
            this.printButtom.Name = "printButtom";
            this.printButtom.Size = new System.Drawing.Size(80, 34);
            this.printButtom.TabIndex = 1;
            this.printButtom.Text = "打印日志";
            this.printButtom.UseVisualStyleBackColor = false;
            this.printButtom.Click += new System.EventHandler(this.printButtom_Click);
            // 
            // logInfo
            // 
            this.logInfo.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logInfo.Location = new System.Drawing.Point(6, 20);
            this.logInfo.Multiline = true;
            this.logInfo.Name = "logInfo";
            this.logInfo.ReadOnly = true;
            this.logInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logInfo.Size = new System.Drawing.Size(260, 224);
            this.logInfo.TabIndex = 0;
            // 
            // runInfo
            // 
            this.runInfo.Controls.Add(this.tips3);
            this.runInfo.Controls.Add(this.tips2);
            this.runInfo.Controls.Add(this.tips1);
            this.runInfo.Controls.Add(this.green);
            this.runInfo.Controls.Add(this.yellow);
            this.runInfo.Controls.Add(this.red);
            this.runInfo.Controls.Add(this.redis_status);
            this.runInfo.Controls.Add(this.tomcat_status);
            this.runInfo.Controls.Add(this.mysql_status);
            this.runInfo.Controls.Add(this.Tomcat_label);
            this.runInfo.Controls.Add(this.redis_label);
            this.runInfo.Controls.Add(this.mysql_label);
            this.runInfo.Location = new System.Drawing.Point(4, 4);
            this.runInfo.Name = "runInfo";
            this.runInfo.Size = new System.Drawing.Size(161, 253);
            this.runInfo.TabIndex = 1;
            this.runInfo.TabStop = false;
            this.runInfo.Text = "运行状态";
            // 
            // tips3
            // 
            this.tips3.AutoSize = true;
            this.tips3.Location = new System.Drawing.Point(122, 20);
            this.tips3.Name = "tips3";
            this.tips3.Size = new System.Drawing.Size(29, 12);
            this.tips3.TabIndex = 8;
            this.tips3.Text = "启动";
            // 
            // tips2
            // 
            this.tips2.AutoSize = true;
            this.tips2.Location = new System.Drawing.Point(64, 20);
            this.tips2.Name = "tips2";
            this.tips2.Size = new System.Drawing.Size(41, 12);
            this.tips2.TabIndex = 7;
            this.tips2.Text = "启动中";
            // 
            // tips1
            // 
            this.tips1.AutoSize = true;
            this.tips1.Location = new System.Drawing.Point(17, 20);
            this.tips1.Name = "tips1";
            this.tips1.Size = new System.Drawing.Size(29, 12);
            this.tips1.TabIndex = 6;
            this.tips1.Text = "停止";
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Lime;
            this.green.Location = new System.Drawing.Point(110, 20);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(12, 12);
            this.green.TabIndex = 5;
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.Location = new System.Drawing.Point(52, 20);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(12, 12);
            this.yellow.TabIndex = 4;
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(6, 20);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(12, 12);
            this.red.TabIndex = 3;
            // 
            // redis_status
            // 
            this.redis_status.BackColor = System.Drawing.Color.Red;
            this.redis_status.Location = new System.Drawing.Point(82, 77);
            this.redis_status.Name = "redis_status";
            this.redis_status.Size = new System.Drawing.Size(12, 12);
            this.redis_status.TabIndex = 3;
            // 
            // tomcat_status
            // 
            this.tomcat_status.BackColor = System.Drawing.Color.Red;
            this.tomcat_status.Location = new System.Drawing.Point(82, 104);
            this.tomcat_status.Name = "tomcat_status";
            this.tomcat_status.Size = new System.Drawing.Size(12, 12);
            this.tomcat_status.TabIndex = 4;
            // 
            // mysql_status
            // 
            this.mysql_status.BackColor = System.Drawing.Color.Red;
            this.mysql_status.Location = new System.Drawing.Point(82, 48);
            this.mysql_status.Name = "mysql_status";
            this.mysql_status.Size = new System.Drawing.Size(12, 12);
            this.mysql_status.TabIndex = 2;
            // 
            // Tomcat_label
            // 
            this.Tomcat_label.AutoSize = true;
            this.Tomcat_label.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tomcat_label.Location = new System.Drawing.Point(16, 100);
            this.Tomcat_label.Name = "Tomcat_label";
            this.Tomcat_label.Size = new System.Drawing.Size(66, 16);
            this.Tomcat_label.TabIndex = 2;
            this.Tomcat_label.Text = "Tomcat：";
            // 
            // redis_label
            // 
            this.redis_label.AutoSize = true;
            this.redis_label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redis_label.Location = new System.Drawing.Point(25, 70);
            this.redis_label.Name = "redis_label";
            this.redis_label.Size = new System.Drawing.Size(60, 19);
            this.redis_label.TabIndex = 1;
            this.redis_label.Text = "redis：";
            // 
            // mysql_label
            // 
            this.mysql_label.AutoSize = true;
            this.mysql_label.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mysql_label.Location = new System.Drawing.Point(19, 45);
            this.mysql_label.Name = "mysql_label";
            this.mysql_label.Size = new System.Drawing.Size(64, 16);
            this.mysql_label.TabIndex = 0;
            this.mysql_label.Text = "MySQL：";
            // 
            // operationButtom
            // 
            this.operationButtom.Controls.Add(this.current_select);
            this.operationButtom.Controls.Add(this.restart);
            this.operationButtom.Controls.Add(this.stop);
            this.operationButtom.Controls.Add(this.start);
            this.operationButtom.Location = new System.Drawing.Point(186, 3);
            this.operationButtom.Name = "operationButtom";
            this.operationButtom.Size = new System.Drawing.Size(272, 100);
            this.operationButtom.TabIndex = 0;
            this.operationButtom.TabStop = false;
            this.operationButtom.Text = "操作区";
            // 
            // current_select
            // 
            this.current_select.AutoSize = true;
            this.current_select.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_select.ForeColor = System.Drawing.Color.Red;
            this.current_select.Location = new System.Drawing.Point(12, 22);
            this.current_select.Name = "current_select";
            this.current_select.Size = new System.Drawing.Size(68, 16);
            this.current_select.TabIndex = 3;
            this.current_select.Text = "应用启停";
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(162)))), ((int)(((byte)(54)))));
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.restart.ForeColor = System.Drawing.Color.White;
            this.restart.Location = new System.Drawing.Point(181, 48);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 40);
            this.restart.TabIndex = 2;
            this.restart.Text = "重启";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stop.ForeColor = System.Drawing.Color.White;
            this.stop.Location = new System.Drawing.Point(97, 48);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 40);
            this.stop.TabIndex = 1;
            this.stop.Text = "停止";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(76)))));
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(14, 48);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 40);
            this.start.TabIndex = 0;
            this.start.Text = "启动";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "点击这里弹出窗口";
            this.notifyIcon.BalloonTipTitle = "最小化到托盘";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "DevelopmentToolList 1.0.0";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.服务管理ToolStripMenuItem,
            this.toolStripSeparator9,
            this.退出程序ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 54);
            // 
            // 服务管理ToolStripMenuItem
            // 
            this.服务管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启动全部ToolStripMenuItem,
            this.停止全部ToolStripMenuItem,
            this.重启全部ToolStripMenuItem});
            this.服务管理ToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.b_tblops;
            this.服务管理ToolStripMenuItem.Name = "服务管理ToolStripMenuItem";
            this.服务管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.服务管理ToolStripMenuItem.Text = "服务管理";
            // 
            // 启动全部ToolStripMenuItem
            // 
            this.启动全部ToolStripMenuItem.Name = "启动全部ToolStripMenuItem";
            this.启动全部ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.启动全部ToolStripMenuItem.Text = "启动全部";
            this.启动全部ToolStripMenuItem.Click += new System.EventHandler(this.启动全部ToolStripMenuItem_Click);
            // 
            // 停止全部ToolStripMenuItem
            // 
            this.停止全部ToolStripMenuItem.Name = "停止全部ToolStripMenuItem";
            this.停止全部ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.停止全部ToolStripMenuItem.Text = "停止全部";
            this.停止全部ToolStripMenuItem.Click += new System.EventHandler(this.停止全部ToolStripMenuItem_Click);
            // 
            // 重启全部ToolStripMenuItem
            // 
            this.重启全部ToolStripMenuItem.Name = "重启全部ToolStripMenuItem";
            this.重启全部ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.重启全部ToolStripMenuItem.Text = "重启全部";
            this.重启全部ToolStripMenuItem.Click += new System.EventHandler(this.重启全部ToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(121, 6);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Image = global::ToolsManage.Properties.Resources.b_drop;
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // saveLog
            // 
            this.saveLog.DefaultExt = "xin";
            this.saveLog.FileName = "保存日志";
            this.saveLog.Filter = "日志文件(*.xin)|*.xin|所有文件|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolList 1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.logGroup.ResumeLayout(false);
            this.logGroup.PerformLayout();
            this.runInfo.ResumeLayout(false);
            this.runInfo.PerformLayout();
            this.operationButtom.ResumeLayout(false);
            this.operationButtom.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.Button Tomcat;
        private System.Windows.Forms.Button mysql;
        private System.Windows.Forms.Button redis;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label menuLine;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label left_line;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.GroupBox operationButtom;
        private System.Windows.Forms.GroupBox runInfo;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label Tomcat_label;
        private System.Windows.Forms.Label redis_label;
        private System.Windows.Forms.Label mysql_label;
        private System.Windows.Forms.Panel mysql_status;
        private System.Windows.Forms.Panel redis_status;
        private System.Windows.Forms.Panel tomcat_status;
        private System.Windows.Forms.GroupBox logGroup;
        private System.Windows.Forms.TextBox logInfo;
        private System.Windows.Forms.Button printButtom;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 服务管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动全部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止全部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重启全部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        private System.Windows.Forms.Label current_select;
        private System.Windows.Forms.Panel green;
        private System.Windows.Forms.Panel yellow;
        private System.Windows.Forms.Panel red;
        private System.Windows.Forms.Label tips3;
        private System.Windows.Forms.Label tips2;
        private System.Windows.Forms.Label tips1;
        private System.Windows.Forms.Button Maven;
        private System.Windows.Forms.Button JDK;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem 打开hostToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmd操作redisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Cmd_MySQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件位置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySQLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tomcatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mavenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jDKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 软件根目录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开cmdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 软件站点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem github仓库地址ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作者GitHub主页ToolStripMenuItem;
        private System.Windows.Forms.Label backColor;
        private System.Windows.Forms.SaveFileDialog saveLog;
        private System.Windows.Forms.ToolStripMenuItem 数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作MySQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作redisToolStripMenuItem;
    }
}

