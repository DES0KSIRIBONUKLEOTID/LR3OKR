using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;

namespace LW3_OKR
{
    public partial class OrderForm : Form
    {
        private Form1.Order order;

        public bool OrderCancelled { get; private set; } = false;

        public OrderForm(Form1.Order order)
        {
            InitializeComponent();
            this.order = order;
            LoadOrder();
        }

        private void LoadOrder()
        {
            listBoxItems.Items.Clear();

            foreach (var item in order.Items)
            {
                listBoxItems.Items.Add($"{item.Name} — {item.Quantity} грн");
            }

            lblItemsSum.Text = $"Сума страв: {order.GetItemsSum()} грн";
            lblTips.Text = $"Чайові: {order.Tips} грн";
            lblTotal.Text = $"Разом: {order.GetTotal()} грн";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Скасувати це замовлення?", "Підтвердження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                OrderCancelled = true;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveOrderToDB()
        {
            var client = new MongoClient("mongodb+srv://ivandmytruk42_db_user:lwokr123@db.rdcvntl.mongodb.net/?appName=DB");
            var db = client.GetDatabase("LW3_OKR_DB");
            var ordersCollection = db.GetCollection<Orders>("Orders");

            var newOrder = new Orders();
            newOrder.Number = Guid.NewGuid().ToString().Substring(0, 8); // Генерація номера
            newOrder.PersonalId = "Admin"; // тимчасово
            newOrder.Sum = order.GetItemsSum();
            newOrder.Tip = order.Tips;
            newOrder.Date = DateTime.Now;

            // Додаємо товари з замовлення:
            newOrder.Items = order.Items.Select(i => new GoodsInOrder
            {
                Name = i.Name,
                Quantity = i.Quantity ?? 0
            }).ToList();

            ordersCollection.InsertOne(newOrder);
            MessageBox.Show("Замовлення збережено у базу!");
        }

    }
}
