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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public int k = 1;
        public void truyen()
        {

            //if (k == 4)
            //{


            //}
            //else if (k == 5)
            //{
            //    menuItem2.Enabled = true;
            //    menuItem3.Enabled = true;
            //    menuItem14.Enabled = true;
            //    //panel_danhmuc.Enabled = true;
            //    //panel_chucnang.Enabled = true;
            //    //panel_quanly.Enabled = true;
            //    barBubble.Enabled = true;
            //    //cmd_dangnhap.Enabled = false;
            //    menuItem4.Enabled = false;
            //    menuItem5.Enabled = false;
            //}
        }
        public static string quyen;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            
            if (quyen == "Admin")
            {
                menuItem2.Enabled = true;
                menuItem3.Enabled = true;
                menuItem14.Enabled = true;
                menuItem5.Enabled = true;
            }
            else if(quyen=="user")
            {
                menuItem2.Enabled = true;
                menuItem3.Enabled = true;
                menuItem14.Enabled = true;
                menuItem5.Enabled = false;
            }




        }



        //private void menuItemdmk_Click(object sender, EventArgs e)
        //{
        //    frmdoimatkhau fdm = new frmdoimatkhau();
        //    panel_show.Show();
        //    panel_show.Controls.Clear();
        //    fdm.TopLevel = false;
        //    fdm.Dock = DockStyle.Fill;
        //    panel_show.Controls.Add(fdm);
        //    fdm.Show();
        //}



        private void menuItem11_Click(object sender, EventArgs e)
        {
            frmtimkiem ftk = new frmtimkiem();
            panel_show.Show();
            panel_show.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ftk);
            ftk.Show();
        }



        private void menuItem19_Click(object sender, EventArgs e)
        {

        }

        private void menuItem20_Click(object sender, EventArgs e)
        {

        }


        private void cmd_exit_MouseMove(object sender, MouseEventArgs e)
        {
            cmd_exit.BackgroundImage = Properties.Resources.butbut;
        }

        private void cmd_exit_MouseLeave(object sender, EventArgs e)
        {
            cmd_exit.BackgroundImage = Properties.Resources._133;
        }
        //int n;
        //private void cmd_taiKhoan_Click(object sender, EventArgs e)
        //{
        //    if (n == 0)
        //    {
        //        cmd_taiKhoan.ForeColor = Color.DarkMagenta;
        //        cmd_danhmuc.Location = new Point(28, 324);
        //        cmd_quanly.Location = new Point(28, 379);
        //        cmd_chucnag.Location = new Point(28, 434);
        //        panel_taikhoan.Show();
        //        panel_taikhoan.Location = new Point(40, 211);
        //        panel_taikhoan.Size = new Size(143, 97);
        //        n = 1;
        //    }
        //    else if (n == 1)
        //    {

        //        vitricu();
        //        n = 0;
        //    }
        //}

        //public void vitricu()
        //{
        //    cmd_taiKhoan.ForeColor = Color.Black;
        //    cmd_quanly.ForeColor = Color.Black;
        //    cmd_danhmuc.ForeColor = Color.Black;
        //    cmd_chucnag.ForeColor = Color.Black;
        //    panel_taikhoan.Hide();
        //    panel_danhmuc.Hide();
        //    panel_quanly.Hide();
        //    panel_chucnang.Hide();
        //    cmd_danhmuc.Location = new Point(28, 213);
        //    cmd_quanly.Location = new Point(28, 268);
        //    cmd_chucnag.Location = new Point(28, 323);
        //    panel_chucnang.Size = new Size(143, 166);
        //    panel_danhmuc.Size = new Size(143, 166);
        //    panel_quanly.Size = new Size(143, 166);


        //}

        //private void cmd_danhmuc_Click(object sender, EventArgs e)
        //{
        //    if (n == 0)
        //    {
        //        cmd_danhmuc.ForeColor = Color.DarkMagenta;
        //        cmd_quanly.Location = new Point(28, 445);
        //        cmd_chucnag.Location = new Point(28, 500);
        //        panel_danhmuc.Show();
        //        panel_danhmuc.Location = new Point(40, 267);
        //        panel_danhmuc.Size = new Size(143, 166);
        //        n = 1;
        //    }
        //    else if (n == 1)
        //    {

        //        vitricu();
        //        n = 0;
        //    }
        //}


        private void cmd_taiKhoan_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void cmd_taiKhoan_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }

        private void cmd_dangnhap_Click(object sender, EventArgs e)
        {


            this.Hide();
            frmdangnhap f1 = new frmdangnhap();
            f1.ShowDialog();
            this.Close();
            //Global.frmmain.Hide();
            //frmdangnhap f1 = new frmdangnhap();
            //f1.ShowDialog();

            //panel_show.Show();
            //panel_show.Controls.Clear();
            //f1.TopLevel = false;
            //f1.Dock = DockStyle.Fill;
            //panel_show.Controls.Add(f1);
            //f1.Show();

        }

        private void cmd_dangnhap_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
        }

        private void cmd_dangnhap_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.b1;
        }

        private void cmd_dangky_Click(object sender, EventArgs e)
        {


        }

        //private void cmd_chucnag_Click(object sender, EventArgs e)
        //{
        //    if (n == 0)
        //    {
        //        cmd_chucnag.ForeColor = Color.DarkMagenta;

        //        panel_chucnang.Show();
        //        panel_chucnang.Location = new Point(40, 375);
        //        panel_chucnang.Size = new Size(143, 166);
        //        n = 1;
        //    }
        //    else if (n == 1)
        //    {

        //        vitricu();
        //        n = 0;
        //    }
        //}

        //private void cmd_quanly_Click(object sender, EventArgs e)
        //{
        //    if (n == 0)
        //    {
        //        cmd_quanly.ForeColor = Color.DarkMagenta;

        //        cmd_chucnag.Location = new Point(28, 491);
        //        panel_quanly.Show();
        //        panel_quanly.Location = new Point(40, 323);
        //        panel_quanly.Size = new Size(143, 166);
        //        n = 1;
        //    }
        //    else if (n == 1)
        //    {

        //        vitricu();
        //        n = 0;
        //    }
        //}

        private void cmd_nhansu_Click(object sender, EventArgs e)
        {
            frmcoban fc = new frmcoban();
            panel_show.Show();
            panel_show.Controls.Clear();
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fc);
            fc.Show();

        }

        private void cmd_thongticanhan_Click(object sender, EventArgs e)
        {
            frmthongtincanhan ft = new frmthongtincanhan();

            panel_show.Show();
            panel_show.Controls.Clear();
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ft);
            ft.Show();

        }

        private void cmd_chedo_Click(object sender, EventArgs e)
        {
            frmchedo fcd = new frmchedo();
            panel_show.Show();
            panel_show.Controls.Clear();
            fcd.TopLevel = false;
            fcd.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fcd);
            fcd.Show();
        }

        private void cmd_tienluong_Click(object sender, EventArgs e)
        {
            frmluong fl = new frmluong();

            panel_show.Show();
            panel_show.Controls.Clear();
            fl.TopLevel = false;
            fl.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fl);
            fl.Show();
        }

        private void cmd_tracuu_Click(object sender, EventArgs e)
        {
            frmtimkiem ftk = new frmtimkiem();
            panel_show.Show();
            panel_show.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ftk);
            ftk.Show();
        }

        private void cmd_Qlphongban_Click(object sender, EventArgs e)
        {
            frmphongban fpb = new frmphongban();
            panel_show.Show();
            panel_show.Controls.Clear();
            fpb.TopLevel = false;
            fpb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fpb);
            fpb.Show();

        }

        private void cmd_Qlbophan_Click(object sender, EventArgs e)
        {
            frmbophan frb = new frmbophan();
            panel_show.Show();
            panel_show.Controls.Clear();
            frb.TopLevel = false;
            frb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frb);
            frb.Show();
        }

        private void cmd_QLhoso_Click(object sender, EventArgs e)
        {
            frmhosothuviec fhtv = new frmhosothuviec();

            panel_show.Show();
            panel_show.Controls.Clear();
            fhtv.TopLevel = false;
            fhtv.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fhtv);
            fhtv.Show();
        }

        private void cmd_qlbangcong_Click(object sender, EventArgs e)
        {
            frmbangcong fbc = new frmbangcong();

            panel_show.Show();
            panel_show.Controls.Clear();
            fbc.TopLevel = false;
            fbc.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fbc);
            fbc.Show();
        }

        //private void button1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    button1.Size = new Size(45, 36);
        //}

        //private void button1_MouseLeave(object sender, EventArgs e)
        //{
        //    button1.Size = new Size(43, 34);
        //}

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    vitricu();
        //}

        private void btntracuu_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmtimkiem ftk = new frmtimkiem();
            panel_show.Show();
            panel_show.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ftk);
            ftk.Show();
        }

        private void btndmk_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmdoimatkhau fdm = new frmdoimatkhau();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();

        }

        private void btnchedo_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmchedo fcd = new frmchedo();
            panel_show.Show();
            panel_show.Controls.Clear();
            fcd.TopLevel = false;
            fcd.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fcd);
            fcd.Show();
        }

        private void btnluong_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmluong fl = new frmluong();

            panel_show.Show();
            panel_show.Controls.Clear();
            fl.TopLevel = false;
            fl.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fl);
            fl.Show();
        }

        private void bubblenhansu_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmthongtincanhan ft = new frmthongtincanhan();

            panel_show.Show();
            panel_show.Controls.Clear();
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ft);
            ft.Show();
        }

        private void bubblebophan_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmbophan frb = new frmbophan();
            panel_show.Show();
            panel_show.Controls.Clear();
            frb.TopLevel = false;
            frb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frb);
            frb.Show();
        }

        private void bubblephongban_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmphongban fpb = new frmphongban();
            panel_show.Show();
            panel_show.Controls.Clear();
            fpb.TopLevel = false;
            fpb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fpb);
            fpb.Show();
        }

        private void bubbleBcnhanvien_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void cmd_minimax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cmd_maximax_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).Size = new Size(26, 25);
        }

        private void cmd_maximax_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Size = new Size(24, 23);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void panel_show_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            frmdangnhap dn = new frmdangnhap();
            this.Hide();
            dn.ShowDialog();
            dn.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void menuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuItemdmk_Click_1(object sender, EventArgs e)
        {
            frmdoimatkhau fdm = new frmdoimatkhau();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();

        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            frmcoban fc = new frmcoban();
            panel_show.Show();
            panel_show.Controls.Clear();
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fc);
            fc.Show();

        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            frmthongtincanhan ft = new frmthongtincanhan();

            panel_show.Show();
            panel_show.Controls.Clear();
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ft);
            ft.Show();
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            frmchedo fcd = new frmchedo();
            panel_show.Show();
            panel_show.Controls.Clear();
            fcd.TopLevel = false;
            fcd.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fcd);
            fcd.Show();
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            frmhosothuviec bag = new frmhosothuviec();
            panel_show.Show();
            panel_show.Controls.Clear();
            bag.TopLevel = false;
            bag.Dock = DockStyle.Fill;
            panel_show.Controls.Add(bag);
            bag.Show();
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            frmphongban fpb = new frmphongban();
            panel_show.Show();
            panel_show.Controls.Clear();
            fpb.TopLevel = false;
            fpb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fpb);
            fpb.Show();
        }

        private void menuItem16_Click(object sender, EventArgs e)
        {
            frmbophan frb = new frmbophan();
            panel_show.Show();
            panel_show.Controls.Clear();
            frb.TopLevel = false;
            frb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frb);
            frb.Show();
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            frmbangcong fhtv = new frmbangcong();
            panel_show.Show();
            panel_show.Controls.Clear();
            fhtv.TopLevel = false;
            fhtv.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fhtv);
            fhtv.Show();
        }

        private void menuItem18_Click(object sender, EventArgs e)
        {
            frmluong aa = new frmluong();
            panel_show.Show();
            panel_show.Controls.Clear();
            aa.TopLevel = false;
            aa.Dock = DockStyle.Fill;
            panel_show.Controls.Add(aa);
            aa.Show();

        }

        private void menuItem19_Click_1(object sender, EventArgs e)
        {
            bcnv a = new bcnv();
            panel_show.Show();
            panel_show.Controls.Clear();
            a.TopLevel = false;
            a.Dock = DockStyle.Fill;
            panel_show.Controls.Add(a);
            a.Show();

        }

        private void menuItem20_Click_1(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            panel_show.Show();
            panel_show.Controls.Clear();
            a.TopLevel = false;
            a.Dock = DockStyle.Fill;
            panel_show.Controls.Add(a);
            a.Show();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            frmdangki b = new frmdangki();
            panel_show.Show();
            panel_show.Controls.Clear();
            b.TopLevel = false;
            b.Dock = DockStyle.Fill;
            panel_show.Controls.Add(b);
            b.Show();
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            frmtrogiup x = new frmtrogiup();
            panel_show.Show();
            panel_show.Controls.Clear();
            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            panel_show.Controls.Add(x);
            x.Show();
        }

       


    }
}
