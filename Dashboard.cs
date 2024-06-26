using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student studentInfo = new Student();
            studentInfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book BookInfo = new Book();
            BookInfo.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Borrowing borrowInfo = new Borrowing();
            borrowInfo.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Librarian librarianInfo = new Librarian();
            librarianInfo.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit application", "Exit message", MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                    {
                        Application.Exit();
                    }      
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
