namespace bai416
{
    partial class frmCryptoStockTicker
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
            btnStart = new Button();
            btnPause = new Button();
            lblBTCPrice = new Label();
            statusStrip1 = new StatusStrip();
            lblLastUpdate = new ToolStripStatusLabel();
            lblSyncCount = new ToolStripStatusLabel();
            dgvHistoryLog = new DataGridView();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistoryLog).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(340, 7);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(147, 47);
            btnStart.TabIndex = 0;
            btnStart.Text = "[Bắt đầu Giám sát]";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(493, 7);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(118, 47);
            btnPause.TabIndex = 1;
            btnPause.Text = "[Tạm dừng]";
            btnPause.UseVisualStyleBackColor = true;
            // 
            // lblBTCPrice
            // 
            lblBTCPrice.AutoSize = true;
            lblBTCPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBTCPrice.Location = new Point(0, 11);
            lblBTCPrice.Name = "lblBTCPrice";
            lblBTCPrice.Size = new Size(76, 31);
            lblBTCPrice.TabIndex = 2;
            lblBTCPrice.Text = "label1";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblLastUpdate, lblSyncCount });
            statusStrip1.Location = new Point(0, 570);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(632, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblLastUpdate
            // 
            lblLastUpdate.Name = "lblLastUpdate";
            lblLastUpdate.Size = new Size(31, 20);
            lblLastUpdate.Text = "giờ";
            // 
            // lblSyncCount
            // 
            lblSyncCount.Name = "lblSyncCount";
            lblSyncCount.Size = new Size(92, 20);
            lblSyncCount.Text = "giờ đồng bộ";
            // 
            // dgvHistoryLog
            // 
            dgvHistoryLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoryLog.Location = new Point(0, 65);
            dgvHistoryLog.Name = "dgvHistoryLog";
            dgvHistoryLog.RowHeadersWidth = 51;
            dgvHistoryLog.Size = new Size(632, 502);
            dgvHistoryLog.TabIndex = 4;
            // 
            // frmCryptoStockTicker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 596);
            Controls.Add(dgvHistoryLog);
            Controls.Add(statusStrip1);
            Controls.Add(lblBTCPrice);
            Controls.Add(btnPause);
            Controls.Add(btnStart);
            Name = "frmCryptoStockTicker";
            Text = "Form1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistoryLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnPause;
        private Label lblBTCPrice;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblLastUpdate;
        private ToolStripStatusLabel lblSyncCount;
        private DataGridView dgvHistoryLog;
    }
}
