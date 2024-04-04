namespace DBProject
{
	partial class OrderSummary
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
			button3 = new Button();
			textBox3 = new TextBox();
			label3 = new Label();
			textBox2 = new TextBox();
			label2 = new Label();
			button2 = new Button();
			label5 = new Label();
			dataGridView1 = new DataGridView();
			textBox1 = new TextBox();
			label4 = new Label();
			label1 = new Label();
			panel1 = new Panel();
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
			panel2.Controls.Add(button3);
			panel2.Controls.Add(textBox3);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(textBox2);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(button2);
			panel2.Controls.Add(label5);
			panel2.Controls.Add(dataGridView1);
			panel2.Controls.Add(textBox1);
			panel2.Controls.Add(label4);
			panel2.Controls.Add(label1);
			panel2.Location = new Point(211, 12);
			panel2.Name = "panel2";
			panel2.Size = new Size(781, 514);
			panel2.TabIndex = 11;
			// 
			// button3
			// 
			button3.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			button3.Location = new Point(163, 416);
			button3.Name = "button3";
			button3.Size = new Size(187, 57);
			button3.TabIndex = 36;
			button3.Text = "Start New Order";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// textBox3
			// 
			textBox3.BackColor = Color.LightGray;
			textBox3.Location = new Point(325, 318);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(203, 27);
			textBox3.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(220, 321);
			label3.Name = "label3";
			label3.Size = new Size(94, 20);
			label3.TabIndex = 34;
			label3.Text = "Amount Paid";
			// 
			// textBox2
			// 
			textBox2.BackColor = Color.LightGray;
			textBox2.Location = new Point(325, 351);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(203, 27);
			textBox2.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(220, 354);
			label2.Name = "label2";
			label2.Size = new Size(59, 20);
			label2.TabIndex = 32;
			label2.Text = "Change";
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(0, 118, 225);
			button2.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			button2.ForeColor = Color.White;
			button2.Location = new Point(394, 416);
			button2.Name = "button2";
			button2.Size = new Size(189, 57);
			button2.TabIndex = 31;
			button2.Text = "Complete Order";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(325, 65);
			label5.Name = "label5";
			label5.Size = new Size(106, 20);
			label5.TabIndex = 28;
			label5.Text = "Selected Items";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(228, 88);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(300, 188);
			dataGridView1.TabIndex = 27;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.LightGray;
			textBox1.Location = new Point(325, 285);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(203, 27);
			textBox1.TabIndex = 1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(220, 288);
			label4.Name = "label4";
			label4.Size = new Size(99, 20);
			label4.TabIndex = 21;
			label4.Text = "Total Amount";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F, FontStyle.Underline, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.Desktop;
			label1.Location = new Point(302, 30);
			label1.Name = "label1";
			label1.Size = new Size(150, 24);
			label1.TabIndex = 17;
			label1.Text = "Order Summary";
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(button9);
			panel1.Controls.Add(button8);
			panel1.Controls.Add(button7);
			panel1.Controls.Add(button4);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(200, 514);
			panel1.TabIndex = 10;
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
			button9.Text = "Manage Register";
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
			button8.Text = "New Order";
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
			button7.Text = "Clock In/Out";
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
			// OrderSummary
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(0, 118, 225);
			ClientSize = new Size(1004, 538);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "OrderSummary";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "OrderSummary";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private Button button2;
		private Label label5;
		private DataGridView dataGridView1;
		private TextBox textBox1;
		private Label label4;
		private Label label1;
		private Panel panel1;
		private Button button9;
		private Button button8;
		private Button button7;
		private Button button4;
		private Button button3;
		private TextBox textBox3;
		private Label label3;
		private TextBox textBox2;
		private Label label2;
	}
}