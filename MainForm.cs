﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevelopmentToolList.apps;
using System.Xml.Linq;

namespace DevelopmentToolList
{
    public partial class MainForm : Form
    {
        // 软件对应的当前按钮的颜色
        private Color prevAppBtnColor;
        private Color prevAppTextColor;  // 上一个按钮对应的文字颜色
        private Button prevApp;
        private string currentApp;


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.mavenPanel.Visible = false;
            /* 
             * 检查是否开启了mysql 
             */
            if (Utils.testConnect(3306))
            {
                // 开启成功
                this.mysql_status.BackColor = Color.Lime;
                this.logInfo.AppendText("MySQL启动成功！  " + DateTime.Now.ToLongTimeString().ToString() + "\r\n");
            } else
            {
                // 没有开启
                this.mysql_status.BackColor = Color.Red;
            }

            /*
             * 检查redis是否开启
             */
            if (Utils.testConnect(6379))
            {
                // 开启成功
                this.redis_status.BackColor = Color.Lime;
                this.logInfo.AppendText("redis启动成功！  " + DateTime.Now.ToLongTimeString().ToString() + "\r\n");

            }
            else
            {
                // 没有开启
                this.redis_status.BackColor = Color.Red;
            }

            /*
             * 检查Tomcat是否开启
             */
            if (Utils.testConnect(8080))
            {
                // 开启成功
                this.tomcat_status.BackColor = Color.Lime;
                this.logInfo.AppendText("Tomcat启动成功！  " + DateTime.Now.ToLongTimeString().ToString() + "\r\n");

            }
            else
            {
                // 没有开启
                this.tomcat_status.BackColor = Color.Red;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 取消关闭窗口
            e.Cancel = true;
            // 将窗体最小化
            this.WindowState = FormWindowState.Minimized;
            // 从系统状态栏去除
            this.ShowInTaskbar = false;
            // 启动气泡
            // this.notifyIcon.ShowBalloonTip(0);
        }

        /*
          为notifyIcon设置双击事件，可以使得窗口显示出来
         */
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) 
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;   // 显示窗口
                // 显示在系统状态栏
                this.ShowInTaskbar = true;
            }
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notifyIcon.Dispose();
            System.Environment.Exit(0);  // 关闭程序
        }

        // 点击mysql按钮
        private void mysql_Click(object sender, EventArgs e)
        {
            // 设置按钮信息
            setAppBtn("MySQL启停", this.mysql);
            this.currentApp = "MySQL";
            // 初始化mysql
            string currentPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string mysqlPath = currentPath + "Applications\\MySQL\\bin";
            new Mysql().initMysql(mysqlPath);
        }

        // 点击redis按钮
        private void redis_Click(object sender, EventArgs e)
        {
            setAppBtn("redis启停", this.redis);
            this.currentApp = "redis";
            // 初始化redis
            string currentPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string redisPath = currentPath + "Applications\\redis";
            new Redis().initRedis(redisPath);
        }

        // 点击Tomcat按钮
        private void Tomcat_Click(object sender, EventArgs e)
        {
            setAppBtn("Tomcat启停", this.Tomcat);
            this.currentApp = "Tomcat";
            // 初始化Tomcat
            string currentPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string tomcatPath = currentPath + "Applications\\Tomcat\\bin";
            new Tomcat().initTomcat(tomcatPath);
        }

        private void setAppBtn(string labelInfo, Button currentBtn)
        {
            this.current_select.Text = labelInfo;
            // 还原上一个按钮的颜色
            if (prevApp != null) 
            {
                prevApp.BackColor = prevAppBtnColor;
                prevApp.ForeColor = prevAppTextColor;
            }
            // 更新上一个按钮信息
            this.prevAppBtnColor = currentBtn.BackColor;
            this.prevAppTextColor = currentBtn.ForeColor;
            this.prevApp = currentBtn;

            // 设置当前按钮的颜色
            currentBtn.BackColor = Color.White;
            currentBtn.ForeColor = Color.Black;

            // 让所有的按钮可以点击
            this.start.Enabled = true;
            this.stop.Enabled = true;
            this.restart.Enabled = true;

            // 显示面板
            this.mavenPanel.Visible = false;
        }

        // 启动服务
        private void start_Click(object sender, EventArgs e)
        {
            string currentPath = System.AppDomain.CurrentDomain.BaseDirectory;
            switch (currentApp)
            {
                case "MySQL":
                    {
                        new Mysql().startMySQLService(this.stop, this.restart, this.start, this.mysql_status, 
                            this.logInfo);
                    }
                    break;
                case "redis":
                    {
                        new Redis().startRedis(this.stop, this.restart, this.start, this.redis_status,
                            this.logInfo);
                    }
                    break;
                case "Tomcat":
                    {
                        new Tomcat().startTomcatService(this.stop, this.restart, this.start, this.tomcat_status,
                            this.logInfo);
                    }
                    break;
                default:
                    {
                        MessageBox.Show("请先选择要启动的应用！", "选择应用", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        // 关闭服务
        private void stop_Click(object sender, EventArgs e)
        {
            string currentPath = System.AppDomain.CurrentDomain.BaseDirectory;
            switch (currentApp)
            {
                case "MySQL":
                    {
                        new Mysql().stopMySQLService(this.stop, this.restart, this.start, this.mysql_status, 
                            this.logInfo);
                    }
                    break;
                case "redis":
                    {
                        new Redis().stopRedisService(this.stop, this.restart, this.start, this.redis_status,
                            this.logInfo);
                    }
                    break;
                case "Tomcat":
                    {
                        new Tomcat().stopTomcatService(this.stop, this.restart, this.start, this.tomcat_status,
                            this.logInfo);
                    }
                    break;
                default:
                    {
                        MessageBox.Show("请先选择要停止的应用！", "选择应用", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        // 重启服务
        private void restart_Click(object sender, EventArgs e)
        {
            string currentPath = System.AppDomain.CurrentDomain.BaseDirectory;
            switch (currentApp)
            {
                case "MySQL":
                    {
                        new Mysql().restartMySQLService(this.stop, this.restart, this.start, this.mysql_status,
                            this.logInfo);
                    }
                    break;
                case "redis":
                    {
                        new Redis().restartRedisService(this.stop, this.restart, this.start, this.redis_status,
                            this.logInfo);
                    }
                    break;
                case "Tomcat":
                    {
                        new Tomcat().restartTomcatService(this.stop, this.restart, this.start, this.tomcat_status,
                            this.logInfo);
                    }
                    break;
                default:
                    {
                        MessageBox.Show("请先选择要重启的应用！", "选择应用", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        // 点击Maven应用按钮
        private void Maven_Click(object sender, EventArgs e)
        {
            setAppBtn("Maven启停", this.Maven);
            this.currentApp = "Maven";

            // 显示Maven面板
            this.mavenPanel.Visible = true;
        }

        // 显示选择maven仓库的控件
        private void select_maven_repository_Click(object sender, EventArgs e)
        {
            if (this.mavenFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string maven_repository_path = this.mavenFolder.SelectedPath;
                this.maven_repository.Text = maven_repository_path;
            }
        }

        // 设置maven仓库的路径
        private void save_repository_Click(object sender, EventArgs e)
        {
            string currentPath = System.AppDomain.CurrentDomain.BaseDirectory;
            // 获取路径
            string maven_path = this.maven_repository.Text;
            // 获取settings文件的路径
            string settings_path = currentPath + "Applications\\Maven\\conf\\settings.xml";
            XDocument xd = XDocument.Load(settings_path);
            IEnumerable<XElement> ie = xd.Root.Descendants(xd.Root.Name.Namespace + "localRepository");
            if (ie.Count() > 0)
            {
                ie.First().Remove();
            }
            XElement element = new XElement(new XElement(xd.Root.Name.Namespace + "localRepository", maven_path));
            xd.Root.Add(element);
            xd.Save(settings_path);
            // 修改成功
            MessageBox.Show("修改Maven本地仓库成功！", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
