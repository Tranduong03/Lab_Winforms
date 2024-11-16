namespace WinFormsCore.Views
{
    partial class SuaHoaDon
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
            button1 = new Button();
            lbSDT = new Label();
            lbName = new Label();
            listView1 = new ListView();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            cbbKhanhHang = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1145, 704);
            button1.Name = "button1";
            button1.Size = new Size(254, 46);
            button1.TabIndex = 55;
            button1.Text = "Lưu đơn hàng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbSDT
            // 
            lbSDT.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lbSDT.Location = new Point(711, 92);
            lbSDT.Margin = new Padding(5, 0, 5, 0);
            lbSDT.Name = "lbSDT";
            lbSDT.Size = new Size(636, 40);
            lbSDT.TabIndex = 54;
            lbSDT.Text = "SDT";
            // 
            // lbName
            // 
            lbName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lbName.Location = new Point(711, 40);
            lbName.Margin = new Padding(5, 0, 5, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(748, 40);
            lbName.TabIndex = 53;
            lbName.Text = "Khách Hàng";
            // 
            // listView1
            // 
            listView1.Location = new Point(711, 184);
            listView1.Name = "listView1";
            listView1.Size = new Size(688, 482);
            listView1.TabIndex = 52;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(644, 477);
            dataGridView1.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(711, 142);
            label2.Name = "label2";
            label2.Size = new Size(214, 32);
            label2.TabIndex = 50;
            label2.Text = "Sản phẩm đã chọn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 115);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 49;
            label1.Text = "Danh sách sản phẩm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label8.Location = new Point(23, 37);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(176, 40);
            label8.TabIndex = 48;
            label8.Text = "Khách Hàng";
            // 
            // cbbKhanhHang
            // 
            cbbKhanhHang.FormattingEnabled = true;
            cbbKhanhHang.Location = new Point(219, 40);
            cbbKhanhHang.Name = "cbbKhanhHang";
            cbbKhanhHang.Size = new Size(313, 40);
            cbbKhanhHang.TabIndex = 47;
            // 
            // SuaHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 931);
            Controls.Add(button1);
            Controls.Add(lbSDT);
            Controls.Add(lbName);
            Controls.Add(listView1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(cbbKhanhHang);
            Name = "SuaHoaDon";
            Text = "SuaHoaDon";
            Load += SuaHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lbSDT;
        private Label lbName;
        private ListView listView1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Label label8;
        private ComboBox cbbKhanhHang;
    }
}