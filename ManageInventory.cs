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
	public partial class ManageInventory : Form
	{
		public ManageInventory()
		{
			InitializeComponent();

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlDataAdapter da = new SqlDataAdapter("select * from Inventory", ConnectionString);
			DataSet ds = new DataSet();


			SqlCommandBuilder cmdBldr = new SqlCommandBuilder(da);
			da.Fill(ds, "Inventory");
			dataGridView1.DataSource = ds.Tables[0];
			da.Update(ds, "Inventory");

			con.Close();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Create and configure the form
			Form addVendorForm = new Form();
			addVendorForm.Text = "Add Vendor";
			addVendorForm.Size = new Size(400, 300);

			// Create and configure controls
			Label vendorNameLabel = new Label();
			vendorNameLabel.Text = "Vendor Name:";
			TextBox vendorNameTextBox = new TextBox();

			Label cityLabel = new Label();
			cityLabel.Text = "City:";
			TextBox cityTextBox = new TextBox();

			Label houseNoLabel = new Label();
			houseNoLabel.Text = "House Number:";
			TextBox houseNoTextBox = new TextBox();

			Label phoneLabel = new Label();
			phoneLabel.Text = "Phone Number:";
			TextBox phoneTextBox = new TextBox();

			Label emailLabel = new Label();
			emailLabel.Text = "Email:";
			TextBox emailTextBox = new TextBox();

			Label cnicLabel = new Label();
			cnicLabel.Text = "CNIC:";
			TextBox cnicTextBox = new TextBox();

			Button addVendorButton = new Button();
			addVendorButton.Text = "Add Vendor";
			addVendorButton.Click += (s, ev) => AddVendor(
				vendorNameTextBox.Text,
				cityTextBox.Text,
				houseNoTextBox.Text,
				phoneTextBox.Text,
				emailTextBox.Text,
				cnicTextBox.Text
			);

			Button cancelButton = new Button();
			cancelButton.Text = "Cancel";
			cancelButton.Click += (s, ev) => addVendorForm.Close();

			// Set control positions
			int labelWidth = 150;
			int textBoxWidth = 200;
			int buttonWidth = 100;
			int padding = 10;
			int startY = 20;

			vendorNameLabel.SetBounds(padding, startY, labelWidth, 20);
			vendorNameTextBox.SetBounds(padding + labelWidth, startY, textBoxWidth, 20);

			cityLabel.SetBounds(padding, startY + 30, labelWidth, 20);
			cityTextBox.SetBounds(padding + labelWidth, startY + 30, textBoxWidth, 20);

			houseNoLabel.SetBounds(padding, startY + 60, labelWidth, 20);
			houseNoTextBox.SetBounds(padding + labelWidth, startY + 60, textBoxWidth, 20);

			phoneLabel.SetBounds(padding, startY + 90, labelWidth, 20);
			phoneTextBox.SetBounds(padding + labelWidth, startY + 90, textBoxWidth, 20);

			emailLabel.SetBounds(padding, startY + 120, labelWidth, 20);
			emailTextBox.SetBounds(padding + labelWidth, startY + 120, textBoxWidth, 20);

			cnicLabel.SetBounds(padding, startY + 150, labelWidth, 20);
			cnicTextBox.SetBounds(padding + labelWidth, startY + 150, textBoxWidth, 20);

			addVendorButton.SetBounds(padding, startY + 180, buttonWidth, 30);
			cancelButton.SetBounds(padding + buttonWidth + 10, startY + 180, buttonWidth, 30);

			// Add controls to the form
			addVendorForm.Controls.Add(vendorNameLabel);
			addVendorForm.Controls.Add(vendorNameTextBox);
			addVendorForm.Controls.Add(cityLabel);
			addVendorForm.Controls.Add(cityTextBox);
			addVendorForm.Controls.Add(houseNoLabel);
			addVendorForm.Controls.Add(houseNoTextBox);
			addVendorForm.Controls.Add(phoneLabel);
			addVendorForm.Controls.Add(phoneTextBox);
			addVendorForm.Controls.Add(emailLabel);
			addVendorForm.Controls.Add(emailTextBox);
			addVendorForm.Controls.Add(cnicLabel);
			addVendorForm.Controls.Add(cnicTextBox);
			addVendorForm.Controls.Add(addVendorButton);
			addVendorForm.Controls.Add(cancelButton);

			// Show the form
			addVendorForm.ShowDialog();
		}

		// Function to handle the "Add Vendor" button click
		private void AddVendor(string vendorName, string city, string houseNo, string phone, string email, string cnic)
		{
			// Perform database insertion or other actions with the obtained data
			// ...

			// Optionally, close the form
			foreach (Form form in Application.OpenForms)
			{
				if (form.Text == "Add Vendor")
				{
					form.Close();
					break;
				}
			}
		}


		private void button3_Click(object sender, EventArgs e)
		{
			// Create and configure the form
			Form updateVendorForm = new Form();
			updateVendorForm.Text = "Update Vendor";
			updateVendorForm.Size = new Size(400, 300);

			// Create and configure controls
			Label vendorListLabel = new Label();
			vendorListLabel.Text = "Select Vendor:";
			ComboBox vendorComboBox = new ComboBox();
			// Populate the ComboBox with current vendor names or IDs

			// Add more controls for updating vendor details

			Button updateVendorButton = new Button();
			updateVendorButton.Text = "Update Vendor";
			updateVendorButton.Click += (s, ev) => UpdateVendor(
				vendorComboBox.SelectedItem.ToString() /*, parameters for updating vendor */
			);

			Button cancelButton = new Button();
			cancelButton.Text = "Cancel";
			cancelButton.Click += (s, ev) => updateVendorForm.Close();

			// Set control positions
			int labelWidth = 150;
			int comboBoxWidth = 200;
			int buttonWidth = 100;
			int padding = 10;
			int startY = 20;

			vendorListLabel.SetBounds(padding, startY, labelWidth, 20);
			vendorComboBox.SetBounds(padding + labelWidth, startY, comboBoxWidth, 20);

			// Add more controls for updating vendor details

			updateVendorButton.SetBounds(padding, startY + 30, buttonWidth, 30);
			cancelButton.SetBounds(padding + buttonWidth + 10, startY + 30, buttonWidth, 30);

			// Add controls to the form
			updateVendorForm.Controls.Add(vendorListLabel);
			updateVendorForm.Controls.Add(vendorComboBox);
			// Add more controls for updating vendor details
			updateVendorForm.Controls.Add(updateVendorButton);
			updateVendorForm.Controls.Add(cancelButton);

			// Show the form
			updateVendorForm.ShowDialog();
		}

		// Function to handle the "Update Vendor" button click
		private void UpdateVendor(string selectedVendor /*, parameters for updating vendor */)
		{
			// Check if a vendor is selected
			if (!string.IsNullOrEmpty(selectedVendor))
			{
				// Perform database update or other actions with the obtained data
				// ...

				// Optionally, close the form
				foreach (Form form in Application.OpenForms)
				{
					if (form.Text == "Update Vendor")
					{
						form.Close();
						break;
					}
				}
			}
			else
			{
				// Display a message or handle the case where no vendor is selected
				MessageBox.Show("Please select a vendor to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void button5_Click(object sender, EventArgs e)
		{
			// Create and configure the form
			Form removeVendorForm = new Form();
			removeVendorForm.Text = "Remove Vendor";
			removeVendorForm.Size = new Size(400, 300);

			// Create and configure controls
			Label vendorListLabel = new Label();
			vendorListLabel.Text = "Select Vendor:";
			ComboBox vendorComboBox = new ComboBox();
			// Populate the ComboBox with current vendor names or IDs

			Button removeVendorButton = new Button();
			removeVendorButton.Text = "Remove Vendor";
			removeVendorButton.Click += (s, ev) => RemoveVendor(
				vendorComboBox.SelectedItem.ToString() /*, parameters for removing vendor */
			);

			Button cancelButton = new Button();
			cancelButton.Text = "Cancel";
			cancelButton.Click += (s, ev) => removeVendorForm.Close();

			// Set control positions
			int labelWidth = 150;
			int comboBoxWidth = 200;
			int buttonWidth = 100;
			int padding = 10;
			int startY = 20;

			vendorListLabel.SetBounds(padding, startY, labelWidth, 20);
			vendorComboBox.SetBounds(padding + labelWidth, startY, comboBoxWidth, 20);

			removeVendorButton.SetBounds(padding, startY + 30, buttonWidth, 30);
			cancelButton.SetBounds(padding + buttonWidth + 10, startY + 30, buttonWidth, 30);

			// Add controls to the form
			removeVendorForm.Controls.Add(vendorListLabel);
			removeVendorForm.Controls.Add(vendorComboBox);
			removeVendorForm.Controls.Add(removeVendorButton);
			removeVendorForm.Controls.Add(cancelButton);

			// Show the form
			removeVendorForm.ShowDialog();
		}

		// Function to handle the "Remove Vendor" button click
		private void RemoveVendor(string selectedVendor /*, parameters for removing vendor */)
		{
			// Check if a vendor is selected
			if (!string.IsNullOrEmpty(selectedVendor))
			{
				// Perform database removal or other actions with the obtained data
				// ...

				// Optionally, close the form
				foreach (Form form in Application.OpenForms)
				{
					if (form.Text == "Remove Vendor")
					{
						form.Close();
						break;
					}
				}
			}
			else
			{
				// Display a message or handle the case where no vendor is selected
				MessageBox.Show("Please select a vendor to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			// Create and configure the form
			Form orderItemsForm = new Form();
			orderItemsForm.Text = "Order Items";
			orderItemsForm.Size = new Size(400, 200); // Set the initial size of the form
			orderItemsForm.StartPosition = FormStartPosition.CenterScreen; // Center the form on the screen

			// Create and configure controls
			Label itemNameLabel = new Label();
			itemNameLabel.Text = "Item Name:";
			TextBox itemNameTextBox = new TextBox();

			Label quantityLabel = new Label();
			quantityLabel.Text = "Quantity:";
			NumericUpDown quantityNumericUpDown = new NumericUpDown();

			Button orderButton = new Button();
			orderButton.Text = "Place Order";
			orderButton.Click += (s, ev) => PlaceOrder(
				itemNameTextBox.Text,
				(int)quantityNumericUpDown.Value
			);

			Button cancelButton = new Button();
			cancelButton.Text = "Cancel";
			cancelButton.Click += (s, ev) => orderItemsForm.Close();

			// Set control positions
			int labelWidth = 100;
			int controlWidth = 200;
			int buttonWidth = 100;
			int padding = 10;
			int startY = 20;

			itemNameLabel.SetBounds(padding, startY, labelWidth, 20);
			itemNameTextBox.SetBounds(padding + labelWidth, startY, controlWidth, 20);

			quantityLabel.SetBounds(padding, startY + 30, labelWidth, 20);
			quantityNumericUpDown.SetBounds(padding + labelWidth, startY + 30, controlWidth, 20);

			orderButton.SetBounds(padding, startY + 60, buttonWidth, 30);
			cancelButton.SetBounds(padding + buttonWidth + 10, startY + 60, buttonWidth, 30);

			// Add controls to the form
			orderItemsForm.Controls.Add(itemNameLabel);
			orderItemsForm.Controls.Add(itemNameTextBox);
			orderItemsForm.Controls.Add(quantityLabel);
			orderItemsForm.Controls.Add(quantityNumericUpDown);
			orderItemsForm.Controls.Add(orderButton);
			orderItemsForm.Controls.Add(cancelButton);

			// Show the form
			orderItemsForm.ShowDialog();
		}

		// Function to handle the "Place Order" button click
		private void PlaceOrder(string itemName, int quantity)
		{
			// Perform actions with the obtained data (e.g., update database with the order details)

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlCommand cmd = new SqlCommand("SELECT * from Inventory WHERE ingredient_name = '" + itemName + "'", con);
			SqlDataReader reader = cmd.ExecuteReader();

			int original_quantity = 0;

			DateTime dateTime = DateTime.Now;

			if (reader.Read())
			{
				dateTime = reader.GetDateTime(2);
				original_quantity = reader.GetInt32(4);
			}

			reader.Close();

			quantity += original_quantity;
			dateTime.AddMonths(3);

			DateTime today = DateTime.Today;

			string query = "UPDATE Inventory SET quantity = " + quantity.ToString() +
						   ", order_date = '" + today.ToString() + "'" +
						   ", expired_date = '" + dateTime.AddMonths(3).ToString("d") + "'" + 
						   " WHERE ingredient_name = '" + itemName + "'";

			SqlCommand myCommand = new SqlCommand(query, con);
			myCommand.ExecuteNonQuery();

			con.Close();

			// Optionally, close the form
			foreach (Form form in Application.OpenForms)
			{
				if (form.Text == "Order Items")
				{
					form.Close();
					break;
				}
			}
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
			ManageStaff manageStaff = new ManageStaff();
			manageStaff.Show();
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
	}
}
