using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using WinFormsCore.Models.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsCore.Views
{
    public partial class FormAc : Form
    {
        private readonly ShopContext _context;

        public FormAc()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txt1.Text;
            string password = txt2.Text;
            string connectionString = "Data Source=localhost;Initial Catalog=LTTQ;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM Account WHERE UserName = @username AND Password = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số để bảo mật tránh SQL Injection
                    command.Parameters.AddWithValue("@username", userName);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
 
                        ShopContext context = new ShopContext();

                        MainForm mainForm = new MainForm(context);
                        mainForm.Show(); 
                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void FormAc_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                        "Bạn có chắc chắn muốn thoát không?", 
                        "Xác nhận thoát",                     
                        MessageBoxButtons.YesNo,             
                        MessageBoxIcon.Question               
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
    }
}
