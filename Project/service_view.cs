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
    public partial class service_view : Form
    {
        public service_view()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=luckyplace;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        private void showservice()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM service";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            dataService.DataSource = ds.Tables[0].DefaultView;
        }

        private void service_view_Load(object sender, EventArgs e)
        {
            showservice();
        }

        private void dataService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataService.CurrentRow.Selected = true;
            roomtxt.Text = dataService.Rows[e.RowIndex].Cells["room"].FormattedValue.ToString();
           serviceinfotxt.Text = dataService.Rows[e.RowIndex].Cells["maintenaceservice"].FormattedValue.ToString();
            timetxt.Text = dataService.Rows[e.RowIndex].Cells["time"].FormattedValue.ToString();
            statustxt.Text = dataService.Rows[e.RowIndex].Cells["status"].FormattedValue.ToString();
            allowtxt.Text=dataService.Rows[e.RowIndex].Cells["allow"].FormattedValue.ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminpage admin = new adminpage();
            this.Hide();
            admin.Show();
        }

        private void editstatusBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = dataService.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataService.Rows[selectedRow].Cells["id"].Value);
            if (MessageBox.Show("ดำเนินการปรับสถานะของงานแจ้งซ่อมหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection conn = databaseConnection();

                String sql = "UPDATE service SET status = '" + "ดำเนินการเข้าซ่อมเรียบร้อยแล้ว" + "' WHERE id = '" + editId + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    MessageBox.Show("ปรับสถานะเรียบร้อย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showservice();
                }
            }
        }
    }
}
