namespace DBProject
{
    partial class TrackOrder
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
            panel1 = new Panel();
            button4 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(211, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(781, 514);
            panel2.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 118, 225);
            button5.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(154, 372);
            button5.Name = "button5";
            button5.Size = new Size(173, 46);
            button5.TabIndex = 16;
            button5.Text = "Back to Menu";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 59);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 17;
            label1.Text = "Order Status";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(276, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 27);
            textBox2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 96);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 19;
            label2.Text = "Est. Delivery Time";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(217, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(382, 372);
            button1.Name = "button1";
            button1.Size = new Size(173, 46);
            button1.TabIndex = 22;
            button1.Text = "Cancel Order";
            button1.UseVisualStyleBackColor = false;
            // 
            // TrackOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 118, 225);
            ClientSize = new Size(1004, 538);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrackOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrackOrder";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button5;
        private Panel panel1;
        private Button button4;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
    }
}