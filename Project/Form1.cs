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
    public partial class loginPage : Form
    {
        
        MySqlConnection connect =new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=luckyplace;");
        
        MySqlDataAdapter adapter;
        DataTable table;
        public loginPage()
        {
            InitializeComponent();
        }
        public void openConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            } 
        }
        public void closeConnection()
        {
            if(connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }
        public static DataTable tableData=new DataTable();
        public void dataAdapterLogin(String query)
        {
            openConnection();
            adapter=new MySqlDataAdapter(query,connect);
            table=new DataTable();
            adapter.Fill(table);
            tableData = table;

            if(table.Rows.Count > 0)
            {
                string status= table.Rows[0][2].ToString();
                if(status == "admin")
                {
                    MessageBox.Show("เข้าสู่ระบบสำเร็จ(ADMIN)", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    adminpage admin = new adminpage();
                    this.Hide();
                    admin.Show(); 
                }
                else if(status == "user")
                {
                    MessageBox.Show("เข้าสู่ระบบสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    userpage user = new userpage();
                    this.Hide();
                    user.Show();
                }
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้หรือ รหัสผ่านไม่ถูกต้อง","แจ้งเตือน",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        

        private void login_Click(object sender, EventArgs e)
        {
            
            string login = "SELECT * FROM user WHERE username = '" + usernameBox.Text + "'AND password='" + passwordBox.Text + "'";
            dataAdapterLogin(login);
        }
        private void linktoleasetxt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            leasePage lease_View = new leasePage();
            lease_View.Show();
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_Click(login_Btn, e);
            }
        }
        private void loginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
