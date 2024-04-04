namespace DBProject
{
	partial class CartPage
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
			dataGridView1 = new DataGridView();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(154, 110);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(477, 152);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.ActiveCaption;
			button1.FlatStyle = FlatStyle.Popup;
			button1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(464, 299);
			button1.Name = "button1";
			button1.Size = new Size(167, 34);
			button1.TabIndex = 1;
			button1.Text = "Checkout";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// CartPage
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Name = "CartPage";
			Text = "CartPage";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
		private Button button1;
	}
}