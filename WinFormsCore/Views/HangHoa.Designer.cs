namespace WinFormsCore.Views
{
    partial class HangHoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nhậpHàngToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            btnSearch = new Button();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            txtTimKiem = new TextBox();
            ngườiDùngToolStripMenuItem = new ToolStripMenuItem();
            hàngHoáToolStripMenuItem = new ToolStripMenuItem();
            nhậpXuấtToolStripMenuItem = new ToolStripMenuItem();
            xuấtHàngToolStripMenuItem = new ToolStripMenuItem();
            label10 = new Label();
            label9 = new Label();
            comboBoxCot = new ComboBox();
            comboBoxSapXep = new ComboBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            lbSoTrang = new Label();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            btnTrangSau = new Button();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            NhaCungCap = new Label();
            btn_capnhat = new Button();
            btn_themmoi = new Button();
            tbx_Gia = new TextBox();
            label5 = new Label();
            tbx_DonViTinh = new TextBox();
            tbx_TenHang = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            btnTrangTruoc = new Button();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // nhậpHàngToolStripMenuItem
            // 
            nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            nhậpHàngToolStripMenuItem.Size = new Size(266, 44);
            nhậpHàngToolStripMenuItem.Text = "Nhập hàng";
            // 
            // button1
            // 
            button1.Location = new Point(1531, 1166);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 42;
            button1.Text = "In Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1560, 526);
            btnSearch.Margin = new Padding(5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(168, 46);
            btnSearch.TabIndex = 30;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(146, 36);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(1163, 533);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(389, 39);
            txtTimKiem.TabIndex = 41;
            // 
            // ngườiDùngToolStripMenuItem
            // 
            ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            ngườiDùngToolStripMenuItem.Size = new Size(276, 44);
            ngườiDùngToolStripMenuItem.Text = "Người dùng";
            ngườiDùngToolStripMenuItem.Click += ngườiDùngToolStripMenuItem_Click;
            // 
            // hàngHoáToolStripMenuItem
            // 
            hàngHoáToolStripMenuItem.Name = "hàngHoáToolStripMenuItem";
            hàngHoáToolStripMenuItem.Size = new Size(276, 44);
            hàngHoáToolStripMenuItem.Text = "Hàng hoá";
            hàngHoáToolStripMenuItem.Click += hàngHoáToolStripMenuItem_Click;
            // 
            // nhậpXuấtToolStripMenuItem
            // 
            nhậpXuấtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nhậpHàngToolStripMenuItem, xuấtHàngToolStripMenuItem });
            nhậpXuấtToolStripMenuItem.Name = "nhậpXuấtToolStripMenuItem";
            nhậpXuấtToolStripMenuItem.Size = new Size(149, 36);
            nhậpXuấtToolStripMenuItem.Text = "Nhập/Xuất";
            // 
            // xuấtHàngToolStripMenuItem
            // 
            xuấtHàngToolStripMenuItem.Name = "xuấtHàngToolStripMenuItem";
            xuấtHàngToolStripMenuItem.Size = new Size(266, 44);
            xuấtHàngToolStripMenuItem.Text = "Xuất hàng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label10.Location = new Point(1006, 533);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(142, 40);
            label10.TabIndex = 40;
            label10.Text = "Tìm Kiếm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label9.Location = new Point(565, 533);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(62, 40);
            label9.TabIndex = 39;
            label9.Text = "Cột";
            // 
            // comboBoxCot
            // 
            comboBoxCot.FormattingEnabled = true;
            comboBoxCot.Items.AddRange(new object[] { "Id", "ProductName", "UnitPrice", "Package" });
            comboBoxCot.Location = new Point(667, 533);
            comboBoxCot.Name = "comboBoxCot";
            comboBoxCot.Size = new Size(218, 40);
            comboBoxCot.TabIndex = 38;
            comboBoxCot.SelectedIndexChanged += comboBoxCot_SelectedIndexChanged_1;
            // 
            // comboBoxSapXep
            // 
            comboBoxSapXep.FormattingEnabled = true;
            comboBoxSapXep.Items.AddRange(new object[] { "Tăng Dần", "Giảm Dần" });
            comboBoxSapXep.Location = new Point(245, 533);
            comboBoxSapXep.Name = "comboBoxSapXep";
            comboBoxSapXep.Size = new Size(206, 40);
            comboBoxSapXep.TabIndex = 37;
            comboBoxSapXep.SelectedIndexChanged += comboBoxSapXep_SelectedIndexChanged_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label8.Location = new Point(114, 533);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(123, 40);
            label8.TabIndex = 36;
            label8.Text = "Sắp Xếp";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "5", "10", "20", "30" });
            comboBox1.Location = new Point(302, 1166);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(85, 40);
            comboBox1.TabIndex = 35;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbSoTrang
            // 
            lbSoTrang.BackColor = SystemColors.ActiveCaption;
            lbSoTrang.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lbSoTrang.Location = new Point(1311, 1166);
            lbSoTrang.Margin = new Padding(5, 0, 5, 0);
            lbSoTrang.Name = "lbSoTrang";
            lbSoTrang.Size = new Size(126, 40);
            lbSoTrang.TabIndex = 34;
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ngườiDùngToolStripMenuItem, hàngHoáToolStripMenuItem, thốngKêToolStripMenuItem });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(74, 36);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(276, 44);
            thốngKêToolStripMenuItem.Text = "Đơn hàng";
            thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
            // 
            // btnTrangSau
            // 
            btnTrangSau.Location = new Point(920, 1160);
            btnTrangSau.Name = "btnTrangSau";
            btnTrangSau.Size = new Size(150, 46);
            btnTrangSau.TabIndex = 33;
            btnTrangSau.Text = "Trang Sau";
            btnTrangSau.UseVisualStyleBackColor = true;
            btnTrangSau.Click += btnTrangSau_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(NhaCungCap);
            groupBox1.Controls.Add(btn_capnhat);
            groupBox1.Controls.Add(btn_themmoi);
            groupBox1.Controls.Add(tbx_Gia);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbx_DonViTinh);
            groupBox1.Controls.Add(tbx_TenHang);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(114, 122);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1614, 354);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hàng hoá";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1059, 53);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 40);
            comboBox2.TabIndex = 14;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // NhaCungCap
            // 
            NhaCungCap.AutoSize = true;
            NhaCungCap.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            NhaCungCap.Location = new Point(838, 49);
            NhaCungCap.Margin = new Padding(5, 0, 5, 0);
            NhaCungCap.Name = "NhaCungCap";
            NhaCungCap.Size = new Size(198, 40);
            NhaCungCap.TabIndex = 13;
            NhaCungCap.Text = "Nhà cung cấp";
            // 
            // btn_capnhat
            // 
            btn_capnhat.Location = new Point(838, 257);
            btn_capnhat.Margin = new Padding(5);
            btn_capnhat.Name = "btn_capnhat";
            btn_capnhat.Size = new Size(231, 46);
            btn_capnhat.TabIndex = 12;
            btn_capnhat.Text = "Cập nhật";
            btn_capnhat.UseVisualStyleBackColor = true;
            btn_capnhat.Click += btn_capnhat_Click_1;
            // 
            // btn_themmoi
            // 
            btn_themmoi.Location = new Point(92, 266);
            btn_themmoi.Margin = new Padding(5);
            btn_themmoi.Name = "btn_themmoi";
            btn_themmoi.Size = new Size(231, 46);
            btn_themmoi.TabIndex = 11;
            btn_themmoi.Text = "Thêm mới";
            btn_themmoi.UseVisualStyleBackColor = true;
            btn_themmoi.Click += btn_themmoi_Click_1;
            // 
            // tbx_Gia
            // 
            tbx_Gia.Location = new Point(1001, 154);
            tbx_Gia.Margin = new Padding(5);
            tbx_Gia.Name = "tbx_Gia";
            tbx_Gia.Size = new Size(435, 39);
            tbx_Gia.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label5.Location = new Point(860, 160);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 40);
            label5.TabIndex = 7;
            label5.Text = "Giá";
            // 
            // tbx_DonViTinh
            // 
            tbx_DonViTinh.Location = new Point(218, 154);
            tbx_DonViTinh.Margin = new Padding(5);
            tbx_DonViTinh.Name = "tbx_DonViTinh";
            tbx_DonViTinh.Size = new Size(457, 39);
            tbx_DonViTinh.TabIndex = 4;
            // 
            // tbx_TenHang
            // 
            tbx_TenHang.Location = new Point(218, 56);
            tbx_TenHang.Margin = new Padding(5);
            tbx_TenHang.Name = "tbx_TenHang";
            tbx_TenHang.Size = new Size(457, 39);
            tbx_TenHang.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(51, 153);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 40);
            label3.TabIndex = 1;
            label3.Text = "Đơn vị tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(80, 53);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 40);
            label2.TabIndex = 0;
            label2.Text = "Tên Hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(743, 57);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(283, 45);
            label1.TabIndex = 27;
            label1.Text = "Quản lý hàng hoá";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, tệpToolStripMenuItem, nhậpXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2027, 40);
            menuStrip1.TabIndex = 43;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnTrangTruoc
            // 
            btnTrangTruoc.Location = new Point(550, 1160);
            btnTrangTruoc.Name = "btnTrangTruoc";
            btnTrangTruoc.Size = new Size(150, 46);
            btnTrangTruoc.TabIndex = 32;
            btnTrangTruoc.Text = "Trang Trước";
            btnTrangTruoc.UseVisualStyleBackColor = true;
            btnTrangTruoc.Click += btnTrangTruoc_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label7.Location = new Point(168, 1160);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(126, 40);
            label7.TabIndex = 31;
            label7.Text = "Số dòng";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(114, 628);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1614, 471);
            dataGridView1.TabIndex = 29;
            // 
            // HangHoa
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2027, 1344);
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
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(btnTrangTruoc);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Name = "HangHoa";
            Text = "HangHoa";
            Load += HangHoa_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem nhậpHàngToolStripMenuItem;
        private Button button1;
        private Button btnSearch;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private TextBox txtTimKiem;
        private ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private ToolStripMenuItem hàngHoáToolStripMenuItem;
        private ToolStripMenuItem nhậpXuấtToolStripMenuItem;
        private ToolStripMenuItem xuấtHàngToolStripMenuItem;
        private Label label10;
        private Label label9;
        private ComboBox comboBoxCot;
        private ComboBox comboBoxSapXep;
        private Label label8;
        private ComboBox comboBox1;
        private Label lbSoTrang;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private Button btnTrangSau;
        private GroupBox groupBox1;
        private Button btn_capnhat;
        private Button btn_themmoi;
        private TextBox tbx_Gia;
        private Label label5;
        private TextBox tbx_DonViTinh;
        private TextBox tbx_TenHang;
        private Label label3;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private Button btnTrangTruoc;
        private Label label7;
        private DataGridView dataGridView1;
        private Label NhaCungCap;
        private ComboBox comboBox2;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
    }
}