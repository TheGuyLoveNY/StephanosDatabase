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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project2DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project2DataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.project2DataSet.Student);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form firstPage = new RegisterForm();
            firstPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form databasePage1 = new DatabasePage1();
            databasePage1.Show();
        }
    }
}
