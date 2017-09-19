using System;
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
    public partial class RegistrationForm2 : Form
    {
        
        public RegistrationForm2()
        {
            InitializeComponent();
        }



        private void RegistrationForm2_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'project2DataSet.Parent' table. You can move, or remove it, as needed.
            this.parentTableAdapter.Fill(this.project2DataSet.Parent);

            StartUp();

        }

        private void StartUp()
        {
            try
            {
                // MessageBox.Show("Got the value : " + RegisterForm.theBox.Text);

                this.parentBindingSource.AddNew();
                this.student_IDTextBox.Text = "" + RegisterForm.studentID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.parentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.project2DataSet);

                this.Hide();
                Form nextForm = new RegistrationForm3();
                nextForm.Show();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
