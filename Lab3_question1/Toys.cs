using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_question1
{
    public class Toys
    {
        public string Item { get; set; }
        public double Price { get; set; }
        public Toys(string item, double price)
        {
            Item = item;
            Price = price;
        }
    }
}
