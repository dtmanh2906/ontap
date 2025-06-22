namespace DinhTienManh_Ontap5
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTenBaiHat = new TextBox();
            txtCaSiTrinhBay = new TextBox();
            txtThoiLuong = new TextBox();
            dtpNgayTrinhBay = new DateTimePicker();
            cboDiaDiem = new ComboBox();
            btnSua = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(739, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 191);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Ten bai hat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 221);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Ca si trinh bay";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 250);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 3;
            label3.Text = "ngay trinh bay";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 191);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 4;
            label4.Text = "Dia diem";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 224);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 5;
            label5.Text = "Thoi luong";
            // 
            // txtTenBaiHat
            // 
            txtTenBaiHat.Location = new Point(118, 188);
            txtTenBaiHat.Name = "txtTenBaiHat";
            txtTenBaiHat.Size = new Size(100, 23);
            txtTenBaiHat.TabIndex = 6;
            // 
            // txtCaSiTrinhBay
            // 
            txtCaSiTrinhBay.Location = new Point(118, 221);
            txtCaSiTrinhBay.Name = "txtCaSiTrinhBay";
            txtCaSiTrinhBay.Size = new Size(100, 23);
            txtCaSiTrinhBay.TabIndex = 7;
            // 
            // txtThoiLuong
            // 
            txtThoiLuong.Location = new Point(443, 221);
            txtThoiLuong.Name = "txtThoiLuong";
            txtThoiLuong.Size = new Size(100, 23);
            txtThoiLuong.TabIndex = 8;
            // 
            // dtpNgayTrinhBay
            // 
            dtpNgayTrinhBay.Location = new Point(113, 250);
            dtpNgayTrinhBay.Name = "dtpNgayTrinhBay";
            dtpNgayTrinhBay.Size = new Size(200, 23);
            dtpNgayTrinhBay.TabIndex = 9;
            // 
            // cboDiaDiem
            // 
            cboDiaDiem.FormattingEnabled = true;
            cboDiaDiem.Items.AddRange(new object[] { "Ha Noi", "TP HCM", "Da Nang" });
            cboDiaDiem.Location = new Point(443, 183);
            cboDiaDiem.Name = "cboDiaDiem";
            cboDiaDiem.Size = new Size(121, 23);
            cboDiaDiem.TabIndex = 10;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(588, 224);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(588, 187);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tim kiem";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(588, 253);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(443, 253);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 14;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 288);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnTimKiem);
            Controls.Add(btnSua);
            Controls.Add(cboDiaDiem);
            Controls.Add(dtpNgayTrinhBay);
            Controls.Add(txtThoiLuong);
            Controls.Add(txtCaSiTrinhBay);
            Controls.Add(txtTenBaiHat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTenBaiHat;
        private TextBox txtCaSiTrinhBay;
        private TextBox txtThoiLuong;
        private DateTimePicker dtpNgayTrinhBay;
        private ComboBox cboDiaDiem;
        private Button btnSua;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnThem;
    }
}
