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
            btnConfirmOrder = new Button();
            label2 = new Label();
            txtTips = new TextBox();
            SuspendLayout();
            // 
            // listBoxItems
            // 
            listBoxItems.FormattingEnabled = true;
            listBoxItems.ItemHeight = 25;
            listBoxItems.Location = new Point(15, 66);
            listBoxItems.Margin = new Padding(4);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(519, 229);
            listBoxItems.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 1;
            label1.Text = "Поточне замовлення";
            // 
            // lblItemsSum
            // 
            lblItemsSum.AutoSize = true;
            lblItemsSum.Location = new Point(15, 299);
            lblItemsSum.Margin = new Padding(4, 0, 4, 0);
            lblItemsSum.Name = "lblItemsSum";
            lblItemsSum.Size = new Size(59, 25);
            lblItemsSum.TabIndex = 2;
            lblItemsSum.Text = "label2";
            // 
            // lblTips
            // 
            lblTips.AutoSize = true;
            lblTips.Location = new Point(15, 336);
            lblTips.Margin = new Padding(4, 0, 4, 0);
            lblTips.Name = "lblTips";
            lblTips.Size = new Size(59, 25);
            lblTips.TabIndex = 3;
            lblTips.Text = "label3";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(15, 373);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 25);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "label4";
            // 
            // button1
            // 
            button1.Location = new Point(15, 500);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(234, 48);
            button1.TabIndex = 5;
            button1.Text = "Скасувати замовлення";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Location = new Point(301, 500);
            btnConfirmOrder.Margin = new Padding(4);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(234, 48);
            btnConfirmOrder.TabIndex = 6;
            btnConfirmOrder.Text = "Підтвердити замовлення";
            btnConfirmOrder.UseVisualStyleBackColor = true;
            btnConfirmOrder.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 299);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 7;
            label2.Text = "Введіть чайові:";
            // 
            // txtTips
            // 
            txtTips.Location = new Point(378, 336);
            txtTips.Name = "txtTips";
            txtTips.Size = new Size(144, 31);
            txtTips.TabIndex = 8;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_12_лист__2025_р___09_39_43;
            ClientSize = new Size(550, 562);
            Controls.Add(txtTips);
            Controls.Add(label2);
            Controls.Add(btnConfirmOrder);
            Controls.Add(button1);
            Controls.Add(lblTotal);
            Controls.Add(lblTips);
            Controls.Add(lblItemsSum);
            Controls.Add(label1);
            Controls.Add(listBoxItems);
            Margin = new Padding(4);
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
        private Button btnConfirmOrder;
        private Label label2;
        private TextBox txtTips;
    }
}