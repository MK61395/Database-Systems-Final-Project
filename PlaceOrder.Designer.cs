namespace DBProject
{
    partial class PlaceOrder
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
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox2 = new GroupBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(211, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(781, 514);
            panel2.TabIndex = 3;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 118, 225);
            button5.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(186, 455);
            button5.Name = "button5";
            button5.Size = new Size(311, 46);
            button5.TabIndex = 16;
            button5.Text = "Proceed To Checkout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(34, 342);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Previous";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(240, 342);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button4);
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 514);
            panel1.TabIndex = 2;
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(388, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(34, 386);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 24);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Delivery";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(145, 386);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 24);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "Pickup";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(388, 285);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // PlaceOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 118, 225);
            ClientSize = new Size(1004, 538);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlaceOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlaceOrder";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button5;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private Button button4;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
    }
}