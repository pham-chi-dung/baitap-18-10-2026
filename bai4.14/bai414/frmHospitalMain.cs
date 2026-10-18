using System;
using System.Linq;
using System.Windows.Forms;

namespace bai414
{
    public partial class frmHospitalMain : Form
    {
        public frmHospitalMain()
        {
            InitializeComponent();
            SetupMenuEvents();
        }

        private void SetupMenuEvents()
        {
            // Menu Hệ thống
            menuExit.Click += (s, e) => Application.Exit();

            // Menu Quản lý (Mở Form con)
            menuPatient.Click += MenuPatient_Click;
            menuDoctor.Click += MenuDoctor_Click;

            // Menu Cửa sổ (Sắp xếp)
            menuCascade.Click += (s, e) => this.LayoutMdi(MdiLayout.Cascade); // Xếp tầng[cite: 10]
            menuTileHorizontal.Click += (s, e) => this.LayoutMdi(MdiLayout.TileHorizontal); // Xếp ngang[cite: 10]
            menuTileVertical.Click += (s, e) => this.LayoutMdi(MdiLayout.TileVertical); // Xếp dọc[cite: 10]
            menuCloseAll.Click += MenuCloseAll_Click;
        }

        // --- NGHIỆP VỤ QUẢN LÝ FORM CON MDI ---

        // Hàm tổng quát dùng để mở Form con, ngăn chặn mở lặp lại[cite: 9]
        private void OpenChildForm(Type formType)
        {
            // Duyệt qua danh sách MdiChildren xem form này đã mở chưa[cite: 10]
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == formType)
                {
                    // Nếu đã mở, gọi lệnh Activate() để mang Form đó lên trên cùng[cite: 10]
                    frm.Activate();
                    return;
                }
            }

            // Nếu Form chưa mở, khởi tạo Instance mới, gán MdiParent và gọi Show()[cite: 10]
            Form newForm = (Form)Activator.CreateInstance(formType);
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void MenuPatient_Click(object sender, EventArgs e)
        {
            // Mở form Hồ sơ bệnh nhân
            OpenChildForm(typeof(frmPatientProfiles));
        }

        private void MenuDoctor_Click(object sender, EventArgs e)
        {
            // Mở form Lịch trực bác sĩ
            OpenChildForm(typeof(frmDoctorSchedule));
        }

        private void MenuCloseAll_Click(object sender, EventArgs e)
        {
            // Đóng tất cả các Form con đang mở
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
    }
}