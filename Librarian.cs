using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library_Management_System
{
    public partial class Librarian : Form
    {
        public Librarian()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Insert into Librarian values(@ID, @Name, @Age, @PhoneNumber, @Address)", con);

            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@Name", textBox2.Text);

            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@PhoneNumber", textBox4.Text);

            cnn.Parameters.AddWithValue("@Address", textBox5.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data saved");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            SqlCommand cnn = new SqlCommand("Select*from Librarian", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Update Librarian set Name =  @Name, Age = @Age, PhoneNumber = @PhoneNumber, Address = @Address)", con);

            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@Name", textBox2.Text);

            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@PhoneNumber", textBox4.Text);

            cnn.Parameters.AddWithValue("@Address", textBox5.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Delete Librarian where ID = @ID", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data deleted");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            SqlCommand cnn = new SqlCommand("Select*from Librarian", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SATHMI;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Insert into Librarian values(@ID, @Name, @Age, @PhoneNumber, @Address)", con);

            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@Name", textBox2.Text);

            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@PhoneNumber", textBox4.Text);

            cnn.Parameters.AddWithValue("@Address", textBox5.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data saved");
        }
    }
}
