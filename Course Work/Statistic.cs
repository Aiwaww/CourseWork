using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    public class Statistic
    {
        public string date { get; set; } = "";

        public string product_name { get; set; } = "";

        public string product_category { get; set; } = "";

        public string product_manufacturer { get; set; } = "";

        public int product_id { get; set; } = 0;

        public int total_quantity { get; set; } = 0;

        public int total_revenue { get; set; } = 0;

        public int total_orders { get; set; } = 0;
    }
}
