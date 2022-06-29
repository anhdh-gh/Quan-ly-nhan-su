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
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker2.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker3.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker4.CustomFormat = " MM / dd / yyyy ";
            cls.loadcombobox(comboBox2, "select * from TblBoPhan", 0);
            cls.loadcombobox(comboBox3, "select * from TblPhongBan",1);
            cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
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
            try
            {

                string insert = "insert into TblTTNVCoBan values(N'" + comboBox2.Text + "',N'" + comboBox3.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "',N'" + textBox5.Text + "',N'" + dateTimePicker1.Text + "',N'" + comboBox1.Text + "',N'" + textBox8.Text + "',N'" + textBox9.Text + "',N'" + dateTimePicker2.Text + "',N'" + textBox11.Text + "',N'" + textBox12.Text + "',N'" + textBox13.Text + "',N'" + textBox14.Text + "',N'" + textBox15.Text + "',N'" + dateTimePicker3.Text + "',N'" + dateTimePicker4.Text + "',N'" + textBox18.Text + "',N'" + textBox19.Text + "')";
                if (!cls.kttrungkhoa(textBox3.Text, "select MaNV from TblTTNVCoBan"))
                {
                    if (textBox3.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                comboBox2.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                comboBox3.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[hang].Cells[5].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[hang].Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.Rows[hang].Cells[7].Value.ToString();
                textBox9.Text = dataGridView1.Rows[hang].Cells[8].Value.ToString();
                dateTimePicker2.Text = dataGridView1.Rows[hang].Cells[9].Value.ToString();
                textBox11.Text = dataGridView1.Rows[hang].Cells[10].Value.ToString();
                textBox12.Text = dataGridView1.Rows[hang].Cells[11].Value.ToString();
                textBox13.Text = dataGridView1.Rows[hang].Cells[12].Value.ToString();
                textBox14.Text = dataGridView1.Rows[hang].Cells[13].Value.ToString();
                textBox15.Text = dataGridView1.Rows[hang].Cells[14].Value.ToString();
                dateTimePicker3.Text = dataGridView1.Rows[hang].Cells[15].Value.ToString();
                dateTimePicker4.Text = dataGridView1.Rows[hang].Cells[16].Value.ToString();
                textBox18.Text = dataGridView1.Rows[hang].Cells[17].Value.ToString();
                textBox19.Text = dataGridView1.Rows[hang].Cells[18].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblTTNVCoBan set MaBoPhan=N'" + comboBox2.Text + "',MaPhong=N'" + comboBox3.Text + "',HoTen=N'" + textBox4.Text + "',BiDanh=N'" + textBox5.Text + "',NgaySinh='" + dateTimePicker1.Text + "',GioiTinh=N'" + comboBox1.Text + "',TTHonNhan=N'" + textBox8.Text + "',CMTND=N'" + textBox9.Text + "',NgayCap='" + dateTimePicker2.Text + "',NoiCap=N'" + textBox11.Text + "',ChucVu=N'" + textBox12.Text + "',ChucDanh=N'" + textBox13.Text + "',LoaiHD=N'" + textBox14.Text + "',ThoiGian=N'" + textBox15.Text + "',NgayKy='" + dateTimePicker3.Text + "',NgayHetHan='" + dateTimePicker4.Text + "',Anh=N'" + textBox18.Text + "',GhiChu=N'" + textBox19.Text + "' where MaNV=N'" + textBox3.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblTTNVCoBan where MaNV=N'" + textBox3.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmbaocao fbc = new frmbaocao();
            fbc.ShowDialog();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }
    }
}
