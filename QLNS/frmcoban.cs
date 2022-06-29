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
    public partial class frmcoban : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public static SqlConnection Con;
        public frmcoban()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker)||(ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("amthanh.wav");
            p.Play();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("amthanh.wav");
            p.Play();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("amthanh.wav");
            p.Play();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("amthanh.wav");
            p.Play();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("amthanh.wav");
            p.Play();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("amthanh.wav");
            p.Play();
        }

        private void frmcoban_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-N5JKS23\sqlexpress;Initial Catalog=QLNS;Integrated Security=True";
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker3.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker4.CustomFormat = " MM / dd / yyyy ";
            cls.loadcombobox(comboBox4, "select MaLuong from TblBangLuongCTy", 0);

            frmcoban.FillCombo("SELECT MaBoPhan FROM TblBoPhan", comboBox2, "MaBoPhan", "MaBoPhan");
            comboBox2.SelectedIndex = -1;
            
            cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
          
            //try
            //{
                
                string insert = "insert into TblTTNVCoBan values(N'" + comboBox2.Text + "',N'" + comboBox3.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "',N'" + comboBox4.Text + "',N'" + dateTimePicker1.Text + "',N'" + comboBox1.Text + "',N'" + textBox8.Text + "',N'" + textBox9.Text + "',N'" + textBox11.Text + "',N'" + textBox12.Text + "',N'" + textBox14.Text + "',N'" + textBox15.Text + "',N'" + dateTimePicker3.Text + "',N'" + dateTimePicker4.Text + "',N'" + textBox19.Text + "')";

                if ((!cls.kttrungkhoa(textBox3.Text, "select MaNV from TblTTNVCoBan")) && (!cls.kttrungkhoa(textBox9.Text, "select CMTND from TblNVThoiViec")))
                {
                    if (textBox3.Text != "" && textBox9.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
                        MessageBox.Show("Thêm thành công");
                    }
                    else if (textBox3.Text == "") MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                    else if (textBox9.Text == "") MessageBox.Show("Bạn chưa nhập số CMTND");
                }
                else if ((!cls.kttrungkhoa(textBox3.Text, "select MaNV from TblTTNVCoBan")) && (cls.kttrungkhoa(textBox9.Text, "select CMTND from TblNVThoiViec")))
                {
                    if (MessageBox.Show("Nhân viên này đã từng làm ở công ty, bạn có chắc muốn thêm?", "Thêm thất bại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cls.thucthiketnoi(insert);
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
                        MessageBox.Show("Thêm thành công");
                        string delete = "delete from TblNVThoiViec where CMTND='" + textBox9.Text + "'";
                        cls.thucthiketnoi(delete);
                    }
                }
                else if ((cls.kttrungkhoa(textBox3.Text, "select MaNV from TblTTNVCoBan")) && (!cls.kttrungkhoa(textBox9.Text, "select CMTND from TblNVThoiViec")))
                    MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            string ine = "insert into TblTTCaNhan(MaNV,HoTen) select MaNV,HoTen from TblTTNVCoBan where MaNV='" + textBox3.Text + "'";
            if ((!cls.kttrungkhoa(textBox3.Text, "select MaNV from TblTTCaNhan")))
            {
                if (textBox3.Text != "")
                {
                    cls.thucthiketnoi(ine);
                    dataGridView1.Refresh();
                }
                else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
            }
            else
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            string ins = "insert into TblCongKhoiDieuhanh(MaNV,HoTen,MaLuong) select MaNV,HoTen,MaLuong from TblTTNVCoBan where MaNV='" + textBox3.Text + "'";
            if ((!cls.kttrungkhoa(textBox3.Text, "select MaNV from TblCongKhoiDieuHanh")))
            {
                if (textBox3.Text != "")
                {
                    cls.thucthiketnoi(ins);
                    dataGridView1.Refresh();
                }
                else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
            }
            else
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            string updata = " update TblCongKhoiDieuHanh set TenPhong = (select top(1) TenPhong from TblPhongBan a,TblTTNVCoBan b where a.MaPhong=b.MaPhong and a.MaPhong=N'"+comboBox3.Text+"' group by TenPhong) where MaNV='" + textBox3.Text + "'";
            
                    cls.thucthiketnoi(updata);
                    dataGridView1.Refresh();
              
        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                comboBox2.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                comboBox3.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
                comboBox4.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();
                
                dateTimePicker1.Text = dataGridView1.Rows[hang].Cells[5].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[hang].Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.Rows[hang].Cells[7].Value.ToString();
                textBox9.Text = dataGridView1.Rows[hang].Cells[8].Value.ToString();
                textBox11.Text = dataGridView1.Rows[hang].Cells[9].Value.ToString();
                textBox12.Text = dataGridView1.Rows[hang].Cells[10].Value.ToString();
                textBox14.Text = dataGridView1.Rows[hang].Cells[11].Value.ToString();
                textBox15.Text = dataGridView1.Rows[hang].Cells[12].Value.ToString();
                dateTimePicker3.Text = dataGridView1.Rows[hang].Cells[13].Value.ToString();
                dateTimePicker4.Text = dataGridView1.Rows[hang].Cells[14].Value.ToString();
                textBox19.Text = dataGridView1.Rows[hang].Cells[15].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
                string update = "update TblTTNVCoBan set MaBoPhan=N'" + comboBox2.Text + "',MaPhong=N'" + comboBox3.Text + "',HoTen=N'" + textBox4.Text + "',MaLuong=N'" + comboBox4.Text + "',NgaySinh='" + dateTimePicker1.Text + "',GioiTinh=N'" + comboBox1.Text + "',TTHonNhan=N'" + textBox8.Text + "',CMTND=N'" + textBox9.Text + "',NoiCap=N'" + textBox11.Text + "',ChucVu=N'" + textBox12.Text + "',LoaiHD=N'" + textBox14.Text + "',ThoiGian=N'" + textBox15.Text + "',NgayKy='" + dateTimePicker3.Text + "',NgayHetHan='" + dateTimePicker4.Text + "',GhiChu=N'" + textBox19.Text + "' where MaNV=N'" + textBox3.Text + "'";
                cls.thucthiketnoi(update);
                dataGridView1.Refresh();
                cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
                MessageBox.Show("Sửa thảnh công");
            //}
            //catch
            //{
            //    MessageBox.Show("Dữ liệu đầu vào không đúng");

            //}
            string upd = "update TblCongKhoiDieuHanh set HoTen=N'" + textBox4.Text + "',MaLuong=N'" + comboBox4.Text + "' where MaNV=N'" + textBox3.Text + "'";
            cls.thucthiketnoi(upd);
            cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
            string ds = "update TblCongKhoiDieuHanh set TenPhong = (select top(1) TenPhong from TblPhongBan a,TblTTNVCoBan b where a.MaPhong=b.MaPhong and a.MaPhong=N'" + comboBox3.Text + "' group by TenPhong) where MaNV='" + textBox3.Text + "'";

            cls.thucthiketnoi(ds);
            dataGridView1.Refresh();
              
        }

        
        
            
   
        private void button3_Click(object sender, EventArgs e)
        {
            string insert = "insert into TblNVThoiViec(HoTen,CMTND,LyDo) select HoTen,CMTND,GhiChu from TblTTNVCoBan where MaNV='" + textBox3.Text + "'";
            {
                cls.thucthiketnoi(insert);
                cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
            }
            MessageBox.Show("Thêm thành công dữ liệu vào bảng NVThoiViec");
            
        
           string delete = "delete from TblTTNVCoBan where MaNV=N'" + textBox3.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
            }
            MessageBox.Show("Đã xóa dữ liệu ");
            

           }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string sql;
            //sql = "Select MaPhong from tblPhongBan where MaBoPhan=N'" + comboBox2.Text + "'";
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmcoban.FillCombo("select p.MaPhong from TblBoPhan b,TblPhongBan p where b.MaBoPhan=p.MaBoPhan and p.MaBoPhan=N'" + comboBox2.SelectedValue + "'", comboBox3, "MaPhong", "MaPhong");
            comboBox3.DisplayMember = "MaPhong";
            comboBox3.ValueMember = "MaPhong";
           
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
