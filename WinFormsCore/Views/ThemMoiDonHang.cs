using DocumentFormat.OpenXml.InkML;
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

namespace WinFormsCore.Views
{
    public partial class ThemMoiDonHang : Form
    {
        private readonly ShopContext _context;

        public ThemMoiDonHang(ShopContext context)
        {
            InitializeComponent();
            _context = context;
            dataGridView1.CellClick += dataGridView1_CellClick;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            SetupListView();
            LoadCustomersToComboBox();
            cbbKhanhHang.SelectedIndexChanged += cbbKhanhHang_SelectedIndexChanged;

        }

        private void ThemMoiDonHang_Load(object sender, EventArgs e)
        {
            var filterProducts = _context.Products
                                       .OrderBy(a => a.Id)
                                       //.Skip((TrangHienTaiForm - 1) * SoDong)
                                       //.Take(SoDong)
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

        }
        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Product ID", 100);   // Cột ID sản phẩm
            listView1.Columns.Add("Product Name", 200); // Cột Tên sản phẩm
            listView1.Columns.Add("Price", 100);         // Cột Giá sản phẩm
            listView1.Columns.Add("Quantity", 80);       // Cột Số lượng
        }

        // Xử lý sự kiện click vào dòng trong DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu dòng không phải là header
            {
                // Lấy thông tin sản phẩm từ dòng dữ liệu
                var product = dataGridView1.Rows[e.RowIndex].DataBoundItem as dynamic;

                // Kiểm tra nếu sản phẩm đã có trong ListView
                bool productExists = false;

                foreach (ListViewItem item in listView1.Items)
                {
                    // So sánh Mã sản phẩm
                    if (item.SubItems[0].Text == product.Id.ToString())
                    {
                        // Nếu sản phẩm đã tồn tại, tăng số lượng lên 1
                        item.SubItems[3].Text = (int.Parse(item.SubItems[3].Text) + 1).ToString();
                        productExists = true;
                        break;
                    }
                }

                // Nếu sản phẩm chưa có trong ListView, thêm sản phẩm mới
                if (!productExists)
                {
                    ListViewItem newItem = new ListViewItem(product.Id.ToString());  // Mã sản phẩm
                    newItem.SubItems.Add(product.ProductName);  // Tên sản phẩm
                    newItem.SubItems.Add(product.UnitPrice.ToString("C"));  // Giá sản phẩm (Định dạng tiền tệ)
                    newItem.SubItems.Add("1");  // Số lượng ban đầu là 1

                    // Thêm vào ListView
                    listView1.Items.Add(newItem);
                }
            }
        }

        // Xử lý sự kiện double-click vào sản phẩm trong ListView
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Lấy dòng đã chọn trong ListView
            ListViewItem selectedItem = listView1.SelectedItems.Cast<ListViewItem>().FirstOrDefault();

            if (selectedItem != null)
            {
                // Tăng số lượng lên 1
                selectedItem.SubItems[3].Text = (int.Parse(selectedItem.SubItems[3].Text) + 1).ToString();
            }
        }




        //private void LoadCustomersToComboBox()
        //{
        //    var customers = _context.Customers.ToList();

        //    // Xóa tất cả các mục trong ComboBox
        //    cbbKhanhHang.Items.Clear();

        //    // Thiết lập DisplayMember và ValueMember
        //    cbbKhanhHang.DisplayMember = "Text";  // Hiển thị tên khách hàng
        //    cbbKhanhHang.ValueMember = "Value";   // Lưu trữ ID khách hàng

        //    // Thêm khách hàng vào ComboBox
        //    foreach (var customer in customers)
        //    {
        //        cbbKhanhHang.Items.Add(new { Text = customer.FirstName + " " + customer.LastName, Value = customer.Id });
        //    }

        //    // Nếu cần, chọn khách hàng đầu tiên
        //    if (cbbKhanhHang.Items.Count > 0)
        //    {
        //        cbbKhanhHang.SelectedIndex = 0;
        //    }
        //}
        //private void cbbKhanhHang_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    // Kiểm tra xem có khách hàng nào được chọn hay không
        //    if (cbbKhanhHang.SelectedItem != null)
        //    {
        //        // Lấy đối tượng khách hàng đã chọn từ ComboBox (dùng dynamic để lấy Text và Value)
        //        var selectedCustomer = cbbKhanhHang.SelectedItem as dynamic;

        //        // Cập nhật thông tin cho Label (ví dụ: họ tên đầy đủ và số điện thoại)
        //        lbName.Text = "Tên khách hàng: " + selectedCustomer.Text;
        //        lbSDT.Text = "Số điện thoại: " + selectedCustomer.Phone;
        //    }
        //}
        private void LoadCustomersToComboBox()
        {
            var customers = _context.Customers.ToList();

            // Xóa tất cả các mục trong ComboBox
            cbbKhanhHang.Items.Clear();

            // Thiết lập DisplayMember và ValueMember
            cbbKhanhHang.DisplayMember = "Text";  // Hiển thị tên khách hàng
            cbbKhanhHang.ValueMember = "Value";   // Lưu trữ ID khách hàng

            // Thêm khách hàng vào ComboBox
            foreach (var customer in customers)
            {
                cbbKhanhHang.Items.Add(new
                {
                    Text = customer.FirstName + " " + customer.LastName,
                    Value = customer.Id,
                    Phone = customer.Phone // Thêm thông tin số điện thoại vào đối tượng
                });
            }

            // Nếu cần, chọn khách hàng đầu tiên
            if (cbbKhanhHang.Items.Count > 0)
            {
                cbbKhanhHang.SelectedIndex = 0;
            }
        }
        private void cbbKhanhHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có khách hàng nào được chọn hay không
            if (cbbKhanhHang.SelectedItem != null)
            {
                // Lấy đối tượng khách hàng đã chọn từ ComboBox (dùng dynamic để lấy Text, Value và Phone)
                var selectedCustomer = cbbKhanhHang.SelectedItem as dynamic;

                // Cập nhật thông tin cho Label (ví dụ: họ tên đầy đủ và số điện thoại)
                lbName.Text = "Tên khách hàng: " + selectedCustomer.Text;
                lbSDT.Text = "Số điện thoại: " + selectedCustomer.Phone; // Hiển thị số điện thoại
            }
        }

        // lưu data
        private void SaveOrder()
        {
            var lastOrder = _context.Orders
                           .OrderByDescending(o => o.OrderNumber)
                           .FirstOrDefault();
            // Kiểm tra nếu khách hàng và sản phẩm chưa được chọn
            if (cbbKhanhHang.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy thông tin khách hàng đã chọn
            var selectedCustomer = cbbKhanhHang.SelectedItem as dynamic;
            int customerId = selectedCustomer.Value;

            // Tính toán tổng số tiền hóa đơn
            decimal totalAmount = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                decimal unitPrice = decimal.Parse(item.SubItems[2].Text, System.Globalization.NumberStyles.Currency);  // Đọc giá sản phẩm từ ListView
                int quantity = int.Parse(item.SubItems[3].Text);  // Đọc số lượng sản phẩm từ ListView

                totalAmount += unitPrice * quantity;
            }

            string orderNumber;
            if (lastOrder != null)
            {
                // Tách phần số cuối cùng của OrderNumber (giả sử là "DH202311160001")
                string lastOrderNumber = lastOrder.OrderNumber.Substring(0); // Loại bỏ "DH"
                int lastNumber = int.Parse(lastOrderNumber); // Chuyển đổi phần số cuối cùng thành số nguyên

                // Tạo mã đơn hàng mới bằng cách cộng thêm 1 vào số cuối cùng
                orderNumber = (lastNumber + 1).ToString("D6"); // Đảm bảo có 4 chữ số
            }
            else
            {
                // Nếu không có đơn hàng nào, bắt đầu từ mã "DH0001"
                orderNumber = "Loi";
            }

            // Tạo đơn hàng mới
            var order = new Order
            {
                OrderDate = DateTime.Now,
                OrderNumber = orderNumber,  // Gán mã đơn hàng đã tạo
                CustomerId = customerId,
                TotalAmount = totalAmount
            };


            // Lưu đơn hàng vào bảng Orders
            _context.Orders.Add(order);
            _context.SaveChanges();  // Lưu thay đổi vào cơ sở dữ liệu

            // Lưu chi tiết đơn hàng vào bảng OrderItems
            foreach (ListViewItem item in listView1.Items)
            {
                int productId = int.Parse(item.SubItems[0].Text);  // Lấy mã sản phẩm từ ListView
                decimal unitPrice = decimal.Parse(item.SubItems[2].Text, System.Globalization.NumberStyles.Currency);  // Lấy giá sản phẩm từ ListView
                int quantity = int.Parse(item.SubItems[3].Text);  // Lấy số lượng sản phẩm từ ListView

                var orderItem = new OrderItem
                {
                    OrderId = order.Id,
                    ProductId = productId,
                    UnitPrice = unitPrice,
                    Quantity = quantity
                };

                // Lưu chi tiết vào bảng OrderItems
                _context.OrderItems.Add(orderItem);
            }

            // Lưu thay đổi vào cơ sở dữ liệu
            _context.SaveChanges();

            MessageBox.Show("Đơn hàng đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Chuyển sang form Donhang (MainForm) và ẩn form hiện tại
            Donhang donhangForm = new Donhang(_context);
            donhangForm.Show(); // Hiển thị Donhang form
            this.Hide(); // Ẩn ThemMoiDonHang form
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SaveOrder();
        }

        private void cbbKhanhHang_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
