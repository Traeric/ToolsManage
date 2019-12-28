using DevelopmentToolList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsManage
{
    public partial class RedisForm : Form
    {
        public RedisForm()
        {
            InitializeComponent();
        }

        // 打开管理redis的网站
        private void sirviaBtn_Click(object sender, EventArgs e)
        {
            // 检测tomcat端口是否打开
            if (!Utils.testConnect(8080))
            {
                // 没有打开
                MessageBox.Show("tomcat未启动", "未启动", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            System.Diagnostics.Process.Start("http://localhost:8080/admin/redis/login");
        }
    }
}
