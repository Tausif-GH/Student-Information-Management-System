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
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void btn_viewDatabase_Click(object sender, EventArgs e)
        {
            Student s1 = new Student();
            s1.Show();
            this.Hide();
        }

        private void btn_adminLogin_Click(object sender, EventArgs e)
        {
            Login log1 = new Login();
            log1.Show();
            this.Hide();
        }

        private void lbl_proName_Click(object sender, EventArgs e)
        {

        }
    }
}
