namespace tugasbesar
{
    partial class HalamanUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanUtama));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.pelangganButton5 = new tugasbesar.PelangganButton();
            this.pelangganButton4 = new tugasbesar.PelangganButton();
            this.pelangganButton2 = new tugasbesar.PelangganButton();
            this.pelangganButton1 = new tugasbesar.PelangganButton();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pelangganButton5);
            this.panel1.Controls.Add(this.pelangganButton4);
            this.panel1.Controls.Add(this.pelangganButton2);
            this.panel1.Controls.Add(this.pelangganButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 100);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(616, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(465, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pelanggan";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(333, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pemasok";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(219, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Produk";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(427, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inventory Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 551);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(947, 48);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(947, 451);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // pelangganButton5
            // 
            this.pelangganButton5.Image = ((System.Drawing.Image)(resources.GetObject("pelangganButton5.Image")));
            this.pelangganButton5.ImageHover = ((System.Drawing.Image)(resources.GetObject("pelangganButton5.ImageHover")));
            this.pelangganButton5.ImageNormal = ((System.Drawing.Image)(resources.GetObject("pelangganButton5.ImageNormal")));
            this.pelangganButton5.Location = new System.Drawing.Point(602, 12);
            this.pelangganButton5.Name = "pelangganButton5";
            this.pelangganButton5.Size = new System.Drawing.Size(63, 50);
            this.pelangganButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pelangganButton5.TabIndex = 13;
            this.pelangganButton5.TabStop = false;
            this.pelangganButton5.Click += new System.EventHandler(this.pelangganButton5_Click);
            // 
            // pelangganButton4
            // 
            this.pelangganButton4.Image = ((System.Drawing.Image)(resources.GetObject("pelangganButton4.Image")));
            this.pelangganButton4.ImageHover = ((System.Drawing.Image)(resources.GetObject("pelangganButton4.ImageHover")));
            this.pelangganButton4.ImageNormal = ((System.Drawing.Image)(resources.GetObject("pelangganButton4.ImageNormal")));
            this.pelangganButton4.Location = new System.Drawing.Point(466, 12);
            this.pelangganButton4.Name = "pelangganButton4";
            this.pelangganButton4.Size = new System.Drawing.Size(63, 50);
            this.pelangganButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pelangganButton4.TabIndex = 12;
            this.pelangganButton4.TabStop = false;
            this.pelangganButton4.Click += new System.EventHandler(this.pelangganButton4_Click);
            // 
            // pelangganButton2
            // 
            this.pelangganButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pelangganButton2.Image = ((System.Drawing.Image)(resources.GetObject("pelangganButton2.Image")));
            this.pelangganButton2.ImageHover = ((System.Drawing.Image)(resources.GetObject("pelangganButton2.ImageHover")));
            this.pelangganButton2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("pelangganButton2.ImageNormal")));
            this.pelangganButton2.Location = new System.Drawing.Point(341, 12);
            this.pelangganButton2.Name = "pelangganButton2";
            this.pelangganButton2.Size = new System.Drawing.Size(63, 50);
            this.pelangganButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pelangganButton2.TabIndex = 10;
            this.pelangganButton2.TabStop = false;
            this.pelangganButton2.Click += new System.EventHandler(this.pelangganButton2_Click);
            // 
            // pelangganButton1
            // 
            this.pelangganButton1.Image = ((System.Drawing.Image)(resources.GetObject("pelangganButton1.Image")));
            this.pelangganButton1.ImageHover = ((System.Drawing.Image)(resources.GetObject("pelangganButton1.ImageHover")));
            this.pelangganButton1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("pelangganButton1.ImageNormal")));
            this.pelangganButton1.Location = new System.Drawing.Point(215, 12);
            this.pelangganButton1.Name = "pelangganButton1";
            this.pelangganButton1.Size = new System.Drawing.Size(63, 50);
            this.pelangganButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pelangganButton1.TabIndex = 0;
            this.pelangganButton1.TabStop = false;
            this.pelangganButton1.Click += new System.EventHandler(this.pelangganButton1_Click);
            this.pelangganButton1.MouseLeave += new System.EventHandler(this.pelangganButton1_Click);
            this.pelangganButton1.MouseHover += new System.EventHandler(this.pelangganButton1_Click);
            // 
            // HalamanUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 599);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "HalamanUtama";
            this.Text = "HalamanUtama";
            this.Load += new System.EventHandler(this.HalamanUtama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PelangganButton pelangganButton5;
        private PelangganButton pelangganButton4;
        private PelangganButton pelangganButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        public PelangganButton pelangganButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}