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
    public partial class feedbackpage : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=luckyplace;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        public feedbackpage()
        {
            InitializeComponent();
        }

        private void summitBtn_Click(object sender, EventArgs e)
        {
            if (feedbackinfotxt.Text == ""||feedbacksubtxt.Text==""|| feedbackinfotxt.Text == " " || feedbacksubtxt.Text == " ")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("ดำเนินการเพิ่มข้อมูลหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection conn = databaseConnection();
                    String sql = "INSERT INTO feedback (room,feedback,info,status) VALUES('" + usershowtxt.Text + "','" + feedbacksubtxt.Text + "','" + feedbackinfotxt.Text + "','" + "ยังไม่ได้จัดการ" + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    conn.Close();
                    if (MessageBox.Show("บันทึกข้อมูลสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Hide();
                        userpage user = new userpage();
                        this.Hide();
                        user.Show();
                    }
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            userpage user = new userpage();
            this.Hide();
            user.Show();
        }

        private void feedbackpage_Load(object sender, EventArgs e)
        {
            usershowtxt.Text = loginPage.tableData.Rows[0][3].ToString();
        }
    }
}
