using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmluong : Form
    {
        Clsdatabase cls = new Clsdatabase();
        DataSet ds1 = new DataSet();
        public frmluong()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmluong_Load(object sender, EventArgs e)
        {
            dateTimePicker6.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker2.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker3.CustomFormat = " MM / dd / yyyy ";
            DataSet ds1 = new DataSet();
            cls.loaddatagridview(dataGridView1, "select * from TblBangLuongCTy");
            cls.loaddatagridview1(dg2, ds1, "select * from TblTangLuong");
            cls.loadcombobox(comboBox1, "select * from TblTTNVCoBan", 2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = e.RowIndex;
            txt1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txt6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txt7.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            txt8.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            dateTimePicker3.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
            txt9.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            //MessageBox.Show(dg2.Rows[i].Cells[0].Value.ToString());

            comboBox1.Text = dg2.Rows[i].Cells[0].Value.ToString();
            txt10.Text = dg2.Rows[i].Cells[1].Value.ToString();
            txt11.Text = dg2.Rows[i].Cells[2].Value.ToString();
            txt12.Text = dg2.Rows[i].Cells[3].Value.ToString();
            txt13.Text = dg2.Rows[i].Cells[4].Value.ToString();
            txt14.Text = dg2.Rows[i].Cells[5].Value.ToString();
            txt15.Text = dg2.Rows[i].Cells[6].Value.ToString();
            txt16.Text = dg2.Rows[i].Cells[7].Value.ToString();
            txt17.Text = dg2.Rows[i].Cells[8].Value.ToString();
            dateTimePicker6.Text = dg2.Rows[i].Cells[9].Value.ToString();
            txt18.Text = dg2.Rows[i].Cells[10].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblBangLuongCTy values(N'" + txt1.Text + "',N'" + txt2.Text + "',N'" + txt3.Text + "',N'" + txt4.Text + "',N'" + txt5.Text + "',N'" + dateTimePicker1.Text + "',N'" + txt6.Text + "',N'" + dateTimePicker2.Text + "',N'" + txt7.Text + "',N'" + txt8.Text + "',N'" + dateTimePicker3.Text + "',N'" + txt9.Text + "')";
                if (!cls.kttrungkhoa(txt1.Text, "select MaLuong from TblBangLuongCTy"))
                {
                    if (txt1.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        cls.loaddatagridview(dataGridView1, "select * from TblBangLuongCTy");
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã Lương");
                }
                else
                    MessageBox.Show("Mã Lương này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblBangLuongCTy set ChucVu=N'" + txt2.Text + "',ChucDanh=N'" + txt3.Text + "',LCB=N'" + txt4.Text + "',PCChucVu=N'" + txt5.Text + "',NgayNhap='" + dateTimePicker1.Text + "',LCBMoi=N'" + txt6.Text + "',NgaySua=N'" + dateTimePicker2.Text + "',LyDo=N'" + txt7.Text + "',PCCVuMoi='" + txt8.Text + "',NgaySuaPC=N'" + dateTimePicker3.Text + "',GhiChu=N'" + txt9.Text + "' where MaLuong=N'" + txt1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from TblBangLuongCTy");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblBangLuongCTy where MaLuong=N'" + txt1.Text + "'";
            string delete1 = "delete from TblSoBH where MaLuong=N'" + txt1.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete1);
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dataGridView1, "select * from TblBangLuongCTy");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox4.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblTangLuong values(N'"+comboBox1.Text+"',N'" + txt10.Text + "',N'" + txt11.Text + "',N'" + txt12.Text + "',N'" + txt13.Text + "',N'" + txt14.Text + "',N'" + txt15.Text + "',N'" + txt16.Text + "',N'" + txt17.Text + "',N'" + dateTimePicker6.Text + "',N'" + txt18.Text + "'";
                if (!cls.kttrungkhoa(comboBox1.Text, "select MaNV from TblTangLuong"))
                {
                    if (txt1.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        cls.loaddatagridview(dg2, "select * from TblTangLuong");
                    }
                    else MessageBox.Show("Bạn chưa chọn mà nhân viên");
                }
                else
                    MessageBox.Show("Nhân viên này bạn đã nhập dữ liêu rồi", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                
                string update = "update TblTangLuong set HoTen=N'" + txt10.Text + "',GioiTinh=N'" + txt11.Text + "',ChucVu=N'" + txt12.Text + "',ChucDanh=N'" + txt13.Text + "',LCBCu='" + txt14.Text + "',LCBMoi=N'" + txt15.Text + "',PCapCu=N'" + txt16.Text + "',PCapMoi=N'" + txt17.Text + "',NgayTang='" + dateTimePicker6.Text + "',LyDo=N'" + txt18.Text + "' where MaNV=N'" + comboBox1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dg2, ds1, "select * from TblTangLuong");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextbox(txt10, "select HoTen from TblTangLuong where MaNV='" + comboBox1.Text + "'");
            cls.loadtextbox(txt11, "select GioiTinh from TblTangLuong where MaNV='" + comboBox1.Text + "'");
            cls.loadtextbox(txt12, "select ChucVu from TblTangLuong where MaNV='" + comboBox1.Text + "'");
            cls.loadtextbox(txt13, "select ChucDanh from TblTangLuong where MaNV='" + comboBox1.Text + "'");
            cls.loadtextbox(txt14, "select LCBCu from TblTangLuong where MaNV='" + comboBox1.Text + "'");
            cls.loadtextbox(txt15, "select LCBMoi from TblTangLuong where MaNV='" + comboBox1.Text + "'");
            cls.loadtextbox(txt16, "select PCapCu from TblTangLuong where MaNV='" + comboBox1.Text + "'");
            cls.loadtextbox(txt17, "select PCapMoi from TblTangLuong where MaNV='" + comboBox1.Text + "'");
            cls.loadtextbox(txt18, "select LyDo from TblTangLuong where MaNV='" + comboBox1.Text + "'");
            cls.loaddatetime(dateTimePicker6, "select NgayTang from TblTangLuong where MaNV='" + comboBox1.Text + "'", 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            string delete = "delete from TblTangLuong where MaNV=N'" + comboBox1.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview1(dg2, ds1, "select * from TblTangLuong");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            
                string insert = "insert into TblTangLuong values(N'" + comboBox1.Text + "',N'" + txt10.Text + "',N'" + txt11.Text + "',N'" + txt12.Text + "',N'" + txt13.Text + "',N'" + txt14.Text + "',N'" + txt15.Text + "',N'" + txt16.Text + "',N'" + txt17.Text + "',N'" + dateTimePicker6.Text + "',N'" + txt18.Text + "')";
                if (!cls.kttrungkhoa(comboBox1.Text, "select MaNV from TblTangLuong"))
                {
                    if (comboBox1.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dg2.Refresh();
                        cls.loaddatagridview1(dg2, ds1, "select * from TblTangLuong");
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                }
                else
                    MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //catch
            //{
            //    MessageBox.Show("Dữ liệu đầu vào không đúng");
            //}
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }
    }
}
