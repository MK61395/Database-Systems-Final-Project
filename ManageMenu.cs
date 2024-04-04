using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
	public partial class ManageMenu : Form
	{
		public ManageMenu()
		{
			InitializeComponent();

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlDataAdapter da = new SqlDataAdapter("select i.item_name as 'Item Name', i.item_price as 'Item Price', c.category_name as 'Category', c.category_id as 'Category ID' from Items i join Category c on i.cat_id = c.category_id order by c.category_id", ConnectionString);
			DataSet ds = new DataSet();

			SqlCommandBuilder cmdBldr = new SqlCommandBuilder(da);
			da.Fill(ds, "Items");
			dataGridView1.DataSource = ds.Tables[0];
			da.Update(ds, "Items");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Create and configure the form
			Form addItemForm = new Form();
			addItemForm.Text = "Add Item";

			// Create and configure controls
			Label nameLabel = new Label();
			nameLabel.Text = "Name:";
			TextBox nameTextBox = new TextBox();

			Label descriptionLabel = new Label();
			descriptionLabel.Text = "Description:";
			TextBox descriptionTextBox = new TextBox();

			Label priceLabel = new Label();
			priceLabel.Text = "Price:";
			TextBox priceTextBox = new TextBox();

			// Add a label and textbox for the item category
			Label categoryLabel = new Label();
			categoryLabel.Text = "Category:";
			TextBox categoryTextBox = new TextBox();

			Button addButton = new Button();
			addButton.Text = "Add";
			addButton.Click += (s, ev) => AddItem(nameTextBox.Text, descriptionTextBox.Text, priceTextBox.Text, categoryTextBox.Text); // Modify this line

			Button cancelButton = new Button();
			cancelButton.Text = "Cancel";
			cancelButton.Click += (s, ev) => addItemForm.Close();

			// Set control positions
			int labelWidth = 100;
			int textBoxWidth = 150;
			int buttonWidth = 70;
			int padding = 10;
			int startY = 20;

			nameLabel.SetBounds(padding, startY, labelWidth, 20);
			nameTextBox.SetBounds(padding + labelWidth, startY, textBoxWidth, 20);

			descriptionLabel.SetBounds(padding, startY + 30, labelWidth, 20);
			descriptionTextBox.SetBounds(padding + labelWidth, startY + 30, textBoxWidth, 20);

			priceLabel.SetBounds(padding, startY + 60, labelWidth, 20);
			priceTextBox.SetBounds(padding + labelWidth, startY + 60, textBoxWidth, 20);

			// Set the position of the category label and textbox
			categoryLabel.SetBounds(padding, startY + 90, labelWidth, 20);
			categoryTextBox.SetBounds(padding + labelWidth, startY + 90, textBoxWidth, 20);

			addButton.SetBounds(padding, startY + 120, buttonWidth, 30);
			cancelButton.SetBounds(padding + buttonWidth + 10, startY + 120, buttonWidth, 30);

			// Add controls to the form
			addItemForm.Controls.Add(nameLabel);
			addItemForm.Controls.Add(nameTextBox);
			addItemForm.Controls.Add(descriptionLabel);
			addItemForm.Controls.Add(descriptionTextBox);
			addItemForm.Controls.Add(priceLabel);
			addItemForm.Controls.Add(priceTextBox);
			addItemForm.Controls.Add(categoryLabel); // Add this line
			addItemForm.Controls.Add(categoryTextBox); // Add this line
			addItemForm.Controls.Add(addButton);
			addItemForm.Controls.Add(cancelButton);

			// Show the form
			addItemForm.ShowDialog();
		}

		// Function to handle the "Add" button click
		private void AddItem(string itemName, string itemDescription, string itemPrice, string itemCategory)
		{
			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			string query = "INSERT INTO Items (item_name, item_price, cat_id)" + 
			"VALUES ('" + itemName + "', " + itemPrice + ", " + itemCategory + ")";

			SqlCommand myCommand = new SqlCommand(query, con);
			myCommand.ExecuteNonQuery();

			con.Close();

			// Optionally, close the form
			foreach (Form form in Application.OpenForms)
			{
				if (form.Text == "Add Item")
				{
					form.Close();
					break;
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			// Create and configure the form
			Form updateItemForm = new Form();
			updateItemForm.Text = "Update Item";

			// Create and configure controls
			ComboBox itemComboBox = new ComboBox();

			itemComboBox.DisplayMember = "Text";
			itemComboBox.ValueMember = "Value";

			// Populate the ComboBox with the current list of menu items

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlCommand cmd = new SqlCommand();
			cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select item_name from Items";
			cmd.Connection = con;
			SqlDataReader datareader = cmd.ExecuteReader();

			while (datareader.Read())
			{
				itemComboBox.Items.Add(new { Text = datareader.GetString(0), Value = "A" });
			}

			con.Close();

			itemComboBox.GetItemText(itemComboBox.SelectedItem);

			Label nameLabel = new Label();
			nameLabel.Text = "Name:";
			TextBox nameTextBox = new TextBox();

			Label descriptionLabel = new Label();
			descriptionLabel.Text = "Description:";
			TextBox descriptionTextBox = new TextBox();

			Label priceLabel = new Label();
			priceLabel.Text = "Price:";
			TextBox priceTextBox = new TextBox();

			Button updateButton = new Button();
			updateButton.Text = "Update";
			updateButton.Click += (s, ev) => UpdateItem(itemComboBox.GetItemText(itemComboBox.SelectedItem), nameTextBox.Text, descriptionTextBox.Text, priceTextBox.Text);

			Button cancelButton = new Button();
			cancelButton.Text = "Cancel";
			cancelButton.Click += (s, ev) => updateItemForm.Close();

			// Set control positions
			int comboBoxWidth = 150;
			int labelWidth = 100;
			int textBoxWidth = 150;
			int buttonWidth = 70;
			int padding = 10;
			int startY = 20;

			itemComboBox.SetBounds(padding, startY, comboBoxWidth, 20);

			nameLabel.SetBounds(padding, startY + 30, labelWidth, 20);
			nameTextBox.SetBounds(padding + labelWidth, startY + 30, textBoxWidth, 20);

			descriptionLabel.SetBounds(padding, startY + 60, labelWidth, 20);
			descriptionTextBox.SetBounds(padding + labelWidth, startY + 60, textBoxWidth, 20);

			priceLabel.SetBounds(padding, startY + 90, labelWidth, 20);
			priceTextBox.SetBounds(padding + labelWidth, startY + 90, textBoxWidth, 20);

			updateButton.SetBounds(padding, startY + 120, buttonWidth, 30);
			cancelButton.SetBounds(padding + buttonWidth + 10, startY + 120, buttonWidth, 30);

			// Add controls to the form
			updateItemForm.Controls.Add(itemComboBox);
			updateItemForm.Controls.Add(nameLabel);
			updateItemForm.Controls.Add(nameTextBox);
			updateItemForm.Controls.Add(descriptionLabel);
			updateItemForm.Controls.Add(descriptionTextBox);
			updateItemForm.Controls.Add(priceLabel);
			updateItemForm.Controls.Add(priceTextBox);
			updateItemForm.Controls.Add(updateButton);
			updateItemForm.Controls.Add(cancelButton);

			// Show the form
			updateItemForm.ShowDialog();
		}


		// Function to handle the "Update" button click
		private void UpdateItem(string selectedItem, string itemName, string itemDescription, string itemPrice)
		{
			// Perform database update or other actions with the obtained data

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();


			MessageBox.Show("Successfully updated " + selectedItem);

			MessageBox.Show("new name: " + itemName);

			string query = "UPDATE Items SET item_name = '" + itemName + "', item_price = " + itemPrice + " WHERE item_name = '" + selectedItem + "';";


			SqlCommand myCommand = new SqlCommand(query, con);
			myCommand.ExecuteNonQuery();

			con.Close();


			// Optionally, close the form
			foreach (Form form in Application.OpenForms)
			{
				if (form.Text == "Update Item")
				{
					form.Close();
					break;
				}
			}
		}


		private void button5_Click(object sender, EventArgs e)
		{
			// Create and configure the form
			Form removeItemForm = new Form();
			removeItemForm.Text = "Remove Item";

			// Create and configure controls
			ComboBox itemComboBox = new ComboBox();

			itemComboBox.DisplayMember = "Text";
			itemComboBox.ValueMember = "Value";

			// Populate the ComboBox with the current list of menu items

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlCommand cmd = new SqlCommand();
			cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select item_name from Items";
			cmd.Connection = con;
			SqlDataReader datareader = cmd.ExecuteReader();

			while (datareader.Read())
			{
				itemComboBox.Items.Add(new { Text = datareader.GetString(0), Value = "A" });
			}

			con.Close();

			itemComboBox.GetItemText(itemComboBox.SelectedItem);

			Button removeButton = new Button();
			removeButton.Text = "Remove";
			removeButton.Click += (s, ev) => RemoveItem(itemComboBox.GetItemText(itemComboBox.SelectedItem));

			Button cancelButton = new Button();
			cancelButton.Text = "Cancel";
			cancelButton.Click += (s, ev) => removeItemForm.Close();

			// Set control positions
			int comboBoxWidth = 150;
			int buttonWidth = 70;
			int padding = 10;
			int startY = 20;

			itemComboBox.SetBounds(padding, startY, comboBoxWidth, 20);

			removeButton.SetBounds(padding, startY + 30, buttonWidth + 10, 30);
			cancelButton.SetBounds(padding + buttonWidth + 10, startY + 30, buttonWidth, 30);

			// Add controls to the form
			removeItemForm.Controls.Add(itemComboBox);
			removeItemForm.Controls.Add(removeButton);
			removeItemForm.Controls.Add(cancelButton);

			// Show the form
			removeItemForm.ShowDialog();
		}


		// Function to handle the "Remove" button click
		private void RemoveItem(string selectedItem)
		{

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();


			MessageBox.Show("Successfully removed " + selectedItem + " from the menu.");

			string query = "DELETE FROM Items WHERE item_name='" + selectedItem + "'";

			SqlCommand myCommand = new SqlCommand(query, con);
			myCommand.ExecuteNonQuery();

			con.Close();


			// Optionally, close the form
			foreach (Form form in Application.OpenForms)
			{
				if (form.Text == "Remove Item")
				{
					form.Close();
					break;
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
			managerDashboard.Show();
			this.Hide();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			ManageStaff manageStaff = new ManageStaff();
			manageStaff.Show();
			this.Hide();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			ManageInventory manageInventory = new ManageInventory();
			manageInventory.Show();
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
