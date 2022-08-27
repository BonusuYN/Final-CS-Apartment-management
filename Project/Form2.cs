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
    public partial class userpage : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=luckyplace;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        public userpage()
        {
            InitializeComponent();
        }

        private void logout_click(object sender, EventArgs e)
        {
            this.Hide();
            loginPage login = new loginPage();
            this.Hide();
            login.Show();
        }

        private void maintananceBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            servicepage service = new servicepage();
            service.Show();
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            feedbackpage feedback = new feedbackpage();
            feedback.Show();
        }
        private void contactbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("เบอร์โทรศัพท์ 08-5615-5952 LineID:@LuckyKKU 💗", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        private void userpage_Load(object sender, EventArgs e)
        {
            usershowtxt.Text = loginPage.tableData.Rows[0][3].ToString(); 
        }

        private void receiptBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataSet ds = new DataSet();
            DataSet ds_ = new DataSet();
            MySqlConnection conn = databaseConnection();
            MySqlCommand cmd = conn.CreateCommand();
            MySqlCommand cmd_ = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = "SELECT * FROM rentalfee WHERE room='"+usershowtxt.Text+"'";
            cmd_.CommandText = "SELECT * FROM residents_name WHERE room='" + usershowtxt.Text + "'";
            MySqlDataReader dr = cmd.ExecuteReader();
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = cmd;
            DataTable dTable = new DataTable();
            conn.Close();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlDataAdapter adapter_ = new MySqlDataAdapter(cmd_);
            adapter.Fill(ds);
            adapter_.Fill(ds_);


            conn.Close();
            var rental = ds.Tables[0].Rows[0].ItemArray.ToList();
            var ressident = ds_.Tables[0].Rows[0].ItemArray.ToList();
            conn.Close();

            e.Graphics.DrawString("Lucky Place Apartment", new Font("Mali", 26, FontStyle.Bold), Brushes.Black, new Point(50, 90));
            e.Graphics.DrawString("ใบแจ้งค่าเช่า", new Font("Mali", 23, FontStyle.Bold), Brushes.Black, new Point(330, 160));
            e.Graphics.DrawString("หมายเลขห้อง : " + rental[0], new Font("Mali", 12, FontStyle.Regular), Brushes.Black, new PointF(80, 190));
            e.Graphics.DrawString("ชื่อผู้เช่า : " + ressident[1], new Font("Mali", 12, FontStyle.Regular), Brushes.Black, new PointF(80, 230));
            e.Graphics.DrawString("ที่อยู่ : " + ressident[6], new Font("Mali", 12, FontStyle.Regular), Brushes.Black, new PointF(80, 270));
            e.Graphics.DrawString("เวลาที่พิมพ์ : " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("Mali", 12, FontStyle.Regular), Brushes.Black, new PointF(80, 320));
            e.Graphics.DrawString("เดือน : " + System.DateTime.Now.ToString("MM/yyyy"), new Font("Mali", 12, FontStyle.Regular), Brushes.Black, new PointF(80, 360));
            e.Graphics.DrawString("------------------------------------------------------------------------------------", new Font("Mali", 14, FontStyle.Regular), Brushes.Black, new Point(80, 390));
            e.Graphics.DrawString("รายการ                     ค่าบริการ                        รวมราคา", new Font("Mali", 15, FontStyle.Bold), Brushes.Black, new Point(120, 410));
            e.Graphics.DrawString("------------------------------------------------------------------------------------", new Font("Mali", 14, FontStyle.Regular), Brushes.Black, new Point(80, 430));

            e.Graphics.DrawString("ค่าเช่าห้อง :"+ rental[0], new Font("Mali", 12, FontStyle.Regular), Brushes.Black, new PointF(80, 470));
            e.Graphics.DrawString( rental[9] + " บาท", new Font("Mali", 12, FontStyle.Regular), Brushes.Black, new PointF(370, 470));
            e.Graphics.DrawString( rental[9] + " บาท", new Font("Mali", 12, FontStyle.Regular), Brushes.Black, new PointF(655, 470));
            e.Graphics.DrawString("ค่าไฟฟ้า :" + rental[1] + "-" + rental[2] + "=" + rental[3]+" หน่วย", new Font("Mali", 12, FontStyle.Regular), Brushes.Black, new PointF(80, 500));
            e.Graphics.DrawString(  "6บาท/หน่วย", new Font("Mali", 12, FontStyle.Regular), Brushes.Black, new PointF(370, 500));
            e.Graphics.DrawString( rental[4] + "   บาท", new Font("Mali", 12, FontStyle.Regular), Brushes.Black, new PointF(655, 500));
            e.Graphics.DrawString("ค่านำ้ประปา :" + rental[5] + "-" + rental[6] + "=" + rental[7] + " หน่วย", new Font("Mali", 12, FontStyle.Regular), Brushes.Black, new PointF(80, 530));
            e.Graphics.DrawString(  "25บาท/หน่วย", new Font("Mali", 12, FontStyle.Regular), Brushes.Black, new PointF(370, 530));
            e.Graphics.DrawString( rental[8] + "  บาท", new Font("Mali", 12, FontStyle.Regular), Brushes.Black, new PointF(655, 530));
            e.Graphics.DrawString("**มิเตอร์นำ้ -ไฟ จดทุกวันที่ 25 ของทุกเดือน**", new Font("Mali", 12, FontStyle.Regular), Brushes.Black, new PointF(80, 570));
            e.Graphics.DrawString("------------------------------------------------------------------------------------", new Font("Mali", 14, FontStyle.Regular), Brushes.Black, new Point(80, 600));
            e.Graphics.DrawString("รวมเป็นเงินทั้งสิ้น", new Font("Mali", 18, FontStyle.Bold), Brushes.Black, new Point(80, 630));
            e.Graphics.DrawString("------------------------------------------------------------------------------------", new Font("Mali", 14, FontStyle.Regular), Brushes.Black, new Point(80, 660));
            e.Graphics.DrawString( rental[10]+ ".00 บาท", new Font("Mali", 18, FontStyle.Bold), Brushes.Black, new Point(610, 630));
        }
    }
}
