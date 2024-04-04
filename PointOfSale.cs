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
	public partial class PointOfSale : Form
	{
		string orderID, personID;
		public PointOfSale(string personID)
		{
			InitializeComponent();
			this.personID = personID;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			OrderSummary summary = new OrderSummary(orderID, personID);
			summary.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();

			this.Close();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			ManageRegister manageRegister = new ManageRegister(personID);
			manageRegister.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TimeClock timeClock = new TimeClock(personID);
			timeClock.Show();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void button3_Click(object sender, EventArgs e)
		{
			orderID = textBox1.Text;

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlDataAdapter da = new SqlDataAdapter("select order_id as 'Order ID', bill as 'Total Bill', order_status as 'Status', " +
												   " (select (CONCAT(FirstName, ' ', LastName)) from PersonDetails where ID = person_id) " +
												   " as 'Ordered By' from Orders where order_id = " + orderID, ConnectionString);
			DataSet ds = new DataSet();


			SqlCommandBuilder cmdBldr = new SqlCommandBuilder(da);
			da.Fill(ds, "Orders");
			dataGridView1.DataSource = ds.Tables[0];
			da.Update(ds, "Orders");
			con.Close();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
