namespace bai413
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            menuOpen = new ToolStripMenuItem();
            menuSave = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            menuAdd = new ToolStripMenuItem();
            menuDelete = new ToolStripMenuItem();
            menuSearch = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbOpen = new ToolStripButton();
            tsbSave = new ToolStripButton();
            tsbAdd = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblTotalBooks = new ToolStripStatusLabel();
            lblTotalValue = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBookId = new TextBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            picBookCover = new PictureBox();
            btnLoadImage = new Button();
            dgvBooks = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(838, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuOpen, menuSave, menuExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // menuOpen
            // 
            menuOpen.Name = "menuOpen";
            menuOpen.Size = new Size(224, 26);
            menuOpen.Text = "Mở file CSV";
            // 
            // menuSave
            // 
            menuSave.Name = "menuSave";
            menuSave.Size = new Size(224, 26);
            menuSave.Text = "Lưu file CSV";
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(224, 26);
            menuExit.Text = "Thoát";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuAdd, menuDelete, menuSearch });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // menuAdd
            // 
            menuAdd.Name = "menuAdd";
            menuAdd.Size = new Size(224, 26);
            menuAdd.Text = "Thêm";
            // 
            // menuDelete
            // 
            menuDelete.Name = "menuDelete";
            menuDelete.Size = new Size(224, 26);
            menuDelete.Text = "Xoá";
            // 
            // menuSearch
            // 
            menuSearch.Name = "menuSearch";
            menuSearch.Size = new Size(224, 26);
            menuSearch.Text = "Tìm kiếm";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbOpen, tsbSave, tsbAdd });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(838, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            tsbOpen.Image = (Image)resources.GetObject("tsbOpen.Image");
            tsbOpen.ImageTransparentColor = Color.Magenta;
            tsbOpen.Name = "tsbOpen";
            tsbOpen.Size = new Size(80, 24);
            tsbOpen.Text = "mở file";
            // 
            // tsbSave
            // 
            tsbSave.Image = (Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(79, 24);
            tsbSave.Text = "lưu file";
            // 
            // tsbAdd
            // 
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(97, 24);
            tsbAdd.Text = "thêm mới";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTotalBooks, lblTotalValue, lblTime });
            statusStrip1.Location = new Point(0, 479);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(838, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(139, 20);
            lblTotalBooks.Text = "Tổng số đầu sách: 0";
            // 
            // lblTotalValue
            // 
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(136, 20);
            lblTotalValue.Text = "Tổng giá trị: 0 VNĐ";
            // 
            // lblTime
            // 
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(124, 20);
            lblTime.Text = "Thời gian hiện tại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 65);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 3;
            label1.Text = "mã sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 94);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 4;
            label2.Text = "tên sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 124);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "tác giả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 159);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 6;
            label4.Text = "giá tiền";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(69, 62);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(125, 27);
            txtBookId.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(69, 95);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 8;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(69, 128);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(69, 161);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 10;
            // 
            // picBookCover
            // 
            picBookCover.Location = new Point(500, 65);
            picBookCover.Name = "picBookCover";
            picBookCover.Size = new Size(326, 217);
            picBookCover.SizeMode = PictureBoxSizeMode.Zoom;
            picBookCover.TabIndex = 11;
            picBookCover.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(400, 139);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(94, 29);
            btnLoadImage.TabIndex = 12;
            btnLoadImage.Text = "tải ảnh bìa";
            btnLoadImage.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(0, 288);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(826, 188);
            dgvBooks.TabIndex = 13;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 505);
            Controls.Add(dgvBooks);
            Controls.Add(btnLoadImage);
            Controls.Add(picBookCover);
            Controls.Add(txtPrice);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(txtBookId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuOpen;
        private ToolStripMenuItem menuSave;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem menuAdd;
        private ToolStripMenuItem menuDelete;
        private ToolStripMenuItem menuSearch;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbOpen;
        private ToolStripButton tsbSave;
        private ToolStripButton tsbAdd;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTotalBooks;
        private ToolStripStatusLabel lblTotalValue;
        private ToolStripStatusLabel lblTime;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBookId;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private PictureBox picBookCover;
        private Button btnLoadImage;
        private DataGridView dgvBooks;
        private System.Windows.Forms.Timer timer1;
    }
}
