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
    public partial class bcnv : Form
    {
        public bcnv()
        {
            InitializeComponent();
        }

        private void bcnv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.TblTTNVCoBan' table. You can move, or remove it, as needed.
            this.TblTTNVCoBanTableAdapter.Fill(this.DataSet1.TblTTNVCoBan);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
