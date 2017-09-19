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
    public partial class RankingDatabase : Form
    {
        public RankingDatabase()
        {
            InitializeComponent();
        }

        private void rankingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rankingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project2DataSet);

        }

        private void RankingDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project2DataSet.Ranking' table. You can move, or remove it, as needed.
            this.rankingTableAdapter.Fill(this.project2DataSet.Ranking);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form studentDatabase = new StudentDatabase();
            studentDatabase.Show();
        }
    }
}
