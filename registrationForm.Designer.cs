namespace DBProject
{
	partial class registrationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrationForm));
			linkLabel1 = new LinkLabel();
			button1 = new Button();
			textBox1 = new TextBox();
			label3 = new Label();
			label2 = new Label();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			label4 = new Label();
			textBox5 = new TextBox();
			label5 = new Label();
			textBox6 = new TextBox();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			textBox2 = new TextBox();
			textBox7 = new TextBox();
			textBox8 = new TextBox();
			textBox9 = new TextBox();
			textBox10 = new TextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.LinkColor = Color.Teal;
			linkLabel1.Location = new Point(424, 442);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(183, 20);
			linkLabel1.TabIndex = 15;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Already Registered? Login";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// button1
			// 
			button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			button1.Location = new Point(450, 382);
			button1.Name = "button1";
			button1.Size = new Size(139, 46);
			button1.TabIndex = 11;
			button1.Text = "REGISTER";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(509, 252);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(171, 27);
			textBox1.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(392, 301);
			label3.Name = "label3";
			label3.Size = new Size(94, 23);
			label3.TabIndex = 11;
			label3.Text = "Password";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(392, 256);
			label2.Name = "label2";
			label2.Size = new Size(98, 23);
			label2.TabIndex = 10;
			label2.Text = "Username";
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(49, 120);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(309, 215);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 9;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(392, 129);
			label1.Name = "label1";
			label1.Size = new Size(99, 23);
			label1.TabIndex = 16;
			label1.Text = "Firstname";
			label1.Click += label1_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(509, 125);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(171, 27);
			textBox3.TabIndex = 1;
			textBox3.TextChanged += textBox3_TextChanged;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(509, 168);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(171, 27);
			textBox4.TabIndex = 2;
			textBox4.TextChanged += textBox4_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(392, 172);
			label4.Name = "label4";
			label4.Size = new Size(95, 23);
			label4.TabIndex = 18;
			label4.Text = "Lastname";
			label4.Click += label4_Click;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(509, 209);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(171, 27);
			textBox5.TabIndex = 3;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(392, 213);
			label5.Name = "label5";
			label5.Size = new Size(60, 23);
			label5.TabIndex = 20;
			label5.Text = "Email";
			// 
			// textBox6
			// 
			textBox6.Location = new Point(509, 297);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(171, 27);
			textBox6.TabIndex = 5;
			textBox6.TextChanged += textBox6_TextChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(709, 168);
			label6.Name = "label6";
			label6.Size = new Size(64, 23);
			label6.TabIndex = 22;
			label6.Text = "Phone";
			label6.Click += label6_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(709, 129);
			label7.Name = "label7";
			label7.Size = new Size(52, 23);
			label7.TabIndex = 24;
			label7.Text = "CNIC";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(709, 209);
			label8.Name = "label8";
			label8.Size = new Size(44, 23);
			label8.TabIndex = 25;
			label8.Text = "City";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label9.Location = new Point(709, 252);
			label9.Name = "label9";
			label9.Size = new Size(62, 23);
			label9.TabIndex = 26;
			label9.Text = "Street";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label10.Location = new Point(709, 297);
			label10.Name = "label10";
			label10.Size = new Size(65, 23);
			label10.TabIndex = 27;
			label10.Text = "House";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(782, 297);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(171, 27);
			textBox2.TabIndex = 10;
			// 
			// textBox7
			// 
			textBox7.Location = new Point(782, 209);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(171, 27);
			textBox7.TabIndex = 8;
			// 
			// textBox8
			// 
			textBox8.Location = new Point(782, 168);
			textBox8.Name = "textBox8";
			textBox8.Size = new Size(171, 27);
			textBox8.TabIndex = 7;
			// 
			// textBox9
			// 
			textBox9.Location = new Point(782, 125);
			textBox9.Name = "textBox9";
			textBox9.Size = new Size(171, 27);
			textBox9.TabIndex = 6;
			// 
			// textBox10
			// 
			textBox10.Location = new Point(782, 252);
			textBox10.Name = "textBox10";
			textBox10.Size = new Size(171, 27);
			textBox10.TabIndex = 9;
			// 
			// registrationForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightGray;
			ClientSize = new Size(1001, 507);
			Controls.Add(textBox2);
			Controls.Add(textBox7);
			Controls.Add(textBox8);
			Controls.Add(textBox9);
			Controls.Add(textBox10);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(textBox6);
			Controls.Add(label6);
			Controls.Add(textBox5);
			Controls.Add(label5);
			Controls.Add(textBox4);
			Controls.Add(label4);
			Controls.Add(textBox3);
			Controls.Add(label1);
			Controls.Add(linkLabel1);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(pictureBox1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "registrationForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "registrationForm";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private LinkLabel linkLabel1;
		private Button button1;
		private TextBox textBox1;
		private Label label3;
		private Label label2;
		private PictureBox pictureBox1;
		private Label label1;
		private TextBox textBox3;
		private TextBox textBox4;
		private Label label4;
		private TextBox textBox5;
		private Label label5;
		private TextBox textBox6;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private TextBox textBox2;
		private TextBox textBox7;
		private TextBox textBox8;
		private TextBox textBox9;
		private TextBox textBox10;
	}
}