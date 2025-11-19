using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3_OKR.Models
{
    public class Goods
    {
        public string Id { get; set; }
        public string? Type { get; set; }
        public string? Name { get; set; }
        public int? Quantity { get; set; }
        public Goods()
        {
            Type = "";
            Name = "";
            Quantity = 0;
        }
        public Goods(string type, string name, int quantity)
        {
            Type = type;
            Name = name;
            Quantity = quantity;
        }
    }
    public class Sets
    {
        public string? Id { get; set; }
        public string? SetName { get; set; }
        public List<string> GoodsIds { get; set; }
        public Sets()
        {
            SetName = "";
            GoodsIds = new List<string>();
        }
        public Sets(string setName, List<string> goodsIds)
        {
            SetName = setName;
            GoodsIds = goodsIds;
        }
    }
}
