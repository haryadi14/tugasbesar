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
    public partial class transaksi : Form
    {
        public transaksi()
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

        private void transaksi_Load(object sender, EventArgs e)
        {
            munculdatabarang();

        }
        void munculdatabarang()
        {
            MySqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new MySqlCommand("select * from transaksi;", conn);
            ds = new DataSet();
            da = new MySqlDataAdapter(cmd);

            da.Fill(ds, "transaksi");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "transaksi";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }
    }
}
