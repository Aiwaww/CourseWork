using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    public class Order
    {
        public int order_id { get; set; } = 0;

        public int product_id { get; set; } = 0;

        public int client_id { get; set; } = 0;

        public int quantity { get; set; } = 0;

        public double total { get; set; } = 0;

        public string status { get; set; } = "";

        public string product_name { get; set; } = "";

        public string product_category { get; set; } = "";

        public string product_manufacturer { get; set; } = "";

        public string client_name { get; set; } = "";

        public string created { get; set; } = "";

        public string updated { get; set; } = "";
    }
}
