namespace LW3_OKR
{
    partial class OrderForm
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
            listBoxItems = new ListBox();
            label1 = new Label();
            lblItemsSum = new Label();
            lblTips = new Label();
            lblTotal = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBoxItems
            // 
            listBoxItems.FormattingEnabled = true;
            listBoxItems.Location = new Point(12, 53);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(416, 224);
            listBoxItems.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 20);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 1;
            label1.Text = "Поточне замовлення";
            // 
            // lblItemsSum
            // 
            lblItemsSum.AutoSize = true;
            lblItemsSum.Location = new Point(19, 282);
            lblItemsSum.Name = "lblItemsSum";
            lblItemsSum.Size = new Size(50, 20);
            lblItemsSum.TabIndex = 2;
            lblItemsSum.Text = "label2";
            // 
            // lblTips
            // 
            lblTips.AutoSize = true;
            lblTips.Location = new Point(19, 311);
            lblTips.Name = "lblTips";
            lblTips.Size = new Size(50, 20);
            lblTips.TabIndex = 3;
            lblTips.Text = "label3";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(19, 341);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "label4";
            // 
            // button1
            // 
            button1.Location = new Point(12, 400);
            button1.Name = "button1";
            button1.Size = new Size(187, 38);
            button1.TabIndex = 5;
            button1.Text = "Скасувати замовлення";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(241, 400);
            button2.Name = "button2";
            button2.Size = new Size(187, 38);
            button2.TabIndex = 6;
            button2.Text = "Закрити";
            button2.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblTotal);
            Controls.Add(lblTips);
            Controls.Add(lblItemsSum);
            Controls.Add(label1);
            Controls.Add(listBoxItems);
            Name = "OrderForm";
            Text = "OrderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxItems;
        private Label label1;
        private Label lblItemsSum;
        private Label lblTips;
        private Label lblTotal;
        private Button button1;
        private Button button2;
    }
}