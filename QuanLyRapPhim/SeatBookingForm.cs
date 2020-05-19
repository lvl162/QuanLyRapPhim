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
        public SeatBookingForm()
        {
            InitializeComponent();
            foreach (var c in Controls)
            {
                if (c is PictureBox)
                {
                    (c as PictureBox).Click += chooseSeat_Click;
                }
                
            }
        }
        static String filepath = "E:\\test.txt";// đường dẫn của file muốn tạo
        static FileStream fs = new FileStream(filepath, FileMode.Create);//Tạo file mới tên là test.txt            
        StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 
        private void chooseSeat_Click(object sender, EventArgs e)
        {
            if ((sender as PictureBox).BackColor == Color.White){
                (sender as PictureBox).BackColor = Color.Blue;
                sWriter.WriteLine((sender as PictureBox).Location);
                int x = (sender as PictureBox).Location.X;
                int y = (sender as PictureBox).Location.Y;
                int l = 64 + (int) Math.Floor((y - 78)/ 44f + 1);
                int r = (int) Math.Round((x - 73)/ 58f + 1);
                MessageBox.Show("Ban da chon ghe " + (char)l + r);
            }
        }
        
    }
}
