namespace DBProject
{
	partial class ManageRegister
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
			label5 = new Label();
			dataGridView1 = new DataGridView();
			label1 = new Label();
			panel1 = new Panel();
			button9 = new Button();
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
			panel2.Controls.Add(label5);
			panel2.Controls.Add(dataGridView1);
			panel2.Controls.Add(label1);
			panel2.Location = new Point(211, 12);
			panel2.Name = "panel2";
			panel2.Size = new Size(781, 514);
			panel2.TabIndex = 13;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(322, 93);
			label5.Name = "label5";
			label5.Size = new Size(139, 20);
			label5.TabIndex = 28;
			label5.Text = "Recent Transactions";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(91, 125);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(594, 308);
			dataGridView1.TabIndex = 27;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F, FontStyle.Underline, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.Desktop;
			label1.Location = new Point(291, 44);
			label1.Name = "label1";
			label1.Size = new Size(208, 24);
			label1.TabIndex = 17;
			label1.Text = "Manage Cash Register";
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(button9);
			panel1.Controls.Add(button8);
			panel1.Controls.Add(button4);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(200, 514);
			panel1.TabIndex = 12;
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
			button9.Text = "Clock In/Out";
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
			// ManageRegister
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(0, 118, 225);
			ClientSize = new Size(1004, 538);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ManageRegister";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ManageRegister";
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
		private Label label1;
		private Panel panel1;
		private Button button9;
		private Button button8;
		private Button button4;
	}
}