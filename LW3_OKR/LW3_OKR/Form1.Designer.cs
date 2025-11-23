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
            VivePersonal = new Button();
            flowGoods = new FlowLayoutPanel();
            button5 = new Button();
            buttonViveHist = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(160, 18);
            label1.Name = "label1";
            label1.Size = new Size(157, 41);
            label1.TabIndex = 0;
            label1.Text = "СУШІХПК";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(3, 79);
            button1.Name = "button1";
            button1.Size = new Size(73, 59);
            button1.TabIndex = 1;
            button1.Text = "Суші";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // button2
            // 
            button2.Location = new Point(3, 209);
            button2.Name = "button2";
            button2.Size = new Size(73, 59);
            button2.TabIndex = 2;
            button2.Text = "Сети";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseEnter += button1_MouseEnter;
            button2.MouseLeave += button1_MouseLeave;
            // 
            // button3
            // 
            button3.Location = new Point(3, 144);
            button3.Name = "button3";
            button3.Size = new Size(73, 59);
            button3.TabIndex = 3;
            button3.Text = "Роли";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button3.MouseEnter += button1_MouseEnter;
            button3.MouseLeave += button1_MouseLeave;
            // 
            // button4
            // 
            button4.Location = new Point(3, 274);
            button4.Name = "button4";
            button4.Size = new Size(73, 59);
            button4.TabIndex = 4;
            button4.Text = "Напої";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            button4.MouseEnter += button1_MouseEnter;
            button4.MouseLeave += button1_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_12_лист__2025_р___09_39_43;
            pictureBox1.Location = new Point(82, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(882, 434);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ChatGPT_Image_12_лист__2025_р___09_26_52;
            pictureBox2.InitialImage = Properties.Resources.ChatGPT_Image_12_лист__2025_р___09_26_52;
            pictureBox2.Location = new Point(82, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // VivePersonal
            // 
            VivePersonal.Location = new Point(845, 22);
            VivePersonal.Name = "VivePersonal";
            VivePersonal.Size = new Size(119, 46);
            VivePersonal.TabIndex = 7;
            VivePersonal.Text = "Персонал";
            VivePersonal.UseVisualStyleBackColor = true;
            VivePersonal.Click += VivePersonal_Click;
            VivePersonal.MouseEnter += button1_MouseEnter;
            VivePersonal.MouseLeave += button1_MouseLeave;
            // 
            // flowGoods
            // 
            flowGoods.BackgroundImage = Properties.Resources.ChatGPT_Image_12_лист__2025_р___09_39_43;
            flowGoods.BackgroundImageLayout = ImageLayout.Stretch;
            flowGoods.Location = new Point(82, 79);
            flowGoods.Name = "flowGoods";
            flowGoods.Size = new Size(882, 433);
            flowGoods.TabIndex = 9;
            // 
            // button5
            // 
            button5.Location = new Point(576, 22);
            button5.Name = "button5";
            button5.Size = new Size(263, 46);
            button5.TabIndex = 10;
            button5.Text = "Переглянути замовлення";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            button5.MouseEnter += button1_MouseEnter;
            button5.MouseLeave += button1_MouseLeave;
            // 
            // buttonViveHist
            // 
            buttonViveHist.Location = new Point(397, 22);
            buttonViveHist.Name = "buttonViveHist";
            buttonViveHist.Size = new Size(150, 46);
            buttonViveHist.TabIndex = 11;
            buttonViveHist.Text = "Історія замовлень";
            buttonViveHist.UseVisualStyleBackColor = true;
            buttonViveHist.Click += buttonViveHist_Click;
            buttonViveHist.MouseEnter += button1_MouseEnter;
            buttonViveHist.MouseLeave += button1_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(977, 535);
            Controls.Add(buttonViveHist);
            Controls.Add(button5);
            Controls.Add(flowGoods);
            Controls.Add(VivePersonal);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Меню";
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
        private Button VivePersonal;
        private FlowLayoutPanel flowGoods;
        private Button button5;
        private Button buttonViveHist;
    }
}
