using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace QuanLy
{
    public partial class FormNVIEN : Form
    {
        public FormNVIEN()
        {
            InitializeComponent();
        }

        private void FormNVIEN_Load(object sender, EventArgs e)
        {
            ClassQuanLy kn = new ClassQuanLy();
            string sql = "select*from NVIEN";
            dataGridViewNVIEN.DataSource = kn.taobang(sql);

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void dataGridViewNVIEN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            Box_Manv.Text = dataGridViewNVIEN.Rows[dong].Cells[0].Value.ToString();
            Box_Hoten.Text = dataGridViewNVIEN.Rows[dong].Cells[1].Value.ToString();
            Box_Diachi.Text = dataGridViewNVIEN.Rows[dong].Cells[2].Value.ToString();
            Box_Ngaysinh.Text = dataGridViewNVIEN.Rows[dong].Cells[3].Value.ToString();
            Box_Dienthoai.Text = dataGridViewNVIEN.Rows[dong].Cells[4].Value.ToString();
            Box_Chucvu.Text = dataGridViewNVIEN.Rows[dong].Cells[5].Value.ToString();
            Box_Bophan.Text = dataGridViewNVIEN.Rows[dong].Cells[6].Value.ToString();
            Box_Bangcap.Text = dataGridViewNVIEN.Rows[dong].Cells[7].Value.ToString();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int flag;

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-762C5QE\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            con.Open();
              try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = System.String.Concat("Delete From NVIEN" +
                    "Where MANV='" + Box_Manv.Text.ToString() + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                Box_Manv.ResetText();
                Box_Hoten.ResetText();
                Box_Dienthoai.ResetText();
                Box_Ngaysinh.ResetText();
                Box_Diachi.ResetText();
                Box_Chucvu.ResetText();
                Box_Bophan.ResetText();
                Box_Bangcap.ResetText();
                Box_Manv.Focus();

                FormNVIEN_Load(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn dữ liệu xóa");

            }
            con.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            Box_Diachi.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Box_Diachi.ResetText();
            Box_Manv.ResetText();
            Box_Dienthoai.ResetText();
            Box_Ngaysinh.ResetText();
            Box_Hoten.ResetText();
            Box_Chucvu.ResetText();
            Box_Bophan.ResetText();
            Box_Bangcap.ResetText();

            Box_Diachi.Focus();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0) //Thêm
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-762C5QE\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("Insert into NVIEN Values('" + Box_Manv.Text.ToString() + "'," +
                        "'" + Box_Hoten.Text.ToString() + "'," +
                        "'" + Box_Diachi.Text.ToString() + "'," +
                        "'" + Box_Ngaysinh.Text.ToString() + "'," +
                        "'" + Box_Dienthoai.Text.ToString() + "'," +
                        "'" + Box_Bangcap.Text.ToString() + "'," +
                        "'" + Box_Bophan.Text.ToString() + "', " +
                        "'" + Box_Chucvu.Text.ToString() + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    Box_Diachi.ResetText();
                    Box_Manv.ResetText();
                    Box_Dienthoai.ResetText();
                    Box_Ngaysinh.ResetText();
                    Box_Hoten.ResetText();
                    Box_Chucvu.ResetText();
                    Box_Bophan.ResetText();
                    Box_Bangcap.ResetText();

                    Box_Diachi.Focus();

                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    FormNVIEN_Load(sender, e);

                }
                catch (Exception)
                {
                    MessageBox.Show("Mã NV đã có, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            else if (flag == 1) // Sửa
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-762C5QE\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
                con.Open();


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = System.String.Concat("Update NVIEN Set HOTEN = '" + Box_Hoten.Text.ToString() + "'," +
                    "DIACHI ='" + Box_Diachi.Text.ToString() + "'," +
                    "NGSINH ='" + Box_Ngaysinh.Text.ToString() + "'," +
                    "DIENTHOAI = '" + Box_Dienthoai.Text.ToString() + "'," +
                    "BANGCAP = '" + Box_Bangcap.Text.ToString() + "'," +
                    "BOPHAN = '" + Box_Bophan.Text.ToString() + "'," +
                    "CHUCVU ='" + Box_Chucvu.Text.ToString() + "'" +
                    "WHERE MANV='" + Box_Manv.Text.ToString() + "'");

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                Box_Diachi.ResetText();
                Box_Manv.ResetText();
                Box_Dienthoai.ResetText();
                Box_Ngaysinh.ResetText();
                Box_Hoten.ResetText();
                Box_Chucvu.ResetText();
                Box_Bophan.ResetText();
                Box_Bangcap.ResetText();

                Box_Diachi.Focus();

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                FormNVIEN_Load(sender, e);
                con.Close();

            }
        }
    } 
}
