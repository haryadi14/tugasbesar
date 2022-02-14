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
    public partial class UserModulForm : Form
    {
        public UserModulForm()
        {
            InitializeComponent();
        }
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;
        Db konn = new Db();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserModulForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "" || txtNama.Text.Trim() == "" || txtAlamat.Text.Trim() == "" || textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua terisi");
            }
            else
            {
                MySqlConnection conn = konn.GetConn();
                cmd = new MySqlCommand("insert into pelanggan values('" + textBox2.Text + "','" + txtNama.Text + "','" + txtAlamat.Text + "','" + textBox1.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil masuk");

            }
        }
        void munculproduk()
        {
            MySqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM pelanggan", conn);
            ds = new DataSet();
            da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "pelanggan");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "pelanggan";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox2.Text = row.Cells["id"].Value.ToString();
                txtNama.Text = row.Cells["nama"].Value.ToString();
                txtAlamat.Text = row.Cells["alamat"].Value.ToString();
                textBox1.Text = row.Cells["no_hp"].Value.ToString();


            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }

        }
        void kondisireset()
        {
            textBox2.Text = "";
            txtNama.Text = "";
            txtAlamat.Text = "";
            textBox1.Text = "";

            munculproduk();
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "" || txtNama.Text.Trim() == "" || txtAlamat.Text.Trim() == "" || textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua terisi");
            }
            else
            {
                MySqlConnection conn = konn.GetConn();
                cmd = new MySqlCommand("Update pelanggan set nama = '" + textBox2.Text + "','" + txtNama.Text + "', alamat = '" + txtAlamat.Text + "', no_hp = '" + textBox1.Text + "', where Id = '" + textBox2.Text + "'", conn);
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
            if (textBox2.Text.Trim() == "" || txtNama.Text.Trim() == "" || txtAlamat.Text.Trim() == "" || textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua terisi");
            }
            else
            {
                if (MessageBox.Show("APAKAH YAKIN AKAN MENGHAPUS DATA INI :" + txtNama.Text + "??", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection conn = konn.GetConn();

                    cmd = new MySqlCommand("DELETE from pelanggan where id ='" + textBox2.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil di Hapus");
                    kondisireset();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kondisireset();

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)

        {
            if ((e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("hanya bisa diisi angka");
            }
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        void nootomatis()
        {
            long hitung;
            string urutan;
            MySqlDataReader rd;
            MySqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new MySqlCommand("select id from pelanggan where id in(select max(id) from pelanggan) order by id desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[1].ToString().Substring(rd["id"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urutan = "PEL" + joinstr.Substring(joinstr.Length - 3, 3);

            }
            else
            {
                urutan = "PEL001";
            }
            rd.Close();
            textBox2.Text = urutan;
            conn.Close();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            nootomatis();
        }
    }
    
}
