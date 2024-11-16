using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel; // Thư viện EPPlus
using System.Globalization; // Thêm namespace này

namespace WinFormsCore.Views
{
    public partial class HangHoa : Form
    {
        private int SoDong = 10;       // Số lượng mục trên mỗi trang (mặc định là 10)
        private int TrangHienTai = 1; // Trang hiện tại
        private int TongSoTrang = 0;  // Tổng số trang

        private readonly ShopContext _context;
        public HangHoa(ShopContext context)
        {

            InitializeComponent();    // hàm mặc định
            _context = context;
            InitializePagination();   // đếm số trang
            LoadPage(TrangHienTai);   // đổ dữ liệu vào
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            LoadSuppliersToComboBox();

        }
        private void InitializePagination()
        {
            // Tính tổng các dòng dl
            var totalItems = _context.Products.Count();

            // In ra số trang hiển thị dựa trên soDong đã khai báo ở trên
            TongSoTrang = (int)Math.Ceiling((double)totalItems / SoDong);
            // comboBox1.SelectedIndex = 2; // Mặc định là 10 mục (vị trí 2 của ComboBox), dựa vào nó để tính có bao nhiêu phân trang

        }
        private void LoadPage(int TrangHienTaiForm)
        {
            // Tính toán số mục cần bỏ qua và lấy dữ liệu cho trang hiện tại
            var filterProducts = _context.Products
                                         .OrderBy(a => a.Id)
                                         .Skip((TrangHienTaiForm - 1) * SoDong)
                                         .Take(SoDong)
                                         .Join(_context.Suppliers,
                                               product => product.SupplierId,
                                               supplier => supplier.Id,
                                               (product, supplier) => new
                                               {
                                                   product.Id,
                                                   product.ProductName,
                                                   SupplierName = supplier.CompanyName, // Lấy tên nhà cung cấp
                                                   product.UnitPrice,
                                                   product.Package,
                                                   product.IsDiscontinued
                                               })
                                         .ToList();

            // Hiển thị dữ liệu lên DataGridView
            dataGridView1.DataSource = filterProducts;

            // Ẩn cột "Orders" nếu tồn tại
            if (dataGridView1.Columns["OrderItems"] != null)
            {
                dataGridView1.Columns["OrderItems"].Visible = false;
            }

            lbSoTrang.Text = TrangHienTai.ToString() + "/" + TongSoTrang.ToString();
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
            var sortedData = _context.Products.AsQueryable();

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





        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            // Kiểm tra xem từ khóa có trống không
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tìm kiếm khách hàng dựa trên từ khóa (ví dụ tìm theo tên hoặc họ)
            var searchResults = _context.Products
                                        .Where(c => c.ProductName.Contains(keyword)) // Tìm theo FirstName hoặc LastName
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


        private void btn_themmoi_Click_1(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên form
            string tenHang = tbx_TenHang.Text.Trim();
            string donViTinh = tbx_DonViTinh.Text.Trim();

            // Kiểm tra nếu người dùng chưa chọn nhà cung cấp
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy Id của nhà cung cấp từ ComboBox
            if (comboBox2.SelectedValue is not int selectedSupplierId)
            {
                MessageBox.Show("Không thể lấy Id của nhà cung cấp, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra và chuyển đổi giá trị từ TextBox sang kiểu decimal
            if (!decimal.TryParse(tbx_Gia.Text.Trim(), out decimal gia))
            {
                MessageBox.Show("Vui lòng nhập giá là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra thông tin có hợp lệ không
            if (string.IsNullOrWhiteSpace(tenHang) || string.IsNullOrWhiteSpace(donViTinh))
            {
                MessageBox.Show("Tên hàng và đơn vị tính không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng Product mới
            var newProduct = new Product
            {
                ProductName = tenHang,
                Package = donViTinh,
                SupplierId = selectedSupplierId, // Gán Id của nhà cung cấp đã chọn
                UnitPrice = Math.Round(gia, 2)   // Làm tròn giá trị về 2 chữ số thập phân
            };

            // Thêm đối tượng vào cơ sở dữ liệu
            _context.Products.Add(newProduct);

            // Lưu thay đổi vào cơ sở dữ liệu
            try
            {
                _context.SaveChanges();
                MessageBox.Show("Thêm sản phẩm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa các TextBox sau khi thêm thành công
                tbx_TenHang.Clear();
                tbx_DonViTinh.Clear();
                tbx_Gia.Clear();
                comboBox2.SelectedIndex = -1; // Đặt lại ComboBox về mặc định

                // Cập nhật lại danh sách hiển thị trong DataGridView
                LoadPage(TrangHienTai);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btn_capnhat_Click_1(object sender, EventArgs e)
        {
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
        private void btnTrangSau_Click_1(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoDong = int.Parse(comboBox1.SelectedItem.ToString());

            // Tính lại tổng số trang dựa trên số lượng mục mới
            var totalItems = _context.Products.Count();
            TongSoTrang = (int)Math.Ceiling((double)totalItems / SoDong);

            // Tải lại trang đầu tiên với số lượng mục mới
            TrangHienTai = 1;
            LoadPage(TrangHienTai);
        }
        private bool isComboBoxLoading = false;


        // Hàm để tải dữ liệu nhà cung cấp vào ComboBox
        private void LoadSuppliersToComboBox()
        {
            isComboBoxLoading = true;
            // Lấy danh sách các nhà cung cấp từ cơ sở dữ liệu, bao gồm cả Id và CompanyName
            var suppliers = _context.Suppliers
                                    .OrderBy(s => s.CompanyName)
                                    .Select(s => new { s.Id, s.CompanyName }) // Lấy cả Id và CompanyName
                                    .ToList();

            // Thiết lập dữ liệu cho ComboBox
            comboBox2.DataSource = suppliers;
            comboBox2.DisplayMember = "CompanyName"; // Hiển thị tên nhà cung cấp
            comboBox2.ValueMember = "Id"; // Lấy Id làm giá trị
            comboBox2.SelectedIndex = -1; // Không chọn mục nào mặc định
            isComboBoxLoading = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu cờ đang bật (đang nạp dữ liệu) thì không xử lý sự kiện
            if (isComboBoxLoading || comboBox2.SelectedIndex == -1)
                return;

            // Khi người dùng chọn một nhà cung cấp
            string selectedSupplierName = comboBox2.SelectedItem.ToString();
            MessageBox.Show($"Bạn đã chọn nhà cung cấp: {selectedSupplierName}");
        }
        private void comboBoxSapXep_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBoxCot_SelectedIndexChanged(sender, e);

        }
        private void comboBoxCot_SelectedIndexChanged_1(object sender, EventArgs e)
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
                    selectedColumn = "ProductName";  // Sắp xếp theo tên
                    break;
                case 2:
                    selectedColumn = "UnitPrice";  // Sắp xếp theo Tỉnh/TP
                    break;
                case 3:
                    selectedColumn = "Package";  // Sắp xếp theo Quốc Gia
                    break;
                default:
                    return;  // Nếu không chọn cột hợp lệ, thoát khỏi sự kiện
            }

            // Xử lý sắp xếp tăng dần hoặc giảm dần
            bool isAscending = comboBoxSapXep.SelectedIndex == 0;

            // Lấy dữ liệu từ cơ sở dữ liệu và sắp xếp theo cột đã chọn
            var sortedData = _context.Products.AsQueryable();

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
            if (dataGridView1.Columns["OrderItem"] != null)
            {
                dataGridView1.Columns["OrderItem"].Visible = false;
            }

        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopContext context = new ShopContext();
            Point lastLocation = this.Location;
            // Khởi tạo và hiển thị MainForm
            MainForm mainForm = new MainForm(context);
            mainForm.Location = lastLocation;

            mainForm.Show(); // Hiển thị MainForm
            this.Hide(); // Ẩn LoginForm
        }

        private void hàngHoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopContext context = new ShopContext();
            Point lastLocation = this.Location;

            // Khởi tạo và hiển thị MainForm
            HangHoa hangHoa = new HangHoa(context);
            hangHoa.Location = lastLocation;

            hangHoa.Show(); // Hiển thị MainForm
            this.Hide(); // Ẩn LoginForm
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point lastLocation = this.Location;

            ShopContext context = new ShopContext();

            // Khởi tạo và hiển thị MainForm
            Donhang Donhang = new Donhang(context);
            Donhang.Location = lastLocation;

            Donhang.Show(); // Hiển thị MainForm
            this.Hide(); // Ẩn LoginForm
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc FormAc = new FormAc();
            FormAc.Show(); // Hiển thị MainForm
            this.Hide(); // Ẩn LoginForm
        }
    }
}
