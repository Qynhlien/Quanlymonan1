
namespace Quanlymonan1
{
    partial class CHITIETQLKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewChiTiet = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.qLYBANHANGDataSet = new Quanlymonan1.QLYBANHANGDataSet();
            this.DGVChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLYBANHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVChiTietDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 1056);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Image = global::Quanlymonan1.Properties.Resources.BaosFood1;
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 79);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(320, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trang/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(376, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(465, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tài khoản khách hàng";
            // 
            // dataGridViewChiTiet
            // 
            this.dataGridViewChiTiet.AllowUserToOrderColumns = true;
            this.dataGridViewChiTiet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTiet.Location = new System.Drawing.Point(316, 122);
            this.dataGridViewChiTiet.Name = "dataGridViewChiTiet";
            this.dataGridViewChiTiet.RowHeadersWidth = 51;
            this.dataGridViewChiTiet.RowTemplate.Height = 24;
            this.dataGridViewChiTiet.Size = new System.Drawing.Size(882, 216);
            this.dataGridViewChiTiet.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(317, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tài khoản khách hàng";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DisplayMember = "HoTen";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(945, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 27);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "IDKhachHang";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(1098, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Detail";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(1098, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "QLKH";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // qLYBANHANGDataSet
            // 
            this.qLYBANHANGDataSet.DataSetName = "QLYBANHANGDataSet";
            this.qLYBANHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DGVChiTietDonHang
            // 
            this.DGVChiTietDonHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGVChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVChiTietDonHang.Location = new System.Drawing.Point(317, 361);
            this.DGVChiTietDonHang.Name = "DGVChiTietDonHang";
            this.DGVChiTietDonHang.RowHeadersWidth = 51;
            this.DGVChiTietDonHang.RowTemplate.Height = 24;
            this.DGVChiTietDonHang.Size = new System.Drawing.Size(880, 242);
            this.DGVChiTietDonHang.TabIndex = 10;
            // 
            // CHITIETQLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 1055);
            this.Controls.Add(this.DGVChiTietDonHang);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewChiTiet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "CHITIETQLKH";
            this.Text = "CHITIETQLKH";
            this.Load += new System.EventHandler(this.CHITIETQLKH_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLYBANHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVChiTietDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewChiTiet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private QLYBANHANGDataSet qLYBANHANGDataSet;
        private System.Windows.Forms.DataGridView DGVChiTietDonHang;
    }
}