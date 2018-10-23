using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace QuanLy
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLOGIN_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-762C5QE\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = BOX_USER.Text;
                string mk = BOX_PASSWORD.Text;
                string sql = "select * from ID where ID ='" + tk + "' and PASS='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
            
                if (dta.Read()==true)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormNVIEN f2 = new FormNVIEN();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void BtnEXIT_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = (MessageBox.Show("Bạn có muốn thoát?", "Chú ý",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (ThongBao == DialogResult.Yes)
                Application.Exit();
        }
    }
}
