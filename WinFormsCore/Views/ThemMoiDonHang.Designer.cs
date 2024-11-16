namespace WinFormsCore.Views
{
    partial class ThemMoiDonHang
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
            cbbKhanhHang = new ComboBox();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            listView1 = new ListView();
            lbName = new Label();
            lbSDT = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbbKhanhHang
            // 
            cbbKhanhHang.FormattingEnabled = true;
            cbbKhanhHang.Location = new Point(211, 29);
            cbbKhanhHang.Name = "cbbKhanhHang";
            cbbKhanhHang.Size = new Size(313, 40);
            cbbKhanhHang.TabIndex = 0;
            cbbKhanhHang.SelectedIndexChanged += cbbKhanhHang_SelectedIndexChanged_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label8.Location = new Point(27, 26);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(176, 40);
            label8.TabIndex = 37;
            label8.Text = "Khách Hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 116);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 39;
            label1.Text = "Danh sách sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(822, 126);
            label2.Name = "label2";
            label2.Size = new Size(214, 32);
            label2.TabIndex = 41;
            label2.Text = "Sản phẩm đã chọn";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(679, 477);
            dataGridView1.TabIndex = 42;
            // 
            // listView1
            // 
            listView1.Location = new Point(822, 161);
            listView1.Name = "listView1";
            listView1.Size = new Size(698, 482);
            listView1.TabIndex = 43;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbName
            // 
            lbName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lbName.Location = new Point(750, 26);
            lbName.Margin = new Padding(5, 0, 5, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(748, 40);
            lbName.TabIndex = 44;
            lbName.Text = "Khách Hàng";
            // 
            // lbSDT
            // 
            lbSDT.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lbSDT.Location = new Point(750, 77);
            lbSDT.Margin = new Padding(5, 0, 5, 0);
            lbSDT.Name = "lbSDT";
            lbSDT.Size = new Size(636, 40);
            lbSDT.TabIndex = 45;
            lbSDT.Text = "SDT";
            // 
            // button1
            // 
            button1.Location = new Point(844, 696);
            button1.Name = "button1";
            button1.Size = new Size(254, 46);
            button1.TabIndex = 46;
            button1.Text = "Lưu đơn hàng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ThemMoiDonHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 929);
            Controls.Add(button1);
            Controls.Add(lbSDT);
            Controls.Add(lbName);
            Controls.Add(listView1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(cbbKhanhHang);
            Name = "ThemMoiDonHang";
            Text = "ThemMoiDonHang";
            Load += ThemMoiDonHang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbKhanhHang;
        private Label label8;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private ListView listView1;
        private Label lbName;
        private Label lbSDT;
        private Button button1;
    }
}