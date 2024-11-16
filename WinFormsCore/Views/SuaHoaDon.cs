using DocumentFormat.OpenXml.InkML;
using NPOI.SS.Formula.Functions;
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
    public partial class SuaHoaDon : Form
    {
        private TextBox txtProductName;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private readonly ShopContext _context;
        public SuaHoaDon(ShopContext context)
        {
            InitializeComponent();
            _context = context;
            dataGridView1.CellClick += dataGridView1_CellClick;
           

           

            SetupListView();
            LoadCustomersToComboBox();
            cbbKhanhHang.SelectedIndexChanged += cbbKhanhHang_SelectedIndexChanged;
            listView1.MouseDoubleClick += ListView1_MouseDoubleClick;

        }

        private void SuaHoaDon_Load(object sender, EventArgs e)
        {
            // Nếu ComboBox có khách hàng, lấy đơn hàng của khách hàng đầu tiên
            if (cbbKhanhHang.Items.Count > 0)
            {
                var firstCustomer = cbbKhanhHang.Items[0] as dynamic;
                LoadOrdersForCustomer((int)firstCustomer.Value);
            }
        }


        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Product ID", 100);   // Cột ID sản phẩm
            listView1.Columns.Add("Product Name", 200); // Cột Tên sản phẩm
            listView1.Columns.Add("Price", 100);         // Cột Giá sản phẩm
            listView1.Columns.Add("Quantity", 80);       // Cột Số lượng
            listView1.LabelEdit = true; // Đã được kích hoạt trong SetupListView



        }

        // Xử lý sự kiện click vào dòng trong DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu dòng không phải là header
            {
                // Lấy thông tin đơn hàng từ dòng dữ liệu
                var order = dataGridView1.Rows[e.RowIndex].DataBoundItem as dynamic;

                // Lấy OrderId của đơn hàng
                int orderId = order.Id;

                // Hiển thị các sản phẩm của đơn hàng trong ListView
                LoadOrderProducts(orderId);
            }
        }
        private void LoadOrderProducts(int orderId)
        {
            // Truy vấn các sản phẩm trong hóa đơn theo OrderId
            var orderProducts = _context.OrderItems  // Giả sử bạn có bảng OrderDetails lưu trữ các sản phẩm trong đơn hàng
                                     .Where(od => od.OrderId == orderId)
                                     .Join(_context.Products,
                                           od => od.ProductId,
                                           product => product.Id,
                                           (od, product) => new
                                           {
                                               product.Id,
                                               product.ProductName,
                                               product.UnitPrice,
                                               od.Quantity
                                           })
                                     .ToList();

            // Cập nhật ListView với các sản phẩm trong hóa đơn
            listView1.Items.Clear();  // Xóa dữ liệu cũ trong ListView

            foreach (var item in orderProducts)
            {
                ListViewItem newItem = new ListViewItem(item.Id.ToString());  // Mã sản phẩm
                newItem.SubItems.Add(item.ProductName);                        // Tên sản phẩm
                newItem.SubItems.Add(item.UnitPrice.ToString());            // Giá sản phẩm (Định dạng tiền tệ)
                newItem.SubItems.Add(item.Quantity.ToString());               // Số lượng

                // Thêm vào ListView
                newItem.Tag = item.Id;

                listView1.Items.Add(newItem);
            }
        }

        private void LoadOrdersForCustomer(int customerId)
        {
            // Truy vấn các hóa đơn của khách hàng theo CustomerId
            var orders = _context.Orders
                                 .Where(order => order.CustomerId == customerId)
                                 .OrderBy(order => order.Id)
                                 .Join(_context.Customers,
                                       order => order.CustomerId,
                                       customer => customer.Id,
                                       (order, customer) => new
                                       {
                                           order.Id,
                                           order.OrderNumber,
                                           order.OrderDate,
                                           order.TotalAmount
                                       })
                                 .ToList();

            // Hiển thị dữ liệu lên DataGridView
            dataGridView1.DataSource = orders;
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

                // Lọc các hóa đơn của khách hàng đã chọn
                LoadOrdersForCustomer((int)selectedCustomer.Value);
            }
        }

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

        //
        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy dòng đang được chọn
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Kiểm tra nếu Tag không phải là null
                if (selectedItem.Tag != null)
                {
                    int productId = (int)selectedItem.Tag;  // Lấy ProductId từ Tag


                    // Tạo một Form nhỏ hoặc TextBox để chỉnh sửa
                    Form editForm = new Form
                    {
                        Width = 600,
                        Height = 800,
                        Text = "Chỉnh sửa sản phẩm"
                    };

                    // Thêm nhãn cho các TextBox
                    Label lblProductName = new Label { Left = 20, Top = 20, Width = 100, Height = 50, Text = "Tên sản phẩm:" };
                     txtProductName = new TextBox { Left = 120, Top = 20, Width = 250, Height = 50, Text = selectedItem.SubItems[1].Text };

                    Label lblUnitPrice = new Label { Left = 20, Top = 60, Width = 100, Height = 50, Text = "Giá sản phẩm:" };
                     txtUnitPrice = new TextBox { Left = 120, Top = 60, Width = 250, Text = selectedItem.SubItems[2].Text };

                    Label lblQuantity = new Label { Left = 20, Top = 100, Width = 100, Height = 50, Text = "Số lượng:" };
                     txtQuantity = new TextBox { Left = 120, Top = 100, Width = 250, Height = 50, Text = selectedItem.SubItems[3].Text };

                    Button btnSave = new Button { Text = "Lưu", Left = 160, Width = 100, Height = 50, Top = 150 };
                    Button btnCancel = new Button { Text = "Hủy", Left = 50, Width = 100, Height = 50, Top = 150 };

                    // Sự kiện khi ấn nút Lưu
                    btnSave.Click += (s, ev) =>
                    {
                        // Kiểm tra dữ liệu hợp lệ trước khi lưu
                        if (decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) && int.TryParse(txtQuantity.Text, out int quantity))
                        {
                            // Lưu thay đổi vào ListViewItem
                            selectedItem.SubItems[1].Text = txtProductName.Text;
                            selectedItem.SubItems[2].Text = txtUnitPrice.Text;
                            selectedItem.SubItems[3].Text = txtQuantity.Text;

                            // Nếu cần lưu vào cơ sở dữ liệu
                            int productId = (int)selectedItem.Tag;  // Giả sử bạn lưu ProductId trong Tag
                            var product = _context.Products.FirstOrDefault(p => p.Id == productId);
                            if (product != null)
                            {
                                product.ProductName = txtProductName.Text;
                                product.UnitPrice = unitPrice;
                                // Nếu cần, bạn có thể cập nhật lại số lượng của sản phẩm
                                // product.Quantity = quantity;
                                _context.SaveChanges();
                            }

                            // Đóng Form chỉnh sửa
                            editForm.Close();
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại!");
                        }
                    };

                    // Sự kiện khi ấn nút Hủy
                    btnCancel.Click += (s, ev) =>
                    {
                        editForm.Close();
                    };

                    // Thêm các control vào Form chỉnh sửa
                    editForm.Controls.Add(lblProductName);
                    editForm.Controls.Add(txtProductName);
                    editForm.Controls.Add(lblUnitPrice);
                    editForm.Controls.Add(txtUnitPrice);
                    editForm.Controls.Add(lblQuantity);
                    editForm.Controls.Add(txtQuantity);
                    editForm.Controls.Add(btnSave);
                    editForm.Controls.Add(btnCancel);

                    // Hiển thị Form chỉnh sửa
                    editForm.ShowDialog();
                }
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy dòng đang được chọn
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Kiểm tra null và lấy thông tin từ các TextBox trong Form chỉnh sửa
                if (txtProductName != null && txtUnitPrice != null && txtQuantity != null)
                {
                    // Kiểm tra xem các TextBox có trống không
                    if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                        string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                        string.IsNullOrWhiteSpace(txtQuantity.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                        return; // Nếu có TextBox rỗng, dừng việc tiếp tục và không thực hiện lưu
                    }

                    string newProductName = txtProductName.Text;
                    decimal newUnitPrice;
                    int newQuantity;

                    // Kiểm tra giá trị nhập vào có hợp lệ cho UnitPrice
                    if (!decimal.TryParse(txtUnitPrice.Text, out newUnitPrice))
                    {
                        MessageBox.Show("Giá sản phẩm không hợp lệ. Vui lòng nhập lại.");
                        return;
                    }

                    // Kiểm tra giá trị nhập vào có hợp lệ cho Quantity
                    if (!int.TryParse(txtQuantity.Text, out newQuantity))
                    {
                        MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập lại.");
                        return;
                    }

                    // Cập nhật dữ liệu vào cơ sở dữ liệu
                    var product = _context.Products.FirstOrDefault(p => p.Id == (int)selectedItem.Tag);

                    if (product != null)
                    {
                        // Kiểm tra sự thay đổi trước khi lưu
                        bool isUpdated = false;

                        // Cập nhật thông tin của sản phẩm nếu có thay đổi
                        if (product.ProductName != newProductName)
                        {
                            product.ProductName = newProductName;
                            isUpdated = true;
                        }
                        if (product.UnitPrice != newUnitPrice)
                        {
                            product.UnitPrice = newUnitPrice;
                            isUpdated = true;
                        }

                        // Cập nhật lại số lượng trong bảng OrderItem nếu có thay đổi
                        var orderItems = _context.OrderItems.Where(oi => oi.ProductId == product.Id).ToList();

                        foreach (var orderItem in orderItems)
                        {
                            if (orderItem.Quantity != newQuantity)
                            {
                                orderItem.Quantity = newQuantity;
                                isUpdated = true;
                            }
                        }

                        if (isUpdated)
                        {
                            // Lưu lại thay đổi vào cơ sở dữ liệu
                            _context.SaveChanges();

                            // Cập nhật lại ListView
                            selectedItem.SubItems[1].Text = newProductName;
                            selectedItem.SubItems[2].Text = newUnitPrice.ToString(); 
                            selectedItem.SubItems[3].Text = newQuantity.ToString();

                            // Hiển thị thông báo thành công
                            MessageBox.Show("Cập nhật thông tin sản phẩm thành công!");
                            // Chuyển sang form Donhang (MainForm) và ẩn form hiện tại
                            Donhang donhangForm = new Donhang(_context);
                            donhangForm.Show(); // Hiển thị Donhang form
                            this.Hide(); // Ẩn ThemMoiDonHang form
                        }
                        else
                        {
                            MessageBox.Show("Không có thay đổi nào để cập nhật.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm để cập nhật.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin12.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần cập nhật.");
            }
        }




    }
}
