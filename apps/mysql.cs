using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevelopmentToolList.apps
{
    class Mysql : SuperApp
    {
        // 初始化mysql数据库
        public void initMysql(object mysqlPath)
        {
            string[] commands = new string[4];
            commands[0] = ((string) mysqlPath).Split(':')[0] + ":";
            commands[1] = "cd " + ((string) mysqlPath).Split(':')[1];
            commands[2] = "mysqld --install";
            commands[3] = "mysqld --initialize-insecure";
            Utils.execCMD(commands);
        }

        // 启动mysql服务
        public void startMySQLService(Button stopBtn, Button restartBtn, Button startBtn, Panel mysql_status, 
            TextBox logInfo)
        {
            startService(stopBtn, restartBtn, startBtn, mysql_status, logInfo, "net start Mysql", 
                "MySQL", 3306);
        }
    
    
        // 关闭mysql服务
        public void stopMySQLService(Button stop, Button restart, Button start, Panel mysql_status,
            TextBox logInfo)
        {
            stopService(stop, restart, start, mysql_status, logInfo, "net stop Mysql", 
                "MySQL", 3306);
        }
        
        // 重启mysql服务
        public void restartMySQLService(Button stop, Button restart, Button start, Panel mysql_status,
            TextBox logInfo)
        {
            restartService(stop, restart, start, mysql_status, logInfo, 
                new string[2] { "net stop Mysql", "net start Mysql" }, "MySQL", 3306);
        }
    }
}
