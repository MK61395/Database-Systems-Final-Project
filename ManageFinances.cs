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
    public partial class ManageFinances : Form
    {
        public ManageFinances()
        {
            InitializeComponent();

			string ConnectionString = "Data Source=HP-PAVILION-15;Initial Catalog=DBProject;Integrated Security=True;TrustServerCertificate=True";
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();

			SqlDataAdapter da = new SqlDataAdapter("select * from Sales", ConnectionString);
			DataSet ds = new DataSet();


			SqlCommandBuilder cmdBldr = new SqlCommandBuilder(da);
			da.Fill(ds, "Sales");
			dataGridView1.DataSource = ds.Tables[0];
			da.Update(ds, "Sales");
		}

        private void ManageFinances_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Financial Metrics Section
            Form financialMetricsForm = new Form();
            financialMetricsForm.Text = "Financial Metrics";
            financialMetricsForm.Size = new Size(350, 150); // Set the desired size

            Label revenueLabel = new Label();
            revenueLabel.Text = "Total Revenue:";
            revenueLabel.AutoSize = true;
            revenueLabel.Location = new Point(10, 10);
            financialMetricsForm.Controls.Add(revenueLabel);

            TextBox revenueTextBox = new TextBox();
            revenueTextBox.ReadOnly = true;
            revenueTextBox.Text = FetchTotalRevenueFromDatabase(); // Fetch and set the actual revenue value from your data
            revenueTextBox.Location = new Point(revenueLabel.Right + 10, revenueLabel.Top - 3);
            revenueTextBox.Size = new Size(200, 20);
            financialMetricsForm.Controls.Add(revenueTextBox);

            Label expensesLabel = new Label();
            expensesLabel.Text = "Total Expenses:";
            expensesLabel.AutoSize = true;
            expensesLabel.Location = new Point(10, 40);
            financialMetricsForm.Controls.Add(expensesLabel);

            TextBox expensesTextBox = new TextBox();
            expensesTextBox.ReadOnly = true;
            expensesTextBox.Text = FetchTotalExpensesFromDatabase(); // Fetch and set the actual expenses value from your data
            expensesTextBox.Location = new Point(expensesLabel.Right + 10, expensesLabel.Top - 3);
            expensesTextBox.Size = new Size(200, 20);
            financialMetricsForm.Controls.Add(expensesTextBox);

            // Show the form
            financialMetricsForm.ShowDialog();
        }

        // Function to fetch total revenue from the database
        private string FetchTotalRevenueFromDatabase()
        {
            // Implement the logic to fetch and return the total revenue from your database
            // ...

            // For now, returning a placeholder value
            return "$100,000";
        }

        // Function to fetch total expenses from the database
        private string FetchTotalExpensesFromDatabase()
        {
            // Implement the logic to fetch and return the total expenses from your database
            // ...

            // For now, returning a placeholder value
            return "$50,000";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Budgeting and Expense Tracking Section
            Form budgetExpenseForm = new Form();
            budgetExpenseForm.Text = "Budgeting and Expense Tracking";
            budgetExpenseForm.Size = new Size(300, 150); // Set the desired size

            Label budgetLabel = new Label();
            budgetLabel.Text = "Budget Amount: $" + FetchBudgetAmountFromDatabase(); // Set the actual budget value from your data
            budgetLabel.AutoSize = true;
            budgetLabel.Location = new Point(10, 10);
            budgetExpenseForm.Controls.Add(budgetLabel);

            Label expenseLabel = new Label();
            expenseLabel.Text = "Expense Tracking: $" + FetchExpenseTrackingFromDatabase(); // Set the actual expense tracking value from your data
            expenseLabel.AutoSize = true;
            expenseLabel.Location = new Point(10, budgetLabel.Bottom + 5);
            budgetExpenseForm.Controls.Add(expenseLabel);

            // Show the form
            budgetExpenseForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Financial Reports and Analytics Section
            Form financialReportsForm = new Form();
            financialReportsForm.Text = "Financial Reports and Analytics";
            financialReportsForm.Size = new Size(300, 150); // Set the desired size

            Label reportsLabel = new Label();
            reportsLabel.Text = "Financial Reports: " + FetchFinancialReportsFromDatabase(); // Set the actual reports value from your data
            reportsLabel.AutoSize = true;
            reportsLabel.Location = new Point(10, 10);
            financialReportsForm.Controls.Add(reportsLabel);

            // Show the form
            financialReportsForm.ShowDialog();
        }

        // Functions to fetch data from the database
        private string FetchBudgetAmountFromDatabase()
        {
            // Implement the logic to fetch and return the budget amount from your database
            // ...

            // For now, returning a placeholder value
            return "50,000";
        }

        private string FetchExpenseTrackingFromDatabase()
        {
            // Implement the logic to fetch and return the expense tracking value from your database
            // ...

            // For now, returning a placeholder value
            return "30,000";
        }

        private string FetchFinancialReportsFromDatabase()
        {
            // Implement the logic to fetch and return the financial reports value from your database
            // ...

            // For now, returning a placeholder value
            return "Monthly Financial Report";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Generate Fiscal Report Section
            Form generateReportForm = new Form();
            generateReportForm.Text = "Generate Fiscal Report";
            generateReportForm.Size = new Size(400, 200); // Increased the size

            Label periodLabel = new Label();
            periodLabel.Text = "Select Period:";
            periodLabel.AutoSize = true;
            periodLabel.Location = new Point(10, 10);
            generateReportForm.Controls.Add(periodLabel);

            ComboBox periodComboBox = new ComboBox();
            periodComboBox.Items.AddRange(new object[] { "Last Day", "Last Week", "Last Month", "Last Year" });
            periodComboBox.Location = new Point(10, periodLabel.Bottom + 5);
            generateReportForm.Controls.Add(periodComboBox);

            Button generateButton = new Button();
            generateButton.Text = "Generate Report";
            generateButton.Size = new Size(120, 30); // Increased the size
            generateButton.Location = new Point(10, periodComboBox.Bottom + 10);
            generateButton.Click += (s, ev) => GenerateFiscalReport(periodComboBox.SelectedItem.ToString());
            generateReportForm.Controls.Add(generateButton);

            // Show the form
            generateReportForm.ShowDialog();
        }


        // Function to handle the "Generate Report" button click for Fiscal Reports
        private void GenerateFiscalReport(string selectedPeriod)
        {
            // TODO: Fetch data from the database based on the selected period
            // Example: 
            // 1. Fetch revenue and expense data for the selected period
            // 2. Perform calculations or queries to generate the fiscal report

            // For demonstration purposes, let's assume you have fetched revenue and expense data
            decimal totalRevenue = FetchTotalRevenue(selectedPeriod);
            decimal totalExpenses = FetchTotalExpenses(selectedPeriod);

            // Display the fiscal report (you can customize this part based on your report format)
            string reportText = $"Fiscal Report for {selectedPeriod}:\n";
            reportText += $"Total Revenue: ${totalRevenue}\n";
            reportText += $"Total Expenses: ${totalExpenses}";

            // Optionally, you can display the report in a MessageBox or another UI component
            MessageBox.Show(reportText, "Fiscal Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // TODO: Add functions to fetch data from the database based on the selected period
        private decimal FetchTotalRevenue(string selectedPeriod)
        {
            // TODO: Implement logic to fetch total revenue from the database
            // Example: Fetch data from a "Revenue" table where the timestamp matches the selected period
            return 10000.0m; // Placeholder value, replace with actual fetched value
        }

        private decimal FetchTotalExpenses(string selectedPeriod)
        {
            // TODO: Implement logic to fetch total expenses from the database
            // Example: Fetch data from an "Expenses" table where the timestamp matches the selected period
            return 5000.0m; // Placeholder value, replace with actual fetched value
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Check the user's choice
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
            ManageInventory manageInventory = new ManageInventory();
            manageInventory.Show();
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
