using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_QLKH
    {
        private DAL_QLKH dal = new DAL_QLKH();

        public DataTable LayDanhSachKhachHang()
        {
            return dal.GetThongTinKhachHang();
        }
        public DataTable TimKiemKhachHang(string searchText)
        {
            return dal.TimKiemKhachHang(searchText);
        }
        public DataTable LayThongTinKhachHang(int idKhachHang)
        {
            return dal.LayThongTinKhachHang(idKhachHang);
        }

        public DataTable LayThongTinChiTietDonHang(int idDonHang)
        {
            return dal.LayThongTinChiTietDonHang(idDonHang);
        }
    }
}
