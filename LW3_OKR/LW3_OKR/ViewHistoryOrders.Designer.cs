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
            label1.Location = new Point(292, 122);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 21);
            label1.TabIndex = 0;
            label1.Text = "Загальна сума замовлень";
            // 
            // textBoxSum
            // 
            textBoxSum.BackColor = Color.White;
            textBoxSum.ForeColor = Color.Red;
            textBoxSum.Location = new Point(293, 149);
            textBoxSum.Margin = new Padding(2);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.Size = new Size(98, 27);
            textBoxSum.TabIndex = 1;
            // 
            // textBoxDate
            // 
            textBoxDate.BackColor = Color.White;
            textBoxDate.ForeColor = Color.Red;
            textBoxDate.Location = new Point(292, 75);
            textBoxDate.Margin = new Padding(2);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(123, 27);
            textBoxDate.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Bauhaus 93", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(292, 50);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(275, 23);
            label2.TabIndex = 3;
            label2.Text = "Введіть дату вашого замовлення";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Vladimir Script", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(5, 18);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(209, 28);
            label3.TabIndex = 5;
            label3.Text = "Історія замовлень";
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 63);
            listView1.Name = "listView1";
            listView1.Size = new Size(273, 265);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonFind
            // 
            buttonFind.BackColor = Color.White;
            buttonFind.Location = new Point(293, 289);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(156, 39);
            buttonFind.TabIndex = 7;
            buttonFind.Text = "Знайти за датою";
            buttonFind.UseVisualStyleBackColor = false;
            buttonFind.Click += buttonFind_Click;
            buttonFind.MouseEnter += buttonFind_MouseEnter;
            buttonFind.MouseLeave += buttonFind_MouseLeave;
            // 
            // ViewHistoryOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(522, 360);
            Controls.Add(buttonFind);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxSum);
            Controls.Add(label1);
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