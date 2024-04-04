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
	public partial class CustomerSatisfaction : Form
	{
		string order;
		public CustomerSatisfaction()
		{
			InitializeComponent();


			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlDataAdapter da = new SqlDataAdapter("select feedback_id as 'Feedback number', order_id as 'Order Number (select)', (select CONCAT(FirstName, ' ', LastName) from PersonDetails where ID = customer_id) as 'Full Name' ," + 
				" review as 'Customer Review', response as 'Our Response' from Feedback\r\n", ConnectionString);
			DataSet ds = new DataSet();


			SqlCommandBuilder cmdBldr = new SqlCommandBuilder(da);
			da.Fill(ds, "Feedback");
			dataGridView1.DataSource = ds.Tables[0];
			da.Update(ds, "Feedback");
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			this.order = dataGridView1.Rows[e.RowIndex].Cells[0].Value as string;
			MessageBox.Show("'" + this.order + "' selected.");
		}

		private void button10_Click(object sender, EventArgs e)
		{
			// Create and configure the form
			Form respondToFeedbackForm = new Form();
			respondToFeedbackForm.Text = "Respond to Feedback";
			respondToFeedbackForm.Size = new Size(400, 300); // Set the desired size


			Label responseLabel = new Label();
			responseLabel.Text = "Response:";
			responseLabel.Location = new Point(10, 10);
			respondToFeedbackForm.Controls.Add(responseLabel);

			TextBox responseTextBox = new TextBox();
			responseTextBox.Multiline = true;
			responseTextBox.Size = new Size(300, 80);
			responseTextBox.Location = new Point(10, 50);
			respondToFeedbackForm.Controls.Add(responseTextBox);

			Button sendResponseButton = new Button();
			sendResponseButton.Text = "Send Response";
			sendResponseButton.Location = new Point(10, 150);
			sendResponseButton.Click += (s, ev) => SendResponse(order.ToString(), responseTextBox.Text);
			respondToFeedbackForm.Controls.Add(sendResponseButton);

			// Show the form
			respondToFeedbackForm.ShowDialog();
		}

		// Function to handle the "Send Response" button click
		private void SendResponse(string order, string response)
		{
			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			string query = "update Feedback set response = " +
							"'" + response + "' where order_id = " + order;


			MessageBox.Show("Response submitted successfully.");


			SqlCommand myCommand = new SqlCommand(query, con);
			myCommand.ExecuteNonQuery();

			con.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			// Display a confirmation dialog
			DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			// Check the user's choice
			if (result == DialogResult.OK)
			{
				// If OK is selected, navigate to the login screen (Assuming Form1 is your login screen)
				Form1 form = new Form1();
				form.Show();

				// Close the current form (assuming this form is your current form)
				this.Close();
			}

		}

		private void button8_Click(object sender, EventArgs e)
		{
			ManagerDashboard managerDashboard = new ManagerDashboard();
			managerDashboard.ShowDialog();
			this.Hide();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			ManageMenu manageMenu = new ManageMenu();
			manageMenu.ShowDialog();
			this.Hide();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			ManageStaff manageStaff = new ManageStaff();
			manageStaff.ShowDialog();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ManageInventory manageInventory = new ManageInventory();
			manageInventory.ShowDialog();
			this.Hide();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			ManageFinances manageFinances = new ManageFinances();
			manageFinances.ShowDialog();
			this.Hide();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				this.order = this.dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
			}
			MessageBox.Show("'" + this.order + "' selected.");
		}
	}
}
