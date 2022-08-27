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
    public partial class feedback_view : Form
    {
        public feedback_view()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=luckyplace;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        private void showfeedback()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM feedback";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            dataFeedback.DataSource = ds.Tables[0].DefaultView;
        }

        private void feedback_view_Load(object sender, EventArgs e)
        {
            showfeedback();
        }

        private void dataFeedback_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataFeedback.CurrentRow.Selected = true;
            roomtxt.Text = dataFeedback.Rows[e.RowIndex].Cells["room"].FormattedValue.ToString();
            feedbacksubtxt.Text = dataFeedback.Rows[e.RowIndex].Cells["feedback"].FormattedValue.ToString();
            feedbackinfotxt.Text = dataFeedback.Rows[e.RowIndex].Cells["info"].FormattedValue.ToString();
            statustxt.Text = dataFeedback.Rows[e.RowIndex].Cells["status"].FormattedValue.ToString();
            howtotxt.Text = dataFeedback.Rows[e.RowIndex].Cells["how"].FormattedValue.ToString();
        }


        private void editstatusBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = dataFeedback.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataFeedback.Rows[selectedRow].Cells["id"].Value);

            if (howtotxt.Text == "")
            {
                MessageBox.Show("กรุณากรอกการจัดการเรื่องร้องเรียน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("ดำเนินการปรับสถานะของเรื่องร้องเรียนหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection conn = databaseConnection();

                    String sql = "UPDATE feedback SET status = '" + "แจ้งเตือนเรียบร้อยแล้ว" + "' WHERE id = '" + editId + "'";
                    string sql_ = "UPDATE feedback SET how='" + howtotxt.Text + "'WHERE id='" + editId + "'";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlCommand cmd_ = new MySqlCommand(sql_, conn);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();
                    int rows_ = cmd_.ExecuteNonQuery();
                    conn.Close();
                    if (rows > 0)
                    {
                        MessageBox.Show("ปรับสถานะเรียบร้อย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showfeedback();
                    }
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
