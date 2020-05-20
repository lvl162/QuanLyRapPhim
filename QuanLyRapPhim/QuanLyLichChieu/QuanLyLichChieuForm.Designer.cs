namespace QuanLyRapPhim
{
    partial class QuanLyLichChieuForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.DSButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xoaLichChieu1 = new QuanLyRapPhim.XoaLichChieu();
            this.themLichChieu1 = new QuanLyRapPhim.ThemLichChieu();
            this.suaLichChieu1 = new QuanLyRapPhim.SuaLichChieu();
            this.lietKeDSLichChieu1 = new QuanLyRapPhim.LietKeDSLichChieu();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.DSButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 42);
            this.panel1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(256, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 34);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Them ";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(363, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 34);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Xoa";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(470, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 34);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Sua";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // DSButton
            // 
            this.DSButton.Location = new System.Drawing.Point(108, 5);
            this.DSButton.Name = "DSButton";
            this.DSButton.Size = new System.Drawing.Size(116, 34);
            this.DSButton.TabIndex = 0;
            this.DSButton.Text = "DSLichChieu";
            this.DSButton.UseVisualStyleBackColor = true;
            this.DSButton.Click += new System.EventHandler(this.DSButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(577, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 34);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Thoat";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lietKeDSLichChieu1);
            this.panel2.Controls.Add(this.xoaLichChieu1);
            this.panel2.Controls.Add(this.themLichChieu1);
            this.panel2.Controls.Add(this.suaLichChieu1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 408);
            this.panel2.TabIndex = 1;
            // 
            // xoaLichChieu1
            // 
            this.xoaLichChieu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xoaLichChieu1.Location = new System.Drawing.Point(0, 0);
            this.xoaLichChieu1.Name = "xoaLichChieu1";
            this.xoaLichChieu1.Size = new System.Drawing.Size(800, 408);
            this.xoaLichChieu1.TabIndex = 2;
            // 
            // themLichChieu1
            // 
            this.themLichChieu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themLichChieu1.Location = new System.Drawing.Point(0, 0);
            this.themLichChieu1.Name = "themLichChieu1";
            this.themLichChieu1.Size = new System.Drawing.Size(800, 408);
            this.themLichChieu1.TabIndex = 1;
            // 
            // suaLichChieu1
            // 
            this.suaLichChieu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suaLichChieu1.Location = new System.Drawing.Point(0, 0);
            this.suaLichChieu1.Name = "suaLichChieu1";
            this.suaLichChieu1.Size = new System.Drawing.Size(800, 408);
            this.suaLichChieu1.TabIndex = 0;
            // 
            // lietKeDSLichChieu1
            // 
            this.lietKeDSLichChieu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lietKeDSLichChieu1.Location = new System.Drawing.Point(0, 0);
            this.lietKeDSLichChieu1.Name = "lietKeDSLichChieu1";
            this.lietKeDSLichChieu1.Size = new System.Drawing.Size(800, 408);
            this.lietKeDSLichChieu1.TabIndex = 3;
            // 
            // QuanLyLichChieuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyLichChieuForm";
            this.Text = "QuanLyLichChieuForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button DSButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel2;
        private XoaLichChieu xoaLichChieu1;
        private ThemLichChieu themLichChieu1;
        private SuaLichChieu suaLichChieu1;
        private LietKeDSLichChieu lietKeDSLichChieu1;
    }
}