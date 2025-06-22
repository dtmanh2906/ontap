using DinhTienManh_Ontap5.model;


namespace DinhTienManh_Ontap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int selected = 0;
        private void LoadData()
        {
            using (var db = new DataContext())
            {
                dataGridView1.DataSource = db.TrinhBayBaiHats.ToList();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                int tk = int.Parse(txtThoiLuong.Text);
                var result = db.TrinhBayBaiHats.Where(p => p.DiaDiem == "Ha Noi" && p.ThoiLuong > tk).ToList();
                dataGridView1.DataSource = result;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                selected = Convert.ToInt32(row.Cells["MaTrinhBay"].Value.ToString());
                txtTenBaiHat.Text = row.Cells["TenBaiHat"].Value.ToString();
                txtCaSiTrinhBay.Text = row.Cells["CaSiTrinhBay"].Value.ToString();
                dtpNgayTrinhBay.Value = Convert.ToDateTime(row.Cells["NgayTrinhBay"].Value);
                cboDiaDiem.SelectedItem = row.Cells["DiaDiem"].Value.ToString();
                txtThoiLuong.Text = row.Cells["ThoiLuong"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var bh = db.TrinhBayBaiHats.Find(selected);
                if (bh != null)
                {
                    bh.TenBaiHat = txtTenBaiHat.Text;
                    bh.CaSiTrinhBay = txtCaSiTrinhBay.Text;
                    bh.NgayTrinhBay = dtpNgayTrinhBay.Value;
                    bh.DiaDiem = cboDiaDiem.Text;
                    bh.ThoiLuong = int.Parse(txtThoiLuong.Text);

                    db.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var bh = db.TrinhBayBaiHats.Find(selected);
                var rs = MessageBox.Show("Ban co chac chan muon xoa", "xac nhan", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    db.TrinhBayBaiHats.Remove(bh);
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("xoa thanh cong");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using(var db = new DataContext())
            {
                var bh = new TrinhBayBaiHat
                {
                TenBaiHat=txtTenBaiHat.Text,
                CaSiTrinhBay=txtCaSiTrinhBay.Text,
                NgayTrinhBay = dtpNgayTrinhBay.Value,
                DiaDiem= cboDiaDiem.SelectedItem.ToString(),
                ThoiLuong=int.Parse(txtThoiLuong.Text)
                };

                db.TrinhBayBaiHats.Add(bh);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("them thanh cong"); 
                    
            }
        }
    }
}
