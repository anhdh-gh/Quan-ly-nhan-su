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
    public partial class frmdangki : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmdangki()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //foreach (Control ctr in this.groupBox1.Controls)
            //{
            //    if ((ctr is TextBox) || (ctr is DateTimePicker))
            //    {
            //        ctr.Text = "";
            //    }
            //}

           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            string insert = "insert into tbuser values(N'" + textBox1.Text + "','" + textBox2.Text + "',N'" + textBox3.Text + "','" + dateTimePicker1.Text + "')";
                if (cls.kttrungkhoa(textBox1.Text, "select * from tbuser") == true)
                    MessageBox.Show("Tên đăng nhập này đã tồn tại. Bạn có thể thử tên khác");
                else
                {
                    cls.thucthiketnoi(insert);
                    MessageBox.Show("Chúc mừng bạn đã đăng kí thành công");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmdangki_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
        }

        private void button2_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {

            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }
    }
}
