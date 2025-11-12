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
            MongoServerAddress serverAddress = new MongoServerAddress("localhost", 27017);
            LoadData();
        }
        void LoadData()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("LW3_OKR");
            var collection = database.GetCollection<Orders>("Orders");
            var orders = collection.Find(new BsonDocument()).ToList();
        }

        private void VivePersonal_Click(object sender, EventArgs e)
        {
            FVivePersonal fVivePersonal = new FVivePersonal();
            fVivePersonal.ShowDialog();
            LoadData();
        }
    }
}
