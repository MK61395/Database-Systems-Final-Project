namespace DBProject
{
    partial class LoyaltyProgram
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
            textBox1 = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(listBox2);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(213, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(781, 514);
            panel2.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 118, 225);
            button5.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(291, 405);
            button5.Name = "button5";
            button5.Size = new Size(152, 46);
            button5.TabIndex = 16;
            button5.Text = "Redeem";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button4);
            panel1.Location = new Point(14, 12);
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
            // textBox1
            // 
            textBox1.Location = new Point(304, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 20;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 44);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 19;
            label1.Text = "Loyalty Points";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(80, 216);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 21;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(502, 216);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 104);
            listBox2.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 167);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 23;
            label2.Text = "Reward Options";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(524, 167);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 24;
            label3.Text = "Points History";
            // 
            // LoyaltyProgram
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 118, 225);
            ClientSize = new Size(1008, 538);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoyaltyProgram";
            Text = "LoyaltyProgram";
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
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private ListBox listBox2;
        private ListBox listBox1;
    }
}