using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string serviceFilePath = $"{Application.StartupPath}\\WindowsService1.exe";
        string serviceName = "ServiceTestHpy";
        private void btn_StartServer_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.IsServiceExisted(serviceName)) this.ServiceStart(serviceName);

                MessageBox.Show("启动服务完成");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Reboot_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
                myProcess.StartInfo.FileName = "cmd.exe";
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();

                myProcess.StandardInput.WriteLine("shutdown -r -t 60");//执行重启计算机命令

            }
            catch (Exception)
            {


            }
        }

        private bool IsServiceExisted(string serviceName)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (var item in services)
            {
                if (item.ServiceName.ToLower() == serviceName.ToLower())
                    return true;
            }
            return false;
        }

        private void InstallService(string serviceFilePath)
        {
            using(AssemblyInstaller installer=new AssemblyInstaller())
            {
                installer.UseNewContext = true;
                installer.Path = serviceFilePath;
                IDictionary savedState = new Hashtable();
                installer.Install(savedState);
                installer.Commit(savedState);
            }
        }

        private void UninstallService(string serviceFilePath)
        {
            using(AssemblyInstaller installer=new AssemblyInstaller())
            {
                installer.UseNewContext = true;
                installer.Path = serviceFilePath;
                installer.Uninstall(null);

            }
        }


        private void ServiceStart(string serviceName)
        {
            using(ServiceController controller=new ServiceController(serviceName))
            {
                if(controller.Status==ServiceControllerStatus.Stopped)
                {
                    controller.Start();
                }
            }
        }

        private void ServiceStop(string serviceName)
        {
            using (ServiceController controller = new ServiceController(serviceName))
            {
                if (controller.Status == ServiceControllerStatus.Running)
                {
                    controller.Stop();
                }
            }
        }
        private void btn_StopServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsServiceExisted(serviceName)) this.ServiceStop(serviceName);

            }
            catch (Exception ex)
            {

                MessageBox.Show("停止服务异常："+ex.Message);
            }
        }

        private void btn_InstallServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsServiceExisted(serviceName)) this.UninstallService(serviceName);
                this.InstallService(serviceFilePath);
                MessageBox.Show("服务安装完成");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_UnstallServer_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.IsServiceExisted(serviceName))
                {
                    this.ServiceStop(serviceName);
                    this.UninstallService(serviceFilePath);
                    MessageBox.Show("卸载服务完成");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
