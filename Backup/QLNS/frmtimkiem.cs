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
    public partial class frmtimkiem : Form
    {
        Clsdatabase cls = new Clsdatabase();

        public frmtimkiem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int i = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox1.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (i == 1)
                    {
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where MaNV=N'" + textBox1.Text + "'");
                    }
                    if (i == 2)
                    {
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where HoTen=N'" + textBox1.Text + "'");
                    }
                    if (i == 3)
                    {
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where CMTND=N'" + textBox1.Text + "'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }

        }
        
        private void frmtimkiem_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
            try
            {

                if ((textBox1.Text == "") || (textBox1.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
                }
                else
                {
                   
                    if (i == 1)
                    {
                        cls.loatextbox(textBox1, "select * from TblTTNVCoBan where MaNV like N'" + textBox1.Text + "%'", 2);
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where MaNV like N'" + textBox1.Text + "%'");
                    }
                    if (i == 2)
                    {
                        cls.loatextbox(textBox1, "select * from TblTTNVCoBan where MaNV like N'" + textBox1.Text + "%'", 3);
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where HoTen like N'" + textBox1.Text + "%'");
                    }
                    if (i == 3)
                    {
                        cls.loatextbox(textBox1, "select * from TblTTNVCoBan where MaNV like N'" + textBox1.Text + "%'", 8);
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where CMTND like N'" + textBox1.Text + "%'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("tìm kiếm sai");
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nhập vào từ khóa tìm kiếm")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("kjlhjkl");
            
           
            //if (i == 1)
            //{
            //    cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where MaNV like '%'" + textBox1.Text + "'%'");
            //}
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
