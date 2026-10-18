namespace bai415
{
    partial class frmRevenueAnalytics
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
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            btnThongKe = new Button();
            btnHuy = new Button();
            pgbLoading = new ProgressBar();
            lblProcessingStatus = new Label();
            dgvRevenueData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRevenueData).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(47, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(47, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(540, 70);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(160, 29);
            btnThongKe.TabIndex = 2;
            btnThongKe.Text = "thống kê doanh thu";
            btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(540, 119);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(115, 29);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "huỷ thao tác";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // pgbLoading
            // 
            pgbLoading.Location = new Point(47, 130);
            pgbLoading.Name = "pgbLoading";
            pgbLoading.Size = new Size(125, 29);
            pgbLoading.TabIndex = 4;
            // 
            // lblProcessingStatus
            // 
            lblProcessingStatus.AutoSize = true;
            lblProcessingStatus.Location = new Point(47, 97);
            lblProcessingStatus.Name = "lblProcessingStatus";
            lblProcessingStatus.Size = new Size(73, 20);
            lblProcessingStatus.TabIndex = 5;
            lblProcessingStatus.Text = "trạng thái";
            // 
            // dgvRevenueData
            // 
            dgvRevenueData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevenueData.Location = new Point(1, 175);
            dgvRevenueData.Name = "dgvRevenueData";
            dgvRevenueData.RowHeadersWidth = 51;
            dgvRevenueData.Size = new Size(987, 527);
            dgvRevenueData.TabIndex = 6;
            // 
            // frmRevenueAnalytics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 708);
            Controls.Add(dgvRevenueData);
            Controls.Add(lblProcessingStatus);
            Controls.Add(pgbLoading);
            Controls.Add(btnHuy);
            Controls.Add(btnThongKe);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Name = "frmRevenueAnalytics";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvRevenueData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button btnThongKe;
        private Button btnHuy;
        private ProgressBar pgbLoading;
        private Label lblProcessingStatus;
        private DataGridView dgvRevenueData;
    }
}
