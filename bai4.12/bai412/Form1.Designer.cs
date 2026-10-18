namespace bai412
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMemberId = new TextBox();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtFee = new TextBox();
            cboPackage = new ComboBox();
            dtpStartDate = new DateTimePicker();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            dgvMembers = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "mã hội viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 48);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 89);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "SĐT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 126);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "gói tập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 165);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 4;
            label5.Text = "ngày đăng ký";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 199);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 5;
            label6.Text = "phí dịch vụ";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(110, 9);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(125, 27);
            txtMemberId.TabIndex = 6;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(110, 45);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 27);
            txtFullName.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(110, 89);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 8;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(110, 196);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(125, 27);
            txtFee.TabIndex = 9;
            // 
            // cboPackage
            // 
            cboPackage.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPackage.FormattingEnabled = true;
            cboPackage.Location = new Point(110, 126);
            cboPackage.Name = "cboPackage";
            cboPackage.Size = new Size(151, 28);
            cboPackage.TabIndex = 10;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(110, 160);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(393, 190);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(506, 189);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "xoá";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(622, 190);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 14;
            btnClear.Text = "làm mới";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(506, 138);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvMembers
            // 
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(7, 259);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(885, 242);
            dgvMembers.TabIndex = 16;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 506);
            Controls.Add(dgvMembers);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dtpStartDate);
            Controls.Add(cboPackage);
            Controls.Add(txtFee);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(txtMemberId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMemberId;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtFee;
        private ComboBox cboPackage;
        private DateTimePicker dtpStartDate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnAdd;
        private DataGridView dgvMembers;
        private ErrorProvider errorProvider1;
    }
}
