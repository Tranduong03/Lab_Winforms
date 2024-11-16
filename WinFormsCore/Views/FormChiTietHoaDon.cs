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
    public partial class FormChiTietHoaDon : Form
    {
        private readonly ShopContext _context;
        private int _orderId;
        public FormChiTietHoaDon(ShopContext context, int orderId)
        {
            InitializeComponent();
            _context = context;
            _orderId = orderId;
            LoadOrderDetails();
            LoadCustomerInfo();
        }
        private void LoadCustomerInfo()
        {
            // Lấy thông tin khách hàng từ OrderId
            var customerInfo = _context.Orders
                .Where(o => o.Id == _orderId)
                .Join(_context.Customers,
                      order => order.CustomerId,
                      customer => customer.Id,
                      (order, customer) => new
                      {
                          CustomerName = customer.FirstName + " " + customer.LastName,
                          CustomerPhone = customer.Phone,
                          CustomerAddress = customer.City + ", " + customer.Country
                      })
                .FirstOrDefault();

            // Gán thông tin lên các label
            if (customerInfo != null)
            {
                lbHoTen.Text = "Họ tên: " + customerInfo.CustomerName;
                lbSDT.Text = "Số điện thoại: " + customerInfo.CustomerPhone;
                lbDiaChi.Text = "Địa chỉ: " + customerInfo.CustomerAddress;
            }
        }
        // Load thông tin chi tiết đơn hàng
        private void LoadOrderDetails()
        {
            var orderItems = _context.OrderItems
                .Where(oi => oi.OrderId == _orderId)
                .Join(_context.Products,
                      orderItem => orderItem.ProductId,
                      product => product.Id,
                      (orderItem, product) => new
                      {
                          ProductName = product.ProductName,
                          UnitPrice = orderItem.UnitPrice,
                          Quantity = orderItem.Quantity,
                          TotalPrice = orderItem.UnitPrice * orderItem.Quantity
                      })
                .ToList();

            // Tính tổng tiền hóa đơn
            decimal totalAmount = orderItems.Sum(item => item.TotalPrice);

            // Hiển thị lên DataGridView
            dataGridView1.DataSource = orderItems;

            // Thêm cột tổng tiền
            Tien.Text = $"Tổng tiền: {totalAmount:C2}"; // Hiển thị tổng tiền trên form
        }




        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {

        }
    }

   

}
