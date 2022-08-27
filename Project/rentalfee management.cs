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
    public partial class rentalfee_management : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=luckyplace;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        public rentalfee_management()
        {
            InitializeComponent();
        }

        private void showrental()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM rentalfee";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            datarental.DataSource = ds.Tables[0].DefaultView;
        }

        private void rentalfee_management_Load(object sender, EventArgs e)
        {
            showrental ();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (oldelectxt.Text == "หน่วยไฟเดิม" || newelectxt.Text == "หน่วยไฟใหม่" || oldwatertxt.Text == "หน่วยน้ำเดิม" || newwatertxt.Text == "หน่วยน้ำใหม่" )
            {
                MessageBox.Show("กรุณาตรวจสอบข้อมูลให้ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int oldelec = int.Parse(oldelectxt.Text.ToString());
                int newelec = int.Parse(newelectxt.Text.ToString());
                int nowelec;
                int oldwater = int.Parse(oldwatertxt.Text.ToString());
                int newwater = int.Parse(newwatertxt.Text.ToString());
                int nowwater;
                int summitelec;
                int summitwater;
                int total;
                nowelec = newelec - oldelec;
                nowelectxt.Text = nowelec.ToString();
                nowwater = newwater - oldwater;
                nowwatertxt.Text = nowwater.ToString();
                summitelec = nowelec * 6;
                summitelectxt.Text = summitelec.ToString();
                summitwater = nowwater * 25;
                summitwatertxt.Text = summitwater.ToString();
                total = 4000 + summitelec + summitwater;
                totaltxt.Text = total.ToString();
                if (oldelec > newelec)
                {
                    MessageBox.Show("กรุณาตรวจสอบตัวเลขของมิเตอร์ไฟฟ้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    newelectxt.Text = "หน่วยไฟใหม่";
                    nowelectxt.Text = "จำนวนที่ใช้";
                    summitelectxt.Text = "ค่าไฟ(บาท)";
                    totaltxt.Text = "รวม(บาท)";
                }

                if (oldwater > newwater)
                {
                    MessageBox.Show("กรุณาตรวจสอบตัวเลขของมิเตอร์น้ำประปา", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    newwatertxt.Text = "หน่วยน้ำใหม่";
                    nowwatertxt.Text = "จำนวนที่ใช้";
                    summitwatertxt.Text = "ค่าน้ำ(บาท)";
                    totaltxt.Text = "รวม(บาท)";
                }

            }
            
        }

        private void cleardatBtn_Click(object sender, EventArgs e)
        {
            oldelectxt.Text= "หน่วยไฟเดิม";
            newelectxt.Text = "หน่วยไฟใหม่";
            nowelectxt.Text = "จำนวนที่ใช้";
            oldwatertxt.Text = "หน่วยน้ำเดิม";
            newwatertxt.Text = "หน่วยน้ำใหม่";
            nowwatertxt.Text = "จำนวนที่ใช้";
            summitelectxt.Text = "ค่าไฟ(บาท)";
            summitwatertxt.Text = "ค่าน้ำ(บาท)";
            totaltxt.Text = "รวม(บาท)";
            roomtxt_combo.Text = "เลือกหมายเลขห้อง";
        }

        private void addtodbBtn_Click(object sender, EventArgs e)
        {
            if (oldelectxt.Text == "หน่วยไฟเดิม" || newelectxt.Text == "หน่วยไฟใหม่" || nowelectxt.Text == "จำนวนที่ใช้" || summitelectxt.Text == "ค่าไฟ(บาท)" || oldwatertxt.Text == "หน่วยน้ำเดิม" || newwatertxt.Text == "หน่วยน้ำใหม่" || nowwatertxt.Text == "จำนวนที่ใช้" || summitwatertxt.Text == "ค่าน้ำ(บาท)" || totaltxt.Text == "รวม(บาท)")
            {
                MessageBox.Show("กรุณาใส่ข้อมูลให้ครบถ้วนหรือกดปุ่มคำนวณก่อนและเพิ่มค่าลงฐานข้อมูลอีกครั้ง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (roomtxt_combo.Text == "เลือกหมายเลขห้อง")
            {
                MessageBox.Show("กรุณาเลือกห้องที่จะบันทึกข้อมูลและเพิ่มค่าลงฐานข้อมูลอีกครั้ง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("ดำเนินการเพิ่มข้อมูลหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection conn = databaseConnection();

                    String sql = "UPDATE rentalfee SET newelec='"+newelectxt.Text+"',oldelec='"+oldelectxt.Text+"',useelec='"+nowelectxt.Text+"', summitelec = '" + summitelectxt.Text + "',newwater='"+newwatertxt.Text+"',oldwater='"+oldwatertxt.Text+"',usewater='"+nowwatertxt.Text+"',summitwater='" + summitwatertxt.Text + "',total='" + totaltxt.Text + "' WHERE room = '" + roomtxt_combo.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rows > 0)
                    {
                        MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showrental();
                    }
                }
            }
        }
        private void cleardbBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ดำเนินการล้างค่าในฐานข้อมูลหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection conn = databaseConnection();

                String sql = "UPDATE rentalfee SET newelec='" + "0" + "',oldelec='" +"0"+ "',useelec='" + "0" + "', summitelec = '" + "0" + "',newwater='" + "0" + "',oldwater='" + "0" + "',usewater='" + "0" + "',summitwater='" + "0" + "',total='" + "4000" + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    MessageBox.Show("ล้างค่าฐานข้อมูลเรียบร้อยแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showrental();
                }
            }
        }
        #region watermark
        private void oldelectxt_Enter(object sender, EventArgs e)
        {
            String name = oldelectxt.Text;
            if (name.ToLower().Trim().Equals("หน่วยไฟเดิม"))
            {
                oldelectxt.Text = "";
                oldelectxt.ForeColor = Color.Black;
            }
        }

        private void oldelectxt_Leave(object sender, EventArgs e)
        {
            String name = oldelectxt.Text;
            if (name.ToLower().Trim().Equals("หน่วยไฟเดิม") || name.Trim().Equals(""))
            {
                oldelectxt.Text = "หน่วยไฟเดิม";
                oldelectxt.ForeColor = Color.Gray;
            }
        }

        private void newelectxt_Enter(object sender, EventArgs e)
        {
            String name = newelectxt.Text;
            if (name.ToLower().Trim().Equals("หน่วยไฟใหม่"))
            {
                newelectxt.Text = "";
                newelectxt.ForeColor = Color.Black;
            }
        }

        private void newelectxt_Leave(object sender, EventArgs e)
        {
            String name = newelectxt.Text;
            if (name.ToLower().Trim().Equals("หน่วยไฟใหม่") || name.Trim().Equals(""))
            {
                newelectxt.Text = "หน่วยไฟใหม่";
                newelectxt.ForeColor = Color.Gray;
            }
        }

        private void nowelectxt_Enter(object sender, EventArgs e)
        {
            String name = nowelectxt.Text;
            if (name.ToLower().Trim().Equals("จำนวนที่ใช้"))
            {
                nowelectxt.Text = "";
                nowelectxt.ForeColor = Color.Black;
            }
        }

        private void nowelectxt_Leave(object sender, EventArgs e)
        {
            String name = nowelectxt.Text;
            if (name.ToLower().Trim().Equals("จำนวนที่ใช้") || name.Trim().Equals(""))
            {
                nowelectxt.Text = "จำนวนที่ใช้";
                nowelectxt.ForeColor = Color.Gray;
            }
        }

        private void oldwatertxt_Enter(object sender, EventArgs e)
        {
            String name = oldwatertxt.Text;
            if (name.ToLower().Trim().Equals("หน่วยน้ำเดิม"))
            {
                oldwatertxt.Text = "";
                oldwatertxt.ForeColor = Color.Black;
            }
        }

        private void oldwatertxt_Leave(object sender, EventArgs e)
        {
            String name = oldwatertxt.Text;
            if (name.ToLower().Trim().Equals("หน่วยน้ำเดิม") || name.Trim().Equals(""))
            {
                oldwatertxt.Text = "หน่วยน้ำเดิม";
                oldwatertxt.ForeColor = Color.Gray;
            }
        }

        private void newwatertxt_Enter(object sender, EventArgs e)
        {
            String name = newwatertxt.Text;
            if (name.ToLower().Trim().Equals("หน่วยน้ำใหม่"))
            {
                newwatertxt.Text = "";
                newwatertxt.ForeColor = Color.Black;
            }
        }

        private void newwatertxt_Leave(object sender, EventArgs e)
        {
            String name = newwatertxt.Text;
            if (name.ToLower().Trim().Equals("หน่วยน้ำใหม่") || name.Trim().Equals(""))
            {
                newwatertxt.Text = "หน่วยน้ำใหม่";
                newwatertxt.ForeColor = Color.Gray;
            }
        }

        private void nowwatertxt_Enter(object sender, EventArgs e)
        {
            String name = nowwatertxt.Text;
            if (name.ToLower().Trim().Equals("จำนวนที่ใช้"))
            {
                nowwatertxt.Text = "";
                nowwatertxt.ForeColor = Color.Black;
            }
        }

        private void nowwatertxt_Leave(object sender, EventArgs e)
        {
            String name = nowwatertxt.Text;
            if (name.ToLower().Trim().Equals("จำนวนที่ใช้") || name.Trim().Equals(""))
            {
                nowwatertxt.Text = "จำนวนที่ใช้";
                nowwatertxt.ForeColor = Color.Gray;
            }
        }

        private void summitelectxt_Enter(object sender, EventArgs e)
        {
            String name = summitelectxt.Text;
            if (name.ToLower().Trim().Equals("ค่าไฟ(บาท)"))
            {
                summitelectxt.Text = "";
                summitelectxt.ForeColor = Color.Black;
            }
        }

        private void summitelectxt_Leave(object sender, EventArgs e)
        {
            String name = summitelectxt.Text;
            if (name.ToLower().Trim().Equals("ค่าไฟ(บาท)") || name.Trim().Equals(""))
            {
                summitelectxt.Text = "ค่าไฟ(บาท)";
                summitelectxt.ForeColor = Color.Gray;
            }
        }

        private void summitwatertxt_Enter(object sender, EventArgs e)
        {
            String name = summitwatertxt.Text;
            if (name.ToLower().Trim().Equals("ค่าน้ำ(บาท)"))
            {
                summitwatertxt.Text = "";
                summitwatertxt.ForeColor = Color.Black;
            }
        }

        private void summitwatertxt_Leave(object sender, EventArgs e)
        {
            String name = summitwatertxt.Text;
            if (name.ToLower().Trim().Equals("ค่าน้ำ(บาท)") || name.Trim().Equals(""))
            {
                summitwatertxt.Text = "ค่าน้ำ(บาท)";
                summitwatertxt.ForeColor = Color.Gray;
            }
        }

        private void totaltxt_Enter(object sender, EventArgs e)
        {
            String name = totaltxt.Text;
            if (name.ToLower().Trim().Equals("รวม(บาท)"))
            {
                totaltxt.Text = "";
                totaltxt.ForeColor = Color.Black;
            }
        }

        private void totaltxt_Leave(object sender, EventArgs e)
        {
            String name = totaltxt.Text;
            if (name.ToLower().Trim().Equals("รวม(บาท)") || name.Trim().Equals(""))
            {
                totaltxt.Text = "รวม(บาท)";
                totaltxt.ForeColor = Color.Gray;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminpage admin = new adminpage();
            this.Hide();
            admin.Show();
        }

        #endregion
        #region keypress
        private void oldelectxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void newelectxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void oldwatertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void newwatertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
