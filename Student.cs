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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Insert into Student values(@ID, @StudentName, @Age, @Phone, @Email)", con);

            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@StudentName", textBox2.Text);

            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@Phone", textBox4.Text);

            cnn.Parameters.AddWithValue("@Email", textBox5.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data saved");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            SqlCommand cnn = new SqlCommand("Select*from Student", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            SqlCommand cnn = new SqlCommand("Select*from Student", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Update Student set StudentName =  @StudentName, Age = @Age, Phone = @Phone, Email = @Email where ID = @ID ", con);

            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@StudentName", textBox2.Text);

            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@Phone", textBox4.Text);

            cnn.Parameters.AddWithValue("@Email", textBox5.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Delete Student where ID = @ID", con);
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
            textBox5.Clear();
        }
    }
}