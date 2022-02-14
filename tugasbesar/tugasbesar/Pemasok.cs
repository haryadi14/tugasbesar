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
    public partial class Pemasok : Form
    {
        public Pemasok()
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


        void kondisireset()
        {
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtNo.Text = "";
            tbId.Text = "";
            munculpemasok();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pemasok_Load(object sender, EventArgs e)
        {
            munculpemasok();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbId.Text.Trim() == "" || txtNama.Text.Trim() == "" || txtAlamat.Text.Trim() == "" || txtNo.Text.Trim() == "" )
            {
                MessageBox.Show("Pastikan semua terisi");
            }
            else
            {
                MySqlConnection conn = konn.GetConn();
                cmd = new MySqlCommand("insert into pemasok values('" + tbId.Text + "','" + txtNama.Text + "','" + txtAlamat.Text + "','" + txtNo.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil masuk");

            }
        }
        void munculpemasok()
        {
            MySqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM pemasok", conn);
            ds = new DataSet();
            da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "pemasok");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "pemasok";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbId.Text.Trim() == "" || txtNama.Text.Trim() == "" || txtAlamat.Text.Trim() == "" || txtNo.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua terisi");
            }
            else
            {
                MySqlConnection conn = konn.GetConn();
                cmd = new MySqlCommand("Update pemasok set nama = '" + txtNama.Text + "', alamat = '" + txtAlamat.Text + "', no_hp = '" + txtNo.Text + "' where id_pemasok = '" + tbId.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil terganti");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            kondisireset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbId.Text.Trim() == "" || txtNama.Text.Trim() == "" || txtAlamat.Text.Trim() == "" || txtNo.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua terisi");
            }
            else
            {
                if (MessageBox.Show("APAKAH YAKIN AKAN MENGHAPUS DATA INI :" + txtNama.Text + "??", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection conn = konn.GetConn();

                    cmd = new MySqlCommand("DELETE from pemasok where id_pemasok='" + tbId.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil di Hapus");

                }
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            munculpemasok();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tbId.Text = row.Cells["id_pemasok"].Value.ToString();
                txtNama.Text = row.Cells["nama"].Value.ToString();
                txtAlamat.Text = row.Cells["alamat"].Value.ToString();
                txtNo.Text = row.Cells["no_hp"].Value.ToString();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }
    }
}
