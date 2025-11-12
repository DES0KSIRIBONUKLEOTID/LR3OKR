using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
namespace LW3_OKR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //mongoService = new MongoService();
            //LoadData();
        }
        //void LoadData()
        //{
        //    var client = new MongoClient("mongodb+srv://<ivandmytruk42_db_user>:<xd7NiRFVNU2atx5e>@formia.awxcqul.mongodb.net/?appName=ForMiA");
        //    var database = client.GetDatabase("LW3_OKR");
        //    var collection = database.GetCollection<Orders>("Orders");
        //    var orders = collection.Find(new BsonDocument()).ToList();
        //}

        private void VivePersonal_Click(object sender, EventArgs e)
        {
            FVivePersonal fVivePersonal = new FVivePersonal();
            fVivePersonal.ShowDialog();
            //LoadData();
        }
        // 5
        public class Client
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public Client(int id, string name, string phone, string email)
            {
                Id = id;
                Name = name;
                Phone = phone;
                Email = email;
            }

            public override string ToString()
            {
                return $"{Name} ({Phone})";
            }
        }
        public class Income
        {
            public DateTime Date { get; set; }
            public string Description { get; set; }
            public decimal Amount { get; set; }

            public Income(DateTime date, string description, decimal amount)
            {
                Date = date;
                Description = description;
                Amount = amount;
            }

            public override string ToString()
            {
                return $"{Date.ToShortDateString()} Ч {Description}: +{Amount} грн";
            }
        }

        public class Expense
        {
            public DateTime Date { get; set; }
            public string Category { get; set; }
            public decimal Amount { get; set; }

            public Expense(DateTime date, string category, decimal amount)
            {
                Date = date;
                Category = category;
                Amount = amount;
            }

            public override string ToString()
            {
                return $"{Date.ToShortDateString()} Ч {Category}: -{Amount} грн";
            }
        }

        public class Restaurant
        {
            public string Name { get; set; }
            public string Address { get; set; }
            private List<Personal> Employees { get; set; }
            private List<Income> Incomes { get; set; }
            private List<Expense> Expenses { get; set; }

            public Restaurant(string name, string address)
            {
                Name = name;
                Address = address;
                Employees = new List<Personal>();
                Incomes = new List<Income>();
                Expenses = new List<Expense>();
            }

            public void AddEmployee(Personal e) => Employees.Add(e);
            public void AddIncome(Income i) => Incomes.Add(i);
            public void AddExpense(Expense e) => Expenses.Add(e);

            public decimal GetTotalIncome() => Incomes.Sum(i => i.Amount);
            public decimal GetTotalExpense() => Expenses.Sum(e => e.Amount);
            public decimal GetProfit() => GetTotalIncome() - GetTotalExpense();

            public override string ToString()
            {
                return $"–есторан: {Name}, адреса: {Address}, " +
                       $"прац≥вник≥в: {Employees.Count}, " +
                       $"прибуток: {GetProfit()} грн";
            }
        }

        public class RestaurantNetwork
        {
            public string NetworkName { get; set; }
            public List<Restaurant> Restaurants { get; set; }

            public RestaurantNetwork(string networkName)
            {
                NetworkName = networkName;
                Restaurants = new List<Restaurant>();
            }

            public void AddRestaurant(Restaurant r) => Restaurants.Add(r);

            public decimal GetTotalProfit()
            {
                return Restaurants.Sum(r => r.GetProfit());
            }

            public override string ToString()
            {
                return $"ћережа ресторан≥в \"{NetworkName}\", ф≥л≥й: {Restaurants.Count}, " +
                       $"загальний прибуток: {GetTotalProfit()} грн";
            }
        }
    }
}