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
    public partial class QLKH : Form
    {
        private BUS_QLKH bus = new BUS_QLKH();
        public QLKH()
        {
           
            InitializeComponent();
            dataGridView1.DataError += DataGridView1_DataError;


            // Thêm sự kiện CellClick cho DataGridView
            dataGridView1.CellClick += DataGridView1_CellClick;
        }
        
        private void QLKH_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.LayDanhSachKhachHang();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Handle the data error (image conversion issue) here
            MessageBox.Show($"Error in row {e.RowIndex}, column {e.ColumnIndex}: {e.Exception.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // You can also set a default value for the cell to prevent further errors
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;

            // Set the error to handled to prevent the default error dialog
            e.ThrowException = false;
        }

        // Phương thức xử lý sự kiện CellClick
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Lấy giá trị từ cột chứa IDkhachhang trong dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int idKhachHang;
                if (int.TryParse(selectedRow.Cells["IDkhachhang"].Value.ToString(), out idKhachHang))
                {
                    // Tạo thể hiện mới của form CHITIETQLKH và truyền idKhachHang qua constructor hoặc property
                    CHITIETQLKH chitietkhachhang = new CHITIETQLKH(idKhachHang);
                    chitietkhachhang.Show();

                    // Ẩn form hiện tại sau khi mở form mới
                    this.Hide();
                }
                else
                {
                    // Xử lý khi không thể chuyển đổi thành công idKhachHang từ dữ liệu của cột IDkhachhang
                    MessageBox.Show("Không thể lấy ID khách hàng từ dòng được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       private void button2_Click(object sender, EventArgs e)
        {

        }
 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            dataGridView1.DataSource = bus.TimKiemKhachHang(searchText);
        }
        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.AliceBlue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
        }
    }
    }

