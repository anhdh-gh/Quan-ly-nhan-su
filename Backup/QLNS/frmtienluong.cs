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
    public partial class frmtienluong : Form
    {
        public frmtienluong()
        {
            InitializeComponent();
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
            comboBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
            textBox12.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
            textBox13.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[13].Value.ToString();
            textBox15.Text = dataGridView1.Rows[i].Cells[14].Value.ToString();
            textBox16.Text = dataGridView1.Rows[i].Cells[15].Value.ToString();
            textBox17.Text = dataGridView1.Rows[i].Cells[16].Value.ToString();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmtienluong_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
        }
    }
}
