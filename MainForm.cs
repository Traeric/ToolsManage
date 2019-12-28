using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevelopmentToolList.apps;
using System.Diagnostics;
using ToolsManage;
using System.IO;
using System.Threading;
using ToolsManage.apps;

namespace DevelopmentToolList
{
    public partial class MainForm : Form
    {
        // 软件对应的当前按钮的颜色
        private Color prevAppBtnColor;
        private Color prevAppTextColor;  // 上一个按钮对应的文字颜色
        private Button prevApp;
        private string currentApp;

        // 软件根目录
        public static string rootPath = System.AppDomain.CurrentDomain.BaseDirectory;


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* 
             * 检查是否开启了mysql 
             */
            if (Utils.testConnect(3306))
            {
                // 开启成功
                this.mysql_status.BackColor = Color.Lime;
                this.logInfo.AppendText("MySQL正在运行！  " + DateTime.Now.ToLongTimeString().ToString() + "\r\n");
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
                this.logInfo.AppendText("redis正在运行！  " + DateTime.Now.ToLongTimeString().ToString() + "\r\n");

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
                this.logInfo.AppendText("Tomcat正在运行！  " + DateTime.Now.ToLongTimeString().ToString() + "\r\n");

            }
            else
            {
                // 没有开启
                this.tomcat_status.BackColor = Color.Red;
            }
            /*
             * 检查Apache是否开启
             */
            if (Utils.testConnect(80))
            {
                // 开启成功
                //this.tomcat_status.BackColor = Color.Lime;
                this.logInfo.AppendText("Apache正在运行！  " + DateTime.Now.ToLongTimeString().ToString() + "\r\n");

            }
            else
            {
                // 没有开启
                //this.tomcat_status.BackColor = Color.Red;
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
            // 使用多线程执行该命令，因为在该步会消耗非常多的时间，影响用户体验
            Thread thread = new Thread(new ParameterizedThreadStart(new Mysql().initMysql));
            thread.Start(mysqlPath);
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
            currentBtn.BackColor = this.backColor.BackColor;
            currentBtn.ForeColor = this.backColor.ForeColor;

            // 让所有的按钮可以点击
            this.start.Enabled = true;
            this.stop.Enabled = true;
            this.restart.Enabled = true;
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

            // 显示Maven窗口
            MavenForm mavenForm = new MavenForm();
            mavenForm.Show();
        }

        // 退出程序
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notifyIcon.Dispose();
            System.Environment.Exit(0);  // 关闭程序
        }

        // 打开mysql所在的目录
        private void mySQLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(rootPath + "Applications\\MySQL");
            }
            catch (Exception)
            {
                MessageBox.Show("打开目录出错！", "打开出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 打开redis所在的目录
        private void redisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(rootPath + "Applications\\redis");
            }
            catch (Exception)
            {
                MessageBox.Show("打开目录出错！", "打开出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 打开tomcat目录
        private void tomcatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(rootPath + "Applications\\Tomcat");
            }
            catch (Exception)
            {
                MessageBox.Show("打开目录出错！", "打开出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 打开maven目录
        private void mavenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(rootPath + "Applications\\Maven");
            }
            catch (Exception)
            {
                MessageBox.Show("打开目录出错！", "打开出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 打开软件根目录
        private void 软件根目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(rootPath);
            } catch (Exception)
            {
                MessageBox.Show("打开目录出错！", "打开出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 打开host文件
        private void 打开hostToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", "C:\\Windows\\System32\\drivers\\etc\\hosts");
            } catch (Exception)
            {
                MessageBox.Show("打开文件出错！", "打开出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 打开cmd窗口
        private void 打开cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("cmd.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("打开cmd窗口出错！", "打开出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // cmd操作mysql
        private void Cmd_MySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.WorkingDirectory = rootPath + "scripts";
                proc.StartInfo.FileName = "MySQL.bat";
                proc.Start();
                proc.WaitForExit();
            } catch (Exception)
            {
                MessageBox.Show("打开cmd窗口出错！", "打开出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // cmd操作redis
        private void cmd操作redisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.WorkingDirectory = rootPath + "scripts";
                proc.StartInfo.FileName = "redis.bat";
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception)
            {
                MessageBox.Show("打开cmd窗口出错！", "打开出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void github仓库地址ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Traeric/ToolsManage");
        }

        private void 作者GitHub主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Traeric");
        }

        // 启动全部服务
        private void 启动全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 打开窗口
            this.Show();
            this.WindowState = FormWindowState.Normal;   // 显示窗口
            this.ShowInTaskbar = true;     // 显示在系统状态栏
            // 启动mysql
            new Mysql().startMySQLService(this.stop, this.restart, this.start, this.mysql_status,
                            this.logInfo);
            // 启动redis
            new Redis().startRedis(this.stop, this.restart, this.start, this.redis_status,
                            this.logInfo);
            // 启动tomcat
            new Tomcat().startTomcatService(this.stop, this.restart, this.start, this.tomcat_status,
                            this.logInfo);
        }

        private void 停止全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 打开窗口
            this.Show();
            this.WindowState = FormWindowState.Normal;   // 显示窗口
            this.ShowInTaskbar = true;     // 显示在系统状态栏
            // 停止mysql
            new Mysql().stopMySQLService(this.stop, this.restart, this.start, this.mysql_status,
                            this.logInfo);
            // 停止redis
            new Redis().stopRedisService(this.stop, this.restart, this.start, this.redis_status,
                            this.logInfo);
            // 停止tomcat
            new Tomcat().stopTomcatService(this.stop, this.restart, this.start, this.tomcat_status,
                            this.logInfo);
        }

        private void 重启全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 打开窗口
            this.Show();
            this.WindowState = FormWindowState.Normal;   // 显示窗口
            this.ShowInTaskbar = true;     // 显示在系统状态栏
            // 重启mysql
            new Mysql().restartMySQLService(this.stop, this.restart, this.start, this.mysql_status,
                            this.logInfo);
            // 重启redis
            new Redis().restartRedisService(this.stop, this.restart, this.start, this.redis_status,
                            this.logInfo);
            // 重启tomcat
            new Tomcat().restartTomcatService(this.stop, this.restart, this.start, this.tomcat_status,
                            this.logInfo);
        }

        // 点击jdk应用按钮
        private void JDK_Click(object sender, EventArgs e)
        {
            setAppBtn("JDK启停", this.JDK);
            this.currentApp = "JDK";

            // 显示jdk窗口
            JDKForm jdkForm = new JDKForm();
            jdkForm.Show();
        }

        // 显示jdk目录
        private void jDKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(rootPath + "Applications\\JDK");
            }
            catch (Exception)
            {
                MessageBox.Show("打开目录出错！", "打开出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 打印日志功能
        private void printButtom_Click(object sender, EventArgs e)
        {
            // 获取日志信息
            string log = this.logInfo.Text;
            if (this.saveLog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter file = new StreamWriter(this.saveLog.FileName))
                {
                    file.WriteLineAsync(log);
                }
                DialogResult result = MessageBox.Show("保存日志文件成功，是否打开？", "保存成功", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("explorer.exe", this.saveLog.FileName);
                }
            }
        }

        // 打开操作MySQL的窗口
        private void 操作MySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 修改apache文件并打开服务
            Thread thread = new Thread(new ParameterizedThreadStart(new Apache().changeConfFile));
            thread.Start(rootPath);

            // 打开mysql窗口
            MySQLForm mySQLForm = new MySQLForm();
            mySQLForm.Show();
        }

        // 打开redis窗口
        private void 操作redisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedisForm redisForm = new RedisForm();
            redisForm.Show();
        }

        // 打开测试端口的窗口
        private void TestPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TestPortForm().Show();
        }
    }
}

