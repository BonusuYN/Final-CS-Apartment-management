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
    public partial class view_roomstatus : Form
    {

        public view_roomstatus()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=luckyplace;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        private void showroomlist()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM roomlist";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            dataroomlist.DataSource = ds.Tables[0].DefaultView;
        }

        private void veiw_roomstatus_Load(object sender, EventArgs e)
        {
            showroomlist();
        }

        private void unaviableBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = dataroomlist.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataroomlist.Rows[selectedRow].Cells["room"].Value);
            if (howtotxt.Text == "สาเหตุในการปรับสถานะ" || howtotxt.Text == " ")
            {
                MessageBox.Show("กรุณากรอกสาเหตุในการปรับสถานะ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("ดำเนินการปรับสถานะของห้องหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection conn = databaseConnection();

                    String sql = "UPDATE roomlist SET status = '" + "ไม่ว่าง" + "', how='" + howtotxt.Text + "' WHERE room = '" + editId + "'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rows > 0)
                    {
                        MessageBox.Show("ปรับสถานะเรียบร้อย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showroomlist();
                    }
                }
            }
        }

        private void dataroomlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataroomlist.CurrentRow.Selected = true;
        }

        private void aviableBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = dataroomlist.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataroomlist.Rows[selectedRow].Cells["room"].Value);
            if(howtotxt.Text== "สาเหตุในการปรับสถานะ"|| howtotxt.Text == " ")
            {
                MessageBox.Show("กรุณากรอกสาเหตุในการปรับสถานะ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("ดำเนินการปรับสถานะของห้องหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection conn = databaseConnection();

                    String sql = "UPDATE roomlist SET status = '" + "ว่าง" + "' ,how='" + "" + "' WHERE room = '" + editId + "'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rows > 0)
                    {
                        MessageBox.Show("ปรับสถานะเรียบร้อย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showroomlist();
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
        #region watermark
        private void howtotxt_Enter(object sender, EventArgs e)
        {
               String uname = howtotxt.Text;
               if (uname.ToLower().Trim().Equals("สาเหตุในการปรับสถานะ"))
               {
                   howtotxt.Text = "";
                   howtotxt.ForeColor = Color.Black;
               }
        }

        private void howtotxt_Leave(object sender, EventArgs e)
        {
               String uname = howtotxt.Text;
               if (uname.ToLower().Trim().Equals("สาเหตุในการปรับสถานะ") || uname.Trim().Equals(""))
               {
                   howtotxt.Text = "สาเหตุในการปรับสถานะ";
                   howtotxt.ForeColor = Color.Gray;
               }
        }
        #endregion
    }
}
