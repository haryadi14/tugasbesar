using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tugasbesar
{
    public partial class ProdukModul : Form
    {
        public ProdukModul()
        {
            InitializeComponent();
        }
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;
        Db konn = new Db();
        private string url = "server=localhost;userid=root;password=;database=wms";


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPName.Text.Trim() == "" || txtPQty.Text.Trim() == "" || txtPPrice.Text.Trim() == "" || comboCat.Text.Trim() == "" || dateTimePicker1.Text.Trim() == "") 
            {
                MessageBox.Show("Pastikan semua terisi");
            }
            else
            {
                MySqlConnection conn = konn.GetConn();
                cmd = new MySqlCommand("insert into produk values('" + txtPName.Text + "','" + txtPQty.Text + "','" + txtPPrice.Text + "','" + comboCat.Text + "','" + tbprodukid.Text + "','" + dateTimePicker1.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil masuk");
                
            }
        }
        void munculproduk()
        {
            MySqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM produk", conn);
            ds = new DataSet();
            da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "produk");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "produk";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void categori()
        {
            comboCat.Items.Add("AKSESORIS");
            comboCat.Items.Add("KEYBOARD");
            comboCat.Items.Add("MOUSE");
        }
        private void ProdukModul_Load(object sender, EventArgs e)
        {
            categori();
            munculproduk();

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtPName.Text = row.Cells["nama_produk"].Value.ToString();
                txtPQty.Text = row.Cells["jumlah"].Value.ToString();
                txtPPrice.Text = row.Cells["harga"].Value.ToString();
                comboCat.Text = row.Cells["kategori"].Value.ToString();
                tbprodukid.Text = row.Cells["produk_id"].Value.ToString();
                dateTimePicker1.Text = row.Cells["Tanggal"].Value.ToString();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }
        void kondisireset()
        {
            txtPName.Text = "";
            txtPQty.Text = "";
            txtPPrice.Text = "";
            tbprodukid.Text = "";
            comboCat.Text = "";
            munculproduk();
        }
    

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPName.Text.Trim() == "" || txtPQty.Text.Trim() == "" || txtPPrice.Text.Trim() == "" || comboCat.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua terisi");
            }
            else
            {
                MySqlConnection conn = konn.GetConn();
                cmd = new MySqlCommand("Update produk set nama_produk = '" + txtPName.Text + "', jumlah = '" + txtPQty.Text + "', harga = '" + txtPPrice.Text + "', kategori = '" + comboCat.Text + "' where produk_id = '" + tbprodukid.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil terganti");
                kondisireset();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            kondisireset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPName.Text.Trim() == "" || txtPQty.Text.Trim() == "" || txtPPrice.Text.Trim() == "" || comboCat.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua terisi");
            }
            else
            {
                if (MessageBox.Show("APAKAH YAKIN AKAN MENGHAPUS DATA INI :" + txtPName.Text + "??", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection conn = konn.GetConn();

                    cmd = new MySqlCommand("DELETE from produk where produk_id='" + tbprodukid.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil di Hapus");
                    kondisireset();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            munculproduk();
        }
        
    }
}
