using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Landing l1 = new Landing();
            l1.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from AdminInfo where AdminName= '" + txt_UserName.Text + "' and Password= '" + txt_pass.Text + "'";
                DataTable dt = DataAccess.Data(query);
                if (dt.Rows.Count == 1)
                {
                    //MessageBox.Show("Login Successful");
                    AdminPanel p1 = new AdminPanel();
                    p1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong UserName or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
