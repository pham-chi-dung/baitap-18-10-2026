using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace bai413
{
    public partial class Form1 : Form
    {
        private BindingList<BookModel> _bookList;
        private string _currentImagePath = ""; // Lưu đường dẫn ảnh tạm

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            SetupEvents();
        }

        private void InitializeData()
        {
            _bookList = new BindingList<BookModel>();
            dgvBooks.DataSource = _bookList;
            UpdateStatusStrip(); // Cập nhật ngay khi khởi tạo
        }

        private void SetupEvents()
        {
            // Các sự kiện Timer và Giao diện
            timer1.Tick += Timer1_Tick;
            btnLoadImage.Click += BtnLoadImage_Click;
            dgvBooks.SelectionChanged += DgvBooks_SelectionChanged;

            // Các sự kiện MenuStrip
            menuOpen.Click += MenuOpen_Click;
            menuSave.Click += MenuSave_Click;
            menuExit.Click += (s, e) => Application.Exit();
            menuAdd.Click += ActionAddBook;
            menuDelete.Click += ActionDeleteBook;

            // Các sự kiện ToolStrip (Gắn chung hàm với MenuStrip)
            tsbOpen.Click += MenuOpen_Click;
            tsbSave.Click += MenuSave_Click;
            tsbAdd.Click += ActionAddBook;
        }

        // 1. Cập nhật StatusStrip (Tổng số lượng, Tổng giá trị, Thời gian)
        private void UpdateStatusStrip()
        {
            int totalBooks = _bookList.Count;
            decimal totalValue = _bookList.Sum(b => b.Price);

            lblTotalBooks.Text = $"Tổng số đầu sách: {totalBooks}";
            lblTotalValue.Text = $"Tổng giá trị: {totalValue:N0} VNĐ";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = $"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
        }

        // 2. Thao tác Tải ảnh bìa sử dụng OpenFileDialog
        
        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh bìa sách";
                ofd.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _currentImagePath = ofd.FileName; // Lưu đường dẫn
                        picBookCover.Image = Image.FromFile(_currentImagePath); // Nạp ảnh lên PictureBox
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể tải ảnh này. File ảnh có thể bị lỗi hoặc không đúng định dạng!", "Lỗi tải ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _currentImagePath = ""; // Reset lại đường dẫn nếu file lỗi
                        picBookCover.Image = null; // Xóa ảnh cũ trên khung (nếu có)
                    }
                }
            }
        }

        // 3. Nghiệp vụ Thêm sách và Xóa sách
        private void ActionAddBook(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookId.Text) || string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin mã sách và tên sách!");
                return;
            }

            decimal price = 0;
            decimal.TryParse(txtPrice.Text, out price);

            var newBook = new BookModel
            {
                BookId = txtBookId.Text.Trim(),
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                Price = price,
                ImagePath = _currentImagePath
            };

            _bookList.Add(newBook);
            ClearInputs();
            UpdateStatusStrip(); // Mỗi khi danh sách biến động, tự động tính toán lại
        }

        private void ActionDeleteBook(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow?.DataBoundItem is BookModel currentBook)
            {
                _bookList.Remove(currentBook);
                ClearInputs();
                UpdateStatusStrip();
            }
        }

        private void ClearInputs()
        {
            txtBookId.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPrice.Clear();
            picBookCover.Image = null;
            _currentImagePath = "";
        }

        private void DgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow?.DataBoundItem is BookModel currentBook)
            {
                txtBookId.Text = currentBook.BookId;
                txtTitle.Text = currentBook.Title;
                txtAuthor.Text = currentBook.Author;
                txtPrice.Text = currentBook.Price.ToString();

                _currentImagePath = currentBook.ImagePath;
                if (!string.IsNullOrEmpty(_currentImagePath) && File.Exists(_currentImagePath))
                {
                    picBookCover.Image = Image.FromFile(_currentImagePath);
                }
                else
                {
                    picBookCover.Image = null;
                }
            }
        }

        // 4. Xuất dữ liệu CSV sử dụng SaveFileDialog
        private void MenuSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.Title = "Lưu danh sách sách";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            // Ghi header (tùy chọn)
                            sw.WriteLine("BookId,Title,Author,Price,ImagePath");

                            // Duyệt danh sách sách và ghi dữ liệu phân cách bằng dấu phẩy
                            foreach (var book in _bookList)
                            {
                                sw.WriteLine($"{book.BookId},{book.Title},{book.Author},{book.Price},{book.ImagePath}");
                            }
                        }
                        MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
                    }
                }
            }
        }

        // 5. Nhập dữ liệu CSV sử dụng OpenFileDialog
        private void MenuOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV Files (*.csv)|*.csv";
                ofd.Title = "Mở danh sách sách";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _bookList.Clear();

                        // Tiến hành đọc từng dòng, parse dữ liệu thành danh sách BookModel
                        string[] lines = File.ReadAllLines(ofd.FileName);

                        // Bỏ qua dòng đầu tiên nếu đó là header (BookId,Title...)
                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] data = lines[i].Split(','); // Phân cách bằng dấu phẩy
                            if (data.Length >= 5)
                            {
                                decimal.TryParse(data[3], out decimal price);
                                _bookList.Add(new BookModel
                                {
                                    BookId = data[0],
                                    Title = data[1],
                                    Author = data[2],
                                    Price = price,
                                    ImagePath = data[4]
                                }); // nạp vào BindingList
                            }
                        }

                        UpdateStatusStrip(); // Cập nhật lại thanh trạng thái sau khi Import
                        MessageBox.Show("Mở file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi đọc file hoặc sai định dạng: " + ex.Message);
                    }
                }
            }
        }
    }

    // Lớp đối tượng BookModel
    public class BookModel
    {
        public string BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; } // Chỉ lưu tên file ảnh hoặc đường dẫn ngắn
    }
}