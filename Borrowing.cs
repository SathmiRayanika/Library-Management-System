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

namespace Library_Management_System
{
    public partial class Borrowing : Form
    {
        public Borrowing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Insert into Borrowing values(@ID, @StudentName, @Book, @DateBorrowed, @DateReturn)", con);

            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@StudentName", textBox2.Text);

            cnn.Parameters.AddWithValue("@Book", textBox3.Text);

            cnn.Parameters.Add("@DateBorrowed", SqlDbType.NVarChar).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            cnn.Parameters.Add("@DateReturn", SqlDbType.NVarChar).Value = dateTimePicker2.Value.ToString("yyyy-MM-dd");


            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data saved");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            SqlCommand cnn = new SqlCommand("Select*from Borrowing", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            SqlCommand cnn = new SqlCommand("Select*from Borrowing", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Update Borrowing set StudentName =  @StudentName, Book = @Book, DateBorrowed = @DateBorrowed, DateReturn = @DateReturn where ID = @ID", con);

            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@StudentName", textBox2.Text);

            cnn.Parameters.AddWithValue("@Book", textBox3.Text);

            cnn.Parameters.Add("@DateBorrowed", SqlDbType.NVarChar).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            cnn.Parameters.Add("@DateReturn", SqlDbType.NVarChar).Value = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Delete Borrowing where ID = @ID", con);
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
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
