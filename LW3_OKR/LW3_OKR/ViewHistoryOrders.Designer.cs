namespace LW3_OKR
{
    partial class ViewHistoryOrders
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(475, 153);
            label1.Name = "label1";
            label1.Size = new Size(226, 21);
            label1.TabIndex = 0;
            label1.Text = "Загальна сума замовлень";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(476, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(475, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Cyan;
            label2.Font = new Font("Bauhaus 93", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InactiveCaptionText;
            label2.Location = new Point(475, 63);
            label2.Name = "label2";
            label2.Size = new Size(275, 23);
            label2.TabIndex = 3;
            label2.Text = "Введіть дату вашого замовлення";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 192);
            label3.Font = new Font("Vladimir Script", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(12, 20);
            label3.Name = "label3";
            label3.Size = new Size(209, 28);
            label3.TabIndex = 5;
            label3.Text = "Історія замовлень";
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 63);
            listView1.Name = "listView1";
            listView1.Size = new Size(463, 330);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ViewHistoryOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.FonHistory;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ViewHistoryOrders";
            Text = "ViewHistoryOrders";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private ListView listView1;
    }
}