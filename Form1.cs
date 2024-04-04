using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Open the registration form when the link is clicked
			this.Hide();
			registrationForm RegistrationForm = new registrationForm();
			RegistrationForm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			string enteredUsername = textBox1.Text;
			string enteredPassword = textBox2.Text;


			SqlCommand check_User_Name = new SqlCommand("SELECT Designation FROM PersonDetails WHERE UserName = '" + enteredUsername + "' AND PWord = '" + enteredPassword + "'", con);
			SqlDataReader reader = check_User_Name.ExecuteReader();

			if (!reader.HasRows)
			{
				MessageBox.Show("User not found!");
			}

			string role = "None";

			while (reader.Read())
			{
				role = reader.GetString(0);
			}

			reader.Close();

			SqlCommand cmd = new SqlCommand("SELECT ID FROM PersonDetails WHERE UserName = '" + enteredUsername + "'", con);
			SqlDataReader rd = cmd.ExecuteReader();

			if (!rd.HasRows)
			{
				MessageBox.Show("User not found!");
			}

			string personID = "NULL";

			while (rd.Read())
			{
				personID = rd.GetInt32(0).ToString();
			}

			if (role == "Customer")
			{
				Menu customerMenu = new Menu(personID);
				customerMenu.Show();
				this.Hide();
			}
			else if (role == "Manager")
			{
				ManagerDashboard managerDashboard = new ManagerDashboard();
				managerDashboard.Show();
				this.Hide();
			}
			else if (role == "Cashier")
			{
				PointOfSale pointOfSaleForm = new PointOfSale(personID);
				pointOfSaleForm.Show();
				this.Hide();
			}
			else
			{
				// Password is incorrect, show an error message or handle it accordingly
				MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}



		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
