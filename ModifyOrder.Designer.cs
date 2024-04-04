namespace DBProject
{
    partial class ModifyOrder
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
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
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
            button5.Location = new Point(371, 290);
            button5.Name = "button5";
            button5.Size = new Size(152, 46);
            button5.TabIndex = 16;
            button5.Text = "Add to Cart";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(34, 385);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Previous";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(240, 385);
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
            // ModifyOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 118, 225);
            ClientSize = new Size(1004, 538);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModifyOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModigyOrder";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button5;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private Button button4;
    }
}