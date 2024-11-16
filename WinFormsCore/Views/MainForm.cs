using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using WinFormsCore.Models.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel; // Thư viện EPPlus


namespace WinFormsCore.Views
{
    public partial class MainForm : Form
    {

        private int SoDong = 10;       // Số lượng mục trên mỗi trang (mặc định là 10)
        private int TrangHienTai = 1; // Trang hiện tại
        private int TongSoTrang = 0;  // Tổng số trang

        private readonly ShopContext _context;

        public MainForm(ShopContext context)
        {
            InitializeComponent();    // hàm mặc định
            _context = context;
            InitializePagination();   // đếm số trang
            LoadPage(TrangHienTai);   // đổ dữ liệu vào
        }

        // Khởi tạo phân trang và thiết lập ComboBox
        private void InitializePagination()
        {
            // Tính tổng các dòng dl
            var totalItems = _context.Customers.Count();

            // In ra số trang hiển thị dựa trên soDong đã khai báo ở trên
            TongSoTrang = (int)Math.Ceiling((double)totalItems / SoDong);
            // comboBox1.SelectedIndex = 2; // Mặc định là 10 mục (vị trí 2 của ComboBox), dựa vào nó để tính có bao nhiêu phân trang

        }

        // Đổ dữ liệu vào girdView Biếm tryền vao là =1
        private void LoadPage(int TrangHienTaiForm)
        {
            // Tính toán số mục cần bỏ qua và lấy dữ liệu cho trang hiện tại
            var filterCustomers = _context.Customers
                                          .OrderBy(a => a.Id)   // Sắp xếp theo ID
                                          .Skip((TrangHienTaiForm - 1) * SoDong) // Bỏ qua các mục trước đó. Đang ở trang 1 nên k có tác đụngk, chỉ có tác dụng với trang 2 trở đi
                                          .Take(SoDong)      // Lấy số lượng dòng tương ứng của trang
                                          .ToList();

            // Hiển thị dữ liệu lên DataGridView
            dataGridView1.DataSource = filterCustomers;

            // Ẩn cột "Orders" nếu tồn tại
            if (dataGridView1.Columns["Orders"] != null)
            {
                dataGridView1.Columns["Orders"].Visible = false;
            }
            lbSoTrang.Text = TrangHienTai.ToString() + "/" + TongSoTrang.ToString();
        }

        // Xử lý sự kiện khi thay đổi số lượng mục trên mỗi trang từ ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy số lượng mục từ ComboBox
            SoDong = int.Parse(comboBox1.SelectedItem.ToString());

            // Tính lại tổng số trang dựa trên số lượng mục mới
            var totalItems = _context.Customers.Count();
            TongSoTrang = (int)Math.Ceiling((double)totalItems / SoDong);

            // Tải lại trang đầu tiên với số lượng mục mới
            TrangHienTai = 1;
            LoadPage(TrangHienTai);
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
        private void btnTrangTruoc_Click_1(object sender, EventArgs e)
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

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            LoadPage(TrangHienTai);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên form
            string firstName = tbx_ho.Text.Trim();
            string lastName = tbx_ten.Text.Trim();
            string city = cbbx_tinh.Text.Trim();
            string country = tbx_quocgia.Text.Trim();
            string phone = tbx_sdt.Text.Trim();

            // Kiểm tra xem thông tin có hợp lệ không (ví dụ: không để trống tên và họ)
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Tên và họ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng Customer mới
            var newCustomer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                City = city,
                Country = country,
                Phone = phone
            };

            // Thêm đối tượng vào cơ sở dữ liệu
            _context.Customers.Add(newCustomer);

            // Lưu thay đổi vào cơ sở dữ liệu
            try
            {
                _context.SaveChanges();
                MessageBox.Show("Thêm khách hàng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_ho.Clear();
                tbx_ten.Clear();
                tbx_sdt.Clear();
                tbx_quocgia.Clear();
                cbbx_tinh.SelectedIndex = -1;

                // Sau khi thêm mới, bạn có thể cập nhật lại danh sách hiển thị trong DataGridView
                // Giả sử bạn đang phân trang

                // Hoặc nếu không phân trang, bạn có thể tải lại toàn bộ danh sách
                // var customers = _context.Customers.ToList();
                // dataGridView1.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Tìm kiếm khách hàng dựa trên từ khóa (ví dụ tìm theo tên hoặc họ)
            var searchResults = _context.Customers
                                        .Where(c => c.FirstName.Contains(keyword) || c.LastName.Contains(keyword))  // Tìm theo FirstName hoặc LastName
                                        .OrderBy(c => c.Id)  // Sắp xếp theo ID
                                        .ToList();

            // Kiểm tra xem có tìm thấy kết quả không
            if (searchResults.Any())
            {
                // Đổ dữ liệu vào DataGridView nếu có kết quả
                dataGridView1.DataSource = searchResults;

                // Ẩn cột "Orders" nếu tồn tại
                if (dataGridView1.Columns["Orders"] != null)
                {
                    dataGridView1.Columns["Orders"].Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Gọi lại sự kiện SelectedIndexChanged của comboBoxCot để cập nhật sắp xếp khi thay đổi kiểu sắp xếp
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

            switch (comboBoxCot.SelectedIndex)
            {
                case 0:
                    selectedColumn = "Id";  // Sắp xếp theo Id (thay vì STT)
                    break;
                case 1:
                    selectedColumn = "LastName";  // Sắp xếp theo tên
                    break;
                case 2:
                    selectedColumn = "City";  // Sắp xếp theo Tỉnh/TP
                    break;
                case 3:
                    selectedColumn = "Country";  // Sắp xếp theo Quốc Gia
                    break;
                default:
                    return;  // Nếu không chọn cột hợp lệ, thoát khỏi sự kiện
            }

            // Xử lý sắp xếp tăng dần hoặc giảm dần
            bool isAscending = comboBoxSapXep.SelectedIndex == 0;

            // Lấy dữ liệu từ cơ sở dữ liệu và sắp xếp theo cột đã chọn
            var sortedData = _context.Customers.AsQueryable();

            if (isAscending)
            {
                // Sắp xếp tăng dần theo cột đã chọn
                sortedData = sortedData.OrderBy(c => EF.Property<object>(c, selectedColumn));
            }
            else
            {
                // Sắp xếp giảm dần theo cột đã chọn
                sortedData = sortedData.OrderByDescending(c => EF.Property<object>(c, selectedColumn));
            }

            // Đổ dữ liệu đã sắp xếp vào DataGridView
            dataGridView1.DataSource = sortedData.ToList();

            // Ẩn cột "Orders" nếu tồn tại
            if (dataGridView1.Columns["Orders"] != null)
            {
                dataGridView1.Columns["Orders"].Visible = false;
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

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc ac = new FormAc();
            ac.Show(); // Hiển thị MainForm
            this.Hide(); // Ẩn LoginForm
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbbx_tinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopContext context = new ShopContext();
            Point lastLocation = this.Location;

            MainForm MainForm = new MainForm(context);
            MainForm.Location = lastLocation;

            MainForm.Show(); 
            this.Hide(); 
        }

        private void hangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point lastLocation = this.Location;

            ShopContext context = new ShopContext();
            HangHoa hangHoaForm = new HangHoa(context);

            hangHoaForm.StartPosition = FormStartPosition.Manual;
            hangHoaForm.Location = lastLocation;

            hangHoaForm.Show();
            this.Hide(); 
        }

        private void donHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point lastLocation = this.Location;
            ShopContext context = new ShopContext();

            Donhang Donhang = new Donhang(context);
            Donhang.StartPosition = FormStartPosition.Manual;

            Donhang.Show(); 
            this.Hide(); 
        }

        private void lbSoTrang_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void NhaphangToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
