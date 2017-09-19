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
    public partial class MembershipDatabase : Form
    {
        public MembershipDatabase()
        {
            InitializeComponent();
        }

        private void membershipBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.membershipBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project2DataSet);

        }

        private void MembershipDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project2DataSet.Membership' table. You can move, or remove it, as needed.
            this.membershipTableAdapter.Fill(this.project2DataSet.Membership);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form parentDatabase = new ParentDatabase();
            parentDatabase.Show();
        }
    }
}
