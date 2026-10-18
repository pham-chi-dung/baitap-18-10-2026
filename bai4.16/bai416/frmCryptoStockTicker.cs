using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai416
{
    public partial class frmCryptoStockTicker : Form
    {
        private CancellationTokenSource _cancellationTokenSource;
        private decimal _currentPrice = 65000.00m; // Giá giả lập ban đầu
        private int _syncCount = 0;
        private BindingList<HistoryLog> _historyLogs;

        public frmCryptoStockTicker()
        {
            InitializeComponent();
            _historyLogs = new BindingList<HistoryLog>();
            dgvHistoryLog.DataSource = _historyLogs;

            btnStart.Click += BtnStart_Click;
            btnPause.Click += BtnPause_Click;
            btnPause.Enabled = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnPause.Enabled = true;

            _cancellationTokenSource = new CancellationTokenSource();

            // Khởi chạy một Task.Run có vòng lặp vô hạn để giám sát dữ liệu[cite: 7]
            Task.Run(() => MonitorLoop(_cancellationTokenSource.Token));
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = false;

            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
            }
        }

        // Tiến trình ngầm thời gian thực (Background Thread)
        private async Task MonitorLoop(CancellationToken token)
        {
            Random rnd = new Random();

            while (!token.IsCancellationRequested)
            {
                // Định kỳ mỗi 2 giây sinh ngẫu nhiên tỷ giá mới[cite: 7]
                await Task.Delay(2000, token);

                // Giả lập biến động giá từ -500 đến +500 USD
                decimal priceChange = (decimal)(rnd.NextDouble() * 1000 - 500);
                decimal newPrice = _currentPrice + priceChange;

                // TUYỆT ĐỐI KHÔNG cập nhật trực tiếp lên Label hay DataGridView tại đây[cite: 7]
                // Đẩy dữ liệu về Main UI Thread để xử lý an toàn
                UpdateUIThreadSafe(newPrice);
            }
        }

        // Hàm cập nhật giao diện tuân thủ Thread Safety (Cross-Thread Rule)[cite: 7]
        private void UpdateUIThreadSafe(decimal newPrice)
        {
            // Bắt buộc kiểm tra if (this.InvokeRequired)[cite: 7]
            if (this.InvokeRequired)
            {
                // Sử dụng this.Invoke để đẩy hành động cập nhật giao diện về Main UI Thread[cite: 7]
                this.Invoke(new Action(() => UpdateUIThreadSafe(newPrice)));
                return;
            }

            // --- TỪ ĐÂY TRỞ XUỐNG ĐÃ AN TOÀN ĐỂ TƯƠNG TÁC VỚI GIAO DIỆN (UI THREAD) ---

            bool isUp = newPrice >= _currentPrice;

            // Thay đổi màu chữ: Xanh nếu tăng, Đỏ nếu giảm[cite: 7]
            lblBTCPrice.ForeColor = isUp ? Color.Green : Color.Red;
            lblBTCPrice.Text = $"BTC/USD: {newPrice:N2}";

            _syncCount++;

            // Hiển thị lần cập nhật cuối (HH:mm:ss) và số lượt đồng bộ thành công[cite: 7]
            // Lưu ý: Đảm bảo bạn đã đặt tên các Label trong StatusStrip tương ứng
            // lblLastUpdate.Text = $"Cập nhật: {DateTime.Now:HH:mm:ss}";
            // lblSyncCount.Text = $"Lượt đồng bộ: {_syncCount}";

            // Ghi nhận nhật ký lịch sử biến động giá qua mỗi lần quét[cite: 7]
            _historyLogs.Insert(0, new HistoryLog
            {
                Time = DateTime.Now.ToString("HH:mm:ss"),
                Price = newPrice,
                Status = isUp ? "TĂNG" : "GIẢM"
            });

            _currentPrice = newPrice;
        }
    }

    // Lớp đối tượng lưu trữ nhật ký
    public class HistoryLog
    {
        public string Time { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
    }
}