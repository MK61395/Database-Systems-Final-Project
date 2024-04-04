namespace DBProject
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			pictureBox1 = new PictureBox();
			label2 = new Label();
			label3 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			button1 = new Button();
			linkLabel1 = new LinkLabel();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(62, 111);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(223, 159);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(355, 155);
			label2.Name = "label2";
			label2.Size = new Size(120, 27);
			label2.TabIndex = 3;
			label2.Text = "Username";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(355, 206);
			label3.Name = "label3";
			label3.Size = new Size(114, 27);
			label3.TabIndex = 4;
			label3.Text = "Password";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(491, 155);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(207, 27);
			textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(491, 209);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(207, 27);
			textBox2.TabIndex = 2;
			textBox2.UseSystemPasswordChar = true;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// button1
			// 
			button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			button1.Location = new Point(320, 317);
			button1.Name = "button1";
			button1.Size = new Size(139, 46);
			button1.TabIndex = 3;
			button1.Text = "LOGIN";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.LinkColor = Color.Teal;
			linkLabel1.Location = new Point(22, 411);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(173, 20);
			linkLabel1.TabIndex = 4;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "New User? Register Here";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightGray;
			ClientSize = new Size(800, 450);
			Controls.Add(linkLabel1);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(pictureBox1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label2;
		private Label label3;
		private TextBox textBox1;
		private TextBox textBox2;
		private Button button1;
		private LinkLabel linkLabel1;
	}
}