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
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(594, 191);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(273, 25);
            label1.TabIndex = 0;
            label1.Text = "Загальна сума замовлень";
            // 
            // textBoxSum
            // 
            textBoxSum.BackColor = Color.White;
            textBoxSum.ForeColor = Color.Red;
            textBoxSum.Location = new Point(595, 232);
            textBoxSum.Margin = new Padding(4, 4, 4, 4);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.Size = new Size(152, 31);
            textBoxSum.TabIndex = 1;
            // 
            // textBoxDate
            // 
            textBoxDate.BackColor = Color.White;
            textBoxDate.ForeColor = Color.Red;
            textBoxDate.Location = new Point(594, 111);
            textBoxDate.Margin = new Padding(4, 4, 4, 4);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(190, 31);
            textBoxDate.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Cyan;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InactiveCaptionText;
            label2.Location = new Point(594, 79);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(428, 29);
            label2.TabIndex = 3;
            label2.Text = "Введіть дату вашого замовлення";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 192);
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(15, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
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
            listView1.Size = new Size(578, 412);
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
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.FonHistory;
            ClientSize = new Size(1000, 562);
            Controls.Add(buttonFind);
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