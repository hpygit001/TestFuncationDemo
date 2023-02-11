using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{

    /// <summary>
    /// 服务包括：安装->启动->卸载
    /// 安装可以使用vs cmd 命令行管理工具
    /// 1.使用installutil 程序名 //安装服务
    /// 2.net start 服务名   //启动安装的服务
    /// 3.installutil 程序名   // 卸载服务
    /// </summary>
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        TCPHelper3.ConnectServerHelper serverHelper;
        ILog_dll.LogProcessHelper LogProcess = new ILog_dll.LogProcessHelper("backServer");
        protected override void OnStart(string[] args)
        {
            try
            {
                LogProcess.Write("服务启动...");
                string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SysCfg", "tcpServer.ini");
                serverHelper = new TCPHelper3.ConnectServerHelper(path);
                serverHelper.iP = IPAddress.Parse("127.0.0.1");
                serverHelper.Port = 60001;
                serverHelper.Save();
                LogProcess.Write($"服务={serverHelper.iP}:{serverHelper.Port} 开始启动..");
                serverHelper.RecevieMsgActionEventHander += LogProcess.Write;
                serverHelper.Open();
                LogProcess.Write($"服务={serverHelper.iP}:{serverHelper.Port} 启动成功");
            }
            catch (Exception ex)
            {
                LogProcess.Write("服务启动异常：" + ex.Message);


            }
        }

        protected override void OnStop()
        {
            serverHelper?.Close();
            LogProcess.Write("服务退出");
        }
    }
}
