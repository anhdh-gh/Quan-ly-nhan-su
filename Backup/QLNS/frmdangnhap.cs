using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNS
{
    public partial class frmdangnhap : Form
    {

        Clsdatabase cls = new Clsdatabase();

        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show( cls.thu(textBox2.Text, "select pass from tbuser").ToString());
            if ((cls.kt(textBox1.Text, "select * from tbuser", 0) == true)&&(cls.kt(textBox2.Text, "select * from tbuser", 1) == true))
            {

                //this.Hide();
                //Global.frmmain.k = 4;
                //Global.frmmain.Refresh();
                //Global.frmmain.truyen();
             
                //Global.frmmain.ShowDialog();
                //MessageBox.Show("Bạn đã đăng nhập thành công");

                this.Hide();
                FrmMain fm = new FrmMain();
                fm.k = 4;
                fm.truyen();
                MessageBox.Show("Bạn đã đăng nhập thành công");
                fm.ShowDialog();     

            }
            else
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng ", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmdangki d = new frmdangki();
            d.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Size = new Size(20, 20);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new Size(18, 18);
        }
    }
}
