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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.TblCongKhoiDieuHanh' table. You can move, or remove it, as needed.
           // this.TblCongKhoiDieuHanhTableAdapter.Fill(this.DataSet2.TblCongKhoiDieuHanh);
            // TODO: This line of code loads data into the 'DataSet2.TblCongKhoiDieuHanh' table. You can move, or remove it, as needed.
            //this.TblCongKhoiDieuHanhTableAdapter.Fill(this.DataSet2.TblCongKhoiDieuHanh);
            // TODO: This line of code loads data into the 'DataSet2.TblCongKhoiDieuHanh' table. You can move, or remove it, as needed.
            //this.TblCongKhoiDieuHanhTableAdapter.Fill(this.DataSet2.TblCongKhoiDieuHanh);
            // TODO: This line of code loads data into the 'DataSet2.TblCongKhoiDieuHanh' table. You can move, or remove it, as needed.
            //this.TblCongKhoiDieuHanhTableAdapter.Fill(this.DataSet2.TblCongKhoiDieuHanh);
           

            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TblCongKhoiDieuHanhTableAdapter.Fill(this.DataSet2.TblCongKhoiDieuHanh,textBox1.Text);

            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
