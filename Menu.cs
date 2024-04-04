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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBProject
{
	public partial class Menu : Form
	{

		string item;
		string id;
		string quantity = "0";
		public Menu(string personID)
		{
			InitializeComponent();

			id = personID;

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			comboBox1.DisplayMember = "Text";
			comboBox1.ValueMember = "Value";

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select COUNT(*) from category";
			cmd.Connection = con;
			SqlDataReader dr = cmd.ExecuteReader();
			dr.Read();
			int max = dr.GetInt32(0);
			dr.Close();

			cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select category_name as 'Category' from category";
			cmd.Connection = con;
			SqlDataReader datareader = cmd.ExecuteReader();

			while (datareader.Read())
			{
				comboBox1.Items.Add(new { Text = datareader.GetString(0), Value = "reportA" });
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			//Form1 login = new Form1();
			//login.Show();
			//this.Hide();


			DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			// Check the user's choice
			if (result == DialogResult.OK)
			{
				Form1 form = new Form1();
				form.Show();

				this.Close();
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			this.item = dataGridView1.Rows[e.RowIndex].Cells[0].Value as string;
			MessageBox.Show("'" + this.item + "' selected.");
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = comboBox1.SelectedIndex;
			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";

			SqlConnection con = new SqlConnection(ConnectionString);

			con.Open();

			SqlDataAdapter da = new SqlDataAdapter("select item_name, item_price from Items Where cat_id = -1", ConnectionString);

			switch (index)
			{
				case 0:
					da = new SqlDataAdapter("select item_name, item_price from Items Where cat_id = 1", ConnectionString);
					break;
				case 1:
					da = new SqlDataAdapter("select item_name, item_price from Items Where cat_id = 2", ConnectionString);
					break;
				case 2:
					da = new SqlDataAdapter("select item_name, item_price from Items Where cat_id = 3", ConnectionString);
					break;
				case 3:
					da = new SqlDataAdapter("select item_name, item_price from Items Where cat_id = 4", ConnectionString);
					break;
				case 4:
					da = new SqlDataAdapter("select item_name, item_price from Items Where cat_id = 5", ConnectionString);
					break;
				default:
					break;
			}


			DataSet ds = new DataSet();


			SqlCommandBuilder cmdBldr = new SqlCommandBuilder(da);
			da.Fill(ds, "Items");
			dataGridView1.DataSource = ds.Tables[0];
			da.Update(ds, "Items");
		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			// Create an instance of the CartPage form


			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			// MessageBox.Show("Items is '" + this.item + "'.");


			string query = "INSERT INTO Cart (item_id, person_id ,quantity)\n" +
							"VALUES ((SELECT item_id from Items where item_name = '" + this.item + "')," + id + ", " + quantity + ")";

			SqlCommand myCommand = new SqlCommand(query, con);
			myCommand.ExecuteNonQuery();


			con.Close();

			CartPage cartPage = new CartPage(id.ToString());
			// Show the CartPage form
			cartPage.Show();

			// Optionally, you can hide the current (Menu) form
			this.Hide();
		}

		private void textBox1_TextChanged_2(object sender, EventArgs e)
		{
			quantity = textBox1.Text;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Feedback feedback = new Feedback(id);
			feedback.Show();	
		}
	}
}
