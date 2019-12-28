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
    public partial class TestPortForm : Form
    {
        public TestPortForm()
        {
            InitializeComponent();
        }

        // 点击测试
        private void TestingBtn_Click(object sender, EventArgs e)
        {
            // 获取填写的端口号
            string port = this.TestingPort.Text;
            // 进行测试
            if (Utils.testConnect(int.Parse(port)))
            {
                MessageBox.Show(string.Format("端口{0}已经启动", port), "测试端口", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show(string.Format("端口{0}没有启动", port), "测试端口", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
