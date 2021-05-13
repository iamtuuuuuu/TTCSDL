using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class CSDL
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Quản lý trung tâm học thêm;Trusted_Connection=Yes;";
        private SqlConnection conn;

        //private string sql;
        private DataTable dt;
        private SqlCommand cmd;
        public CSDL()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                //conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connected Failed: " + ex.Message);
            }

        }
        public DataTable SelectData(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)

            {
                MessageBox.Show("Data Loading ERROR: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading Error: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public int ExeCute(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                foreach (var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error: " + ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }

        public Boolean deleteLH(String id)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sql = "DELETE From LOPHOC where MaLH = '" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                check = true;
                conn.Close();
            }
            catch (Exception)
            {
                check = false;
                throw;
            }


            return check;
        }

        public bool del_lopHoc(string maHV, string maLop)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sql1 = "DELETE FROM HOCVIEN_LOPHOC WHERE MaHV = '" + maHV + "' AND MaLH = '" + maLop + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();
                check = true;
                conn.Close();
            }
            catch
            {
                check = false;
                throw;
            }
            return check;
        }
        public bool del_BLHocPhi(string maBL)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sql1 = "DELETE FROM BIENLAITHUHOCPHI WHERE MaBL = '" + maBL + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();
                check = true;
                conn.Close();
            }
            catch
            {
                check = false;
                throw;
            }
            return check;
        }
        public bool del_dataGV(string magv)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sql = "DELETE From GIAOVIEN where MaGV = '" + magv + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                check = true;
                conn.Close();
            }
            catch (Exception)
            {
                check = false;
                throw;
            }


            return check;
        }
    }
}
