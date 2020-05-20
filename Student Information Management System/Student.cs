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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Landing l1 = new Landing();
            l1.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.LoadTable();
        }

        private void LoadTable()
        {
            try
            {
                string query = "Select * from Students";
                if (txt_search.Text != "")
                {
                    query += " where Student_Name like '%" + txt_search.Text + "%' OR Student_ID like '%" + txt_search.Text + "%' ";
                }
                DataTable dt = DataAccess.Data(query);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            this.LoadTable();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            this.LoadTable();
        }
    }
}
