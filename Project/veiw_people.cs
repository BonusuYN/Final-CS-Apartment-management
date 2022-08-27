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
    public partial class veiw_people : Form
    {
        public veiw_people()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=luckyplace;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        private void showpeople()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM residents_name";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            datapeople.DataSource = ds.Tables[0].DefaultView;
        }

        private void veiw_people_Load(object sender, EventArgs e)
        {
            showpeople();
        }

        private void datapeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datapeople.CurrentRow.Selected = true;
        }

        private void aviableBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = datapeople.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(datapeople.Rows[selectedRow].Cells["room"].Value);
            if (MessageBox.Show("ดำเนินการปรับสถานะของห้องหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection conn = databaseConnection();

                String sql = "UPDATE residents_name SET name='" + "-" + "',tel='" + "-" + "',dob='" + "-" + "',faculty='" + "-" + "',year='" + "-" + "',address='" + "-" + "',parent_name='" + "-" + "',parent_tel='" + "-" + "',arrival_date = '" + "-" + "' WHERE room = '" + editId + "'"; ;

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    MessageBox.Show("ปรับสถานะเรียบร้อย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showpeople();
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminpage admin = new adminpage();
            this.Hide();
            admin.Show();
        }
    }
}
