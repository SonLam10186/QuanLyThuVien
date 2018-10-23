using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLy
{
    class ClassQuanLy
    {
        public SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-762C5QE\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
        
        public DataTable taobang(string sql)
        {
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, cnn);
            ds.Fill(dt);
            return (dt);
        }
    }
}
