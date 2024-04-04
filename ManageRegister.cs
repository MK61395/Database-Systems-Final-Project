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
	public partial class ManageRegister : Form
	{
		string personID;
		public ManageRegister(string personID)
		{
			InitializeComponent();
			this.personID = personID;

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlDataAdapter da = new SqlDataAdapter("select p.ID as ID, CONCAT(p.FirstName, ' ' ,p. LastName) as Name, o.bill as 'Total Bill', i.item_name AS 'Item Name', o.order_status as 'Order Status', c.category_name as 'Category' from Orders o " + 
												   "join PersonDetails p on p.Id = o.person_id " +
												   "join Items i on i.item_id = o.item_id " +
												   "join Category c on i.cat_id = c.category_id " +
												   "where o.order_status = 'Completed'", ConnectionString);
			DataSet ds = new DataSet();


			SqlCommandBuilder cmdBldr = new SqlCommandBuilder(da);
			da.Fill(ds, "Sales");
			dataGridView1.DataSource = ds.Tables[0];
			da.Update(ds, "Sales");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			// Create and configure the form for opening the cash register
			Form openRegisterForm = new Form();
			openRegisterForm.Text = "Open Register";
			openRegisterForm.AutoSize = true;

			Label startingBalanceLabel = new Label
			{
				Text = "Starting Balance:",
				Location = new Point(10, 10),
				AutoSize = true
			};
			openRegisterForm.Controls.Add(startingBalanceLabel);

			TextBox startingBalanceTextBox = new TextBox
			{
				Location = new Point(140, 10),
				AutoSize = true
			};
			openRegisterForm.Controls.Add(startingBalanceTextBox);

			Button confirmButton = new Button
			{
				Text = "Confirm",
				Location = new Point(10, 40),
				AutoSize = true
			};
			confirmButton.Click += (s, ev) => ConfirmOpeningBalance(startingBalanceTextBox.Text);
			openRegisterForm.Controls.Add(confirmButton);

			// Show the form
			openRegisterForm.ShowDialog();
		}


		private void ConfirmOpeningBalance(string startingBalance)
		{
			// Validate and process the starting balance (you can add more validation as needed)
			if (decimal.TryParse(startingBalance, out decimal balance))
			{
				// Display the starting balance in textBox1
				//textBox1.Text = balance.ToString("C"); // Assumes textBox1 is used to display the balance
				CheckLowBalance(balance);
			}
			else
			{
				MessageBox.Show("Invalid starting balance. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			// Create and configure the form for closing the cash register
			Form closeRegisterForm = new Form();
			closeRegisterForm.Text = "Close Register";
			closeRegisterForm.AutoSize = true;

			Label closingBalanceLabel = new Label
			{
				Text = "Closing Balance:",
				Location = new Point(10, 10),
				AutoSize = true
			};
			closeRegisterForm.Controls.Add(closingBalanceLabel);

			TextBox closingBalanceTextBox = new TextBox
			{
				Location = new Point(140, 10),
				AutoSize = true
			};
			closeRegisterForm.Controls.Add(closingBalanceTextBox);

			Button confirmButton = new Button
			{
				Text = "Confirm",
				Location = new Point(10, 40),
				AutoSize = true
			};
			confirmButton.Click += (s, ev) => ConfirmClosingBalance(closingBalanceTextBox.Text);
			closeRegisterForm.Controls.Add(confirmButton);

			// Show the form
			closeRegisterForm.ShowDialog();
		}

		private void ConfirmClosingBalance(string closingBalance)
		{
			// Validate and process the closing balance (you can add more validation as needed)
			if (decimal.TryParse(closingBalance, out decimal balance))
			{
				// Display the closing balance in textBox1
				//textBox1.Text = balance.ToString("C"); // Assumes textBox1 is used to display the balance
				CheckLowBalance(balance);
			}
			else
			{
				MessageBox.Show("Invalid closing balance. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CheckLowBalance(decimal currentBalance)
		{
			// Set your low balance threshold
			decimal lowBalanceThreshold = 500.0m;

			// Display an alert if the balance is below the threshold
			if (currentBalance < lowBalanceThreshold)
			{
				MessageBox.Show("Low cash balance! Please consider replenishing the register.", "Low Balance Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
			this.Close();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			PointOfSale pointOfSale = new PointOfSale(personID);
			pointOfSale.Show();
			this.Hide();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			TimeClock timeClock = new TimeClock(personID);
			timeClock.Show();
			this.Hide();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
