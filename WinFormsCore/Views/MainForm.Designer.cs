namespace WinFormsCore.Views
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            groupBox1 = new GroupBox();
            btn_capnhat = new Button();
            btn_themmoi = new Button();
            cbbx_tinh = new ComboBox();
            tbx_quocgia = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tbx_sdt = new TextBox();
            tbx_ten = new TextBox();
            tbx_ho = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            btnTrangTruoc = new Button();
            btnTrangSau = new Button();
            lbSoTrang = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            comboBoxSapXep = new ComboBox();
            comboBoxCot = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            txtTimKiem = new TextBox();
            btnSearch = new Button();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            DangXuatToolStripMenuItem = new ToolStripMenuItem();
            tepToolStripMenuItem = new ToolStripMenuItem();
            nguoiDungToolStripMenuItem = new ToolStripMenuItem();
            hangHoaToolStripMenuItem = new ToolStripMenuItem();
            donHangToolStripMenuItem = new ToolStripMenuItem();
            nhapXuatToolStripMenuItem = new ToolStripMenuItem();
            NhaphangToolStripMenuItem = new ToolStripMenuItem();
            XuathangToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(572, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(239, 32);
            label1.TabIndex = 0;
            label1.Text = "Quản lý khách hàng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_capnhat);
            groupBox1.Controls.Add(btn_themmoi);
            groupBox1.Controls.Add(cbbx_tinh);
            groupBox1.Controls.Add(tbx_quocgia);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbx_sdt);
            groupBox1.Controls.Add(tbx_ten);
            groupBox1.Controls.Add(tbx_ho);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(88, 62);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1242, 277);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // btn_capnhat
            // 
            btn_capnhat.Location = new Point(928, 208);
            btn_capnhat.Margin = new Padding(4);
            btn_capnhat.Name = "btn_capnhat";
            btn_capnhat.Size = new Size(178, 36);
            btn_capnhat.TabIndex = 12;
            btn_capnhat.Text = "Cập nhật";
            btn_capnhat.UseVisualStyleBackColor = true;
            btn_capnhat.Click += btn_capnhat_Click;
            // 
            // btn_themmoi
            // 
            btn_themmoi.Location = new Point(660, 208);
            btn_themmoi.Margin = new Padding(4);
            btn_themmoi.Name = "btn_themmoi";
            btn_themmoi.Size = new Size(178, 36);
            btn_themmoi.TabIndex = 11;
            btn_themmoi.Text = "Thêm mới";
            btn_themmoi.UseVisualStyleBackColor = true;
            btn_themmoi.Click += btn_themmoi_Click;
            // 
            // cbbx_tinh
            // 
            cbbx_tinh.FormattingEnabled = true;
            cbbx_tinh.Items.AddRange(new object[] { "An Giang", "Bà Rịa - Vũng Tàu", "Bắc Giang", "Bắc Kạn", "Bạc Liêu", "Bắc Ninh", "Bến Tre", "Bình Định", "Bình Dương", "Bình Phước", "Bình Thuận", "Cà Mau", "Cần Thơ", "Cao Bằng", "Đà Nẵng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Nội", "Hà Tĩnh", "Hải Dương", "Hải Phòng", "Hậu Giang", "Hòa Bình", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lâm Đồng", "Lạng Sơn", "Lào Cai", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên Huế", "Tiền Giang", "TP Hồ Chí Minh", "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái" });
            cbbx_tinh.Location = new Point(768, 45);
            cbbx_tinh.Margin = new Padding(4);
            cbbx_tinh.Name = "cbbx_tinh";
            cbbx_tinh.Size = new Size(336, 33);
            cbbx_tinh.TabIndex = 10;
            cbbx_tinh.SelectedIndexChanged += cbbx_tinh_SelectedIndexChanged;
            // 
            // tbx_quocgia
            // 
            tbx_quocgia.Location = new Point(770, 120);
            tbx_quocgia.Margin = new Padding(4);
            tbx_quocgia.Name = "tbx_quocgia";
            tbx_quocgia.Size = new Size(336, 31);
            tbx_quocgia.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label5.Location = new Point(660, 123);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 30);
            label5.TabIndex = 7;
            label5.Text = "Quốc gia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label6.Location = new Point(660, 44);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 30);
            label6.TabIndex = 6;
            label6.Text = "Tỉnh/TP";
            // 
            // tbx_sdt
            // 
            tbx_sdt.Location = new Point(202, 210);
            tbx_sdt.Margin = new Padding(4);
            tbx_sdt.Name = "tbx_sdt";
            tbx_sdt.Size = new Size(318, 31);
            tbx_sdt.TabIndex = 5;
            // 
            // tbx_ten
            // 
            tbx_ten.Location = new Point(168, 120);
            tbx_ten.Margin = new Padding(4);
            tbx_ten.Name = "tbx_ten";
            tbx_ten.Size = new Size(352, 31);
            tbx_ten.TabIndex = 4;
            // 
            // tbx_ho
            // 
            tbx_ho.Location = new Point(168, 44);
            tbx_ho.Margin = new Padding(4);
            tbx_ho.Name = "tbx_ho";
            tbx_ho.Size = new Size(352, 31);
            tbx_ho.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.Location = new Point(78, 214);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 30);
            label4.TabIndex = 2;
            label4.Text = "Điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(78, 123);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 30);
            label3.TabIndex = 1;
            label3.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(78, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 30);
            label2.TabIndex = 0;
            label2.Text = "Họ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(88, 457);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1242, 368);
            dataGridView1.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label7.Location = new Point(129, 873);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 30);
            label7.TabIndex = 13;
            label7.Text = "Số dòng";
            // 
            // btnTrangTruoc
            // 
            btnTrangTruoc.Location = new Point(423, 873);
            btnTrangTruoc.Margin = new Padding(2);
            btnTrangTruoc.Name = "btnTrangTruoc";
            btnTrangTruoc.Size = new Size(115, 36);
            btnTrangTruoc.TabIndex = 15;
            btnTrangTruoc.Text = "Trang Trước";
            btnTrangTruoc.UseVisualStyleBackColor = true;
            btnTrangTruoc.Click += btnTrangTruoc_Click_1;
            // 
            // btnTrangSau
            // 
            btnTrangSau.Location = new Point(708, 873);
            btnTrangSau.Margin = new Padding(2);
            btnTrangSau.Name = "btnTrangSau";
            btnTrangSau.Size = new Size(115, 36);
            btnTrangSau.TabIndex = 16;
            btnTrangSau.Text = "Trang Sau";
            btnTrangSau.UseVisualStyleBackColor = true;
            btnTrangSau.Click += btnTrangSau_Click;
            // 
            // lbSoTrang
            // 
            lbSoTrang.BackColor = SystemColors.ActiveCaption;
            lbSoTrang.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lbSoTrang.Location = new Point(1008, 877);
            lbSoTrang.Margin = new Padding(4, 0, 4, 0);
            lbSoTrang.Name = "lbSoTrang";
            lbSoTrang.Size = new Size(97, 31);
            lbSoTrang.TabIndex = 17;
            lbSoTrang.Click += lbSoTrang_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "5", "10", "20", "30" });
            comboBox1.Location = new Point(232, 877);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(66, 33);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label8.Location = new Point(88, 383);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(94, 30);
            label8.TabIndex = 19;
            label8.Text = "Sắp Xếp";
            label8.Click += label8_Click;
            // 
            // comboBoxSapXep
            // 
            comboBoxSapXep.FormattingEnabled = true;
            comboBoxSapXep.Items.AddRange(new object[] { "Tăng Dần", "Giảm Dần" });
            comboBoxSapXep.Location = new Point(188, 383);
            comboBoxSapXep.Margin = new Padding(2);
            comboBoxSapXep.Name = "comboBoxSapXep";
            comboBoxSapXep.Size = new Size(159, 33);
            comboBoxSapXep.TabIndex = 20;
            comboBoxSapXep.SelectedIndexChanged += comboBoxSapXep_SelectedIndexChanged;
            // 
            // comboBoxCot
            // 
            comboBoxCot.FormattingEnabled = true;
            comboBoxCot.Items.AddRange(new object[] { "STT", "Tên", "Tỉnh/TP", "Quốc Gia" });
            comboBoxCot.Location = new Point(513, 383);
            comboBoxCot.Margin = new Padding(2);
            comboBoxCot.Name = "comboBoxCot";
            comboBoxCot.Size = new Size(169, 33);
            comboBoxCot.TabIndex = 21;
            comboBoxCot.SelectedIndexChanged += comboBoxCot_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label9.Location = new Point(435, 383);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(48, 30);
            label9.TabIndex = 22;
            label9.Text = "Cột";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label10.Location = new Point(774, 383);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(106, 30);
            label10.TabIndex = 23;
            label10.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(895, 383);
            txtTimKiem.Margin = new Padding(2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(300, 31);
            txtTimKiem.TabIndex = 24;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1200, 377);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(129, 36);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1178, 877);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(115, 36);
            button1.TabIndex = 25;
            button1.Text = "In Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { DangXuatToolStripMenuItem, tepToolStripMenuItem, nhapXuatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1438, 33);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // DangXuatToolStripMenuItem
            // 
            DangXuatToolStripMenuItem.Name = "DangXuatToolStripMenuItem";
            DangXuatToolStripMenuItem.Size = new Size(112, 29);
            DangXuatToolStripMenuItem.Text = "Đăng Xuất";
            DangXuatToolStripMenuItem.Click += DangXuatToolStripMenuItem_Click;
            // 
            // tepToolStripMenuItem
            // 
            tepToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nguoiDungToolStripMenuItem, hangHoaToolStripMenuItem, donHangToolStripMenuItem });
            tepToolStripMenuItem.Name = "tepToolStripMenuItem";
            tepToolStripMenuItem.Size = new Size(57, 29);
            tepToolStripMenuItem.Text = "Tệp";
            // 
            // nguoiDungToolStripMenuItem
            // 
            nguoiDungToolStripMenuItem.Name = "nguoiDungToolStripMenuItem";
            nguoiDungToolStripMenuItem.Size = new Size(270, 34);
            nguoiDungToolStripMenuItem.Text = "Người dùng";
            nguoiDungToolStripMenuItem.Click += nguoiDungToolStripMenuItem_Click;
            // 
            // hangHoaToolStripMenuItem
            // 
            hangHoaToolStripMenuItem.Name = "hangHoaToolStripMenuItem";
            hangHoaToolStripMenuItem.Size = new Size(270, 34);
            hangHoaToolStripMenuItem.Text = "Hàng hoá";
            hangHoaToolStripMenuItem.Click += hangHoaToolStripMenuItem_Click;
            // 
            // donHangToolStripMenuItem
            // 
            donHangToolStripMenuItem.Name = "donHangToolStripMenuItem";
            donHangToolStripMenuItem.Size = new Size(270, 34);
            donHangToolStripMenuItem.Text = "Đơn Hàng";
            donHangToolStripMenuItem.Click += donHangToolStripMenuItem_Click;
            // 
            // nhapXuatToolStripMenuItem
            // 
            nhapXuatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NhaphangToolStripMenuItem, XuathangToolStripMenuItem });
            nhapXuatToolStripMenuItem.Name = "nhapXuatToolStripMenuItem";
            nhapXuatToolStripMenuItem.Size = new Size(114, 29);
            nhapXuatToolStripMenuItem.Text = "Nhập/Xuất";
            // 
            // NhaphangToolStripMenuItem
            // 
            NhaphangToolStripMenuItem.Name = "NhaphangToolStripMenuItem";
            NhaphangToolStripMenuItem.Size = new Size(270, 34);
            NhaphangToolStripMenuItem.Text = "Nhập hàng";
            NhaphangToolStripMenuItem.Click += NhaphangToolStripMenuItem_Click;
            // 
            // XuathangToolStripMenuItem
            // 
            XuathangToolStripMenuItem.Name = "XuathangToolStripMenuItem";
            XuathangToolStripMenuItem.Size = new Size(270, 34);
            XuathangToolStripMenuItem.Text = "Xuất hàng";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 980);
            Controls.Add(button1);
            Controls.Add(btnSearch);
            Controls.Add(txtTimKiem);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(comboBoxCot);
            Controls.Add(comboBoxSapXep);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(lbSoTrang);
            Controls.Add(btnTrangSau);
            Controls.Add(btnTrangTruoc);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Main";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox tbx_quocgia;
        private Label label5;
        private Label label6;
        private TextBox tbx_sdt;
        private TextBox tbx_ten;
        private TextBox tbx_ho;
        private Button btn_capnhat;
        private Button btn_themmoi;
        private ComboBox cbbx_tinh;
        private Panel panelDb;
        private DataGridView dataGridView1;
        private Label label7;
        private Button btnTrangTruoc;
        private Button btnTrangSau;
        private Label lbSoTrang;
        private ComboBox comboBox1;
        private Label label8;
        private ComboBox comboBoxSapXep;
        private ComboBox comboBoxCot;
        private Label label9;
        private Label label10;
        private TextBox txtTimKiem;
        private Button btnSearch;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem DangXuatToolStripMenuItem;
        private ToolStripMenuItem tepToolStripMenuItem;
        private ToolStripMenuItem nguoiDungToolStripMenuItem;
        private ToolStripMenuItem hangHoaToolStripMenuItem;
        private ToolStripMenuItem nhapXuatToolStripMenuItem;
        private ToolStripMenuItem NhaphangToolStripMenuItem;
        private ToolStripMenuItem XuathangToolStripMenuItem;
        private ToolStripMenuItem donHangToolStripMenuItem;
    }
}
    

