namespace WinFormsCore.Views
{
    partial class FormChiTietHoaDon
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
            dataGridView1 = new DataGridView();
            Tien = new Label();
            lbDiaChi = new Label();
            lbSDT = new Label();
            lbHoTen = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1125, 300);
            dataGridView1.TabIndex = 0;
            // 
            // Tien
            // 
            Tien.Location = new Point(553, 434);
            Tien.Name = "Tien";
            Tien.Size = new Size(313, 64);
            Tien.TabIndex = 1;
            Tien.Text = "Tổng Tiền";
            // 
            // lbDiaChi
            // 
            lbDiaChi.Location = new Point(437, 9);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(453, 64);
            lbDiaChi.TabIndex = 2;
            lbDiaChi.Text = "Address: ";
            // 
            // lbSDT
            // 
            lbSDT.Location = new Point(12, 55);
            lbSDT.Name = "lbSDT";
            lbSDT.Size = new Size(432, 64);
            lbSDT.TabIndex = 3;
            lbSDT.Text = "Phone: ";
            // 
            // lbHoTen
            // 
            lbHoTen.Location = new Point(12, 9);
            lbHoTen.Name = "lbHoTen";
            lbHoTen.Size = new Size(194, 46);
            lbHoTen.TabIndex = 4;
            lbHoTen.Text = "Name: ";
            // 
            // FormChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 556);
            Controls.Add(lbHoTen);
            Controls.Add(lbSDT);
            Controls.Add(lbDiaChi);
            Controls.Add(Tien);
            Controls.Add(dataGridView1);
            Name = "FormChiTietHoaDon";
            Text = "FormChiTietHoaDon";
            Load += FormChiTietHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label Tien;
        private Label lbDiaChi;
        private Label lbSDT;
        private Label lbHoTen;
    }
}