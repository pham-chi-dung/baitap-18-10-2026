using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai415
{
    public partial class frmRevenueAnalytics : Form
    {
        // Khai báo biến để quản lý tiến trình xử lý[cite: 6]
        private CancellationTokenSource _cancellationTokenSource;

        public frmRevenueAnalytics()
        {
            InitializeComponent();

            // Đảm bảo bạn đã gán sự kiện Click cho 2 nút này trong giao diện hoặc tại đây
            btnThongKe.Click += BtnThongKe_Click;
            btnHuy.Click += BtnHuy_Click;

            btnHuy.Enabled = false; // Tắt nút Hủy khi chưa chạy
        }

        private async void BtnThongKe_Click(object sender, EventArgs e)
        {
            // Reset giao diện trước khi bắt đầu
            pgbLoading.Value = 0;
            lblProcessingStatus.Text = "Đang bắt đầu tổng hợp dữ liệu...";
            dgvRevenueData.DataSource = null;

            btnThongKe.Enabled = false;
            btnHuy.Enabled = true;

            // Khởi tạo CancellationTokenSource để ngắt tiến trình ngầm khi cần[cite: 6]
            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            // Sử dụng Progress<T> để cập nhật an toàn lên UI Thread từ Background Thread
            var progress = new Progress<int>(percent =>
            {
                pgbLoading.Value = percent;
                lblProcessingStatus.Text = $"Đang xử lý: {percent}%";
            });

            try
            {
                // Bắt buộc sử dụng await Task.Run(...) để đẩy công việc tổng hợp dữ liệu xuống Background Thread[cite: 6]
                var result = await Task.Run(() => GetDataProcess(progress, token), token);

                // Cập nhật kết quả lên khu vực DataGridView sau khi hoàn tất[cite: 6]
                dgvRevenueData.DataSource = result;
                lblProcessingStatus.Text = "Hoàn tất thống kê!";
                pgbLoading.Value = 100;
            }
            catch (OperationCanceledException)
            {
                // Dừng ProgressBar và hiển thị thông báo "Đã hủy thao tác!"[cite: 6]
                pgbLoading.Value = 0;
                lblProcessingStatus.Text = "Đã hủy thao tác!";
                MessageBox.Show("Đã hủy thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                // Trả lại trạng thái cho các nút bấm
                btnThongKe.Enabled = true;
                btnHuy.Enabled = false;
                _cancellationTokenSource?.Dispose();
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            // Trong lúc tiến trình đang chạy, nếu người dùng nhấn nút Hủy Thao Tác thì gọi lệnh Cancel()[cite: 6]
            if (_cancellationTokenSource != null && !_cancellationTokenSource.IsCancellationRequested)
            {
                _cancellationTokenSource.Cancel();
            }
        }

        // Giả lập một tiến trình truy xuất CSDL và tổng hợp dữ liệu lớn[cite: 6]
        private List<RevenueData> GetDataProcess(IProgress<int> progress, CancellationToken token)
        {
            var dataList = new List<RevenueData>();
            int totalSteps = 50;

            for (int i = 1; i <= totalSteps; i++)
            {
                // Kiểm tra liên tục xem tiến trình có bị yêu cầu hủy không
                token.ThrowIfCancellationRequested();

                // Giả lập xử lý mất thời gian từ 4-6 giây tổng cộng (Sử dụng Thread.Sleep hoặc Task.Delay)[cite: 6]
                // 50 vòng lặp * 100ms = 5000ms = 5 giây
                Thread.Sleep(100);

                // Tạo dữ liệu giả lập
                dataList.Add(new RevenueData
                {
                    TransactionId = "TRX" + i.ToString("D4"),
                    Date = DateTime.Now.AddDays(-i),
                    Branch = "Chi nhánh trung tâm",
                    Amount = i * 2500000m
                });

                // Gửi phần trăm hoàn thành về cho UI Thread báo cáo tiến độ
                if (progress != null)
                {
                    progress.Report((i * 100) / totalSteps);
                }
            }

            return dataList;
        }
    }

    // Lớp đối tượng để hiển thị lên DataGridView
    public class RevenueData
    {
        public string TransactionId { get; set; }
        public DateTime Date { get; set; }
        public string Branch { get; set; }
        public decimal Amount { get; set; }
    }
}