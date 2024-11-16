using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCore.Models.Entities;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ClosedXML.Excel;
using NPOI;


//using FormChiTietHoaDon;

namespace WinFormsCore.Views
{
    public partial class Donhang : Form
    {
        private int SoDong = 1000;       // Số lượng mục trên mỗi trang (mặc định là 10)
        private int TrangHienTai = 1; // Trang hiện tại
        private int TongSoTrang = 0;  // Tổng số trang


        private readonly ShopContext _context;
        public Donhang(ShopContext context)
        {

            InitializeComponent();
            _context = context;
            InitializePagination();   // đếm số trang
            LoadPage(TrangHienTai);   // đổ dữ liệu vào
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;

        }
        private void InitializePagination()
        {
            // Tính tổng các dòng dl
            var totalItems = _context.Orders.Count();

            // In ra số trang hiển thị dựa trên soDong đã khai báo ở trên
            TongSoTrang = (int)Math.Ceiling((double)totalItems / SoDong);
            // comboBox1.SelectedIndex = 2; // Mặc định là 10 mục (vị trí 2 của ComboBox), dựa vào nó để tính có bao nhiêu phân trang

        }

        // Đổ dữ liệu vào girdView Biếm tryền vao là =1
        private void LoadPage(int TrangHienTaiForm)
        {
            var filterOrder = _context.Orders
                                   .OrderBy(a => a.Id)
                                   .Skip((TrangHienTaiForm - 1) * SoDong)
                                   .Take(SoDong)
                                   .Join(_context.Customers,
                                         order => order.CustomerId,
                                         customer => customer.Id,
                                         (order, customer) => new
                                         {
                                             order.Id,
                                             order.OrderDate,
                                             CustomerName = customer.FirstName + " " + customer.LastName,
                                             order.OrderNumber,
                                             order.TotalAmount,
                                             CustomerPhone = customer.Phone,
                                             CustomerAddress = customer.City + ", " + customer.Country
                                         })
                                   .ToList();

            // Hiển thị dữ liệu lên DataGridView
            dataGridView1.DataSource = filterOrder;

            lbSoTrang.Text = TrangHienTai.ToString() + "/" + TongSoTrang.ToString();
        }
        // Sự kiện khi click đúp vào một hàng trong DataGridView
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy Id của đơn hàng từ hàng được click
                int orderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                // Mở form chi tiết hóa đơn
                FormChiTietHoaDon formChiTiet = new FormChiTietHoaDon(_context, orderId);
                formChiTiet.ShowDialog();
            }
        }

        private void Donhang_Load(object sender, EventArgs e)
        {

        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopContext context = new ShopContext();

            // Khởi tạo và hiển thị MainForm
            Donhang Donhang = new Donhang(context);

            Donhang.Show(); // Hiển thị MainForm
            this.Hide(); // Ẩn LoginForm
        }

        private void hàngHoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            // Khởi tạo ShopContext và HangHoa
            ShopContext context = new ShopContext();
            HangHoa hangHoaForm = new HangHoa(context);

            // Đặt vị trí của form HangHoa bằng vị trí của LoginForm
            hangHoaForm.StartPosition = FormStartPosition.Manual;

            // Hiển thị form HangHoa
            hangHoaForm.Show();
            this.Hide(); // Ẩn LoginForm
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopContext context = new ShopContext();
            Point lastLocation = this.Location;
            // Khởi tạo và hiển thị MainForm
            MainForm MainForm = new MainForm(context);
            MainForm.Location = lastLocation;

            MainForm.Show(); // Hiển thị MainForm
            this.Hide(); // Ẩn LoginForm
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Khởi tạo và hiển thị MainForm
            FormAc FormAc = new FormAc();
            FormAc.Show(); // Hiển thị MainForm
            this.Hide(); // Ẩn LoginForm
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy số lượng mục từ ComboBox
            SoDong = int.Parse(comboBox1.SelectedItem.ToString());

            // Tính lại tổng số trang dựa trên số lượng mục mới
            var totalItems = _context.Orders.Count();
            TongSoTrang = (int)Math.Ceiling((double)totalItems / SoDong);

            // Tải lại trang đầu tiên với số lượng mục mới
            TrangHienTai = 1;
            LoadPage(TrangHienTai);
        }

        private void btnTrangTruoc_Click(object sender, EventArgs e)
        {
            if (TrangHienTai > 1)
            {
                TrangHienTai--;
                LoadPage(TrangHienTai);
            }
            else
            {
                MessageBox.Show("Đây là trang đầu tiên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTrangSau_Click(object sender, EventArgs e)
        {
            if (TrangHienTai < TongSoTrang)
            {
                TrangHienTai++;
                LoadPage(TrangHienTai);
            }
            else
            {
                MessageBox.Show("Đây là trang cuối cùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Mở hộp thoại lưu file để người dùng chọn đường dẫn và đặt tên file
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Chọn nơi lưu file Excel";
                saveFileDialog.FileName = "DataGridViewData.xlsx"; // Tên file mặc định

                // Nếu người dùng chọn đường dẫn và nhấn OK
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn mà người dùng đã chọn
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        // Tạo workbook và worksheet mới
                        IWorkbook workbook = new XSSFWorkbook();
                        ISheet sheet = workbook.CreateSheet("DataGridView Data");

                        // Tạo hàng đầu tiên với tiêu đề cột
                        IRow headerRow = sheet.CreateRow(0);
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            headerRow.CreateCell(j).SetCellValue(dataGridView1.Columns[j].HeaderText);
                        }

                        // Ghi dữ liệu từ DataGridView vào Excel
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            IRow row = sheet.CreateRow(i + 1);
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                // Kiểm tra giá trị ô có null không
                                var cellValue = dataGridView1.Rows[i].Cells[j].Value;
                                row.CreateCell(j).SetCellValue(cellValue?.ToString() ?? "");
                            }
                        }

                        // Ghi dữ liệu vào file Excel
                        using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                        {
                            workbook.Write(fileStream);
                        }

                        workbook.Close();
                        MessageBox.Show("Xuất dữ liệu ra Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra khi lưu file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // Hiển thị hộp thoại để người dùng nhập tháng và năm
            string inputMonth = Microsoft.VisualBasic.Interaction.InputBox("Nhập tháng cần thống kê (1-12):", "Chọn Tháng", DateTime.Now.Month.ToString());
            string inputYear = Microsoft.VisualBasic.Interaction.InputBox("Nhập năm cần thống kê:", "Chọn Năm", DateTime.Now.Year.ToString());

            // Kiểm tra dữ liệu nhập vào
            if (!int.TryParse(inputMonth, out int month) || month < 1 || month > 12)
            {
                MessageBox.Show("Vui lòng nhập tháng hợp lệ (1-12)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(inputYear, out int year) || year < 1900 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Vui lòng nhập năm hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xóa dữ liệu biểu đồ cũ
            chart1.Series.Clear();

            // Tạo một Series mới cho biểu đồ
            Series series = new Series($"Doanh thu tháng {month}/{year}");
            series.ChartType = SeriesChartType.Column; // Biểu đồ cột

            // Lấy dữ liệu thống kê từ cơ sở dữ liệu
            var data = _context.Orders
                               .Where(o => o.OrderDate.Month == month && o.OrderDate.Year == year) // Lọc theo tháng và năm
                               .GroupBy(o => o.OrderDate.Day) // Nhóm theo ngày
                               .Select(g => new
                               {
                                   Month = g.Key,
                                   TotalAmount = g.Sum(o => o.TotalAmount)
                               })
                               .OrderBy(x => x.Month)
                               .ToList();

            // Kiểm tra nếu không có dữ liệu
            if (!data.Any())
            {
                MessageBox.Show($"Không có dữ liệu doanh thu cho tháng {month}/{year}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Thêm dữ liệu vào Series
            foreach (var item in data)
            {
                series.Points.AddXY($"Tháng {month}", item.TotalAmount);
            }

            // Thêm Series vào biểu đồ
            chart1.Series.Add(series);

            // Định dạng biểu đồ
            //chart1.ChartAreas[0].AxisX.Title = "Ngày";
            chart1.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].RecalculateAxesScale();

            MessageBox.Show($"Đã vẽ biểu đồ thống kê doanh thu cho tháng {month}/{year}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void comboBoxSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCot_SelectedIndexChanged(sender, e);
        }

        private void comboBoxCot_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng chưa chọn kiểu sắp xếp
            if (comboBoxSapXep.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn kiểu sắp xếp trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy giá trị của ComboBox để biết cột cần sắp xếp
            string selectedColumn = "";

            // Kiểm tra cột nào được chọn để sắp xếp
            switch (comboBoxCot.SelectedIndex)
            {
                case 0:
                    selectedColumn = "Id";  // Sắp xếp theo Id
                    break;
                case 1:
                    selectedColumn = "OrderNumber";  // Sắp xếp theo số đơn hàng
                    break;
                case 2:
                    selectedColumn = "TotalAmount";  // Sắp xếp theo tổng tiền
                    break;
                case 3:
                    selectedColumn = "CustomerName";  // Sắp xếp theo tên khách hàng
                    break;
                default:
                    return;  // Nếu không chọn cột hợp lệ, thoát khỏi sự kiện
            }

            // Xử lý sắp xếp tăng dần hoặc giảm dần
            bool isAscending = comboBoxSapXep.SelectedIndex == 0;

            // Lấy dữ liệu từ cơ sở dữ liệu và kết hợp bảng Orders với Customers
            var dataQuery = _context.Orders
                                    .Join(_context.Customers,
                                          order => order.CustomerId,
                                          customer => customer.Id,
                                          (order, customer) => new
                                          {
                                              order.Id,
                                              order.OrderNumber,
                                              order.TotalAmount,
                                              CustomerName = customer.FirstName + " " + customer.LastName
                                          });

            // Sắp xếp theo cột đã chọn
            if (isAscending)
            {
                // Sắp xếp tăng dần
                dataQuery = dataQuery.OrderBy(x => EF.Property<object>(x, selectedColumn));
            }
            else
            {
                // Sắp xếp giảm dần
                dataQuery = dataQuery.OrderByDescending(x => EF.Property<object>(x, selectedColumn));
            }

            // Đổ dữ liệu đã sắp xếp vào DataGridView
            dataGridView1.DataSource = dataQuery.ToList();

            // Thiết lập hiển thị cho DataGridView
            if (dataGridView1.Columns["Id"] != null)
            {
                dataGridView1.Columns["Id"].HeaderText = "Mã Đơn Hàng";
            }

            if (dataGridView1.Columns["OrderNumber"] != null)
            {
                dataGridView1.Columns["OrderNumber"].HeaderText = "Số Đơn Hàng";
            }

            if (dataGridView1.Columns["TotalAmount"] != null)
            {
                dataGridView1.Columns["TotalAmount"].HeaderText = "Tổng Tiền";
            }

            if (dataGridView1.Columns["CustomerName"] != null)
            {
                dataGridView1.Columns["CustomerName"].HeaderText = "Tên Khách Hàng";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            // Lấy từ khóa tìm kiếm từ TextBox
            string keyword = txtTimKiem.Text.Trim();

            // Kiểm tra xem từ khóa có trống không
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tìm kiếm khách hàng và đơn hàng dựa trên từ khóa
            var searchResults = _context.Customers
                                        .Join(_context.Orders, // Liên kết với bảng Orders
                                              customer => customer.Id,
                                              order => order.CustomerId,
                                              (customer, order) => new
                                              {
                                                  CustomerId = customer.Id,
                                                  CustomerName = customer.FirstName + " " + customer.LastName,
                                                  customer.Phone,
                                                  OrderId = order.Id,
                                                  order.OrderNumber,
                                                  order.TotalAmount,
                                                  order.OrderDate
                                              })
                                        .Where(x => x.CustomerName.Contains(keyword) || x.OrderNumber.Contains(keyword)) // Tìm theo tên hoặc số hóa đơn
                                        .OrderBy(x => x.CustomerId) // Sắp xếp theo CustomerId
                                        .ToList();

            // Kiểm tra xem có tìm thấy kết quả không
            if (searchResults.Any())
            {
                // Đổ dữ liệu vào DataGridView nếu có kết quả
                dataGridView1.DataSource = searchResults;

                // Thiết lập tiêu đề cho các cột
                dataGridView1.Columns["CustomerId"].HeaderText = "Mã Khách Hàng";
                dataGridView1.Columns["CustomerName"].HeaderText = "Tên Khách Hàng";
                dataGridView1.Columns["Phone"].HeaderText = "Số Điện Thoại";
                dataGridView1.Columns["OrderId"].HeaderText = "Mã Đơn Hàng";
                dataGridView1.Columns["OrderNumber"].HeaderText = "Số Đơn Hàng";
                dataGridView1.Columns["TotalAmount"].HeaderText = "Tổng Tiền";
                dataGridView1.Columns["OrderDate"].HeaderText = "Ngày Đặt Hàng";
            }
            else
            {
                // Thông báo nếu không tìm thấy kết quả
                MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShopContext context = new ShopContext();

            // Khởi tạo và hiển thị MainForm
            SuaHoaDon SuaHoaDon = new SuaHoaDon(context);
            SuaHoaDon.Show(); // Hiển thị MainForm
            this.Hide(); // Ẩn LoginForm
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            ShopContext context = new ShopContext();

            // Khởi tạo và hiển thị MainForm
            ThemMoiDonHang ThemMoiDonHang = new ThemMoiDonHang(context);
            ThemMoiDonHang.Show(); // Hiển thị MainForm
            this.Hide(); // Ẩn LoginForm
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                openFileDialog.Title = "Chọn file Excel để nhập dữ liệu";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file Excel
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        // Mở file Excel
                        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        {
                            IWorkbook workbook = new XSSFWorkbook(fileStream); // Đọc file Excel (.xlsx)
                            ISheet sheet = workbook.GetSheetAt(0); // Lấy sheet đầu tiên

                            // Xóa dữ liệu cũ trong DataGridView
                            dataGridView1.Rows.Clear();
                            dataGridView1.Columns.Clear();

                            // Đọc tiêu đề cột từ hàng đầu tiên
                            IRow headerRow = sheet.GetRow(0);
                            for (int j = 0; j < headerRow.LastCellNum; j++)
                            {
                                // Thêm các cột vào DataGridView
                                dataGridView1.Columns.Add(headerRow.GetCell(j).ToString(), headerRow.GetCell(j).ToString());
                            }

                            // Đọc dữ liệu từ hàng tiếp theo và thêm vào DataGridView
                            for (int i = 1; i <= sheet.LastRowNum; i++)
                            {
                                IRow row = sheet.GetRow(i);
                                if (row == null) continue; // Bỏ qua các hàng rỗng

                                // Tạo mảng để chứa dữ liệu từng hàng
                                object[] rowData = new object[row.LastCellNum];
                                for (int j = 0; j < row.LastCellNum; j++)
                                {
                                    rowData[j] = row.GetCell(j)?.ToString() ?? ""; // Kiểm tra null
                                }

                                // Thêm hàng vào DataGridView
                                dataGridView1.Rows.Add(rowData);
                            }

                            workbook.Close();
                            MessageBox.Show("Nhập dữ liệu từ Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra khi nhập file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}