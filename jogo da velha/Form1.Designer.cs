namespace jogo_da_velha
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button10 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(25, 12);
            button1.Name = "button1";
            button1.Size = new Size(114, 143);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(171, 12);
            button2.Name = "button2";
            button2.Size = new Size(114, 143);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(311, 12);
            button3.Name = "button3";
            button3.Size = new Size(114, 143);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(25, 201);
            button4.Name = "button4";
            button4.Size = new Size(114, 143);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Location = new Point(171, 201);
            button5.Name = "button5";
            button5.Size = new Size(114, 143);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Location = new Point(311, 201);
            button6.Name = "button6";
            button6.Size = new Size(114, 143);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Location = new Point(311, 402);
            button9.Name = "button9";
            button9.Size = new Size(114, 143);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Location = new Point(171, 402);
            button8.Name = "button8";
            button8.Size = new Size(114, 143);
            button8.TabIndex = 9;
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Location = new Point(25, 402);
            button7.Name = "button7";
            button7.Size = new Size(114, 143);
            button7.TabIndex = 10;
            button7.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(192, 255, 255);
            button10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(185, 551);
            button10.Name = "button10";
            button10.Size = new Size(32, 30);
            button10.TabIndex = 11;
            button10.Text = "X";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(192, 192, 255);
            button13.Location = new Point(155, 442);
            button13.Name = "button13";
            button13.Size = new Size(141, 40);
            button13.TabIndex = 14;
            button13.Text = "INICIAR";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click_1;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(192, 255, 255);
            button12.Font = new Font("Times New Roman", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button12.Location = new Point(-16, -5);
            button12.Name = "button12";
            button12.Size = new Size(482, 616);
            button12.TabIndex = 13;
            button12.Text = "JOGO DA VELHA";
            button12.TextImageRelation = TextImageRelation.ImageBeforeText;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(192, 255, 255);
            button11.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button11.Location = new Point(239, 551);
            button11.Name = "button11";
            button11.Size = new Size(32, 30);
            button11.TabIndex = 12;
            button11.Text = "O\r\n";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(451, 604);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button10;
        private Button button13;
        private Button button12;
        private Button button11;
    }
}
