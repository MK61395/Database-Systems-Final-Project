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
	public partial class registrationForm : Form
	{
		public registrationForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Open the registration form when the link is clicked
			this.Hide();
			Form1 login = new Form1();
			login.Show();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";

			SqlConnection con = new SqlConnection(ConnectionString);

			con.Open();

			string FirstName = textBox3.Text;
			string LastName = textBox4.Text;
			string Email = textBox5.Text;
			string Username = textBox1.Text;
			string Password = textBox6.Text;
			string CNIC = textBox9.Text;
			string PhoneNum = textBox8.Text;
			string City = textBox7.Text;
			string Street = textBox10.Text;
			string House = textBox2.Text;

			SqlCommand cmd = new SqlCommand(
			"INSERT INTO PersonDetails (CNIC, FirstName, LastName, PhoneNum, Email, City, Street, HouseNum, UserName, PWord, Designation)" +
			"Values (" + "'" + CNIC + "'," +
			"'" + FirstName + "'," +
			"'" + LastName + "'," +
			"'" + PhoneNum + "'," +
			"'" + Email + "'," +
			"'" + City + "'," +
			Street + "," +
			House + "," +
			"'" + Username + "'," +
			"'" + Password + "'," +
			"'Customer')"
			, con);

			cmd.ExecuteNonQuery();
			MessageBox.Show("Account created successfully!");
			con.Close();

		}

	}
}
