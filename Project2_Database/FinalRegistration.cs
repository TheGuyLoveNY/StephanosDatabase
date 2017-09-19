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
    public partial class FinalRegistration : Form
    {
        public FinalRegistration()
        {
            InitializeComponent();
        }

        private void rankingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rankingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project2DataSet);

        }

        private void FinalRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project2DataSet.Ranking' table. You can move, or remove it, as needed.
            this.rankingTableAdapter.Fill(this.project2DataSet.Ranking);

            this.rankingBindingSource.AddNew();
            this.studentNumberTextBox.Text = "" + RegisterForm.studentID;
            this.rank_ColorTextBox.Text = "White Belt";
            this.rank_NumberTextBox.Text = "100";
            this.rank_RequirementTextBox.Text = "Rank Number : 200";
            this.rank_AssignedDateDateTimePicker.Text = "4/8/2017 10:52 PM";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.rankingBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.project2DataSet);
               // MessageBox.Show("Yeppiee!! Success!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();

        }
    }
}
