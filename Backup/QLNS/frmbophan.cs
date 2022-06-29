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
    public partial class frmbophan : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmbophan()
        {
            InitializeComponent();
        }

        private void frmbophan_Load(object sender, EventArgs e)
        {
            cls.loaddatagridview(dataGridView1, "select * from TblBoPhan");
            
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cls.kttrungkhoa(textBox1.Text, "select MaBoPhan from TblBoPhan"))
                {
                    string insert = "insert into TblBoPhan values(N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "')";
                    cls.thucthiketnoi(insert);
                    cls.loaddatagridview(dataGridView1, "select * from TblBoPhan");
                }
                else
                {
                    MessageBox.Show("Bộ phận này đã tòn tại ", "Trùng bộ phân", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                string update = "update TblBoPhan set TenBoPhan=N'" + textBox2.Text + "',GhiChu=N'" + textBox3.Text + "' where MaBoPhan='" + textBox1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from TblBoPhan");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
                string del = "delete from TblBoPhan where MaBoPhan='" + textBox1.Text + "'";
                string del1 = "delete from TblPhongBan where MaBoPhan='" + textBox1.Text + "'";
                //string del = "delete from TblPhongBan where MaPhong=N'" + textBox2.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(del1);
                    cls.thucthiketnoi(del);
                    cls.loaddatagridview(dataGridView1, "select * from TblBoPhan");
                }
            //}
            //catch
            //{
            //    MessageBox.Show("Dữ liệu đầu vào không đúng");
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }
    }
}
