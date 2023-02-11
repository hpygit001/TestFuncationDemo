
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_StopServer = new System.Windows.Forms.Button();
            this.btn_Reboot = new System.Windows.Forms.Button();
            this.btn_StartServer = new System.Windows.Forms.Button();
            this.btn_InstallServer = new System.Windows.Forms.Button();
            this.btn_UnstallServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_StopServer
            // 
            this.btn_StopServer.Location = new System.Drawing.Point(24, 128);
            this.btn_StopServer.Name = "btn_StopServer";
            this.btn_StopServer.Size = new System.Drawing.Size(75, 23);
            this.btn_StopServer.TabIndex = 0;
            this.btn_StopServer.Text = "停止服务";
            this.btn_StopServer.UseVisualStyleBackColor = true;
            this.btn_StopServer.Click += new System.EventHandler(this.btn_StopServer_Click);
            // 
            // btn_Reboot
            // 
            this.btn_Reboot.Location = new System.Drawing.Point(454, 83);
            this.btn_Reboot.Name = "btn_Reboot";
            this.btn_Reboot.Size = new System.Drawing.Size(75, 23);
            this.btn_Reboot.TabIndex = 1;
            this.btn_Reboot.Text = "重启电脑";
            this.btn_Reboot.UseVisualStyleBackColor = true;
            this.btn_Reboot.Click += new System.EventHandler(this.btn_Reboot_Click);
            // 
            // btn_StartServer
            // 
            this.btn_StartServer.Location = new System.Drawing.Point(24, 83);
            this.btn_StartServer.Name = "btn_StartServer";
            this.btn_StartServer.Size = new System.Drawing.Size(75, 23);
            this.btn_StartServer.TabIndex = 2;
            this.btn_StartServer.Text = "启动服务";
            this.btn_StartServer.UseVisualStyleBackColor = true;
            this.btn_StartServer.Click += new System.EventHandler(this.btn_StartServer_Click);
            // 
            // btn_InstallServer
            // 
            this.btn_InstallServer.Location = new System.Drawing.Point(24, 37);
            this.btn_InstallServer.Name = "btn_InstallServer";
            this.btn_InstallServer.Size = new System.Drawing.Size(75, 23);
            this.btn_InstallServer.TabIndex = 3;
            this.btn_InstallServer.Text = "安装服务";
            this.btn_InstallServer.UseVisualStyleBackColor = true;
            this.btn_InstallServer.Click += new System.EventHandler(this.btn_InstallServer_Click);
            // 
            // btn_UnstallServer
            // 
            this.btn_UnstallServer.Location = new System.Drawing.Point(24, 185);
            this.btn_UnstallServer.Name = "btn_UnstallServer";
            this.btn_UnstallServer.Size = new System.Drawing.Size(75, 23);
            this.btn_UnstallServer.TabIndex = 4;
            this.btn_UnstallServer.Text = "卸载服务";
            this.btn_UnstallServer.UseVisualStyleBackColor = true;
            this.btn_UnstallServer.Click += new System.EventHandler(this.btn_UnstallServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_UnstallServer);
            this.Controls.Add(this.btn_InstallServer);
            this.Controls.Add(this.btn_StartServer);
            this.Controls.Add(this.btn_Reboot);
            this.Controls.Add(this.btn_StopServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_StopServer;
        private System.Windows.Forms.Button btn_Reboot;
        private System.Windows.Forms.Button btn_StartServer;
        private System.Windows.Forms.Button btn_InstallServer;
        private System.Windows.Forms.Button btn_UnstallServer;
    }
}

