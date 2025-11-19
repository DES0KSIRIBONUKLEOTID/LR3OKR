using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LW3_OKR.Models
{
    public class Orders
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Number")]
        public string Number { get; set; }

        [BsonElement("Date")]
        public DateTime Date { get; set; }

        [BsonElement("PersonalId")]
        public string PersonalId { get; set; }

        [BsonElement("Sum")]
        public decimal Sum { get; set; }

        [BsonElement("Tip")]
        public decimal Tip { get; set; }

        [BsonElement("Items")]
        public List<GoodsInOrder> Items { get; set; }

        [BsonElement("FormattedText")]
        public string FormattedText { get; set; }

        public Orders()
        {
            Number = "";
            Date = DateTime.Now;
            PersonalId = "";
            Sum = 0;
            Tip = 0;
            Items = new List<GoodsInOrder>();
        }

        public Orders(string number, DateTime date, string personalId)
        {
            Number = number;
            Date = date;
            PersonalId = personalId;
            Sum = 0;
            Tip = 0;
            Items = new List<GoodsInOrder>();
        }
    }

    public class GoodsInOrder
    {
        public string Name { get; set; }
        public int Quantity { get; set; } // або Price, якщо Quantity = ціна
   
    }
}
