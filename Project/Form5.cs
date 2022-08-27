using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class adminpage : Form
    {
        public adminpage()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            loginPage login = new loginPage();
            this.Close();
            login.Show();
        }

        private void viewserviceBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            service_view service_View = new service_view();
            this.Hide();
            service_View.Show();
        }

        private void feedbackviewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            feedback_view feedback_View = new feedback_view();
            this.Hide();
            feedback_View.Show();
        }

        private void rentalfeemanage_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentalfee_management rental = new rentalfee_management();
            this.Hide();
            rental.Show();
        }

        private void manageresident_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            veiw_people people = new veiw_people();
            this.Hide();
            people.Show();
        }

        private void viewroom_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            view_roomstatus room = new view_roomstatus();
            this.Hide();
            room.Show();
        }
    }
}
