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
	public partial class ManagerDashboard : Form
	{
		public ManagerDashboard()
		{
			InitializeComponent();

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlDataAdapter da = new SqlDataAdapter("select sales_id as 'Sales ID', month_sales as 'Monthly Sales', month_revenue as 'Monthly Revenue', time_period as 'Time Period' from Sales", ConnectionString);
			DataSet ds = new DataSet();


			SqlCommandBuilder cmdBldr = new SqlCommandBuilder(da);
			da.Fill(ds, "Sales");
			dataGridView1.DataSource = ds.Tables[0];
			da.Update(ds, "Sales");
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
			ManageMenu manageMenu = new ManageMenu();
			manageMenu.Show();
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

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string sales = textBox1.Text;
			string revenue = textBox2.Text;
			string period = textBox3.Text;

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			string query = "insert into Sales (month_sales, month_revenue, time_period)" +
							"values (" + sales + ", " + revenue + ",'" + period + "')";


			MessageBox.Show("Report submitted successfully.");


			SqlCommand myCommand = new SqlCommand(query, con);
			myCommand.ExecuteNonQuery();

			con.Close();
		}
	}
}
