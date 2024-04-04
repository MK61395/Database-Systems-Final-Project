using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
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
	public partial class ManageStaff : Form
	{
		public ManageStaff()
		{
			InitializeComponent();

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlDataAdapter da = new SqlDataAdapter("\r\nselect id as 'Employee ID', emp_name as 'Name', (select role_name from Roles where role_id = emp_role) 'Employee Role', CNIC as 'Identification Number', salary as 'Salary'," + 
				" email as 'Email ID', house_address as 'Residence', phone_num as 'Phone Number' from Staff\r\n", ConnectionString);
			DataSet ds = new DataSet();


			SqlCommandBuilder cmdBldr = new SqlCommandBuilder(da);
			da.Fill(ds, "Staff");
			dataGridView1.DataSource = ds.Tables[0];
			da.Update(ds, "Staff");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Create and configure the form
			Form addStaffForm = new Form();
			addStaffForm.Text = "Add Staff";
			addStaffForm.Size = new Size(400, 300); // Set the size of the form

			// Create and configure controls
			Label nameLabel = new Label();
			nameLabel.Text = "Employee Name:";
			TextBox nameTextBox = new TextBox();

			Label cnicLabel = new Label();
			cnicLabel.Text = "CNIC:";
			TextBox cnicTextBox = new TextBox();

			Label addressLabel = new Label();
			addressLabel.Text = "Address:";
			TextBox addressTextBox = new TextBox();

			Label salaryLabel = new Label();
			salaryLabel.Text = "Salary:";
			TextBox salaryTextBox = new TextBox();

			Label phoneLabel = new Label();
			phoneLabel.Text = "Phone Number:";
			TextBox phoneTextBox = new TextBox();

			Label roleLabel = new Label();
			roleLabel.Text = "Role:";
			ComboBox roleComboBox = new ComboBox();
			// Populate the ComboBox with available roles


			roleComboBox.DisplayMember = "Text";
			roleComboBox.ValueMember = "Value";

			// Populate the ComboBox with the current list of menu items

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlCommand cmd = new SqlCommand();
			cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select role_name from roles";
			cmd.Connection = con;
			SqlDataReader datareader = cmd.ExecuteReader();

			while (datareader.Read())
			{
				roleComboBox.Items.Add(new { Text = datareader.GetString(0), Value = "A" });
			}

			con.Close();

			var role = roleComboBox.GetItemText(roleComboBox.SelectedItem);

			Label emailLabel = new Label();
			emailLabel.Text = "Email:";
			TextBox emailTextBox = new TextBox();

			Button hireButton = new Button();
			hireButton.Text = "Hire";
			hireButton.Click += (s, ev) => HireStaff(nameTextBox.Text, cnicTextBox.Text, addressTextBox.Text, salaryTextBox.Text, phoneTextBox.Text, roleComboBox.GetItemText(roleComboBox.SelectedItem), emailTextBox.Text);

			Button cancelButton = new Button();
			cancelButton.Text = "Cancel";
			cancelButton.Click += (s, ev) => addStaffForm.Close();

			// Set control positions

			int labelWidth = 120;
			int textBoxWidth = 200;
			int buttonWidth = 70;
			int padding = 10;
			int startY = 20;

			nameLabel.SetBounds(padding, startY, labelWidth, 20);
			nameTextBox.SetBounds(padding + labelWidth, startY, textBoxWidth, 20);

			cnicLabel.SetBounds(padding, startY + 30, labelWidth, 20);
			cnicTextBox.SetBounds(padding + labelWidth, startY + 30, textBoxWidth, 20);

			addressLabel.SetBounds(padding, startY + 60, labelWidth, 20);
			addressTextBox.SetBounds(padding + labelWidth, startY + 60, textBoxWidth, 20);

			salaryLabel.SetBounds(padding, startY + 90, labelWidth, 20);
			salaryTextBox.SetBounds(padding + labelWidth, startY + 90, textBoxWidth, 20);

			phoneLabel.SetBounds(padding, startY + 120, labelWidth, 20);
			phoneTextBox.SetBounds(padding + labelWidth, startY + 120, textBoxWidth, 20);

			roleLabel.SetBounds(padding, startY + 150, labelWidth, 20);
			roleComboBox.SetBounds(padding + labelWidth, startY + 150, textBoxWidth, 20);
			// Populate the ComboBox with available roles

			emailLabel.SetBounds(padding, startY + 180, labelWidth, 20);
			emailTextBox.SetBounds(padding + labelWidth, startY + 180, textBoxWidth, 20);

			hireButton.SetBounds(padding, startY + 210, buttonWidth, 30);
			cancelButton.SetBounds(padding + buttonWidth + 10, startY + 210, buttonWidth, 30);

			// Add controls to the form
			addStaffForm.Controls.Add(nameLabel);
			addStaffForm.Controls.Add(nameTextBox);
			addStaffForm.Controls.Add(cnicLabel);
			addStaffForm.Controls.Add(cnicTextBox);
			addStaffForm.Controls.Add(addressLabel);
			addStaffForm.Controls.Add(addressTextBox);
			addStaffForm.Controls.Add(salaryLabel);
			addStaffForm.Controls.Add(salaryTextBox);
			addStaffForm.Controls.Add(phoneLabel);
			addStaffForm.Controls.Add(phoneTextBox);
			addStaffForm.Controls.Add(roleLabel);
			addStaffForm.Controls.Add(roleComboBox);
			addStaffForm.Controls.Add(emailLabel);
			addStaffForm.Controls.Add(emailTextBox);
			addStaffForm.Controls.Add(hireButton);
			addStaffForm.Controls.Add(cancelButton);

			// Show the form
			addStaffForm.ShowDialog();
		}

		// Function to handle the "Hire" button click
		private void HireStaff(string employeeName, string cnic, string address, string salary, string phone, string role, string email)
		{
			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			string query = "INSERT INTO Staff (emp_name, CNIC, house_address, phone_num, emp_role, email, salary)" +
			"VALUES ('" + employeeName + "', '" + cnic + "', '" + address + "', '" + phone + "', " + "(select role_id from Roles where role_name = '" + role + "')" + ", '" + email + "', " + salary + ")";

			SqlCommand myCommand = new SqlCommand(query, con);
			myCommand.ExecuteNonQuery();

			con.Close();

			// Optionally, close the form
			foreach (Form form in Application.OpenForms)
			{
				if (form.Text == "Add Staff")
				{
					form.Close();
					break;
				}
			}
		}




		private void button3_Click(object sender, EventArgs e)
		{
			// Create and configure the form
			Form updateStaffForm = new Form();
			updateStaffForm.Text = "Update Staff";

			// Create and configure controls
			ComboBox staffComboBox = new ComboBox();

			// Populate the ComboBox with the current list of staff members

			staffComboBox.DisplayMember = "Text";
			staffComboBox.ValueMember = "Value";

			// Populate the ComboBox with the current list staff member id's

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlCommand cmd = new SqlCommand();
			cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select id from Staff";
			cmd.Connection = con;
			SqlDataReader datareader = cmd.ExecuteReader();


			while (datareader.Read())
			{
				staffComboBox.Items.Add(new { Text = datareader.GetInt32(0).ToString(), Value = "A" });
			}

			datareader.Close();


			ComboBox positionComboBox = new ComboBox();
			positionComboBox.DisplayMember = "Text";
			positionComboBox.ValueMember = "Value";

			// Populate the ComboBox with available roles

			cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select role_name from Roles";
			cmd.Connection = con;
			SqlDataReader datareader1 = cmd.ExecuteReader();


			while (datareader1.Read())
			{
				positionComboBox.Items.Add(new { Text = datareader1.GetString(0), Value = "A" });
			}

			// Set control positions
			int comboBoxWidth = 150;
			int labelWidth = 100;
			int textBoxWidth = 150;
			int buttonWidth = 70;
			int padding = 10;
			int startY = 20;

			staffComboBox.SetBounds(padding, startY, comboBoxWidth, 20);

			Label numLabel = new Label();
			numLabel.Text = "Phone No:";
			numLabel.SetBounds(padding, startY + 30, labelWidth, 20);
			TextBox numTextBox = new TextBox();
			numTextBox.SetBounds(padding + labelWidth, startY + 30, textBoxWidth, 20);

			Label positionLabel = new Label();
			positionLabel.Text = "New Role:";
			positionLabel.SetBounds(padding, startY + 60, labelWidth, 20);
			positionComboBox.SetBounds(padding + labelWidth, startY + 60, textBoxWidth, 20);

			Label salaryLabel = new Label();
			salaryLabel.Text = "Salary:";
			salaryLabel.SetBounds(padding, startY + 90, labelWidth, 20);
			TextBox salaryTextBox = new TextBox();
			salaryTextBox.SetBounds(padding + labelWidth, startY + 90, textBoxWidth, 20);

			Button updateButton = new Button();
			updateButton.Text = "Update";

			updateButton.Click += (s, ev) => UpdateStaff(staffComboBox.GetItemText(staffComboBox.SelectedItem), numTextBox.Text, positionComboBox.GetItemText(positionComboBox.SelectedItem), salaryTextBox.Text);
			updateButton.SetBounds(padding, startY + 120, buttonWidth, 30);

			Button cancelButton = new Button();
			cancelButton.Text = "Cancel";
			cancelButton.Click += (s, ev) => updateStaffForm.Close();
			cancelButton.SetBounds(padding + buttonWidth + 10, startY + 120, buttonWidth, 30);


			// Add controls to the form
			updateStaffForm.Controls.Add(staffComboBox);
			updateStaffForm.Controls.Add(numLabel);
			updateStaffForm.Controls.Add(numTextBox);
			updateStaffForm.Controls.Add(salaryLabel);
			updateStaffForm.Controls.Add(salaryTextBox);
			updateStaffForm.Controls.Add(positionLabel);
			updateStaffForm.Controls.Add(positionComboBox);
			updateStaffForm.Controls.Add(updateButton);
			updateStaffForm.Controls.Add(cancelButton);

			// Show the form
			updateStaffForm.ShowDialog();
		}

		// Function to handle the "Update" button click
		private void UpdateStaff(string selectedStaff, string employeeNum, string position, string salary)
		{
			// Perform database update or other actions with the obtained data

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();


			MessageBox.Show("Successfully updated " + selectedStaff);


			string query = "UPDATE Staff SET phone_num = '" + employeeNum + "', emp_role = (select role_id from Roles where role_name = '" + position + "'), salary = " + salary + " WHERE id = " + selectedStaff;


			SqlCommand myCommand = new SqlCommand(query, con);
			myCommand.ExecuteNonQuery();

			con.Close();

			// Optionally, close the form
			foreach (Form form in Application.OpenForms)
			{
				if (form.Text == "Update Staff")
				{
					form.Close();
					break;
				}
			}
		}


		private void button5_Click(object sender, EventArgs e)
		{
			// Create and configure the form
			Form removeStaffForm = new Form();
			removeStaffForm.Text = "Remove Staff";

			// Create and configure controls
			ComboBox staffComboBox = new ComboBox();
			// Populate the ComboBox with the current list of staff members


			staffComboBox.DisplayMember = "Text";
			staffComboBox.ValueMember = "Value";

			// Populate the ComboBox with the current list of menu items

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlCommand cmd = new SqlCommand();
			cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select id from Staff";
			cmd.Connection = con;
			SqlDataReader datareader = cmd.ExecuteReader();

			while (datareader.Read())
			{
				staffComboBox.Items.Add(new { Text = datareader.GetInt32(0).ToString(), Value = "A" });
			}

			con.Close();

			staffComboBox.GetItemText(staffComboBox.SelectedItem);


			int comboBoxWidth = 170;
			int buttonWidth = 80;
			int padding = 10;
			int startY = 20;

			staffComboBox.SetBounds(padding, startY, comboBoxWidth, 20);

			Button removeButton = new Button();
			removeButton.Text = "Remove";
			removeButton.Click += (s, ev) => RemoveStaff(staffComboBox.GetItemText(staffComboBox.SelectedItem).ToString());
			removeButton.SetBounds(padding, startY + 30, buttonWidth + 10, 30);

			Button cancelButton = new Button();
			cancelButton.Text = "Cancel";
			cancelButton.Click += (s, ev) => removeStaffForm.Close();
			cancelButton.SetBounds(padding + buttonWidth + 10, startY + 30, buttonWidth, 30);


			// Add controls to the form
			removeStaffForm.Controls.Add(staffComboBox);
			removeStaffForm.Controls.Add(removeButton);
			removeStaffForm.Controls.Add(cancelButton);

			// Show the form
			removeStaffForm.ShowDialog();
		}

		// Function to handle the "Remove" button click
		private void RemoveStaff(string selectedStaff)
		{
			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();


			MessageBox.Show("Successfully removed " + selectedStaff + " from the staff.");

			string query = "DELETE FROM Staff WHERE id='" + selectedStaff + "'";

			SqlCommand myCommand = new SqlCommand(query, con);
			myCommand.ExecuteNonQuery();

			con.Close();
			// Optionally, close the form
			foreach (Form form in Application.OpenForms)
			{
				if (form.Text == "Remove Staff")
				{
					form.Close();
					break;
				}
			}
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
			// If Cancel is selected, do nothing
		}

		private void button8_Click(object sender, EventArgs e)
		{
			ManagerDashboard managerDashboard = new ManagerDashboard();
			managerDashboard.Show();
			this.Hide();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			ManageMenu manageMenu = new ManageMenu();
			manageMenu.Show();
			this.Hide();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			ManageInventory manageInventory = new ManageInventory();
			manageInventory.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ManageFinances manageFinances = new ManageFinances();
			manageFinances.Show();
			this.Hide();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			CustomerSatisfaction customerSatisfaction = new CustomerSatisfaction();
			customerSatisfaction.Show();
			this.Hide();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
