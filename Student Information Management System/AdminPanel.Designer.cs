namespace Student_Information_Management_System
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_grade = new System.Windows.Forms.Label();
            this.txt_grd = new System.Windows.Forms.TextBox();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.txt_dob = new System.Windows.Forms.TextBox();
            this.lbl_mot = new System.Windows.Forms.Label();
            this.txt_mot = new System.Windows.Forms.TextBox();
            this.lbl_con = new System.Windows.Forms.Label();
            this.txt_con = new System.Windows.Forms.TextBox();
            this.lbl_fat = new System.Windows.Forms.Label();
            this.txt_fat = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_enter = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_stdName = new System.Windows.Forms.Label();
            this.txt_stdName = new System.Windows.Forms.TextBox();
            this.lbl_stdID = new System.Windows.Forms.Label();
            this.txt_stdID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1116, 490);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Location = new System.Drawing.Point(147, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 44);
            this.panel1.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(416, 11);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student ID or Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(335, 11);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(113, 13);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(216, 20);
            this.txt_search.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_ID,
            this.Student_Name});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(810, 434);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Student_ID
            // 
            this.Student_ID.DataPropertyName = "Student_ID";
            this.Student_ID.HeaderText = "Student_ID";
            this.Student_ID.Name = "Student_ID";
            // 
            // Student_Name
            // 
            this.Student_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student_Name.DataPropertyName = "Student_Name";
            this.Student_Name.HeaderText = "Student_Name";
            this.Student_Name.Name = "Student_Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.btn_addNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(819, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 44);
            this.panel2.TabIndex = 2;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_logout.Location = new System.Drawing.Point(216, 11);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_addNew
            // 
            this.btn_addNew.Location = new System.Drawing.Point(3, 11);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(129, 23);
            this.btn_addNew.TabIndex = 0;
            this.btn_addNew.Text = "Add New Student";
            this.btn_addNew.UseVisualStyleBackColor = true;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_grade);
            this.panel3.Controls.Add(this.txt_grd);
            this.panel3.Controls.Add(this.lbl_dob);
            this.panel3.Controls.Add(this.txt_dob);
            this.panel3.Controls.Add(this.lbl_mot);
            this.panel3.Controls.Add(this.txt_mot);
            this.panel3.Controls.Add(this.lbl_con);
            this.panel3.Controls.Add(this.txt_con);
            this.panel3.Controls.Add(this.lbl_fat);
            this.panel3.Controls.Add(this.txt_fat);
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Controls.Add(this.lbl_enter);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.lbl_stdName);
            this.panel3.Controls.Add(this.txt_stdName);
            this.panel3.Controls.Add(this.lbl_stdID);
            this.panel3.Controls.Add(this.txt_stdID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(819, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 434);
            this.panel3.TabIndex = 3;
            // 
            // lbl_grade
            // 
            this.lbl_grade.AutoSize = true;
            this.lbl_grade.Location = new System.Drawing.Point(53, 286);
            this.lbl_grade.Name = "lbl_grade";
            this.lbl_grade.Size = new System.Drawing.Size(36, 13);
            this.lbl_grade.TabIndex = 36;
            this.lbl_grade.Text = "Grade";
            // 
            // txt_grd
            // 
            this.txt_grd.Location = new System.Drawing.Point(56, 302);
            this.txt_grd.Name = "txt_grd";
            this.txt_grd.Size = new System.Drawing.Size(188, 20);
            this.txt_grd.TabIndex = 35;
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(53, 246);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(66, 13);
            this.lbl_dob.TabIndex = 34;
            this.lbl_dob.Text = "Date of Birth";
            // 
            // txt_dob
            // 
            this.txt_dob.Location = new System.Drawing.Point(56, 262);
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(188, 20);
            this.txt_dob.TabIndex = 33;
            // 
            // lbl_mot
            // 
            this.lbl_mot.AutoSize = true;
            this.lbl_mot.Location = new System.Drawing.Point(53, 207);
            this.lbl_mot.Name = "lbl_mot";
            this.lbl_mot.Size = new System.Drawing.Size(78, 13);
            this.lbl_mot.TabIndex = 32;
            this.lbl_mot.Text = "Mother\'s Name";
            // 
            // txt_mot
            // 
            this.txt_mot.Location = new System.Drawing.Point(56, 223);
            this.txt_mot.Name = "txt_mot";
            this.txt_mot.Size = new System.Drawing.Size(188, 20);
            this.txt_mot.TabIndex = 31;
            // 
            // lbl_con
            // 
            this.lbl_con.AutoSize = true;
            this.lbl_con.Location = new System.Drawing.Point(53, 126);
            this.lbl_con.Name = "lbl_con";
            this.lbl_con.Size = new System.Drawing.Size(44, 13);
            this.lbl_con.TabIndex = 30;
            this.lbl_con.Text = "Contact";
            // 
            // txt_con
            // 
            this.txt_con.Location = new System.Drawing.Point(56, 142);
            this.txt_con.Name = "txt_con";
            this.txt_con.Size = new System.Drawing.Size(188, 20);
            this.txt_con.TabIndex = 29;
            // 
            // lbl_fat
            // 
            this.lbl_fat.AutoSize = true;
            this.lbl_fat.Location = new System.Drawing.Point(53, 165);
            this.lbl_fat.Name = "lbl_fat";
            this.lbl_fat.Size = new System.Drawing.Size(75, 13);
            this.lbl_fat.TabIndex = 28;
            this.lbl_fat.Text = "Father\'s Name";
            // 
            // txt_fat
            // 
            this.txt_fat.Location = new System.Drawing.Point(56, 181);
            this.txt_fat.Name = "txt_fat";
            this.txt_fat.Size = new System.Drawing.Size(188, 20);
            this.txt_fat.TabIndex = 27;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(188, 384);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 23);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_enter
            // 
            this.lbl_enter.AutoSize = true;
            this.lbl_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_enter.Location = new System.Drawing.Point(53, 20);
            this.lbl_enter.Name = "lbl_enter";
            this.lbl_enter.Size = new System.Drawing.Size(170, 13);
            this.lbl_enter.TabIndex = 19;
            this.lbl_enter.Text = "Enter Student Details Below:";
            this.lbl_enter.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(56, 384);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(126, 23);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_stdName
            // 
            this.lbl_stdName.AutoSize = true;
            this.lbl_stdName.Location = new System.Drawing.Point(53, 87);
            this.lbl_stdName.Name = "lbl_stdName";
            this.lbl_stdName.Size = new System.Drawing.Size(75, 13);
            this.lbl_stdName.TabIndex = 15;
            this.lbl_stdName.Text = "Student Name";
            // 
            // txt_stdName
            // 
            this.txt_stdName.Location = new System.Drawing.Point(56, 103);
            this.txt_stdName.Name = "txt_stdName";
            this.txt_stdName.Size = new System.Drawing.Size(188, 20);
            this.txt_stdName.TabIndex = 14;
            // 
            // lbl_stdID
            // 
            this.lbl_stdID.AutoSize = true;
            this.lbl_stdID.Location = new System.Drawing.Point(53, 48);
            this.lbl_stdID.Name = "lbl_stdID";
            this.lbl_stdID.Size = new System.Drawing.Size(58, 13);
            this.lbl_stdID.TabIndex = 7;
            this.lbl_stdID.Text = "Student ID";
            // 
            // txt_stdID
            // 
            this.txt_stdID.Location = new System.Drawing.Point(56, 64);
            this.txt_stdID.Name = "txt_stdID";
            this.txt_stdID.ReadOnly = true;
            this.txt_stdID.Size = new System.Drawing.Size(188, 20);
            this.txt_stdID.TabIndex = 5;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_stdID;
        private System.Windows.Forms.TextBox txt_stdID;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_enter;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_grade;
        private System.Windows.Forms.TextBox txt_grd;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.TextBox txt_dob;
        private System.Windows.Forms.Label lbl_mot;
        private System.Windows.Forms.TextBox txt_mot;
        private System.Windows.Forms.Label lbl_con;
        private System.Windows.Forms.TextBox txt_con;
        private System.Windows.Forms.Label lbl_fat;
        private System.Windows.Forms.TextBox txt_fat;
        private System.Windows.Forms.Label lbl_stdName;
        private System.Windows.Forms.TextBox txt_stdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Name;
    }
}