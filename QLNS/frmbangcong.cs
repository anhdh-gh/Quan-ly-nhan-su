using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;

namespace QLNS
{
    public partial class frmbangcong : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public static SqlConnection Con;
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
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {

            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị

        }

        private void frmbangcong_Load(object sender, EventArgs e)
        {
            
            //DateTime dt1, dt2;
            //dt1 = new DateTime(2009, 5, 10);
            //dt2 = new DateTime(2009, 10, 10);
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-N5JKS23\sqlexpress;Initial Catalog=QLNS;Integrated Security=True";

            cls.loadcombobox(cb1, "select MaNVTV from TblHoSoThuViec", 0);


            frmbangcong.FillCombo("SELECT TenPhong FROM TblPhongBan", comboBox10, "TenPhong", "TenPhong");
            comboBox10.SelectedIndex = -1;
            
            cls.loaddatagridview1(dataGridView1,ds1, "select * from TblBangCongThuViec");
            //cls.loaddatagridview1(dataGridView2, ds2, "select * from TblCongKhoiDieuHanh ");
           
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
          
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblBangCongThuViec set TenBoPhan=N'" + txt1.Text + "',TenPhong=N'" + txt2.Text + "',LuongTViec=N'" + txt3.Text + "',Thang=N'" + txt4.Text + "',Nam='" + txt5.Text + "',SoNgayCong=N'" + txt6.Text + "',SoNgayNghi=N'" + txt7.Text + "',SoGioLamThem=N'" + txt8.Text + "',Luong=N'"+textBox3.Text+"',GhiChu='" + txt9.Text + "' where MaNVTV=N'" + cb1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView1, ds1, "select * from TblBangCongThuViec");
                MessageBox.Show("Sửa thành công");
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
                string update = "update TblCongKhoiDieuHanh set MaNV='"+cb2.Text+"', MaLuong=N'"+txt50.Text+"',TenPhong=N'"+comboBox10.Text+"', HoTen=N'" + txt53.Text + "',LCB=N'" + txt10.Text + "',PCChucVu=N'" + txt11.Text + "',PCapKhac=N'" + txt12.Text + "',Thuong=N'" + textBox1.Text + "',KyLuat='" + textBox2.Text +"',Thang=N'" + txt13.Text + "',Nam='" + txt14.Text + "',SoNgayCongThang=N'" + txt15.Text + "',SoNgayNghi=N'" + txt16.Text + "',SoGioLamThem=N'" + txt17.Text + "',Luong=N'" + txt52.Text + "',GhiChu='" + txt18.Text + "' where MaNV=N'" + cb2.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView2, ds2, "select * from TblCongKhoiDieuHanh where TenPhong=N'"+comboBox10.SelectedValue+"'");
                MessageBox.Show("Sửa thành công");
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
                string delete = "delete from TblBangCongThuViec where MaNVTV=N'" + cb1.Text + "'";
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
            cls.loadtextboxchiso(txt2, "select * from TblPhongBan b,TblHoSoThuViec a where a.MaPhong=b.MaPhong and MaNVTV='" + cb1.Text + "'", 2);
            cls.loadtextboxchiso(txt1, "select * from TblBoPhan,TblPhongBan where TblPhongBan.MaBoPhan=TblBoPhan.MaBoPhan and TenPhong=N'" + txt2.Text + "'", 1);
            cls.loadtextboxchiso(txt3, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 3);
            cls.loadtextboxchiso(txt4, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 4);
            cls.loadtextboxchiso(txt5, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 5);
            cls.loadtextboxchiso(txt6, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 6);
            cls.loadtextboxchiso(txt7, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 7);
            cls.loadtextboxchiso(txt8, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 8);
            cls.loadtextboxchiso(textBox3, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 9);
            cls.loadtextboxchiso(txt9, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 10); 
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {   
            cls.loadtextboxchiso(txt50, "select * from TblTTNVCoBan where MaNV='" + cb2.Text + "'", 4);
            cls.loadtextboxchiso(txt10, "select * from TblBangLuongCTy l where l.MaLuong='" + txt50.Text + "'",1);
            cls.loadtextboxchiso(txt11, "select * from TblBangLuongCTy l where l.MaLuong='" + txt50.Text + "'", 2);
            //cls.loadtextboxchiso(txt10, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 4);
            cls.loadtextboxchiso(txt53, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 2);
            //cls.loadtextboxchiso(txt51, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 3);
            // cls.loadtextboxchiso(txt11, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 5);
            cls.loadtextboxchiso(txt12, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 6);
            cls.loadtextboxchiso(textBox1, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 7);
            cls.loadtextboxchiso(textBox2, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 8);
            cls.loadtextboxchiso(txt13, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 9);
            cls.loadtextboxchiso(txt14, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 10);
            cls.loadtextboxchiso(txt15, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 11);
            cls.loadtextboxchiso(txt16, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 12);
            cls.loadtextboxchiso(txt17, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 13);
            cls.loadtextboxchiso(txt52, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 14);
            cls.loadtextboxchiso(txt18, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 15);
        }
        

      
        private void cb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cls.loadtextboxchiso(txt28, "select * from TblCongKhoiDieuHanh where MaNV='" + cb4.Text + "'", 1);
            //cls.loadtextboxchiso(txt29, "select * from TblCongKhoiDieuHanh where MaNV='" + cb4.Text + "'", 2);
            //cls.loadtextboxchiso(txt30, "select * from TblCongKhoiDieuHanh where MaNV='" + cb4.Text + "'", 3);
            //cls.loadtextboxchiso(txt31, "select * from TblCongKhoiDieuHanh where MaNV='" + cb4.Text + "'", 4);
            //cls.loadtextboxchiso(txt32, "select * from TblCongKhoiDieuHanh where MaNV='" + cb4.Text + "'", 5);
            //cls.loadtextboxchiso(txt33, "select * from TblCongKhoiDieuHanh where MaNV='" + cb4.Text + "'", 6);
            //cls.loadtextboxchiso(txt34, "select * from TblCongKhoiDieuHanh where MaNV='" + cb4.Text + "'", 7);
            //cls.loadtextboxchiso(txt35, "select * from TblCongKhoiDieuHanh where MaNV='" + cb4.Text + "'", 8);
            //cls.loadtextboxchiso(txt36, "select * from TblCongKhoiDieuHanh where MaNV='" + cb4.Text + "'", 9);
        }

        private void cb5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cls.loadtextboxchiso(txt37, "select * from TblCongKhoiDieuHanh where MaNV='" + cb5.Text + "'", 1);
            //cls.loadtextboxchiso(txt38, "select * from TblCongKhoiDieuHanh where MaNV='" + cb5.Text + "'", 2);
            //cls.loadtextboxchiso(txt39, "select * from TblCongKhoiDieuHanh where MaNV='" + cb5.Text + "'", 3);
            //cls.loadtextboxchiso(txt40, "select * from TblCongKhoiDieuHanh where MaNV='" + cb5.Text + "'", 4);
            //cls.loadtextboxchiso(txt41, "select * from TblCongKhoiDieuHanh where MaNV='" + cb5.Text + "'", 5);
            //cls.loadtextboxchiso(txt42, "select * from TblCongKhoiDieuHanh where MaNV='" + cb5.Text + "'", 6);
            //cls.loadtextboxchiso(txt43, "select * from TblCongKhoiDieuHanh where MaNV='" + cb5.Text + "'", 7);
            //cls.loadtextboxchiso(txt44, "select * from TblCongKhoiDieuHanh where MaNV='" + cb5.Text + "'", 8);
            //cls.loadtextboxchiso(txt45, "select * from TblCongKhoiDieuHanh where MaNV='" + cb5.Text + "'", 9);

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
            textBox3.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            txt9.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cb2.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txt10.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            txt53.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txt50.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            comboBox10.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txt11.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            txt12.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            textBox1.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            textBox2.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();
            txt13.Text = dataGridView2.Rows[i].Cells[9].Value.ToString();
            txt14.Text = dataGridView2.Rows[i].Cells[10].Value.ToString();
            txt15.Text = dataGridView2.Rows[i].Cells[11].Value.ToString();
            txt16.Text = dataGridView2.Rows[i].Cells[12].Value.ToString();
            txt17.Text = dataGridView2.Rows[i].Cells[13].Value.ToString();
            txt52.Text = dataGridView2.Rows[i].Cells[14].Value.ToString();
            txt18.Text = dataGridView2.Rows[i].Cells[15].Value.ToString();
            
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
            //try
            //{

            string insert = "insert into TblBangCongThuViec values(N'" + txt1.Text + "',N'" + txt2.Text + "',N'" + cb1.Text + "',N'" + txt3.Text + "',N'" + txt4.Text + "',N'" + txt5.Text + "',N'" + txt6.Text + "',N'" + txt7.Text + "',N'" + txt8.Text + "',N'" + textBox3.Text + "',N'" + txt9.Text + "')";
                if (!cls.kttrungkhoa(cb1.Text, "select MaNVTV from TblBangCongThuViec"))
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
            //catch
            //{
            //    MessageBox.Show("Dữ liệu đầu vào không đúng");
            //}
        //}

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblCongKhoiDieuHanh values(N'" + cb2.Text + "',N'" + txt10.Text + "',N'" + txt53.Text + "',N'" + txt50.Text + "'N'" + txt11.Text + "',N'" + txt12.Text + "',N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + txt13.Text + "',N'" + txt14.Text + "',N'" + txt15.Text + "',N'" + txt16.Text + "',N'" + txt17.Text + "',N'" + txt18.Text + "')";
                if (!cls.kttrungkhoa(cb2.Text, "select MaNV from TblCongKhoiDieuHanh"))
                {
                    if (cb2.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        
                        cls.loaddatagridview1(dataGridView2, ds2, "select * from TblCongKhoiDieuHanh ");
                       
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

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void tl_Click(object sender, EventArgs e)
        {
            int lcb = Convert.ToInt32(txt10.Text);
            int pc = Convert.ToInt32(txt11.Text);
            int pck = Convert.ToInt32(txt12.Text);
            int nc = Convert.ToInt32(txt15.Text);
            int lt = Convert.ToInt32(txt17.Text);
            int th = Convert.ToInt32(textBox1.Text);
            int kl = Convert.ToInt32(textBox2.Text);

            float luong = ((lcb / 26) * nc + (lt * 40000) + pc + pck+th-kl);
            txt52.Text = luong.ToString();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void txt50_TextChanged(object sender, EventArgs e)
        {
            ////cls.loadtextboxchiso(txt10, "select * from TblBangLuongCTy l where l.MaLuong='" + txt50.Text + "'", 1);
           
            
            
            //String i = "select LCB from TblBangLuongCTy l where l.MaLuong ='" + txt50.Text + "'" ;
            //cls.thucthiketnoi(i);
          
  
            
            //thử xem
        }

        private void txt10_TextChanged(object sender, EventArgs e)
        {
         //string i="select LCB from TblBangLuongCTy l where l.MaLuong ='"+txt50.Text+"'";
         //txt10.Text = i.ToString();

        }
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            //frmbangcong.FillCombo("select MaNV from TblCongKhoiDieuHanh b,a p where b.Khoi=p.Khoi and p.Khoi=N'" + comboBox10.SelectedValue + "'", cb2, "MaNV", "MaNV");
            //cb2.DisplayMember = "MaNV";
            //cb2.ValueMember = "MaNV";
            
            
           

        }

        private void comboBox10_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            frmbangcong.FillCombo("select MaNV from TblCongKhoiDieuHanh where TenPhong=(select top(1) TenPhong from TblPhongBan a, TblTTNVCoBan b where a.MaPhong=b.MaPhong and a.TenPhong=N'" + comboBox10.SelectedValue + "' group by TenPhong)", cb2, "MaNV", "MaNV");
            cb2.DisplayMember = "MaNV";
            cb2.ValueMember = "MaNV";
            cls.loaddatagridview1(dataGridView2, ds2, "select * from TblCongKhoiDieuHanh b where b.TenPhong=N'" + comboBox10.SelectedValue + "'");
        }

        private void comboBox10_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int lcb = Convert.ToInt32(txt10.Text);
            int pc = Convert.ToInt32(txt11.Text);
            int pck = Convert.ToInt32(txt12.Text);
            int nc = Convert.ToInt32(txt15.Text);
            int lt = Convert.ToInt32(txt17.Text);
            int th = Convert.ToInt32(textBox1.Text);
            int kl = Convert.ToInt32(textBox2.Text);

            float luong = ((lcb / 26) * nc + (lt * 40000) + pc + pck + th - kl);
            txt52.Text = luong.ToString();
        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            int l = Convert.ToInt32(txt3.Text);
            int nc = Convert.ToInt32(txt6.Text);
            int lt = Convert.ToInt32(txt8.Text);
            float luong = ((l / 26) * nc + (lt * 40000));
            textBox3.Text = luong.ToString();

        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }

        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }

       

       
       
             
    
        }


        


          
    }

