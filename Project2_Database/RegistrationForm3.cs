﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_Database
{
    public partial class RegistrationForm3 : Form
    {
        public RegistrationForm3()
        {
            InitializeComponent();
        }

        private void attendanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attendanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project2DataSet);

        }

        private void RegistrationForm3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project2DataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.project2DataSet.Attendance);
            this.attendanceBindingSource.AddNew();

            this.studentNumberTextBox.Text = "" + RegisterForm.studentID;

        }

        private void studentNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.attendanceBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.project2DataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Hide();
            Form nextForm = new RegistrationForm4();
            nextForm.Show();
        }
    }
}
