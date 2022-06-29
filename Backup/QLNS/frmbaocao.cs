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
    public partial class frmbaocao : Form
    {
        public frmbaocao()
        {
            InitializeComponent();
        }
        string connstr = "Data Source=.\\sqlexpress;Initial Catalog=QLNS;Integrated Security=True";
        public DataTable getnv()
        {
            SqlConnection sqlcon = new SqlConnection(connstr);
            string select = "select * from TblTTNVCoBan";
            sqlcon.Open();
            SqlDataAdapter ada = new SqlDataAdapter(select, sqlcon);
            DataSet ds = new DataSet();
            ada.Fill(ds, "TblTTNVCoBan");
            ds.Tables["TblTTNVCoBan"].Clear();
            ada.Fill(ds, "TblTTNVCoBan");
            return ds.Tables["TblTTNVCoBan"];
        }
        private void frmbaocao_Load(object sender, EventArgs e)
        {
            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(getnv());
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
    }
}
