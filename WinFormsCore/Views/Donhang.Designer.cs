namespace WinFormsCore.Views
{
    partial class Donhang
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            đơnHàngToolStripMenuItem = new ToolStripMenuItem();
            btnTrangSau = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            btnTrangTruoc = new Button();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            btn_capnhat = new Button();
            button3 = new Button();
            button4 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // nhậpHàngToolStripMenuItem
            // 
            nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            nhậpHàngToolStripMenuItem.Size = new Size(266, 44);
            nhậpHàngToolStripMenuItem.Text = "Nhập hàng";
            nhậpHàngToolStripMenuItem.Click += nhậpHàngToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1517, 901);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 42;
            button1.Text = "In Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1546, 261);
            btnSearch.Margin = new Padding(5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(168, 46);
            btnSearch.TabIndex = 30;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(146, 38);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(1149, 268);
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
            nhậpXuấtToolStripMenuItem.Size = new Size(149, 38);
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
            label10.Location = new Point(992, 268);
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
            label9.Location = new Point(551, 268);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(62, 40);
            label9.TabIndex = 39;
            label9.Text = "Cột";
            // 
            // comboBoxCot
            // 
            comboBoxCot.FormattingEnabled = true;
            comboBoxCot.Items.AddRange(new object[] { "Id", "OrderNumber", "TotalAmount", "CustomerName" });
            comboBoxCot.Location = new Point(653, 268);
            comboBoxCot.Name = "comboBoxCot";
            comboBoxCot.Size = new Size(218, 40);
            comboBoxCot.TabIndex = 38;
            comboBoxCot.SelectedIndexChanged += comboBoxCot_SelectedIndexChanged;
            // 
            // comboBoxSapXep
            // 
            comboBoxSapXep.FormattingEnabled = true;
            comboBoxSapXep.Items.AddRange(new object[] { "Tăng Dần", "Giảm Dần" });
            comboBoxSapXep.Location = new Point(231, 268);
            comboBoxSapXep.Name = "comboBoxSapXep";
            comboBoxSapXep.Size = new Size(206, 40);
            comboBoxSapXep.TabIndex = 37;
            comboBoxSapXep.SelectedIndexChanged += comboBoxSapXep_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label8.Location = new Point(100, 268);
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
            comboBox1.Location = new Point(288, 901);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(85, 40);
            comboBox1.TabIndex = 35;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbSoTrang
            // 
            lbSoTrang.BackColor = SystemColors.ActiveCaption;
            lbSoTrang.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lbSoTrang.Location = new Point(1297, 901);
            lbSoTrang.Margin = new Padding(5, 0, 5, 0);
            lbSoTrang.Name = "lbSoTrang";
            lbSoTrang.Size = new Size(126, 40);
            lbSoTrang.TabIndex = 34;
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ngườiDùngToolStripMenuItem, hàngHoáToolStripMenuItem, đơnHàngToolStripMenuItem });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(74, 38);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // đơnHàngToolStripMenuItem
            // 
            đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            đơnHàngToolStripMenuItem.Size = new Size(276, 44);
            đơnHàngToolStripMenuItem.Text = "Đơn Hàng";
            đơnHàngToolStripMenuItem.Click += đơnHàngToolStripMenuItem_Click;
            // 
            // btnTrangSau
            // 
            btnTrangSau.Location = new Point(906, 895);
            btnTrangSau.Name = "btnTrangSau";
            btnTrangSau.Size = new Size(150, 46);
            btnTrangSau.TabIndex = 33;
            btnTrangSau.Text = "Trang Sau";
            btnTrangSau.UseVisualStyleBackColor = true;
            btnTrangSau.Click += btnTrangSau_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(743, 6);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(325, 45);
            label1.TabIndex = 27;
            label1.Text = "Danh sách đơn hàng";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, tệpToolStripMenuItem, nhậpXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2361, 42);
            menuStrip1.TabIndex = 43;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnTrangTruoc
            // 
            btnTrangTruoc.Location = new Point(536, 895);
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
            label7.Location = new Point(154, 895);
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
            dataGridView1.Location = new Point(73, 408);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1614, 471);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_capnhat
            // 
            btn_capnhat.Location = new Point(221, 152);
            btn_capnhat.Margin = new Padding(5);
            btn_capnhat.Name = "btn_capnhat";
            btn_capnhat.Size = new Size(231, 46);
            btn_capnhat.TabIndex = 44;
            btn_capnhat.Text = "Thêm mới";
            btn_capnhat.UseVisualStyleBackColor = true;
            btn_capnhat.Click += btn_capnhat_Click;
            // 
            // button3
            // 
            button3.Location = new Point(683, 152);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(231, 46);
            button3.TabIndex = 46;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1166, 152);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(231, 46);
            button4.TabIndex = 47;
            button4.Text = "Thống kê";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(73, 953);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1594, 468);
            chart1.TabIndex = 49;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // Donhang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2361, 1579);
            Controls.Add(chart1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btn_capnhat);
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
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(btnTrangTruoc);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Name = "Donhang";
            Text = "Donhang";
            Load += Donhang_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
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
        private Label label1;
        private MenuStrip menuStrip1;
        private Button btnTrangTruoc;
        private Label label7;
        private DataGridView dataGridView1;
        private Button btn_capnhat;
        private Button button3;
        private Button button4;
        private ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}