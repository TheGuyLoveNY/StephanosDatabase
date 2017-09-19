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
    public partial class ReportPage1 : Form
    {
        public ReportPage1()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project2DataSet);

        }

        private void ReportPage1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project2DataSet.Ranking' table. You can move, or remove it, as needed.
            this.rankingTableAdapter.Fill(this.project2DataSet.Ranking);
            // TODO: This line of code loads data into the 'project2DataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.project2DataSet.Attendance);
            // TODO: This line of code loads data into the 'project2DataSet.Membership' table. You can move, or remove it, as needed.
            this.membershipTableAdapter.Fill(this.project2DataSet.Membership);
            // TODO: This line of code loads data into the 'project2DataSet.Parent' table. You can move, or remove it, as needed.
            this.parentTableAdapter.Fill(this.project2DataSet.Parent);
            // TODO: This line of code loads data into the 'project2DataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.project2DataSet.Student);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.studentBindingSource.MoveNext();
            this.attendanceBindingSource.MoveNext();
            this.parentBindingSource.MoveNext();
            this.membershipBindingSource.MoveNext();
            this.rankingBindingSource.MoveNext();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.studentBindingSource.MovePrevious();
            this.attendanceBindingSource.MovePrevious();
            this.parentBindingSource.MovePrevious();
            this.membershipBindingSource.MovePrevious();
            this.rankingBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.studentBindingSource.MoveNext();
            this.attendanceBindingSource.MoveNext();
            this.parentBindingSource.MoveNext();
            this.membershipBindingSource.MoveNext();
            this.rankingBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.studentBindingSource.MovePrevious();
            this.attendanceBindingSource.MovePrevious();
            this.parentBindingSource.MovePrevious();
            this.membershipBindingSource.MovePrevious();
            this.rankingBindingSource.MovePrevious();
        }
    }
}
