using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class QuanLyLichChieuForm : Form
    {
        public QuanLyLichChieuForm()
        {
            InitializeComponent();
            QuanLyLichChieu_Load();
        }
        public void QuanLyLichChieu_Load()
        {
            xoaLichChieu1.Hide();
            suaLichChieu1.Hide();
            themLichChieu1.Hide();
            lietKeDSLichChieu1.Hide();
        }
        private void DSButton_Click(object sender, EventArgs e)
        {
            lietKeDSLichChieu1.Show();
            themLichChieu1.Hide();
            xoaLichChieu1.Hide();
            suaLichChieu1.Hide();
            suaLichChieu1.BringToFront();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            lietKeDSLichChieu1.Hide();
            xoaLichChieu1.Hide();
            suaLichChieu1.Hide();
            themLichChieu1.Show();
            themLichChieu1.BringToFront();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            lietKeDSLichChieu1.Hide();
            themLichChieu1.Hide();
            suaLichChieu1.Hide();
            xoaLichChieu1.Show();
            xoaLichChieu1.BringToFront();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            lietKeDSLichChieu1.Hide();
            themLichChieu1.Hide();
            xoaLichChieu1.Hide();
            suaLichChieu1.Show();
            suaLichChieu1.BringToFront();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
