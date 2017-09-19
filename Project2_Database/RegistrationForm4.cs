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
    public partial class RegistrationForm4 : Form
    {
        public RegistrationForm4()
        {
            InitializeComponent();
        }

        private void membershipBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.membershipBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project2DataSet);

        }

        private void RegistrationForm4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project2DataSet.Membership' table. You can move, or remove it, as needed.
            this.membershipTableAdapter.Fill(this.project2DataSet.Membership);
            this.membershipBindingSource.AddNew();

            this.studentNumberTextBox.Text = "" + RegisterForm.studentID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.membershipBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.project2DataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Hide();
            Form nextForm = new FinalRegistration();
            nextForm.Show();
        }
    }
}
