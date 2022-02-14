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
    public partial class loginform : Form
    {

        public loginform()
        {
            InitializeComponent();
        }
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;
        Db konn = new Db();
        private string url = "server=localhost;userid=root;password=;database=wms";
        private void loginform_Load(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPass.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        void main()
        {
            HalamanUtama mainForm = new HalamanUtama();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;
            MySqlConnection conn = konn.GetConn();
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * from admin where username='" + tbUsername.Text + "' and password='" + tbPass.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    
                    main();
                }
                else
                {
                    MessageBox.Show("Salah username atau password");
                    Application.Exit();
                }
            }
            
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == false)
                tbPass.UseSystemPasswordChar = true;
            else
                tbPass.UseSystemPasswordChar = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Applicaton", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
