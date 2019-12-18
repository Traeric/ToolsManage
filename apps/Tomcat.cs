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
        public void startTomcat(Button stopBtn, Button restartBtn, Button startBtn, Panel tomcat_status,
            TextBox logInfo)
        {
            startService(stopBtn, restartBtn, startBtn, tomcat_status, logInfo, "net start Tomcat",
                "Tomcat", 8080);
        }
    }
}
