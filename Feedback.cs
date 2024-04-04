using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
	public partial class Feedback : Form
	{

		string person;
		int orderID;
		public Feedback(string personID)
		{
			InitializeComponent();

			//this.StartPosition = FormStartPosition.Manual;
			//this.Left = 460;
			//this.Top = 240;
			//this.ShowDialog();

			person = personID;

			comboBox1.DisplayMember = "Text";
			comboBox1.ValueMember = "Value";

			// Populate the ComboBox with the current list staff member id's

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlCommand cmd = new SqlCommand();
			cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select order_id from Orders where person_id = " + personID;
			cmd.Connection = con;
			SqlDataReader datareader = cmd.ExecuteReader();



			while (datareader.Read())
			{
				// MessageBox.Show(datareader.GetInt32(0).ToString());
				orderID = datareader.GetInt32(0);
				comboBox1.Items.Add(new { Text = datareader.GetInt32(0).ToString(), Value = "A" });
			}

			datareader.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox1.DisplayMember = "Text";
			comboBox1.ValueMember = "Value";

			// Populate the ComboBox with the current list staff member id's

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlCommand cmd = new SqlCommand();
			cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select order_id from Orders where person_id = " + person;
			cmd.Connection = con;
			SqlDataReader datareader = cmd.ExecuteReader();


			while (datareader.Read())
			{
				// MessageBox.Show(datareader.GetInt32(0).ToString());
				comboBox1.Items.Add(new { Text = datareader.GetInt32(0).ToString(), Value = "A" });
			}

			datareader.Close();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			string feedback = textBox1.Text;

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			string query = "insert into Feedback (customer_id, review, order_id)" +
							"values (" + person + ", '" + feedback + "', " + orderID + ")";

			SqlCommand cmd = new SqlCommand(query, con);
			cmd.ExecuteNonQuery();

			con.Close();


			MessageBox.Show("Feedback submitted successfully.");


		}

		private void button4_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			// Check the user's choice
			if (result == DialogResult.OK)
			{
				Form1 form = new Form1();
				form.Show();

				this.Close();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Menu menu = new Menu(person);
			menu.Show();
			this.Hide();
		}
	}
}
