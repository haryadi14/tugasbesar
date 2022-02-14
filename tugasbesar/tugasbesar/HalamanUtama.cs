using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasbesar
{
    public partial class HalamanUtama : Form
    {
        public HalamanUtama()
        {
            InitializeComponent();
        }
       ProdukModul frmproduk;
        UserModulForm frmuser;
        Pemasok frmpmsk;
        OrderModul frmorder;


        void frmlogin_fromClosed(object sender, FormClosedEventArgs e)
        {
           //frmlogin = null;
        }
        void frmproduk_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmproduk = null;
        }
        void frmuser_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmproduk = null;
        }
        void frmpmsk_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmpmsk = null;
        }
        void frmorder_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmorder = null;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pelangganButton1_Click(object sender, EventArgs e)
        {
            if (frmproduk == null)
            {
                frmproduk = new ProdukModul();
                frmproduk.FormClosed += new FormClosedEventHandler(frmproduk_fromClosed);
                frmproduk.ShowDialog();
            }
            else
            {
                frmproduk.Activate();
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pelangganButton2_Click(object sender, EventArgs e)
        {
            if (frmpmsk == null)
            {
                frmpmsk = new Pemasok();
                frmpmsk.FormClosed += new FormClosedEventHandler(frmpmsk_fromClosed);
                frmpmsk.ShowDialog();
            }
            else
            {
                frmpmsk.Activate();
            }
        }

        private void pelangganButton3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pelangganButton4_Click(object sender, EventArgs e)
        {
            if (frmuser == null)
            {
                frmuser = new UserModulForm();
                frmuser.FormClosed += new FormClosedEventHandler(frmuser_fromClosed);
                frmuser.ShowDialog();
            }
            else
            {
                frmuser.Activate();
            }
        }

        private void HalamanUtama_Load(object sender, EventArgs e)
        {

        }

        private void pelangganButton5_Click(object sender, EventArgs e)
        {
            if (frmorder == null)
            {
                frmorder = new OrderModul();
                frmorder.FormClosed += new FormClosedEventHandler(frmorder_fromClosed);
                frmorder.ShowDialog();
            }
            else
            {
                frmpmsk.Activate();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
