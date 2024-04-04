namespace DBProject
{
	partial class Feedback
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
			comboBox1 = new ComboBox();
			label3 = new Label();
			textBox1 = new TextBox();
			label1 = new Label();
			button5 = new Button();
			panel1 = new Panel();
			button4 = new Button();
			button1 = new Button();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.BackColor = Color.LightGray;
			panel2.Controls.Add(comboBox1);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(textBox1);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(button5);
			panel2.Location = new Point(211, 12);
			panel2.Name = "panel2";
			panel2.Size = new Size(781, 514);
			panel2.TabIndex = 5;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(269, 157);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(243, 28);
			comboBox1.TabIndex = 31;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(142, 228);
			label3.Name = "label3";
			label3.Size = new Size(80, 20);
			label3.TabIndex = 30;
			label3.Text = "Comments";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(269, 221);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(243, 27);
			textBox1.TabIndex = 29;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(131, 160);
			label1.Name = "label1";
			label1.Size = new Size(91, 20);
			label1.TabIndex = 26;
			label1.Text = "Select Order";
			label1.Click += label1_Click;
			// 
			// button5
			// 
			button5.BackColor = Color.FromArgb(0, 118, 225);
			button5.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			button5.ForeColor = Color.White;
			button5.Location = new Point(269, 329);
			button5.Name = "button5";
			button5.Size = new Size(243, 46);
			button5.TabIndex = 16;
			button5.Text = "Submit Feedback";
			button5.UseVisualStyleBackColor = false;
			button5.Click += button5_Click;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(button1);
			panel1.Controls.Add(button4);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(200, 514);
			panel1.TabIndex = 4;
			// 
			// button4
			// 
			button4.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			button4.Location = new Point(32, 434);
			button4.Name = "button4";
			button4.Size = new Size(139, 46);
			button4.TabIndex = 15;
			button4.Text = "LOG OUT";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(32, 29);
			button1.Name = "button1";
			button1.Size = new Size(139, 40);
			button1.TabIndex = 16;
			button1.Text = "Back";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Feedback
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(0, 118, 225);
			ClientSize = new Size(1004, 538);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Feedback";
			Text = "Feedback";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private Button button5;
		private Panel panel1;
		private Button button4;
		private Label label1;
		private Label label3;
		private TextBox textBox1;
		private ComboBox comboBox1;
		private Button button1;
	}
}