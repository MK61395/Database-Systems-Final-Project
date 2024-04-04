namespace DBProject
{
	partial class PointOfSale
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
			button2 = new Button();
			label5 = new Label();
			dataGridView1 = new DataGridView();
			textBox1 = new TextBox();
			label4 = new Label();
			label1 = new Label();
			panel1 = new Panel();
			button1 = new Button();
			button8 = new Button();
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
			panel2.Controls.Add(button2);
			panel2.Controls.Add(label5);
			panel2.Controls.Add(dataGridView1);
			panel2.Controls.Add(textBox1);
			panel2.Controls.Add(label4);
			panel2.Controls.Add(label1);
			panel2.Location = new Point(211, 12);
			panel2.Name = "panel2";
			panel2.Size = new Size(781, 514);
			panel2.TabIndex = 9;
			// 
			// button3
			// 
			button3.Location = new Point(502, 103);
			button3.Name = "button3";
			button3.Size = new Size(94, 29);
			button3.TabIndex = 32;
			button3.Text = "Enter";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(0, 118, 225);
			button2.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			button2.ForeColor = Color.White;
			button2.Location = new Point(286, 389);
			button2.Name = "button2";
			button2.Size = new Size(189, 57);
			button2.TabIndex = 31;
			button2.Text = "Process Payment";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(335, 186);
			label5.Name = "label5";
			label5.Size = new Size(97, 20);
			label5.TabIndex = 28;
			label5.Text = "Order Details";
			label5.Click += label5_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(92, 209);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(586, 141);
			dataGridView1.TabIndex = 27;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.LightGray;
			textBox1.Location = new Point(286, 105);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(189, 27);
			textBox1.TabIndex = 22;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(146, 108);
			label4.Name = "label4";
			label4.Size = new Size(104, 20);
			label4.TabIndex = 21;
			label4.Text = "Enter Order ID";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F, FontStyle.Underline, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.Desktop;
			label1.Location = new Point(281, 30);
			label1.Name = "label1";
			label1.Size = new Size(194, 24);
			label1.TabIndex = 17;
			label1.Text = "Cashier Point of Sale";
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(button1);
			panel1.Controls.Add(button8);
			panel1.Controls.Add(button4);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(200, 514);
			panel1.TabIndex = 8;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(0, 118, 225);
			button1.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			button1.ForeColor = Color.White;
			button1.Location = new Point(32, 105);
			button1.Name = "button1";
			button1.Size = new Size(145, 57);
			button1.TabIndex = 22;
			button1.Text = "Clock In/Out";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
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
			button8.Text = "Manage Register";
			button8.UseVisualStyleBackColor = false;
			button8.Click += button8_Click;
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
			// PointOfSale
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(0, 118, 225);
			ClientSize = new Size(1004, 538);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "PointOfSale";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "PointOfSale";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private Label label5;
		private DataGridView dataGridView1;
		private TextBox textBox1;
		private Label label4;
		private Label label1;
		private Panel panel1;
		private Button button1;
		private Button button8;
		private Button button4;
		private Button button2;
		private Button button3;
	}
}