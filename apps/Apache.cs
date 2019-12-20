using DevelopmentToolList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsManage.apps
{
    class Apache
    {
        // 修改apache关于php的配置
        public void changeConfFile(object rootPath)
        {
            // apache路径
            string apachePath = rootPath + "Applications\\Apache2.4.39\\conf\\";
            // 修改conf/httpd.conf
            string[] contents = File.ReadAllLines(apachePath + "httpd.conf", Encoding.UTF8);
            // 修改40行内容
            contents[39] = "Define SRVROOT \"" + rootPath + "Applications\\Apache2.4.39\"";
            // 修改261行
            contents[260] = "DocumentRoot \"" + rootPath + "tools\"";
            File.WriteAllLines(apachePath + "httpd.conf", contents);


            // 修改vhosts/localhost_80.conf
            contents = File.ReadAllLines(apachePath + "vhosts\\localhost_80.conf", Encoding.UTF8);
            // 修改2行内容
            contents[1] = ("DocumentRoot \"" + rootPath + "tools\"").Replace("\\", "/");
            // 修改3行内容
            contents[2] = ("FcgidInitialEnv PHPRC \"" + rootPath + "Applications/php7.3.4nts\"").Replace("\\", "/");
            // 修改5行内容
            contents[4] = ("FcgidWrapper \"" + rootPath + "Applications/php7.3.4nts/php-cgi.exe\" .php").Replace("\\", "/");
            // 修改6行内容
            contents[5] = ("<Directory \"" + rootPath + "tools\">").Replace("\\", "/");
            // 保存
            File.WriteAllLines(apachePath + "vhosts\\localhost_80.conf", contents);

            // 修改php关于MySQL的内容
            contents = File.ReadAllLines(rootPath + "Applications\\php7.3.4nts\\php.ini", Encoding.UTF8);
            // 修改753行关于ext的内容
            contents[752] = ("extension_dir=\"" + rootPath + "Applications\\php7.3.4nts\\ext\"");
            // 修改1365行
            contents[1364] = "session.save_path=\"" + rootPath + "Applications\\tmp\\tmp\\\"";
            File.WriteAllLines(rootPath + "Applications\\php7.3.4nts\\php.ini", contents);

            // 安装apache服务
            new Apache().initApache((string) rootPath);
            // 打开Apache服务
            new Apache().startApacheService();
        }

        // 安装apache服务
        public void initApache(string rootPath)
        {
            string apachePath = rootPath + "Applications\\Apache2.4.39\\bin";
            string[] commands = new string[3];
            commands[0] = ((string)apachePath).Split(':')[0] + ":";
            commands[1] = "cd " + ((string)apachePath).Split(':')[1];
            commands[2] = "httpd.exe -kinstall -n Apache";
            Utils.execCMD(commands);
        }

        // 启动Apache服务
        public void startApacheService()
        {
            Utils.execCMD(new string[1] { "net start Apache" });
        }
    }
}
