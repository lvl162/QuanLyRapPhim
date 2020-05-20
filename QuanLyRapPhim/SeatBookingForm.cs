using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    
    public partial class SeatBookingForm : Form
    {
        public List<String> seats;
        public String seatsToString()
        {
            String s = "";
            foreach (var item in seats)
            {
                s += item + " ";
            }
            return s;
        }
        public SeatBookingForm()
        {
            InitializeComponent();
            this.seats = new List<string>();
            foreach (var c in Controls)
            {
                if (c is PictureBox)
                {
                    (c as PictureBox).Click += chooseSeat_Click;
                }
                
            }
        }
        private void chooseSeat_Click(object sender, EventArgs e)
        {
            int x = (sender as PictureBox).Location.X;
            int y = (sender as PictureBox).Location.Y;
            int l = 64 + (int)Math.Floor((y - 78) / 44f + 1);
            int r = (int)Math.Round((x - 73) / 58f + 1);
            String seat = (char)l + "" + r;
            if ((sender as PictureBox).BackColor == Color.White){
                //(sender as PictureBox).BackColor = Color.Blue;
                
                MessageBox.Show("Ban da chon ghe " + seat);
                seats.Add(seat);
            }
            if ((sender as PictureBox).BackColor == Color.Blue)
            {
                //(sender as PictureBox).BackColor = Color.White;

                MessageBox.Show("Ban da huy chon ghe " + seat);
                seats.Remove(seat);
            }
            if ((sender as PictureBox).BackColor == Color.Blue) (sender as PictureBox).BackColor = Color.White;
            else (sender as PictureBox).BackColor = Color.Blue;

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (seats.Count == 0)
            {
                MessageBox.Show("Ban chua chon ghe nao!");
                return;
            }
            DialogResult dialogRes = MessageBox.Show("Ban da chon nhung ghe " + seatsToString(), "Xac Nhan", MessageBoxButtons.OKCancel);
            if (dialogRes == DialogResult.OK)
            {

            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
