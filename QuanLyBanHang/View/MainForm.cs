using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Object;
using QuanLyBanHang.Control;
using QuanLyBanHang.View;
using QuanLyBanHang.Report;

namespace QuanLyBanHang
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonForm hd = new HoaDonForm();
            hd.ShowDialog();
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHangForm kh = new KhachHangForm();
            kh.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVienForm nv = new NhanVienForm();
            nv.ShowDialog();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TroGiup tg = new TroGiup();
            tg.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void hàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HangHoaForm hh = new HangHoaForm();
            hh.Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
