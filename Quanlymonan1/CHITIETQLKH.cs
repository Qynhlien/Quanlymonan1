using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Quanlymonan1
{
    public partial class CHITIETQLKH : Form
    {
        private BUS_QLKH bus = new BUS_QLKH();
        private int idKhachHangReceived;

        public CHITIETQLKH(int idKhachHang)
        {
            InitializeComponent();
            dataGridViewChiTiet.DataError += DataGridView1_DataError;
            this.idKhachHangReceived = idKhachHang;

            // Thêm sự kiện CellClick cho DataGridView
            dataGridViewChiTiet.CellClick += dataGridViewChiTiet_CellClick;
        }

        private void CHITIETQLKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLYBANHANGDataSet.Chitietdonhang' table. You can move, or remove it, as needed.
            dataGridViewChiTiet.DataSource = bus.LayThongTinKhachHang(idKhachHangReceived);

            // Xóa các mục hiện có trong ComboBox trước khi thêm dữ liệu mới
            comboBox1.Items.Clear();

            // Gọi phương thức từ BUS để lấy danh sách IDKhachhang từ cơ sở dữ liệu
            DataTable dtIDKhachHang = bus.LayDanhSachKhachHang();

            // Kiểm tra xem DataTable có dữ liệu hay không trước khi đổ vào ComboBox
            if (dtIDKhachHang != null && dtIDKhachHang.Rows.Count > 0)
            {
                foreach (DataRow row in dtIDKhachHang.Rows)
                {
                    // Lấy giá trị từ cột IDKhachhang và thêm vào ComboBox
                    comboBox1.Items.Add(row["IDKhachhang"]);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu IDKhachhang.");
            }
        }

        private void dataGridViewChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị từ cột chứa IDkhachhang trong dòng được chọn
                DataGridViewRow selectedRow = dataGridViewChiTiet.Rows[e.RowIndex];
                int idDonHang;
                if (int.TryParse(selectedRow.Cells["IDDonHang"].Value.ToString(), out idDonHang))
                {
                    DGVChiTietDonHang.DataSource = bus.LayThongTinChiTietDonHang(idDonHang);
                }
                else
                {
                    // Xử lý khi không thể chuyển đổi thành công idKhachHang từ dữ liệu của cột IDKhachhang
                    MessageBox.Show("Không thể lấy ID khách hàng từ dòng được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Phương thức này không có nội dung, bạn có thể xóa nếu không cần thiết.
        }
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Handle the data error (image conversion issue) here
            MessageBox.Show($"Error in row {e.RowIndex}, column {e.ColumnIndex}: {e.Exception.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // You can also set a default value for the cell to prevent further errors
            dataGridViewChiTiet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;

            // Set the error to handled to prevent the default error dialog
            e.ThrowException = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idKhachHang = (int)comboBox1.SelectedItem;
            dataGridViewChiTiet.DataSource = bus.LayThongTinKhachHang(idKhachHang);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Khởi động Form QLKH 
            QLKH qlkh = new QLKH();
            qlkh.Show();

            // Ẩn form hiện tại sau khi mở form mới
            this.Hide();

        }
    }

}
