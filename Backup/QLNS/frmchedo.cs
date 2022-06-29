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
    public partial class frmchedo : Form
    {
        Clsdatabase cls = new Clsdatabase();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        public frmchedo()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void frmchedo_Load(object sender, EventArgs e)
        {
            dt1.CustomFormat = " MM / dd / yyyy ";
            dt2.CustomFormat = " MM / dd / yyyy ";
            dt3.CustomFormat = " MM / dd / yyyy ";
            dt4.CustomFormat = " MM / dd / yyyy ";
            dt5.CustomFormat = " MM / dd / yyyy ";
            cls.loadcombobox(comboBox1, "select * from TblSoBH", 0);
            cls.loadcombobox(comboBox2, "select * from TblThaiSan", 2);
            cls.loaddatagridview1(dataGridView1, ds1, "select * from TblSoBH");
            cls.loaddatagridview1(dataGridView2, ds2, "select * from TblThaiSan");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txt1, "select * from TblSoBH where MaNV=N'" + comboBox1.Text + "'", 1);
            cls.loadtextboxchiso(txt2, "select * from TblSoBH where MaNV=N'" + comboBox1.Text + "'", 2);
            cls.loaddatetime(dt1, "select NgayCapSo from TblSoBH where MaNV=N'" + comboBox1.Text + "'", 0);
            cls.loadtextboxchiso(txt3, "select * from TblSoBH where MaNV=N'" + comboBox1.Text + "'", 4);
            cls.loadtextboxchiso(txt4, "select * from TblSoBH where MaNV=N'" + comboBox1.Text + "'", 5);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txt5, "select * from TblThaiSan where MaNV=N'" + comboBox2.Text + "'", 0);
            cls.loadtextboxchiso(txt6, "select * from TblThaiSan where MaNV=N'" + comboBox2.Text + "'", 1);
            cls.loadtextboxchiso(txt7, "select * from TblThaiSan where MaNV=N'" + comboBox2.Text + "'", 3);
            cls.loadtextboxchiso(txt8, "select * from TblThaiSan where MaNV=N'" + comboBox2.Text + "'", 8);
            cls.loadtextboxchiso(txt9, "select * from TblThaiSan where MaNV=N'" + comboBox2.Text + "'", 9);
            cls.loaddatetime(dt2, "select * from TblThaiSan where MaNV=N'" + comboBox2.Text + "'", 4);
            cls.loaddatetime(dt3, "select * from TblThaiSan where MaNV=N'" + comboBox2.Text + "'", 5);
            cls.loaddatetime(dt4, "select * from TblThaiSan where MaNV=N'" + comboBox2.Text + "'", 6);
            cls.loaddatetime(dt5, "select * from TblThaiSan where MaNV=N'" + comboBox2.Text + "'", 7);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt5.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txt6.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txt7.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            dt2.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            dt3.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            dt4.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            dt5.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            txt8.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();
            txt9.Text = dataGridView2.Rows[i].Cells[9].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            //MessageBox.Show(dataGridView1.Rows[i].Cells[3].Value.ToString());
            
            comboBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dt1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt3.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt4.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblSoBH values(N'" + comboBox1.Text + "',N'" + txt1.Text + "',N'" + txt2.Text + "',N'" + dt1.Text + "',N'" + txt3.Text + "',N'" + txt4.Text + "'";
                if (!cls.kttrungkhoa(txt1.Text, "select MaSoBH from TblSoBH"))
                {
                    if (txt1.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        cls.loaddatagridview1(dataGridView1, ds1, "select * from TblSoBH");
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã số bảo hiểm");
                }
                else
                    MessageBox.Show("Mã số bảo hiểm này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string update = "update TblThaiSan set HoTen=N'" + txt7.Text + "',NgaySinh=N'" + dt2.Text + "',NgayVeSom=N'" + dt3.Text + "',NgayNghiSinh=N'" + dt4.Text + "',NgayLamTroLai='" + dt5.Text + "',TroCapCTy=N'" + txt8.Text + "',GhiChu=N'" + txt9.Text + "' where MaNV=N'" + comboBox2.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView2, ds2, "select * from TblThaiSan");
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
                string update = "update TblSoBH set NgayCapSo=N'" + dt1.Text + "',NoiCapSo=N'" + txt3.Text + "',GhiChu=N'" + txt4.Text + "' where MaNV=N'" + comboBox1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView1, ds1, "select * from TblSoBH");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblSoBH where MaSoBH=N'" + txt2.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview1(dataGridView1, ds1, "select * from TblSoBH");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblThaiSan where MaNV=N'" + comboBox2.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview1(dataGridView2, ds2, "select * from TblThaiSan");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
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
