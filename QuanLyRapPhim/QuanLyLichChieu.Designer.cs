namespace QuanLyRapPhim
{
    partial class QuanLyLichChieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dsTabPage = new System.Windows.Forms.TabPage();
            this.addTabPage = new System.Windows.Forms.TabPage();
            this.delTabPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.findButton = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.updateTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.delTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dsTabPage);
            this.tabControl1.Controls.Add(this.addTabPage);
            this.tabControl1.Controls.Add(this.delTabPage);
            this.tabControl1.Controls.Add(this.updateTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 503);
            this.tabControl1.TabIndex = 0;
            // 
            // dsTabPage
            // 
            this.dsTabPage.Location = new System.Drawing.Point(4, 25);
            this.dsTabPage.Name = "dsTabPage";
            this.dsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dsTabPage.Size = new System.Drawing.Size(1030, 474);
            this.dsTabPage.TabIndex = 0;
            this.dsTabPage.Text = "Liet ke DS Lich Chieu";
            this.dsTabPage.UseVisualStyleBackColor = true;
            // 
            // addTabPage
            // 
            this.addTabPage.Location = new System.Drawing.Point(4, 25);
            this.addTabPage.Name = "addTabPage";
            this.addTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addTabPage.Size = new System.Drawing.Size(1030, 474);
            this.addTabPage.TabIndex = 1;
            this.addTabPage.Text = "Them Lich Chieu";
            this.addTabPage.UseVisualStyleBackColor = true;
            // 
            // delTabPage
            // 
            this.delTabPage.Controls.Add(this.panel2);
            this.delTabPage.Controls.Add(this.panel1);
            this.delTabPage.Controls.Add(this.label3);
            this.delTabPage.Controls.Add(this.label2);
            this.delTabPage.Controls.Add(this.dateTimePicker2);
            this.delTabPage.Controls.Add(this.dateTimePicker1);
            this.delTabPage.Location = new System.Drawing.Point(4, 25);
            this.delTabPage.Name = "delTabPage";
            this.delTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.delTabPage.Size = new System.Drawing.Size(1030, 474);
            this.delTabPage.TabIndex = 2;
            this.delTabPage.Text = "Xoa Lich Chieu";
            this.delTabPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(340, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 372);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh sách lịch chiếu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.findButton);
            this.panel1.Controls.Add(this.listBox3);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(20, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 382);
            this.panel1.TabIndex = 2;
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(71, 312);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(129, 36);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Tìm kiếm";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(41, 234);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(193, 24);
            this.listBox3.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(44, 152);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(193, 24);
            this.listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(41, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 24);
            this.listBox1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phòng chiếu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ca chiếu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(602, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(222, 26);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // updateTabPage
            // 
            this.updateTabPage.Location = new System.Drawing.Point(4, 25);
            this.updateTabPage.Name = "updateTabPage";
            this.updateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.updateTabPage.Size = new System.Drawing.Size(1030, 474);
            this.updateTabPage.TabIndex = 3;
            this.updateTabPage.Text = "Update Lich Chieu";
            this.updateTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Lịch Chiếu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.NgayChieu});
            this.dataGridView1.Location = new System.Drawing.Point(42, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 253);
            this.dataGridView1.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 125;
            // 
            // NgayChieu
            // 
            this.NgayChieu.HeaderText = "Ngày Chiếu";
            this.NgayChieu.MinimumWidth = 6;
            this.NgayChieu.Name = "NgayChieu";
            this.NgayChieu.Width = 125;
            // 
            // QuanLyLichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 556);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyLichChieu";
            this.Text = "QuanLyLichChieu";
            this.tabControl1.ResumeLayout(false);
            this.delTabPage.ResumeLayout(false);
            this.delTabPage.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dsTabPage;
        private System.Windows.Forms.TabPage addTabPage;
        private System.Windows.Forms.TabPage delTabPage;
        private System.Windows.Forms.TabPage updateTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChieu;
    }
}