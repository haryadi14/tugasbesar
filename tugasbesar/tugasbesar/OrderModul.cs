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
    public partial class OrderModul : Form
    {
        public OrderModul()
        {
            InitializeComponent();
        }
        Db konn = new Db();
        private MySqlCommand cmd;
        private MySqlCommand cmd1;
        private MySqlCommand cmd2;
        private MySqlCommand delcmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void munculkodepelanggan()
        {
            MySqlDataReader rd;
            MySqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new MySqlCommand("select * from pelanggan", conn);
            cmd.CommandType = CommandType.Text;
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {

                comboBox2.Items.Add(rd[0].ToString());

            }
            rd.Close();
            conn.Close();
        }
        void munculidpemasok()
        {
            MySqlDataReader rd;
            MySqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new MySqlCommand("select * from pemasok", conn);
            cmd.CommandType = CommandType.Text;
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {

                comboBox3.Items.Add(rd[0].ToString());

            }
            rd.Close();
            conn.Close();

        }
        void barangdicari()
        {

            MySqlDataReader rd;
            MySqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new MySqlCommand("select * from produk where produk_id='" + txtPid.Text + "'", conn);
            cmd.CommandType = CommandType.Text;
            rd = cmd.ExecuteReader();
            rd.Read();

            if (rd.HasRows)


            {
                lbProduk.Text = rd[0].ToString();
                lbStok.Text = rd[1].ToString();
                lbHarga.Text = rd[2].ToString();
                label22.Text = rd[3].ToString();


            }
        }
        void munculdatabarang()
        {
            dataGridView1.Columns.Add("produk_id", "Kode Barang");
            dataGridView1.Columns.Add("namabarang", "Nama Barang");
            dataGridView1.Columns.Add("kategori", "Kategori");
            dataGridView1.Columns.Add("harga", "Harga");
            dataGridView1.Columns.Add("stok", "Jumlah");
            dataGridView1.Columns.Add("subtotal", "Subtotal");

            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
        void nootomatis()
        {
            long hitung;
            string urutan;
            MySqlDataReader rd;
            MySqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new MySqlCommand("select no_transaksi from transaksi where no_transaksi in(select max(no_transaksi) from transaksi) order by no_transaksi desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["no_transaksi"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urutan = "ADI" + joinstr.Substring(joinstr.Length - 3, 3);

            }
            else
            {
                urutan = "ADI000";
            }
            rd.Close();
            textBox4.Text = urutan;
            conn.Close();


        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtPid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtPName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dtOrder_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UDQty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataReader rd;
            MySqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new MySqlCommand("select * from pelanggan where id ='" + comboBox2.Text + "'", conn);
            cmd.CommandType = CommandType.Text;
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                lbPelanggan.Text = rd[1].ToString();
            }
        }

        void Rumushitung()
        {
            decimal hitung = 0;

            for (int i = 0; i < Convert.ToInt32(dataGridView1.Rows.Count) - 1; i++)
            {
                hitung = hitung + Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
            }
            label21.Text = hitung.ToString();
        }
        void kondisiawaljumlah()
        {
            textBox1.Enabled = true;
            textBox1.Text = "";
        }
        void kondisiawal()
        {
            textBox4.Text = "";
            comboBox2.Text = "";
            lbPelanggan.Text = "";
            comboBox3.Text = "";
            label25.Text = "";
            txtPid.Text = "";
            lbProduk.Text = "";
            lbHarga.Text = "";
            lbPelanggan.Text = "";
            lbStok.Text = "";
            lbTanggal.Text = DateTime.Today.ToString();
            textBox1.Text = "";
            label21.Text = "0";
           
            this.dataGridView1.Rows.Clear();
        }


        private void lbPelanggan_Click(object sender, EventArgs e)
        {

        }


        private void OrderModul_Load(object sender, EventArgs e)
        {
            lbTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            kondisiawal();
            munculkodepelanggan();
            nootomatis();
            munculdatabarang();
            munculidpemasok();
            txtPid.Enabled = true;
            textBox4.Enabled = true;
            kondisiawaljumlah();
            label21.Text = "0";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataReader rd;
            MySqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new MySqlCommand("select * from pemasok where id_pemasok ='" + comboBox3.Text + "'", conn);
            cmd.CommandType = CommandType.Text;
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                label25.Text = rd[1].ToString();
            }
        }

        private void txtPid_KeyPress(object sender, KeyPressEventArgs e)
        {
            barangdicari();
        }
        void item()
        {
            decimal hitung = 0;

            for (int i = 0; i < Convert.ToInt32(dataGridView1.Rows.Count) - 1; i++)
            {
                hitung = hitung + Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
            }
            label28.Text = hitung.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int stok;
            int jumlah;

            stok = Convert.ToInt32(lbStok.Text);
            jumlah = Convert.ToInt32(textBox1.Text);

            if (stok < jumlah)
            {
                MessageBox.Show("Mohon Maaf untuk stok barang Kurang");
            }

            else
            {
                int i;
                int j;
                int subtotal;
                i = Convert.ToInt32(lbHarga.Text);
                j = Convert.ToInt32(textBox1.Text);
                subtotal = j * i;
                string[] dataBaru = new string[] { txtPid.Text, lbProduk.Text,label22.Text, lbHarga.Text, textBox1.Text, label21.Text = subtotal.ToString() };
                dataGridView1.Rows.Add(dataBaru);
            }
            Rumushitung();
            item();
            kondisiawaljumlah();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int bayar;
                int total;
                int totalakhir;

                bayar = Convert.ToInt32(textBox5.Text);
                total = Convert.ToInt32(label21.Text);

                totalakhir = bayar - total;
                if (bayar < total)
                {
                    MessageBox.Show("Mohon Maaf untuk Uangnya Kurang");
                }
                else if (bayar == total)
                {
                    label24.Text = "0";
                }
                else if (bayar > total)
                {
                    label24.Text = totalakhir.ToString();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPid.Text == "")
            {
                MessageBox.Show("Proses Transaksi Tidak Ada Pastikan anda mengisi dengan benar");
            }


            else
            {
                MySqlConnection conn = konn.GetConn();
                lbTanggal.Text = DateTime.Now.ToString("yyyy-MM-dd");
                cmd = new MySqlCommand("insert into transaksi values('" + textBox4.Text + "','" + lbProduk.Text + "','" + lbPelanggan.Text + "','" + label28.Text + "','" + textBox5.Text + "','" + label24.Text + "','" + label21.Text + "','" + lbTanggal.Text + "','" + comboBox3.Text + "','" + txtPid.Text + "')", conn);
                cmd1 = new MySqlCommand("Update produk set jumlah = jumlah - '" + label28.Text + "' where produk_id='" + txtPid.Text + "'", conn);




                conn.Open(); cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Transaksi Berhasil Dicetak");


            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click_1(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void lbHarga_Click(object sender, EventArgs e)
        {

        }

        private void lbStok_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
             kondisiawal();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            transaksi frm = new transaksi();
            frm.Show();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int stok;
                int jumlah;

                stok = Convert.ToInt32(lbStok.Text);
                jumlah = Convert.ToInt32(textBox1.Text);

                if (stok < jumlah)
                {
                    MessageBox.Show("Mohon Maaf untuk Uangnya Kurang");
                }
               

            }
        }
    }
}
