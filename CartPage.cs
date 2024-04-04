using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBProject
{
	public partial class CartPage : Form
	{
		string personID;
		public CartPage(string ID)
		{
			InitializeComponent();

			personID = ID;

			// Create and configure a DataGridView for the cart items
			dataGridView1.ColumnCount = 3;
			dataGridView1.Columns[0].Name = "Name";
			dataGridView1.Columns[1].Name = "Quantity";
			dataGridView1.Columns[2].Name = "Price";

			// Set padding for the DataGridView
			Padding newPadding = new Padding(10, 10, 10, 10);
			dataGridView1.Padding = newPadding;

			// TODO: Populate the DataGridView with the cart items

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlCommand cmd = new SqlCommand("select i.item_name AS 'Item Name', c.quantity as 'Quantity', i.item_price " +
											" AS 'Price', CONCAT(p.FirstName, ' ', p.LastName) as 'Name' from Items i join " +
											"Cart c on i.item_id = c.item_id join PersonDetails p on c.person_id = p.ID where " +
											"person_id = " + personID, con);

			SqlDataReader reader = cmd.ExecuteReader();

			if (reader.Read())
			{
				dataGridView1.Rows.Add(reader.GetString(0), reader.GetInt32(1).ToString(), reader.GetInt32(2).ToString());
			}


			// Create and configure a checkout button

			button1.Text = "Checkout";
			button1.Click += (s, ev) => Checkout();

			// Add the DataGridView and the checkout button to the form
			this.Controls.Add(dataGridView1);
			this.Controls.Add(button1);
			this.personID = personID;
		}

		private void Checkout()
		{
			// TODO: Implement the checkout logic
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

			string cartID = "NULL";


			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlCommand cmd = new SqlCommand("select cart_id from Cart where person_id = " + personID, con);

			SqlDataReader reader = cmd.ExecuteReader();

			if (reader.Read())
			{
				cartID = reader.GetInt32(0).ToString();
			}

			// Create an instance of the CheckoutPage form
			CheckoutPage checkoutPage = new CheckoutPage(cartID);

			// Show the CheckoutPage form
			checkoutPage.Show();
			this.Hide();
		}

	}
}
