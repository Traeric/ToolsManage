using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ToolsManage
{
    public partial class MavenForm : Form
    {
        public MavenForm()
        {
            InitializeComponent();
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
