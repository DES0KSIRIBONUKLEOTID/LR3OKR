using System;
using System.Collections.Generic;


namespace LW3_OKR.Models
{
    public class Orders
    {

        public string Id { get; set; }

        public string Number { get; set; }

        public DateTime Date { get; set; }

        public string PersonalId { get; set; }

        public decimal Sum { get; set; }

        public decimal Tip { get; set; }

        public List<GoodsInOrder> Items { get; set; }

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
