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
	public partial class CheckoutPage : Form
	{

		string cartID;
		public CheckoutPage(string cart)
		{
			InitializeComponent();

			cartID = cart;

			MessageBox.Show("Cart number: " + cartID);

			// Set the title of the form
			this.Text = "Checkout";

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlCommand cmd = new SqlCommand("select i.item_price, c.quantity, i.item_id from Items i join Cart c on i.item_id = c.item_id " +
				"where c.cart_id = " + cartID, con);

			int item_price = 0, quantity = 0, item_id = 0;

			SqlDataReader reader = cmd.ExecuteReader();

			if (reader.Read())
			{
				item_price = (reader.GetInt32(0));
				quantity = (reader.GetInt32(1));
				item_id = reader.GetInt32(2);
			}

			int total_price = item_price * quantity;

			// Create and configure a Label for the total price
			label1.Text = "Total Price: $" + total_price.ToString();

			// Create and configure a Button for submitting the payment
			Checkout.Click += (s, ev) => SubmitPayment(total_price, item_id);

			// Add the controls to the form
			this.Controls.Add(label1);
			this.Controls.Add(textBox1);
			this.Controls.Add(Checkout);
		}

		private void SubmitPayment(int bill, int item_id)
		{
			MessageBox.Show("Ordered successfully!");

			string personID = "NULL";

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlCommand cmd = new SqlCommand("select person_id from Cart where cart_id = " + cartID, con);
			SqlDataReader reader = cmd.ExecuteReader();

			if (reader.Read())
			{
				personID = reader.GetInt32(0).ToString();
			}


			reader.Close();

			cmd = new SqlCommand("delete from Cart where cart_id = " + cartID, con);
			cmd.ExecuteNonQuery();

			cmd = new SqlCommand("INSERT INTO Orders (person_id, bill, item_id, order_status) " +
								" VALUES (" + personID + ", " + bill.ToString() + ", " + item_id.ToString() + " , 'Under Progress')", con);

			cmd.ExecuteNonQuery();

			con.Close();

			this.Hide();
			Menu customerMenu = new Menu(personID);
			customerMenu.Closed += (s, args) => this.Close();
			customerMenu.Show();

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}

