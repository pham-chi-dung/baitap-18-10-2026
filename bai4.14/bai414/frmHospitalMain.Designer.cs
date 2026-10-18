namespace bai414
{
    partial class frmHospitalMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            menuReload = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            menuPatient = new ToolStripMenuItem();
            menuDoctor = new ToolStripMenuItem();
            menuDepartment = new ToolStripMenuItem();
            cửaSổToolStripMenuItem = new ToolStripMenuItem();
            menuCascade = new ToolStripMenuItem();
            menuTileHorizontal = new ToolStripMenuItem();
            menuTileVertical = new ToolStripMenuItem();
            menuCloseAll = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblDoctorName = new ToolStripStatusLabel();
            progressBarMain = new ToolStripProgressBar();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, cửaSổToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuLogout, menuReload, menuExit });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(82, 24);
            hệThốngToolStripMenuItem.Text = "hệ thống";
            // 
            // menuLogout
            // 
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(224, 26);
            menuLogout.Text = "đăng xuất";
            // 
            // menuReload
            // 
            menuReload.Name = "menuReload";
            menuReload.Size = new Size(224, 26);
            menuReload.Text = "nạp lại dữ liệu";
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(224, 26);
            menuExit.Text = "thoát";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuPatient, menuDoctor, menuDepartment });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(71, 24);
            quảnLýToolStripMenuItem.Text = "quản lý";
            // 
            // menuPatient
            // 
            menuPatient.Name = "menuPatient";
            menuPatient.Size = new Size(242, 26);
            menuPatient.Text = "hồ sơ bệnh nhân";
            // 
            // menuDoctor
            // 
            menuDoctor.Name = "menuDoctor";
            menuDoctor.Size = new Size(242, 26);
            menuDoctor.Text = "danh mục bác sĩ";
            // 
            // menuDepartment
            // 
            menuDepartment.Name = "menuDepartment";
            menuDepartment.Size = new Size(242, 26);
            menuDepartment.Text = "danh mục khoa/phòng";
            // 
            // cửaSổToolStripMenuItem
            // 
            cửaSổToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuCascade, menuTileHorizontal, menuTileVertical, menuCloseAll });
            cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            cửaSổToolStripMenuItem.Size = new Size(66, 24);
            cửaSổToolStripMenuItem.Text = "cửa sổ";
            // 
            // menuCascade
            // 
            menuCascade.Name = "menuCascade";
            menuCascade.Size = new Size(224, 26);
            menuCascade.Text = "sắp xếp xếp tầng";
            // 
            // menuTileHorizontal
            // 
            menuTileHorizontal.Name = "menuTileHorizontal";
            menuTileHorizontal.Size = new Size(224, 26);
            menuTileHorizontal.Text = "ngang";
            // 
            // menuTileVertical
            // 
            menuTileVertical.Name = "menuTileVertical";
            menuTileVertical.Size = new Size(224, 26);
            menuTileVertical.Text = "dọc";
            // 
            // menuCloseAll
            // 
            menuCloseAll.Name = "menuCloseAll";
            menuCloseAll.Size = new Size(224, 26);
            menuCloseAll.Text = "đóng tất cả";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblDoctorName, progressBarMain });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblDoctorName
            // 
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new Size(177, 20);
            lblDoctorName.Text = "Bác sĩ trực: Nguyễn Văn A";
            // 
            // progressBarMain
            // 
            progressBarMain.Name = "progressBarMain";
            progressBarMain.Size = new Size(100, 18);
            // 
            // frmHospitalMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmHospitalMain";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem menuLogout;
        private ToolStripMenuItem menuReload;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem menuPatient;
        private ToolStripMenuItem menuDoctor;
        private ToolStripMenuItem menuDepartment;
        private ToolStripMenuItem cửaSổToolStripMenuItem;
        private ToolStripMenuItem menuCascade;
        private ToolStripMenuItem menuTileHorizontal;
        private ToolStripMenuItem menuTileVertical;
        private ToolStripMenuItem menuCloseAll;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblDoctorName;
        private ToolStripProgressBar progressBarMain;
    }
}
