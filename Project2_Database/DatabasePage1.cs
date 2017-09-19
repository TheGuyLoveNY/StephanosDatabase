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
    public partial class DatabasePage1 : Form
    {
        public DatabasePage1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form studentDatabase = new StudentDatabase();
            studentDatabase.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form attendanceDatabase = new AttendanceDatabase();
            attendanceDatabase.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form memebershipDatabase = new MembershipDatabase();
            memebershipDatabase.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form parentDatabase = new ParentDatabase();
            parentDatabase.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form rankingDatabase = new RankingDatabase();
            rankingDatabase.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form reportForm = new ReportPage1();
            reportForm.Show();
        }
    }
}
