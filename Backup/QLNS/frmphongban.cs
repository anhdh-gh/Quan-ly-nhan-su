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
    public partial class frmphongban : Form
    {
        public frmphongban()
        {
            InitializeComponent();
        }
        Clsdatabase cls = new Clsdatabase();
        private void frmphongban_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            cls.loaddatagridview(dataGridView1, "select * from tblphongban");
            cls.loadcombobox(comboBox1, "select * from TblBoPhan", 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
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
                if (!cls.kttrungkhoa(textBox2.Text, "select MaPhong from TblPhongBan"))
                {
                    string insert = "insert into TblPhongBan values('" + comboBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "',N'" + dateTimePicker1.Text + "',N'" + textBox5.Text + "')";
                    cls.thucthiketnoi(insert);
                    cls.loaddatagridview(dataGridView1, "select * from tblphongban");
                }
                else
                {
                    MessageBox.Show("Mã phòng này đã tòn tại bạn có thể thử mã phòng khác", "Trùng mã phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            comboBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update tblPhongBan set MaBoPhan=N'" + comboBox1.Text + "',TenPhong=N'" + textBox3.Text + "',NgayTLap=N'" + dateTimePicker1.Text + "',GhiChu=N'" + textBox5.Text + "' where MaPhong=N'" + textBox2.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from tblphongban");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string del = "delete from TblPhongBan where MaPhong=N'" + textBox2.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(del);
                    cls.loaddatagridview(dataGridView1, "select * from tblphongban");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fRMBCphongban fbc1 = new fRMBCphongban();
            fbc1.ShowDialog();
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
