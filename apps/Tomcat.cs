using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevelopmentToolList.apps
{
    class Tomcat : SuperApp
    {

        // 初始化tomcat
        public void initTomcat(string tomcatPath)
        {
            string[] commands = new string[3];
            commands[0] = tomcatPath.Split(':')[0] + ":";
            commands[1] = "cd " + tomcatPath.Split(':')[1];
            commands[2] = "service install Tomcat";
            Utils.execCMD(commands);
        }

        // 启动服务
        public void startTomcatService(Button stopBtn, Button restartBtn, Button startBtn, Panel tomcat_status,
            TextBox logInfo)
        {
            startService(stopBtn, restartBtn, startBtn, tomcat_status, logInfo, "net start Tomcat",
                "Tomcat", 8080);
        }

        // 关闭tomcat服务
        public void stopTomcatService(Button stop, Button restart, Button start, Panel mysql_status,
            TextBox logInfo)
        {
            stopService(stop, restart, start, mysql_status, logInfo, "net stop Tomcat",
                "Tomcat", 8080);
        }

        // 重启mysql服务
        public void restartTomcatService(Button stop, Button restart, Button start, Panel mysql_status,
            TextBox logInfo)
        {
            restartService(stop, restart, start, mysql_status, logInfo,
                new string[2] { "net stop Tomcat", "net start Tomcat" }, "Tomcat", 8080);
        }
    }
}
