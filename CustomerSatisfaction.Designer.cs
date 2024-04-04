namespace DBProject
{
	partial class CustomerSatisfaction
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel2 = new Panel();
			button10 = new Button();
			label5 = new Label();
			dataGridView1 = new DataGridView();
			label1 = new Label();
			panel1 = new Panel();
			button6 = new Button();
			button1 = new Button();
			button9 = new Button();
			button8 = new Button();
			button7 = new Button();
			button4 = new Button();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.BackColor = Color.LightGray;
			panel2.Controls.Add(button10);
			panel2.Controls.Add(label5);
			panel2.Controls.Add(dataGridView1);
			panel2.Controls.Add(label1);
			panel2.Location = new Point(211, 12);
			panel2.Name = "panel2";
			panel2.Size = new Size(781, 514);
			panel2.TabIndex = 17;
			// 
			// button10
			// 
			button10.BackColor = Color.FromArgb(0, 118, 225);
			button10.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			button10.ForeColor = Color.White;
			button10.Location = new Point(263, 424);
			button10.Name = "button10";
			button10.Size = new Size(248, 57);
			button10.TabIndex = 32;
			button10.Text = "Respond to Feedback";
			button10.UseVisualStyleBackColor = false;
			button10.Click += button10_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(292, 82);
			label5.Name = "label5";
			label5.Size = new Size(188, 20);
			label5.TabIndex = 28;
			label5.Text = "Recent Customer Feedback";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(56, 105);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(671, 292);
			dataGridView1.TabIndex = 27;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F, FontStyle.Underline, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.Desktop;
			label1.Location = new Point(242, 30);
			label1.Name = "label1";
			label1.Size = new Size(280, 24);
			label1.TabIndex = 17;
			label1.Text = "Manage Customer Satisfaction";
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(button6);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(button9);
			panel1.Controls.Add(button8);
			panel1.Controls.Add(button7);
			panel1.Controls.Add(button4);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(200, 514);
			panel1.TabIndex = 16;
			// 
			// button6
			// 
			button6.BackColor = Color.FromArgb(0, 118, 225);
			button6.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			button6.ForeColor = Color.White;
			button6.Location = new Point(32, 282);
			button6.Name = "button6";
			button6.Size = new Size(145, 57);
			button6.TabIndex = 23;
			button6.Text = "Manage Finances";
			button6.UseVisualStyleBackColor = false;
			button6.Click += button6_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(0, 118, 225);
			button1.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			button1.ForeColor = Color.White;
			button1.Location = new Point(32, 219);
			button1.Name = "button1";
			button1.Size = new Size(145, 57);
			button1.TabIndex = 22;
			button1.Text = "Manage Inventory";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button9
			// 
			button9.BackColor = Color.FromArgb(0, 118, 225);
			button9.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			button9.ForeColor = Color.White;
			button9.Location = new Point(32, 93);
			button9.Name = "button9";
			button9.Size = new Size(145, 57);
			button9.TabIndex = 21;
			button9.Text = "Manage Menu";
			button9.UseVisualStyleBackColor = false;
			button9.Click += button9_Click;
			// 
			// button8
			// 
			button8.BackColor = Color.FromArgb(0, 118, 225);
			button8.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			button8.ForeColor = Color.White;
			button8.Location = new Point(32, 30);
			button8.Name = "button8";
			button8.Size = new Size(145, 57);
			button8.TabIndex = 20;
			button8.Text = "Dashboard";
			button8.UseVisualStyleBackColor = false;
			button8.Click += button8_Click;
			// 
			// button7
			// 
			button7.BackColor = Color.FromArgb(0, 118, 225);
			button7.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			button7.ForeColor = Color.White;
			button7.Location = new Point(32, 156);
			button7.Name = "button7";
			button7.Size = new Size(145, 57);
			button7.TabIndex = 19;
			button7.Text = "Manage Staff";
			button7.UseVisualStyleBackColor = false;
			button7.Click += button7_Click;
			// 
			// button4
			// 
			button4.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			button4.Location = new Point(38, 435);
			button4.Name = "button4";
			button4.Size = new Size(139, 46);
			button4.TabIndex = 15;
			button4.Text = "LOG OUT";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// CustomerSatisfaction
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(0, 118, 225);
			ClientSize = new Size(1004, 538);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "CustomerSatisfaction";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "CustomerSatisfaction";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private Button button10;
		private Label label5;
		private DataGridView dataGridView1;
		private Label label1;
		private Panel panel1;
		private Button button6;
		private Button button1;
		private Button button9;
		private Button button8;
		private Button button7;
		private Button button4;
	}
}