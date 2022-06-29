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
    public partial class frmbangcong : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmbangcong()
        {
            InitializeComponent();
        }
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();
        DataSet ds5 = new DataSet();
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void frmbangcong_Load(object sender, EventArgs e)
        {
            
            //DateTime dt1, dt2;
            //dt1 = new DateTime(2009, 5, 10);
            //dt2 = new DateTime(2009, 10, 10);


            cls.loadcombobox(cb1, "select MaNV from TblHoSoThuViec", 0);
            cls.loadcombobox(cb2, "select MaNV from TblTTNVCoBan", 0);
            cls.loadcombobox(cb3, "select MaNV from TblTTNVCoBan", 0);
            cls.loadcombobox(cb4, "select MaNV from TblTTNVCoBan", 0);
            cls.loadcombobox(cb5, "select MaNV from TblTTNVCoBan", 0);
            cls.loaddatagridview1(dataGridView1,ds1, "select * from TblBangCongThuViec");
            cls.loaddatagridview1(dataGridView2,ds2, "select * from TblCongKhoiDieuHanh");
            cls.loaddatagridview1(dataGridView3,ds3, "select * from TblCongKhoiSanXuat");
            cls.loaddatagridview1(dataGridView4,ds4, "select * from TblCongKhoiVanChuyen");
            cls.loaddatagridview1(dataGridView5,ds5, "select * from TblCongKhoiVanPHong");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox4.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox6.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox8.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox10.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblBangCongThuViec set TenBoPhan=N'" + txt1.Text + "',TenPhong=N'" + txt2.Text + "',LuongTViec=N'" + txt3.Text + "',Thang=N'" + txt4.Text + "',Nam='" + txt5.Text + "',SoNgayCong=N'" + txt6.Text + "',SoNgayNghi=N'" + txt7.Text + "',SoGioLamThem=N'" + txt8.Text + "',GhiChu='" + txt9.Text + "' where MaNV=N'" + cb1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView1, ds1, "select * from TblBangCongThuViec");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblCongKhoiDieuHanh set LCB=N'" + txt10.Text + "',PhuCapCVu=N'" + txt11.Text + "',PhuCapKhac=N'" + txt12.Text + "',Thang=N'" + txt13.Text + "',Nam='" + txt14.Text + "',SoNgayCongThang=N'" + txt15.Text + "',SoNgayNghi=N'" + txt16.Text + "',SoGioLamThem=N'" + txt17.Text + "',GhiChu='" + txt18.Text + "' where MaNV=N'" + cb2.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView2, ds2, "select * from TblCongKhoiDieuHanh");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblCongKhoiSanXuat set LCB=N'" + txt19.Text + "',PhuCapCVu=N'" + txt20.Text + "',Thang=N'" + txt21.Text + "',Nam='" + txt22.Text + "',SoNgayCongThang=N'" + txt23.Text + "',SoNgayNghi=N'" + txt24.Text + "',SoGioLamThem=N'" + txt25.Text + "',GhiChu='" + txt26.Text + "',MaPhong=N'" + txt27.Text + "' where MaNV=N'" + cb3.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView3, ds3, "select * from TblCongKhoiSanXuat");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblCongKhoiVanChuyen set LCB=N'" + txt28.Text + "',PhuCapCVu=N'" + txt29.Text + "',PCapKhac=N'" + txt30.Text + "',Thang=N'" + txt31.Text + "',Nam='" + txt32.Text + "',SoNgayCongThang=N'" + txt33.Text + "',SoNgayNghi=N'" + txt34.Text + "',SoGioLamThem=N'" + txt35.Text + "',GhiChu='" + txt36.Text + "' where MaNV=N'" + cb4.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView4, ds4, "select * from TblCongKhoiVanChuyen");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblCongKhoiVanPHong set LCB=N'" + txt37.Text + "',PhuCapCVu=N'" + txt38.Text + "',PhuCapKhac=N'" + txt39.Text + "',Thang=N'" + txt40.Text + "',Nam='" + txt41.Text + "',SoNgayCongThang=N'" + txt42.Text + "',SoNgayNghi=N'" + txt43.Text + "',SoGioLamThem=N'" + txt44.Text + "',GhiChu='" + txt45.Text + "' where MaNV=N'" + cb5.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView5, ds5, "select * from TblCongKhoiVanPHong");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblBangCongThuViec where MaNV=N'" + cb1.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview1(dataGridView1, ds1, "select * from TblBangCongThuViec");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblCongKhoiDieuHanh where MaNV=N'" + cb2.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview1(dataGridView2, ds2, "select * from TblCongKhoiDieuHanh");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblCongKhoiSanXuat where MaNV=N'" + cb3.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview1(dataGridView3, ds3, "select * from TblCongKhoiSanXuat");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblCongKhoiVanChuyen where MaNV=N'" + cb4.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview1(dataGridView4, ds4, "select * from TblCongKhoiVanChuyen");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblCongKhoiVanPHong where MaNV=N'" + cb5.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview1(dataGridView5, ds5, "select * from TblCongKhoiVanPHong");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txt1, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'",0);
            cls.loadtextboxchiso(txt2, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 1);
            cls.loadtextboxchiso(txt3, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 3);
            cls.loadtextboxchiso(txt4, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 4);
            cls.loadtextboxchiso(txt5, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 5);
            cls.loadtextboxchiso(txt6, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 6);
            cls.loadtextboxchiso(txt7, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 7);
            cls.loadtextboxchiso(txt8, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 8);
            cls.loadtextboxchiso(txt9, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 9); 
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txt10, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 1);
            cls.loadtextboxchiso(txt11, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 2);
            cls.loadtextboxchiso(txt12, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 3);
            cls.loadtextboxchiso(txt13, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 4);
            cls.loadtextboxchiso(txt14, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 5);
            cls.loadtextboxchiso(txt15, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 6);
            cls.loadtextboxchiso(txt16, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 7);
            cls.loadtextboxchiso(txt17, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 8);
            cls.loadtextboxchiso(txt18, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 9);
        }

        private void cb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txt19, "select * from TblCongKhoiSanXuat where MaNV='" + cb3.Text + "'", 1);
            cls.loadtextboxchiso(txt20, "select * from TblCongKhoiSanXuat where MaNV='" + cb3.Text + "'", 2);
            cls.loadtextboxchiso(txt21, "select * from TblCongKhoiSanXuat where MaNV='" + cb3.Text + "'", 3);
            cls.loadtextboxchiso(txt22, "select * from TblCongKhoiSanXuat where MaNV='" + cb3.Text + "'", 4);
            cls.loadtextboxchiso(txt23, "select * from TblCongKhoiSanXuat where MaNV='" + cb3.Text + "'", 5);
            cls.loadtextboxchiso(txt24, "select * from TblCongKhoiSanXuat where MaNV='" + cb3.Text + "'", 6);
            cls.loadtextboxchiso(txt25, "select * from TblCongKhoiSanXuat where MaNV='" + cb3.Text + "'", 7);
            cls.loadtextboxchiso(txt26, "select * from TblCongKhoiSanXuat where MaNV='" + cb3.Text + "'", 8);
            cls.loadtextboxchiso(txt27, "select * from TblCongKhoiSanXuat where MaNV='" + cb3.Text + "'", 9);

        }

        private void cb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txt28, "select * from TblCongKhoiVanChuyen where MaNV='" + cb4.Text + "'", 1);
            cls.loadtextboxchiso(txt29, "select * from TblCongKhoiVanChuyen where MaNV='" + cb4.Text + "'", 2);
            cls.loadtextboxchiso(txt30, "select * from TblCongKhoiVanChuyen where MaNV='" + cb4.Text + "'", 3);
            cls.loadtextboxchiso(txt31, "select * from TblCongKhoiVanChuyen where MaNV='" + cb4.Text + "'", 4);
            cls.loadtextboxchiso(txt32, "select * from TblCongKhoiVanChuyen where MaNV='" + cb4.Text + "'", 5);
            cls.loadtextboxchiso(txt33, "select * from TblCongKhoiVanChuyen where MaNV='" + cb4.Text + "'", 6);
            cls.loadtextboxchiso(txt34, "select * from TblCongKhoiVanChuyen where MaNV='" + cb4.Text + "'", 7);
            cls.loadtextboxchiso(txt35, "select * from TblCongKhoiVanChuyen where MaNV='" + cb4.Text + "'", 8);
            cls.loadtextboxchiso(txt36, "select * from TblCongKhoiVanChuyen where MaNV='" + cb4.Text + "'", 9);
        }

        private void cb5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txt37, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 1);
            cls.loadtextboxchiso(txt38, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 2);
            cls.loadtextboxchiso(txt39, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 3);
            cls.loadtextboxchiso(txt40, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 4);
            cls.loadtextboxchiso(txt41, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 5);
            cls.loadtextboxchiso(txt42, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 6);
            cls.loadtextboxchiso(txt43, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 7);
            cls.loadtextboxchiso(txt44, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 8);
            cls.loadtextboxchiso(txt45, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 9);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cb1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt5.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txt6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txt7.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txt8.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            txt9.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cb2.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txt10.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txt11.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txt12.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            txt13.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            txt14.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            txt15.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            txt16.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            txt17.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();
            txt18.Text = dataGridView2.Rows[i].Cells[9].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cb3.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
            txt19.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
            txt20.Text = dataGridView3.Rows[i].Cells[2].Value.ToString();
            txt21.Text = dataGridView3.Rows[i].Cells[3].Value.ToString();
            txt22.Text = dataGridView3.Rows[i].Cells[4].Value.ToString();
            txt23.Text = dataGridView3.Rows[i].Cells[5].Value.ToString();
            txt24.Text = dataGridView3.Rows[i].Cells[6].Value.ToString();
            txt25.Text = dataGridView3.Rows[i].Cells[7].Value.ToString();
            txt26.Text = dataGridView3.Rows[i].Cells[8].Value.ToString();
            txt27.Text = dataGridView3.Rows[i].Cells[9].Value.ToString();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cb4.Text = dataGridView4.Rows[i].Cells[0].Value.ToString();
            txt28.Text = dataGridView4.Rows[i].Cells[1].Value.ToString();
            txt29.Text = dataGridView4.Rows[i].Cells[2].Value.ToString();
            txt30.Text = dataGridView4.Rows[i].Cells[3].Value.ToString();
            txt31.Text = dataGridView4.Rows[i].Cells[4].Value.ToString();
            txt32.Text = dataGridView4.Rows[i].Cells[5].Value.ToString();
            txt33.Text = dataGridView4.Rows[i].Cells[6].Value.ToString();
            txt34.Text = dataGridView4.Rows[i].Cells[7].Value.ToString();
            txt35.Text = dataGridView4.Rows[i].Cells[8].Value.ToString();
            txt36.Text = dataGridView4.Rows[i].Cells[9].Value.ToString();
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cb5.Text = dataGridView5.Rows[i].Cells[0].Value.ToString();
            txt37.Text = dataGridView5.Rows[i].Cells[1].Value.ToString();
            txt38.Text = dataGridView5.Rows[i].Cells[2].Value.ToString();
            txt39.Text = dataGridView5.Rows[i].Cells[3].Value.ToString();
            txt40.Text = dataGridView5.Rows[i].Cells[4].Value.ToString();
            txt41.Text = dataGridView5.Rows[i].Cells[5].Value.ToString();
            txt42.Text = dataGridView5.Rows[i].Cells[6].Value.ToString();
            txt43.Text = dataGridView5.Rows[i].Cells[7].Value.ToString();
            txt44.Text = dataGridView5.Rows[i].Cells[8].Value.ToString();
            txt45.Text = dataGridView5.Rows[i].Cells[9].Value.ToString();
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt11_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt28_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt29_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt31_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt32_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt33_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt34_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt35_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblBangCongThuViec values(N'" + txt1.Text + "',N'" + txt2.Text + "',N'" + cb1.Text + "',N'" + txt3.Text + "',N'" + txt4.Text + "',N'" + txt5.Text + "',N'" + txt6.Text + "',N'" + txt7.Text + "',N'" + txt8.Text + "',N'" + txt9.Text + "')";
                if (!cls.kttrungkhoa(cb1.Text, "select MaNV from TblBangCongThuViec"))
                {
                    if (cb1.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        cls.loaddatagridview1(dataGridView1, ds1, "select * from TblBangCongThuViec");

                    }
                    else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                }
                else
                    MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblCongKhoiDieuHanh values(N'" + cb2.Text + "',N'" + txt10.Text + "',N'" + txt11.Text + "',N'" + txt12.Text + "',N'" + txt13.Text + "',N'" + txt14.Text + "',N'" + txt15.Text + "',N'" + txt16.Text + "',N'" + txt17.Text + "',N'" + txt18.Text + "')";
                if (!cls.kttrungkhoa(cb2.Text, "select MaNV from TblCongKhoiDieuHanh"))
                {
                    if (cb2.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        
                        cls.loaddatagridview1(dataGridView2, ds2, "select * from TblCongKhoiDieuHanh");
                       
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                }
                else
                    MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblCongKhoiSanXuat values(N'" + cb3.Text + "',N'" + txt19.Text + "',N'" + txt20.Text + "',N'" + txt21.Text + "',N'" + txt22.Text + "',N'" + txt23.Text + "',N'" + txt24.Text + "',N'" + txt25.Text + "',N'" + txt26.Text + "',N'" + txt27.Text + "')";
                if (!cls.kttrungkhoa(cb3.Text, "select MaNV from TblCongKhoiSanXuat"))
                {
                    if (cb3.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        
                        cls.loaddatagridview1(dataGridView3, ds3, "select * from TblCongKhoiSanXuat");
                       
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                }
                else
                    MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblCongKhoiVanChuyen values(N'" + cb4.Text + "',N'" + txt28.Text + "',N'" + txt29.Text + "',N'" + txt30.Text + "',N'" + txt31.Text + "',N'" + txt32.Text + "',N'" + txt33.Text + "',N'" + txt34.Text + "',N'" + txt35.Text + "',N'" + txt36.Text + "')";
                if (!cls.kttrungkhoa(cb4.Text, "select MaNV from TblCongKhoiVanChuyen"))
                {
                    if (cb4.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                     
                        cls.loaddatagridview1(dataGridView4, ds4, "select * from TblCongKhoiVanChuyen");
                        
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                }
                else
                    MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblCongKhoiVanPHong values(N'" + cb5.Text + "',N'" + txt37.Text + "',N'" + txt38.Text + "',N'" + txt39.Text + "',N'" + txt40.Text + "',N'" + txt41.Text + "',N'" + txt42.Text + "',N'" + txt43.Text + "',N'" + txt44.Text + "',N'" + txt45.Text + "')";
                if (!cls.kttrungkhoa(cb5.Text, "select MaNV from TblCongKhoiVanPHong"))
                {
                    if (cb5.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        cls.loaddatagridview1(dataGridView5, ds5, "select * from TblCongKhoiVanPHong");
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                }
                else
                    MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }   
    }
}
