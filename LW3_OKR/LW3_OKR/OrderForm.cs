using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using System.Text; // Додано для StringBuilder

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

            // 💡 Прив'язка події для автоматичного оновлення суми
            txtTips.TextChanged += txtTips_TextChanged;

            LoadOrder();
        }

        private void LoadOrder()
        {
            listBoxItems.Items.Clear();

            foreach (var item in order.Items)
            {
                // Припускаючи, що Quantity - це сума за товар (грн)
                listBoxItems.Items.Add($"{item.Name} — {item.Quantity} грн");
            }

            // Оновлюємо відображення, використовуючи Ваші імена лейблів (якщо не перейменували)
            lblItemsSum.Text = $"Сума страв: {order.GetItemsSum()} грн";
            lblTips.Text = $"Чайові: {order.Tips} грн"; // Оновлено
            lblTotal.Text = $"Разом: {order.GetTotal()} грн"; // Оновлено

            // 💡 Ініціалізація поля вводу чайових
            txtTips.Text = order.Tips.ToString();
        }

        // 💡 НОВИЙ МЕТОД: Обробка вводу чайових
        private void txtTips_TextChanged(object sender, EventArgs e)
        {
            // Використовуємо 'decimal' для грошових сум
            if (decimal.TryParse(txtTips.Text, out decimal newTips) && newTips >= 0)
            {
                // Оновлюємо об'єкт замовлення
                this.order.Tips = newTips;
            }
            else if (string.IsNullOrEmpty(txtTips.Text))
            {
                // Якщо поле порожнє, встановлюємо чайові в 0
                this.order.Tips = 0;
            }
            // Інакше (некоректний ввід) - ігноруємо, залишаючи order.Tips як є.

            // Оновлюємо відображення загальної суми
            lblTips.Text = $"Чайові: {this.order.Tips} грн";
            lblTotal.Text = $"Разом: {this.order.GetTotal()} грн";
        }

        // button1_Click (Скасувати замовлення) - залишається без змін
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Скасувати це замовлення?", "Підтвердження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                OrderCancelled = true;
                this.Close();
            }
        }

        // 💡 ОНОВЛЕНИЙ МЕТОД: button2_Click (Підтвердити замовлення)
        private void button2_Click(object sender, EventArgs e)
        {
            // Валідація та оновлення чайових перед збереженням (хоча вони оновилися в TextChanged)
            if (!decimal.TryParse(txtTips.Text, out _) && !string.IsNullOrEmpty(txtTips.Text))
            {
                MessageBox.Show("Будь ласка, введіть коректну суму чайових.", "Помилка вводу",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTips.Focus();
                return;
            }

            // Збереження в базу даних
            SaveOrderToDB();

            // Закриваємо форму після успішного збереження
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SaveOrderToDB()
        {
            var client = new MongoClient("mongodb+srv://ivandmytruk42_db_user:lwokr123@db.rdcvntl.mongodb.net/?appName=DB");
            var db = client.GetDatabase("LW3_OKR_DB");
            var ordersCollection = db.GetCollection<Orders>("Orders");

            var newOrder = new Orders();
            newOrder.Number = Guid.NewGuid().ToString().Substring(0, 8);
            newOrder.PersonalId = "Admin";
            newOrder.Sum = order.GetItemsSum();
            newOrder.Tip = order.Tips; // Тут вже актуальні чайові з txtTips
            newOrder.Date = DateTime.Now;

            // ... (решта логіки збереження без змін)

            // Збереження товарів у структурованому вигляді
            newOrder.Items = order.Items.Select(i => new GoodsInOrder
            {
                Name = i.Name,
                // Важливо: перевірте, чи order.Items[i].Quantity — це ціна чи кількість. 
                // Якщо це ціна, то Convert.ToInt32(i.Quantity) може бути помилкою.
                // Я залишаю Ваш початковий код:
                Quantity = Convert.ToInt32(i.Quantity)
            }).ToList();

            // 🔹 Формування красивого тексту для MongoDB
            var sb = new StringBuilder(); // Використовуємо System.Text.StringBuilder
            foreach (var item in newOrder.Items)
            {
                sb.AppendLine($"{item.Name} — {item.Quantity} грн");
            }

            sb.AppendLine($"\nСума страв: {newOrder.Sum} грн");
            sb.AppendLine($"Чайові: {newOrder.Tip} грн");
            sb.AppendLine($"Разом: {newOrder.Sum + newOrder.Tip} грн");

            newOrder.FormattedText = sb.ToString();

            // Зберігаємо в MongoDB
            ordersCollection.InsertOne(newOrder);
            MessageBox.Show("Замовлення збережено у базу!");
        }

        // 💡 Допоміжні класи (якщо вони були у Вас у Form1.cs або окремо)
        // Вам потрібно переконатися, що ці класи доступні
        public class Orders
        {
            public string Number { get; set; }
            public string PersonalId { get; set; }
            public decimal Sum { get; set; }
            public decimal Tip { get; set; }
            public DateTime Date { get; set; }
            public List<GoodsInOrder> Items { get; set; }
            public string FormattedText { get; set; }
        }
        public class GoodsInOrder
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
        }

        private void btnConfirmOrder_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                button.BackColor = Color.LightBlue;
            }
            if (button == button1)
            {
                button.Text = "✖";
            }
            if (button == btnConfirmOrder)
            {
                button.Text = "✔";
            }
        }

        private void btnConfirmOrder_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = SystemColors.Control;
            }
            if (button == button1)
            {
                button.Text = "Скасувати замовлення";
            }
            if (button == btnConfirmOrder)
            {
                button.Text = "Підтвердити замовлення";
            }
        }
    }
}