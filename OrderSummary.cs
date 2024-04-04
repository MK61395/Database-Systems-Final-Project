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
	public partial class OrderSummary : Form
	{

		string orderID, personID;
		public OrderSummary(string orderID, string personID)
		{
			InitializeComponent();

			this.orderID = orderID;
			this.personID = personID;

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlDataAdapter da = new SqlDataAdapter("select o.order_id as 'Order ID', o.bill as 'Bill', o.order_status as 'Order Status', CONCAT(p.FirstName, ' ', p.LastName) as 'Full Name' from Orders o join PersonDetails p on o.person_id = p.ID where order_id = " + orderID, ConnectionString);
			DataSet ds = new DataSet();


			SqlCommandBuilder cmdBldr = new SqlCommandBuilder(da);
			da.Fill(ds, "Orders");
			dataGridView1.DataSource = ds.Tables[0];
			da.Update(ds, "Orders");
			con.Close();

		}

		private void button3_Click(object sender, EventArgs e)
		{
			PointOfSale pointOfSale = new PointOfSale(personID);
			pointOfSale.Show();
			this.Hide();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			PointOfSale pointOfSale = new PointOfSale(personID);
			pointOfSale.Show();
			this.Hide();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			ManageRegister manageRegister = new ManageRegister(personID);
			manageRegister.Show();
			this.Hide();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			TimeClock timeClock = new TimeClock(personID);
			timeClock.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
			this.Close();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			string query1 = "Update Orders set order_status = 'Completed'" +
							"where order_id = " + orderID;

			SqlCommand myCommand1 = new SqlCommand(query1, con);
			myCommand1.ExecuteNonQuery();

			MessageBox.Show("Order completed successfully!");

			con.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
