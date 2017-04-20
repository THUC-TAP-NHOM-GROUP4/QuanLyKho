using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using QuanLyKho.View;

namespace QuanLyKho
{
    public partial class QUANLYKHO : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static XtraTabControl tabstatic;
        public QUANLYKHO()
        {
            InitializeComponent();
            tabstatic = xtraTabControl1;
        }
        public void Skins()
        {
            DevExpress.UserSkins.BonusSkins.Register();

            DevExpress.UserSkins.OfficeSkins.Register();

            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinHT, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Skins();
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
        }

       
        public static bool KiemTraTabPage(string Ten)
        {
            bool ok = false;
            foreach (XtraTabPage tabpage in tabstatic.TabPages)
            {
                if (tabpage.Text == Ten)
                {
                    return ok = true;
                }
            }
            return ok;
        }
        public static int ViTriTabPage(string Ten)
        {
            int vitri = 0;
            for (int i = 0; i < tabstatic.TabPages.Count; i++)
            {
                if (tabstatic.TabPages[i].Text == Ten)
                    vitri = i;
            }
            return vitri;
        }

        public static void thoattab()
        {
            int i = tabstatic.SelectedTabPageIndex;
            tabstatic.TabPages.RemoveAt(i);
            tabstatic.SelectedTabPageIndex = i - 1;
        }

        private void bbiNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage tabNhapHang = new XtraTabPage();
            tabNhapHang.Text = "Phiếu nhập";
            if (KiemTraTabPage(tabNhapHang.Text) == false)
                xtraTabControl1.TabPages.Add(tabNhapHang);
            else
                tabNhapHang.PageVisible = true;
            UC_NhapHang NhapHang = new UC_NhapHang();
            NhapHang.Parent = xtraTabControl1.TabPages[ViTriTabPage(tabNhapHang.Text)];
            NhapHang.Dock = DockStyle.Fill;
            NhapHang.Show();
            xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[ViTriTabPage(tabNhapHang.Text)];


        }

        private void bbiPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage tabXuatHang = new XtraTabPage();
            tabXuatHang.Text = "Phiếu xuất";
            if (KiemTraTabPage(tabXuatHang.Text) == false)
                xtraTabControl1.TabPages.Add(tabXuatHang);
            else
                tabXuatHang.PageVisible = true;
            UC_NhapHang XuatHang = new UC_NhapHang();
            XuatHang.Parent = xtraTabControl1.TabPages[ViTriTabPage(tabXuatHang.Text)];
            XuatHang.Dock = DockStyle.Fill;
            XuatHang.Show();
            xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[ViTriTabPage(tabXuatHang.Text)];
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {


        
            int h = 0;

            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            if (xtraTabControl1.SelectedTabPage.Equals((arg.Page as XtraTabPage)))
                h = xtraTabControl1.SelectedTabPageIndex;
            xtraTabControl1.TabPages.Remove((arg.Page as XtraTabPage));
            xtraTabControl1.SelectedTabPageIndex = h - 1;
        }
    
    }
}
