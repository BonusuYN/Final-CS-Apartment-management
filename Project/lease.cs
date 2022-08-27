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
    public partial class leasePage : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=luckyplace;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        public leasePage()
        {
            InitializeComponent();
        }

        public Boolean checkUsername()
        {
            DB db = new DB();

            String username = user_Box.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM user WHERE username = @usn", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkroom()
        {
            DB db = new DB();

            String room = roomtxt_combo.Text;

            DataTable table2 = new DataTable();

            MySqlDataAdapter adapter2 = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM roomlist WHERE room = @room", db.GetConnection());

            command.Parameters.Add("@room", MySqlDbType.VarChar).Value = room;

            adapter2.SelectCommand = command;

            adapter2.Fill(table2);

            if (table2.Rows.Count > 0)
            {
                string status = table2.Rows[0][1].ToString();
                if(status == "ว่าง")
                {
                    return true;
                }
                else if (status == "ไม่ว่าง")
                {
                    return false;
                }

            }
            return false;
        }
        private void register_Btn_Click(object sender, EventArgs e)
        {
            if (roomtxt_combo.Text == "เลือกหมายเลขห้อง" || nameBox.Text == "ชื่อ-นามสกุล" || telephonrBox.Text == "เบอร์โทรศัพท์" || facBox.Text == "คณะที่กำลังศึกษา" || yearBox.Text == "ชั้นปี" || addressBox.Text == "ที่อยู่ตามทะเบียนบ้าน" || parentnameBox.Text == "ชื่อ-นามสกุล ผู้ปกครอง" || telophonepaBox.Text == "เบอร์โทรศัพท์ผู้ปกครอง" || user_Box.Text == "Username" || pass_Box.Text == "Password"
                || roomtxt_combo.Text == " " || nameBox.Text == " " || telephonrBox.Text == " " || facBox.Text == " " || yearBox.Text == " " || addressBox.Text == " " || parentnameBox.Text == " " || telophonepaBox.Text == " " || user_Box.Text == " " || pass_Box.Text == " ")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (telephonrBox.TextLength < 10)
            {
                MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ให้ครบถ้วน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (telophonepaBox.TextLength < 10)
            {
                MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ผู้ปกครองให้ครบถ้วน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pass_Box.TextLength < 4)
            {
                MessageBox.Show("กรุณากรอกPasswordให้มากกว่า 3 ตัวอักษร", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (pass_Box.Text.Equals(cfpasstxt.Text))
                {

                    if (checkUsername())
                    {
                        MessageBox.Show("มีชื่อผู้ใช่นี้อยู่แล้วกรุณาตั้งใหม่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {


                        if (!checkroom())
                        {
                            MessageBox.Show("กรุณาตรวจสอบเลขห้อง เนื่องจากห้องดังกล่าวมีผู้อยู่อาศัยแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MySqlConnection conn = databaseConnection();
                            String sql = "UPDATE residents_name SET name='" + nameBox.Text + "',tel='" + telephonrBox.Text + "',dob='" + dobpickBox.Text + "',faculty='" + facBox.Text + "',year='" + yearBox.Text + "',address='" + addressBox.Text + "',parent_name='" + parentnameBox.Text + "',parent_tel='" + telophonepaBox.Text + "',arrival_date = '" + arrivedatepick.Text + "' WHERE room = '" + roomtxt_combo.Text + "'";
                            String sql_ = "INSERT INTO user (username,password,status,room) VALUES('" + user_Box.Text + "','" + pass_Box.Text + "', '" + "user" + "','" + roomtxt_combo.Text + "')";
                            string sql_2 = "UPDATE roomlist SET status='" + "ไม่ว่าง" + "',how='" + "มีผู้อยู่อาศัย" + "'WHERE room = '" + roomtxt_combo.Text + "'";
                            MySqlCommand cmd = new MySqlCommand(sql, conn);
                            MySqlCommand sql1 = new MySqlCommand(sql_, conn);
                            MySqlCommand sql2 = new MySqlCommand(sql_2, conn);
                            conn.Open();

                            int rows = cmd.ExecuteNonQuery();
                            int rowss = sql1.ExecuteNonQuery();
                            int rows2 = sql2.ExecuteNonQuery();
                            conn.Close();
                            if (MessageBox.Show("บันทึกข้อมูลสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                this.Hide();
                                loginPage login = new loginPage();
                                login.Show();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("รหัสผ่านไม่ตรงกัน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        #region watermark 

        private void nameBox_Enter(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            if (name.ToLower().Trim().Equals("ชื่อ-นามสกุล"))
            {
                nameBox.Text = "";
                nameBox.ForeColor = Color.Black;
            }
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            if (name.ToLower().Trim().Equals("ชื่อ-นามสกุล") || name.Trim().Equals(""))
            {
                nameBox.Text = "ชื่อ-นามสกุล";
                nameBox.ForeColor = Color.Gray;
            }
        }

        private void telephonrBox_Enter(object sender, EventArgs e)
        {
            String phone = telephonrBox.Text;
            if (phone.ToLower().Trim().Equals("เบอร์โทรศัพท์"))
            {
                telephonrBox.Text = "";
                telephonrBox.ForeColor = Color.Black;
            }
        }

        private void telephonrBox_Leave(object sender, EventArgs e)
        {
            String phone = telephonrBox.Text;
            if (phone.ToLower().Trim().Equals("เบอร์โทรศัพท์") || phone.Trim().Equals(""))
            {
                telephonrBox.Text = "เบอร์โทรศัพท์";
                telephonrBox.ForeColor = Color.Gray;
            }
        }

        private void facBox_Enter(object sender, EventArgs e)
        {
            String fac = facBox.Text;
            if (fac.ToLower().Trim().Equals("คณะที่กำลังศึกษา"))
            {
                facBox.Text = "";
                facBox.ForeColor = Color.Black;
            }
        }

        private void facBox_Leave(object sender, EventArgs e)
        {
            String fac = facBox.Text;
            if (fac.ToLower().Trim().Equals("คณะที่กำลังศึกษา") || fac.Trim().Equals(""))
            {
                facBox.Text = "คณะที่กำลังศึกษา";
                facBox.ForeColor = Color.Gray;
            }
        }

        private void yearBox_Enter(object sender, EventArgs e)
        {
            String year = yearBox.Text;
            if (year.ToLower().Trim().Equals("ชั้นปี"))
            {
                yearBox.Text = "";
                yearBox.ForeColor = Color.Black;
            }
        }

        private void yearBox_Leave(object sender, EventArgs e)
        {
            String year = yearBox.Text;
            if (year.ToLower().Trim().Equals("ชั้นปี") || year.Trim().Equals(""))
            {
                yearBox.Text = "ชั้นปี";
                yearBox.ForeColor = Color.Gray;
            }
        }

        private void addressBox_Enter(object sender, EventArgs e)
        {
            String address = addressBox.Text;
            if (address.ToLower().Trim().Equals("ที่อยู่ตามทะเบียนบ้าน"))
            {
                addressBox.Text = "";
                addressBox.ForeColor = Color.Black;
            }
        }

        private void addressBox_Leave(object sender, EventArgs e)
        {
            String address = addressBox.Text;
            if (address.ToLower().Trim().Equals("ที่อยู่ตามทะเบียนบ้าน") || address.Trim().Equals(""))
            {
                addressBox.Text = "ที่อยู่ตามทะเบียนบ้าน";
                addressBox.ForeColor = Color.Gray;
            }
        }

        private void parentnameBox_Enter(object sender, EventArgs e)
        {
            String pname = parentnameBox.Text;
            if (pname.ToLower().Trim().Equals("ชื่อ-นามสกุล ผู้ปกครอง"))
            {
                parentnameBox.Text = "";
                parentnameBox.ForeColor = Color.Black;
            }
        }

        private void parentnameBox_Leave(object sender, EventArgs e)
        {
            String pname = parentnameBox.Text;
            if (pname.ToLower().Trim().Equals("ชื่อ-นามสกุล ผู้ปกครอง") || pname.Trim().Equals(""))
            {
                parentnameBox.Text = "ชื่อ-นามสกุล ผู้ปกครอง";
                parentnameBox.ForeColor = Color.Gray;
            }
        }

        private void telophonepaBox_Enter(object sender, EventArgs e)
        {
            String ptel = telophonepaBox.Text;
            if (ptel.ToLower().Trim().Equals("เบอร์โทรศัพท์ผู้ปกครอง"))
            {
                telophonepaBox.Text = "";
                telophonepaBox.ForeColor = Color.Black;
            }
        }

        private void telophonepaBox_Leave(object sender, EventArgs e)
        {
            String ptel = telophonepaBox.Text;
            if (ptel.ToLower().Trim().Equals("เบอร์โทรศัพท์ผู้ปกครอง") || ptel.Trim().Equals(""))
            {
                telophonepaBox.Text = "เบอร์โทรศัพท์ผู้ปกครอง";
                telophonepaBox.ForeColor = Color.Gray;
            }
        }

        private void usernameBox_Enter(object sender, EventArgs e)
        {
            String uname = user_Box.Text;
            if (uname.ToLower().Trim().Equals("username"))
            {
                user_Box.Text = "";
                user_Box.ForeColor = Color.Black;
            }
        }

        private void usernameBox_Leave(object sender, EventArgs e)
        {
            String uname = user_Box.Text;
            if (uname.ToLower().Trim().Equals("username") || uname.Trim().Equals(""))
            {
                user_Box.Text = "username";
                user_Box.ForeColor = Color.Gray;
            }
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            String pass = pass_Box.Text;
            if (pass.ToLower().Trim().Equals("password"))
            {
                pass_Box.Text = "";
                pass_Box.ForeColor = Color.Black;
            }
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            String pass = pass_Box.Text;
            if (pass.ToLower().Trim().Equals("password") || pass.Trim().Equals(""))
            {
                pass_Box.Text = "password";
                pass_Box.ForeColor = Color.Gray;
            }
        }
        private void cfpasstxt_Enter(object sender, EventArgs e)
        {
            String cfpass = cfpasstxt.Text;
            if (cfpass.ToLower().Trim().Equals("confirm password"))
            {
                cfpasstxt.Text = "";
                cfpasstxt.ForeColor = Color.Black;
            }
        }

        private void cfpasstxt_Leave(object sender, EventArgs e)
        {
            String cfpass = cfpasstxt.Text;
            if (cfpass.ToLower().Trim().Equals("confirm Password") || cfpass.Trim().Equals(""))
            {
                cfpasstxt.Text = "confirm password";
                cfpasstxt.ForeColor = Color.Gray;
            }
        }
        #endregion 
        #region keypress
        private void telephonrBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled=true;
            }
        }

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 44 && (int)e.KeyChar <= 57)
            {
                MessageBox.Show("ไม่สามารถใส่ตัวเลขได้ !", "ตรวจพบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            else if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 122) || (int)e.KeyChar >= 161 || (int)e.KeyChar == 8 || (int)e.KeyChar == 13 || (int)e.KeyChar == 46 || (int)e.KeyChar == 32)
            {
                e.Handled = false;
            }
        }

        private void yearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void telophonepaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void parentnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 44 && (int)e.KeyChar <= 57)
            {
                MessageBox.Show("ไม่สามารถใส่ตัวเลขได้ !", "ตรวจพบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            else if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 122) || (int)e.KeyChar >= 161 || (int)e.KeyChar == 8 || (int)e.KeyChar == 13 || (int)e.KeyChar == 46 || (int)e.KeyChar == 32)
            {
                e.Handled = false;
            }
        }

        private void user_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((int)e.KeyChar >= 44 && (int)e.KeyChar <= 122) 
                ||(int)e.KeyChar==8||(int)e.KeyChar==13|| (int)e.KeyChar==46)
            {
                e.Handled=false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void pass_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 44 && (int)e.KeyChar <= 122)
                || (int)e.KeyChar == 8 || (int)e.KeyChar == 13 || (int)e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cfpasstxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 44 && (int)e.KeyChar <= 122)
                || (int)e.KeyChar == 8 || (int)e.KeyChar == 13 || (int)e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPage login = new loginPage();
            login.Show();
        }
        public static string globalroom ;
        private void roomtxt_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            globalroom = "";
            
        }

        private void leasePage_Load(object sender, EventArgs e)
        {

        }
    }


}
