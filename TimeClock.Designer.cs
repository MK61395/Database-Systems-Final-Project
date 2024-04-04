namespace DBProject
{
	partial class TimeClock
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
			label2 = new Label();
			button3 = new Button();
			button2 = new Button();
			button10 = new Button();
			button5 = new Button();
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
			panel2.Controls.Add(label2);
			panel2.Controls.Add(button3);
			panel2.Controls.Add(button2);
			panel2.Controls.Add(button10);
			panel2.Controls.Add(button5);
			panel2.Controls.Add(dataGridView1);
			panel2.Controls.Add(label1);
			panel2.Location = new Point(211, 12);
			panel2.Name = "panel2";
			panel2.Size = new Size(781, 514);
			panel2.TabIndex = 15;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(308, 239);
			label2.Name = "label2";
			label2.Size = new Size(94, 20);
			label2.TabIndex = 41;
			label2.Text = "Work History";
			// 
			// button3
			// 
			button3.BackColor = Color.FromArgb(0, 118, 225);
			button3.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			button3.ForeColor = Color.White;
			button3.Location = new Point(215, 145);
			button3.Name = "button3";
			button3.Size = new Size(129, 31);
			button3.TabIndex = 40;
			button3.Text = "Start Break";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(0, 118, 225);
			button2.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			button2.ForeColor = Color.White;
			button2.Location = new Point(215, 93);
			button2.Name = "button2";
			button2.Size = new Size(129, 31);
			button2.TabIndex = 39;
			button2.Text = "Clock In";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button10
			// 
			button10.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			button10.Location = new Point(383, 145);
			button10.Name = "button10";
			button10.Size = new Size(129, 31);
			button10.TabIndex = 38;
			button10.Text = "End Break";
			button10.UseVisualStyleBackColor = true;
			button10.Click += button10_Click;
			// 
			// button5
			// 
			button5.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			button5.Location = new Point(383, 93);
			button5.Name = "button5";
			button5.Size = new Size(129, 31);
			button5.TabIndex = 37;
			button5.Text = "Clock Out";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(140, 262);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(438, 188);
			dataGridView1.TabIndex = 27;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F, FontStyle.Underline, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.Desktop;
			label1.Location = new Point(271, 30);
			label1.Name = "label1";
			label1.Size = new Size(180, 24);
			label1.TabIndex = 17;
			label1.Text = "Cashier Time Clock";
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
			panel1.TabIndex = 14;
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
			// TimeClock
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(0, 118, 225);
			ClientSize = new Size(1004, 538);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "TimeClock";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "TimeClock";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private Button button10;
		private Button button5;
		private DataGridView dataGridView1;
		private Label label1;
		private Panel panel1;
		private Button button9;
		private Button button8;
		private Button button4;
		private Button button2;
		private Button button3;
		private Label label2;
	}
}