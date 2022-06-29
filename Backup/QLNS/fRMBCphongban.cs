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
    public partial class fRMBCphongban : Form
    {
        public fRMBCphongban()
        {
            InitializeComponent();
        }
        string connstr = "Data Source=.\\sqlexpress;Initial Catalog=QLNS;Integrated Security=True";
        public DataTable getnv()
        {
            SqlConnection sqlcon = new SqlConnection(connstr);
            string select = "select * from TblPhongBan";
            sqlcon.Open();
            SqlDataAdapter ada = new SqlDataAdapter(select, sqlcon);
            DataSet ds1 = new DataSet();
            ada.Fill(ds1, "TblPhongBan");
            ds1.Tables["TblPhongBan"].Clear();
            ada.Fill(ds1, "TblPhongBan");
            return ds1.Tables["TblPhongBan"];
        }
        private void fRMBCphongban_Load(object sender, EventArgs e)
        {
            Ctr_phongban cr = new Ctr_phongban();
            cr.SetDataSource(getnv());
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
    }
}
