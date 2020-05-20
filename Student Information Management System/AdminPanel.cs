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
    public partial class AdminPanel : Form
    {
        bool newEntry = false;
        public AdminPanel()
        {
            InitializeComponent();
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
            lbl_enter.Visible = false;
            newEntry = false;
            this.RefreshAll();
        }

        private void RefreshAll()
        {
            txt_search.Text = "";
            txt_stdID.Text = txt_stdName.Text = txt_con.Text = txt_fat.Text = txt_mot.Text = txt_dob.Text = txt_grd.Text = "";
            this.LoadTable();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            lbl_enter.Visible = true;
            txt_stdID.Text = txt_stdName.Text = txt_con.Text = txt_fat.Text = txt_mot.Text = txt_dob.Text = txt_grd.Text = "";

            newEntry = true;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Landing l1 = new Landing();
            l1.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["Student_ID"].Value.ToString();
                this.GetDataFromTable(id);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void GetDataFromTable(string id)
        {
            string query = "Select * from Students where Student_ID=" + id;
            DataTable dt = DataAccess.Data(query);
            txt_stdID.Text = dt.Rows[0]["Student_ID"].ToString();
            txt_stdName.Text = dt.Rows[0]["Student_Name"].ToString();
            txt_con.Text = dt.Rows[0]["Contact"].ToString();
            txt_fat.Text = dt.Rows[0]["Fathers_Name"].ToString();
            txt_mot.Text = dt.Rows[0]["Mothers_Name"].ToString();
            txt_dob.Text = dt.Rows[0]["DateOfBirth"].ToString();
            txt_grd.Text = dt.Rows[0]["Grade"].ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (newEntry == false) //checking if its new entry of edit
            {
                if (txt_stdID.Text == "") 
                {
                    MessageBox.Show("Select a Row to edit");
                    goto End;
                }

                try
                {
                    string id = txt_stdID.Text;

                    string query = "Update Students set Student_Name='" + txt_stdName.Text + "' ,Contact='" + txt_con.Text + "' ,Fathers_Name= '" + txt_fat.Text + "' ,Mothers_Name= '" + txt_mot.Text + "' ,DateOfBirth= '" + txt_dob.Text + "' ,Grade= '" + txt_grd.Text + "' where Student_ID= " + id;
                    DataAccess.RunQuery(query);

                    this.LoadTable();
                    this.GetDataFromTable(txt_stdID.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (newEntry == true)
            {
                try
                {
                    string query = "Insert into Students(Student_Name,Contact,Fathers_Name,Mothers_Name,DateOfBirth,Grade) " +
                            "values('" + txt_stdName.Text + "','" + txt_con.Text + "','" + txt_fat.Text + "','" + txt_mot.Text + "','" + txt_dob.Text + "','" + txt_grd.Text + "')";
                    DataAccess.RunQuery(query);

                    newEntry = false;
                    lbl_enter.Visible = false;

                    this.LoadTable();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        End:;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_stdID.Text == "")
            {
                MessageBox.Show("TO DELETE, Select a row first");
            }
            else
            {
                string query = "delete from Students where Student_ID=" + txt_stdID.Text;
                DataAccess.RunQuery(query);
                this.RefreshAll();
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            this.LoadTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
