using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_QLKH
    {
        private string connectionString = "Data Source=.;Initial Catalog=QLYBANHANG;Integrated Security=True";

        public DataTable GetThongTinKhachHang()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT DH.IDKhachhang, TTKH.HoTen AS HoTenKhachHang, TTKH.Diachi AS DiaChiKhachHang, SUM(DH.Tongdonhang) AS TongDonHangKhachHang FROM DonHang DH JOIN ThongtinKhachHang TTKH ON DH.IDKhachhang = TTKH.IDKhachHang GROUP BY DH.IDKhachhang, TTKH.HoTen, TTKH.Diachi", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable LayThongTinKhachHang(int idKhachHang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT TKH.IDKhachHang, TKH.HoTen, TKH.Diachi, DH.IDDonHang, DH.Ngatdathang, DH.Trangthaidonhang, DH.Ngaygiaohang, DH.Tongdonhang FROM ThongtinKhachHang TKH JOIN DonHang DH ON TKH.IDKhachHang = DH.IDKhachhang WHERE TKH.IDKhachHang = @id;", connection);
                cmd.Parameters.AddWithValue("@id",idKhachHang);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable LayThongTinChiTietDonHang(int idDonHang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Chitietdonhang.*, MonAn.Tenmonan, MonAn.Gia FROM Chitietdonhang INNER JOIN MonAn ON Chitietdonhang.IDMonAn = MonAn.IDMonAn WHERE Chitietdonhang.IDDonHang = @id;", connection);
                cmd.Parameters.AddWithValue("@id", idDonHang);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable TimKiemKhachHang(string searchText)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT DH.IDKhachhang, TTKH.HoTen AS HoTenKhachHang, TTKH.Diachi AS DiaChiKhachHang, SUM(DH.Tongdonhang) AS TongDonHangKhachHang FROM DonHang DH JOIN ThongtinKhachHang TTKH ON DH.IDKhachhang = TTKH.IDKhachHang WHERE TTKH.HoTen LIKE @SearchText OR TTKH.Diachi LIKE @SearchText GROUP BY DH.IDKhachhang, TTKH.HoTen, TTKH.Diachi", connection);
                cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

    }
}
