namespace DBProject
{
	partial class Menu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
			panel1 = new Panel();
			button4 = new Button();
			panel2 = new Panel();
			textBox1 = new TextBox();
			pictureBox1 = new PictureBox();
			button5 = new Button();
			dataGridView1 = new DataGridView();
			label2 = new Label();
			comboBox1 = new ComboBox();
			button1 = new Button();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(button1);
			panel1.Controls.Add(button4);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(200, 514);
			panel1.TabIndex = 0;
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
			// panel2
			// 
			panel2.BackColor = Color.LightGray;
			panel2.Controls.Add(textBox1);
			panel2.Controls.Add(pictureBox1);
			panel2.Controls.Add(button5);
			panel2.Controls.Add(dataGridView1);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(comboBox1);
			panel2.Location = new Point(211, 12);
			panel2.Name = "panel2";
			panel2.Size = new Size(781, 514);
			panel2.TabIndex = 1;
			panel2.Paint += panel2_Paint;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(419, 234);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(152, 27);
			textBox1.TabIndex = 3;
			textBox1.TextChanged += textBox1_TextChanged_2;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(695, 20);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(58, 39);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 17;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// button5
			// 
			button5.BackColor = Color.FromArgb(0, 118, 225);
			button5.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			button5.ForeColor = Color.White;
			button5.Location = new Point(419, 290);
			button5.Name = "button5";
			button5.Size = new Size(152, 46);
			button5.TabIndex = 4;
			button5.Text = "Add to Cart";
			button5.UseVisualStyleBackColor = false;
			button5.Click += button5_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(34, 148);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(326, 188);
			dataGridView1.TabIndex = 2;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(34, 80);
			label2.Name = "label2";
			label2.Size = new Size(80, 20);
			label2.TabIndex = 3;
			label2.Text = "Categories";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(120, 77);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(151, 28);
			comboBox1.TabIndex = 1;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// button1
			// 
			button1.Location = new Point(32, 370);
			button1.Name = "button1";
			button1.Size = new Size(139, 37);
			button1.TabIndex = 16;
			button1.Text = "Feedback";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Menu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(0, 118, 225);
			ClientSize = new Size(1004, 538);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Menu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Menu";
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private DataGridView dataGridView1;
		private Label label2;
		private ComboBox comboBox1;
		private Button button4;
		private Button button5;
		private PictureBox pictureBox1;
		private TextBox textBox1;
		private Button button1;
	}
}