namespace LW3_OKR
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(179, 14);
            label1.Name = "label1";
            label1.Size = new Size(157, 41);
            label1.TabIndex = 0;
            label1.Text = "СУШІХПК";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(3, 65);
            button1.Name = "button1";
            button1.Size = new Size(73, 59);
            button1.TabIndex = 1;
            button1.Text = "Суші";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 130);
            button2.Name = "button2";
            button2.Size = new Size(73, 59);
            button2.TabIndex = 2;
            button2.Text = "Сети";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 195);
            button3.Name = "button3";
            button3.Size = new Size(73, 59);
            button3.TabIndex = 3;
            button3.Text = "Роли";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 260);
            button4.Name = "button4";
            button4.Size = new Size(73, 59);
            button4.TabIndex = 4;
            button4.Text = "Напої";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(82, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(884, 434);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(98, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 68);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(708, 18);
            button5.Name = "button5";
            button5.Size = new Size(119, 46);
            button5.TabIndex = 7;
            button5.Text = "Персонал";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(833, 18);
            button6.Name = "button6";
            button6.Size = new Size(119, 46);
            button6.TabIndex = 8;
            button6.Text = "Call-центр";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 514);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button5;
        private Button button6;
    }
}
