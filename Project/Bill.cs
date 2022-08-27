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

namespace Project
{
    public partial class Bill : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=luckyplace;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        public Bill()
        {
            InitializeComponent();
        }
        private DataTable maintable=new DataTable();
        private void showrental()
        {
            MySqlConnection conn = databaseConnection();
            DataTable ds = new DataTable();
            conn.Open();

            MySqlCommand cmd;
            MySqlCommand cmd_2;
            cmd = conn.CreateCommand();
            cmd_2 = conn.CreateCommand();
            cmd.CommandText = $"SELECT  * FROM rentalfee WHERE room = '{leasePage.globalroom}' "; 
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            maintable = ds;
            conn.Close();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            showrental();
            roomtxt.Text = maintable.Rows[0][0].ToString();
            electotal.Text = maintable.Rows[0][1].ToString();
            watertotal.Text = maintable.Rows[0][2].ToString();
            roompricetxt.Text = maintable.Rows[0][3].ToString();
            totaltxt.Text = maintable.Rows[0][10].ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            userpage user = new userpage();
            user.Show();
        }
    }
}
