namespace DBProject
{
	partial class ManagerDashboard
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
			button2 = new Button();
			label5 = new Label();
			dataGridView1 = new DataGridView();
			label2 = new Label();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			label3 = new Label();
			textBox1 = new TextBox();
			label4 = new Label();
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
			panel2.Controls.Add(button2);
			panel2.Controls.Add(label5);
			panel2.Controls.Add(dataGridView1);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(textBox3);
			panel2.Controls.Add(textBox2);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(textBox1);
			panel2.Controls.Add(label4);
			panel2.Controls.Add(label1);
			panel2.Location = new Point(211, 12);
			panel2.Name = "panel2";
			panel2.Size = new Size(781, 514);
			panel2.TabIndex = 7;
			panel2.Paint += panel2_Paint;
			// 
			// button2
			// 
			button2.Location = new Point(578, 186);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 29;
			button2.Text = "Submit";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(322, 259);
			label5.Name = "label5";
			label5.Size = new Size(118, 20);
			label5.TabIndex = 28;
			label5.Text = "Monthly Reports";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(117, 291);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(516, 174);
			dataGridView1.TabIndex = 27;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(175, 189);
			label2.Name = "label2";
			label2.Size = new Size(94, 20);
			label2.TabIndex = 26;
			label2.Text = "Month / Year";
			label2.Click += label2_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(286, 186);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(189, 27);
			textBox3.TabIndex = 25;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(286, 136);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(189, 27);
			textBox2.TabIndex = 24;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(204, 143);
			label3.Name = "label3";
			label3.Size = new Size(65, 20);
			label3.TabIndex = 23;
			label3.Text = "Revenue";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(286, 88);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(189, 27);
			textBox1.TabIndex = 22;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(226, 91);
			label4.Name = "label4";
			label4.Size = new Size(43, 20);
			label4.TabIndex = 21;
			label4.Text = "Sales";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F, FontStyle.Underline, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.Desktop;
			label1.Location = new Point(260, 30);
			label1.Name = "label1";
			label1.Size = new Size(235, 24);
			label1.TabIndex = 17;
			label1.Text = "Cafe Manager Dashboard";
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
			panel1.TabIndex = 6;
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
			button6.Text = "Customer Satisfaction";
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
			button1.Text = "Manage Finances";
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
			button9.Text = "Manage Staff";
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
			button8.Text = "Manage Menu";
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
			button7.Text = "Manage Inventory";
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
			// ManagerDashboard
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(0, 118, 225);
			ClientSize = new Size(1004, 538);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ManagerDashboard";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ManagerDashboard";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private Panel panel1;
		private Button button9;
		private Button button8;
		private Button button7;
		private Button button4;
		private Label label1;
		private Button button6;
		private Button button1;
		private Label label2;
		private TextBox textBox3;
		private TextBox textBox2;
		private Label label3;
		private TextBox textBox1;
		private Label label4;
		private Label label5;
		private DataGridView dataGridView1;
		private Button button2;
	}
}