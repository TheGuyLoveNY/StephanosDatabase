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
    public partial class RegisterForm : Form
    {
        public static int studentID = 0;


        public RegisterForm()
        {
            InitializeComponent();
           
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project2DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project2DataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.project2DataSet.Student);
            this.studentBindingSource.AddNew();
            //this.project2DataSet.Student.Select("* FROM STUDENT");
        

        }





      /*  private void studentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project2DataSet);

        }*/

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                
                this.Validate();
                this.studentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.project2DataSet);
                studentID += 1;


                this.Hide();
                RegistrationForm2 nextForm = new RegistrationForm2();
                nextForm.Show();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void student_NumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.studentBindingSource.AddNew();
        }

        public static void RegisterKill()
        {
            RegisterForm.ActiveForm.Close();
        }

    }
}
