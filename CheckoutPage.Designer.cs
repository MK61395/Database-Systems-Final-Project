namespace DBProject
{
	partial class CheckoutPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutPage));
			label1 = new Label();
			textBox1 = new TextBox();
			Checkout = new Button();
			label3 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ImageAlign = ContentAlignment.TopCenter;
			label1.Location = new Point(283, 119);
			label1.Name = "label1";
			label1.Size = new Size(81, 28);
			label1.TabIndex = 0;
			label1.Text = "label1";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.Click += label1_Click;
			// 
			// textBox1
			// 
			textBox1.AccessibleDescription = "Enter payment information....";
			textBox1.Location = new Point(261, 211);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(254, 27);
			textBox1.TabIndex = 1;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// Checkout
			// 
			Checkout.FlatStyle = FlatStyle.Popup;
			Checkout.Image = (Image)resources.GetObject("Checkout.Image");
			Checkout.Location = new Point(300, 286);
			Checkout.Name = "Checkout";
			Checkout.Size = new Size(175, 46);
			Checkout.TabIndex = 2;
			Checkout.Text = "Complete Order";
			Checkout.TextImageRelation = TextImageRelation.ImageBeforeText;
			Checkout.UseVisualStyleBackColor = true;
			Checkout.Click += button1_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(64, 214);
			label3.Name = "label3";
			label3.Size = new Size(183, 20);
			label3.TabIndex = 4;
			label3.Text = "Card Details (IF NOT COD)";
			label3.Click += label3_Click;
			// 
			// CheckoutPage
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label3);
			Controls.Add(Checkout);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "CheckoutPage";
			Text = "CheckoutPage";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Button Checkout;
		private Label label3;
	}
}