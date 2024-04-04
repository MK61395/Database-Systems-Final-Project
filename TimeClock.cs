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
	public partial class TimeClock : Form
	{
		string personID;
		private DateTime? clockInTime;
		private DateTime? breakStartTime;
		private DateTime? breakEndTime;
		private DateTime? clockOutTime;
		public TimeClock(string personID)
		{
			InitializeComponent();
			this.personID = personID;

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlDataAdapter da = new SqlDataAdapter("select p.ID, p.FirstName, w.day, w.clock_in, w.clock_out" + 
			", w.start_break, w.end_break from PersonDetails p join WorkHistory w on p.ID = w.worker_id"
			, ConnectionString);
			DataSet ds = new DataSet();


			SqlCommandBuilder cmdBldr = new SqlCommandBuilder(da);
			da.Fill(ds, "Sales");
			dataGridView1.DataSource = ds.Tables[0];
			da.Update(ds, "Sales");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			clockInTime = DateTime.Now;
			DateTime today = DateTime.Today;

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			string query = "insert into WorkHistory (day, clock_in, worker_id)\n"
				+ "values ('" + today + "','" + clockInTime + "', " + personID + ")";

			SqlCommand cmd = new SqlCommand(query, con);
			cmd.ExecuteNonQuery();

			con.Close();

			MessageBox.Show("Clock In successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DateTime start_break = DateTime.Now;
			TimeSpan TodayTime = DateTime.Now.TimeOfDay;

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			// Define the trigger creation query
			string triggerQuery = @"
    IF EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[trg_UpdateStartBreak]'))
    DROP TRIGGER [dbo].[trg_UpdateStartBreak];
    GO

    CREATE TRIGGER trg_UpdateStartBreak
    ON WorkHistory
    AFTER INSERT, UPDATE
    AS
    BEGIN
        UPDATE WorkHistory
        SET start_break = GETDATE()
        FROM inserted i
        WHERE WorkHistory.worker_id = i.worker_id
    END;
    GO
    ";

			// Execute the trigger creation query
			SqlCommand triggerCmd = new SqlCommand(triggerQuery, con);
			triggerCmd.ExecuteNonQuery();

			// Update the start_break field for the current worker
			string updateQuery = "UPDATE WorkHistory SET start_break = '" + TodayTime + "' WHERE worker_id = " + personID;
			SqlCommand updateCmd = new SqlCommand(updateQuery, con);
			updateCmd.ExecuteNonQuery();

			con.Close();

			MessageBox.Show("Break time updated and trigger created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}


		private void button10_Click(object sender, EventArgs e)
		{
			DateTime end_break = DateTime.Now;
			TimeSpan TodayTime = DateTime.Now.TimeOfDay;


			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			string query = "update WorkHistory set end_break = '" + TodayTime + "' where worker_id = " + personID;

			SqlCommand cmd = new SqlCommand(query, con);
			cmd.ExecuteNonQuery();

			con.Close();

			MessageBox.Show("Break time updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			clockOutTime = DateTime.Now;

			DateTime today = DateTime.Today;
			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			string query = "Update WorkHistory set clock_out = '" + clockOutTime + "' where worker_id = " + personID;

			SqlCommand cmd = new SqlCommand(query, con);
			cmd.ExecuteNonQuery();

			con.Close();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
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
	}
}
