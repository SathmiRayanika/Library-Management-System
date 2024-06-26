using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Insert into Book values(@ID, @Book, @Author, @Publisher)", con);

            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@Book", textBox2.Text);

            cnn.Parameters.AddWithValue("@Author", textBox3.Text);

            cnn.Parameters.AddWithValue("@Publisher", textBox4.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data saved");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            SqlCommand cnn = new SqlCommand("Select*from Book", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Update Book set Book =  @Book, Author = @Author, Publisher = @Publisher where ID = @ID)", con);

            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@Book", textBox2.Text);

            cnn.Parameters.AddWithValue("@Author", textBox3.Text);

            cnn.Parameters.AddWithValue("@Publisher", textBox4.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Delete Book where ID = @ID", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data deleted");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            SqlCommand cnn = new SqlCommand("Select * from Book", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }
    }
}