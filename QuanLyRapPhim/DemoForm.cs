﻿using System;
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
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new QuanLyNhanVienForm().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new QuanLyBanVe().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new QuanLyPhim().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new QuanLyLichChieu().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new SeatBookingForm().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new QuanLyPhongChieu().ShowDialog();
        }
    }
}
