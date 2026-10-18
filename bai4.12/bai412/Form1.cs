using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bai412
{
    public partial class Form1 : Form
    {
        private BindingList<MemberModel> _memberList;
        private int _autoMemberIdCounter = 1;

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            SetupDataGridView();
            SetupEvents();
            GenerateNewMemberId();
        }

        private void InitializeData()
        {
            _memberList = new BindingList<MemberModel>();

            cboPackage.Items.AddRange(new string[] { "Theo tháng", "6 tháng", "1 năm" });
            if (cboPackage.Items.Count > 0) cboPackage.SelectedIndex = 0;

            dgvMembers.DataSource = _memberList;
        }

        private void SetupDataGridView()
        {
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.Columns.Clear();

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MemberId", HeaderText = "Mã HV", Width = 80 });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "Tên hội viên", Width = 150 });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Phone", HeaderText = "SĐT", Width = 100 });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Package", HeaderText = "Gói tập", Width = 100 });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StartDate", HeaderText = "Ngày ĐK", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Fee", HeaderText = "Phí dịch vụ", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
        }

        private void SetupEvents()
        {
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;
            dgvMembers.SelectionChanged += DgvMembers_SelectionChanged;
        }

        private void GenerateNewMemberId()
        {
            txtMemberId.Text = $"HV{_autoMemberIdCounter:D3}";
        }

        private bool ValidateInput()
        {
            errorProvider1.Clear();
            bool isValid = true;

            string name = txtFullName.Text.Trim();
            if (string.IsNullOrEmpty(name)) { errorProvider1.SetError(txtFullName, "Tên hội viên không được để trống."); isValid = false; }
            else if (!Regex.IsMatch(name, @"^[\p{L}\s]+$")) { errorProvider1.SetError(txtFullName, "Tên không chứa số/ký tự đặc biệt."); isValid = false; }

            string phone = txtPhone.Text.Trim();
            if (!Regex.IsMatch(phone, @"^\d{10}$")) { errorProvider1.SetError(txtPhone, "SĐT phải đúng 10 chữ số."); isValid = false; }

            if (!decimal.TryParse(txtFee.Text, out decimal fee) || fee <= 0) { errorProvider1.SetError(txtFee, "Phí dịch vụ phải là số nguyên dương."); isValid = false; }

            return isValid;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            _memberList.Add(new MemberModel
            {
                MemberId = txtMemberId.Text,
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Package = cboPackage.Text,
                StartDate = dtpStartDate.Value.Date,
                Fee = decimal.Parse(txtFee.Text)
            });

            _autoMemberIdCounter++;
            BtnClear_Click(null, null);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (dgvMembers.CurrentRow?.DataBoundItem is MemberModel currentMember)
            {
                currentMember.FullName = txtFullName.Text.Trim();
                currentMember.Phone = txtPhone.Text.Trim();
                currentMember.Package = cboPackage.Text;
                currentMember.StartDate = dtpStartDate.Value.Date;
                currentMember.Fee = decimal.Parse(txtFee.Text);

                dgvMembers.Refresh();
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow?.DataBoundItem is MemberModel currentMember)
            {
                if (MessageBox.Show($"Xóa hội viên {currentMember.FullName}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _memberList.Remove(currentMember);
                    BtnClear_Click(null, null);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            GenerateNewMemberId();
            txtFullName.Clear();
            txtPhone.Clear();
            if (cboPackage.Items.Count > 0) cboPackage.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now;
            txtFee.Clear();
            errorProvider1.Clear();
        }

        private void DgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow?.DataBoundItem is MemberModel currentMember)
            {
                txtMemberId.Text = currentMember.MemberId;
                txtFullName.Text = currentMember.FullName;
                txtPhone.Text = currentMember.Phone;
                cboPackage.Text = currentMember.Package;
                dtpStartDate.Value = currentMember.StartDate;
                txtFee.Text = currentMember.Fee.ToString();
                errorProvider1.Clear();
            }
        }
    }

    public class MemberModel
    {
        public string MemberId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Package { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Fee { get; set; }
    }
}