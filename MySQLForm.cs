using DevelopmentToolList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsManage
{
    public partial class MySQLForm : Form
    {
        // 获取根目录
        private static string rootPath = System.AppDomain.CurrentDomain.BaseDirectory;


        public MySQLForm()
        {
            InitializeComponent();
        }

        // 打开apache服务
        private void AdminerBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost/Adminer");
        }

        // 修改密码
        private void changeMySQLPaswordBtn_Click(object sender, EventArgs e)
        {
            // 获取新的密码
            string newPassword = this.changePasswordText.Text;
            if (newPassword == "")
            {
                MessageBox.Show("密码不能为空！", "密码错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 获取旧密码
            string[] contents = File.ReadAllLines(rootPath + "conf\\MySQL.xin", Encoding.UTF8);
            string oldPassword = contents[1];   // 密码在第二行
            // 修改密码
            string mysqlPath = rootPath + "Applications\\MySQL\\bin";
            string[] commands = new string[3];
            commands[0] = ((string)mysqlPath).Split(':')[0] + ":";
            commands[1] = "cd " + ((string)mysqlPath).Split(':')[1];
            commands[2] = string.Format("mysqladmin -u root -p{0} password {1}", oldPassword, newPassword);
            try
            {
                Utils.execCMD(commands);
                // 更新密码
                contents[1] = newPassword;
                File.WriteAllLines(rootPath + "conf\\MySQL.xin", contents);
                MessageBox.Show("修改密码成功！", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Question);
            } catch(Exception)
            {
                MessageBox.Show("修改密码失败！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
