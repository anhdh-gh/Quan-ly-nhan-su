using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace QLNS
{
    public partial class frmthongtincanhan : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmthongtincanhan()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cls.kttrungkhoa(comboBox1.Text, "select MaNV from TblTTCaNhan"))
                {
                    string insert = "insert into TblTTCaNhan values(N'" + comboBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "',N'" + textBox5.Text + "',N'" + textBox6.Text + "',N'" + textBox7.Text + "',N'" + textBox8.Text + "',N'" + textBox9.Text + "',N'" + textBox10.Text + "',N'" + textBox11.Text + "',N'" + textBox12.Text + "',N'" + textBox13.Text + "','" + dateTimePicker1.Text + "',N'" + textBox15.Text + "',N'" + textBox16.Text + "',N'" + textBox17.Text + "')";
                    cls.thucthiketnoi(insert);
                    dataGridView1.Refresh();
                    cls.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
                }
                else MessageBox.Show("Thông tin về nhân viên này đã tồn tại");

            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không chính sác");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmthongtincanhan_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            cls.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
            cls.loadcombobox(comboBox1, "select * from TblTTNVCoBan", 2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
            int hang = e.RowIndex;
            comboBox1.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[hang].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[hang].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[hang].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.Rows[hang].Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.Rows[hang].Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.Rows[hang].Cells[10].Value.ToString();
            textBox12.Text = dataGridView1.Rows[hang].Cells[11].Value.ToString();
            textBox13.Text = dataGridView1.Rows[hang].Cells[12].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[hang].Cells[13].Value.ToString();
            textBox15.Text = dataGridView1.Rows[hang].Cells[14].Value.ToString();
            textBox16.Text = dataGridView1.Rows[hang].Cells[15].Value.ToString();
            textBox17.Text = dataGridView1.Rows[hang].Cells[16].Value.ToString();
            
            }
            catch
            {}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblTTCaNhan set Manv=N'" + comboBox1.Text + "',Noisinh=N'" + textBox2.Text + "',NguyenQuan=N'" + textBox3.Text + "',DCThuongChu=N'" + textBox4.Text + "',DCTamChu='" + textBox5.Text + "',SDT=N'" + textBox6.Text + "',DanToc=N'" + textBox7.Text + "',TonGiao=N'" + textBox8.Text + "',QuocTich='" + textBox9.Text + "',TiengNN=N'" + textBox10.Text + "',TrinhDoNN=N'" + textBox11.Text + "',HocVan=N'" + textBox12.Text + "',HocHam=N'" + textBox13.Text + "',NgayVaoDoan=N'" + dateTimePicker1.Text + "',TenDoanThe='" + textBox15.Text + "',ChucVuDoan='" + textBox16.Text + "',GhiChu=N'" + textBox17.Text + "' where MaNV=N'" + comboBox1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblTTCaNhan where MaNV=N'" + comboBox1.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
                }
            }
            catch
            {
                MessageBox.Show("không xóa được");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CrystalReport1 cr = new CrystalReport1();
            
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
