using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    public class Product
    {
        public int product_id { get; set; } = 0;
        public int quantity { get; set; } = 0;
        public int price { get; set; } = 0;
        public string name { get; set; } = "";
        public string category { get; set; } = "";
        public string manufacturer { get; set; } = "";

        public override string ToString()
        {
            return this.name;
        }
    }
}
