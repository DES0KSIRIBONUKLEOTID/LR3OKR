using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;

namespace LW3_OKR
{
    public partial class ViewHistoryOrders : Form
    {
        private IMongoCollection<Orders> ordersCollection;

        public ViewHistoryOrders()
        {
            InitializeComponent();

            var client = new MongoClient("mongodb+srv://ivandmytruk42_db_user:lwokr123@db.rdcvntl.mongodb.net/?appName=DB"); // або твій рядок підключення
            var database = client.GetDatabase("LW3_OKR_DB");         // заміни на свою БД
            ordersCollection = database.GetCollection<Orders>("Orders");

            SetupListView();
        }
        private void buttonFind_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            if (button != null)
            {
                button.BackColor = Color.LightBlue;
            }
            if (button == find)
            {
                button.Text = "🔍";
            }
        }

        private void buttonFind_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            if (button != null)
            {
                button.BackColor = Color.LightBlue;
            }
            if (button == find)
            {
                button.Text = "Знайти за датою";
            }
        }
        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Номер", 80);
            listView1.Columns.Add("Дата", 120);
            listView1.Columns.Add("Сума", 80);
            listView1.Columns.Add("Чайові", 80);
            listView1.Columns.Add("Страви", 300);
        }

        private async void buttonFind_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(textBoxDate.Text, out DateTime selectedDate))
            {
                MessageBox.Show("Невірний формат дати! Введіть у форматі: рррр-мм-дд");
                return;
            }

            DateTime startDate = selectedDate.Date;
            DateTime endDate = selectedDate.Date.AddDays(1).AddTicks(-1);

            var filter = Builders<Orders>.Filter.And(
                Builders<Orders>.Filter.Gte(o => o.Date, startDate),
                Builders<Orders>.Filter.Lte(o => o.Date, endDate)
            );

            var orders = await ordersCollection.Find(filter).ToListAsync();

            listView1.Items.Clear();
            decimal totalSum = 0;

            foreach (var order in orders)
            {
                string itemsText = string.Join(", ", order.Items.Select(i => $"{i.Name} x{i.Quantity}"));

                ListViewItem item = new ListViewItem(order.Number);
                item.SubItems.Add(order.Date.ToString("yyyy-MM-dd"));
                item.SubItems.Add(order.Sum.ToString("0.00"));
                item.SubItems.Add(order.Tip.ToString("0.00"));
                item.SubItems.Add(itemsText);

                listView1.Items.Add(item);

                totalSum += order.Sum + order.Tip;
            }

            textBoxSum.Text = totalSum.ToString("0.00");

            if (orders.Count == 0)
            {
                MessageBox.Show("Замовлень за цією датою не знайдено.");
            }
        }
    }
}
