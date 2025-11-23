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
            textBoxSum = new TextBox();
            textBoxDate = new TextBox();
            label2 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            buttonFind = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(365, 153);
            label1.Name = "label1";
            label1.Size = new Size(273, 25);
            label1.TabIndex = 0;
            label1.Text = "Загальна сума замовлень";
            // 
            // textBoxSum
            // 
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(366, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 27);
            textBox1.TabIndex = 1;
            // 
            // textBoxDate
            // 
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(365, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Bauhaus 93", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(365, 63);
            label2.Name = "label2";
            label2.Size = new Size(428, 29);
            label2.TabIndex = 3;
            label2.Text = "Введіть дату вашого замовлення";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Vladimir Script", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(270, 32);
            label3.TabIndex = 5;
            label3.Text = "Історія замовлень";
            // 
            // listView1
            // 
            listView1.Location = new Point(8, 79);
            listView1.Margin = new Padding(4, 4, 4, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(340, 330);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonFind
            // 
            buttonFind.BackColor = Color.Cyan;
            buttonFind.Location = new Point(612, 401);
            buttonFind.Margin = new Padding(4, 4, 4, 4);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(195, 64);
            buttonFind.TabIndex = 7;
            buttonFind.Text = "Знайти замовлення за датою";
            buttonFind.UseVisualStyleBackColor = false;
            buttonFind.Click += buttonFind_Click;
            // 
            // ViewHistoryOrders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(653, 450);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxSum);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ViewHistoryOrders";
            Text = "ViewHistoryOrders";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxSum;
        private TextBox textBoxDate;
        private Label label2;
        private Label label3;
        private ListView listView1;
        private Button buttonFind;
    }
}