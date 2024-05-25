using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    public class Client
    {
        public int client_id { get; set; } = 0;
        public string name { get; set; } = "";

        public Client(int id, string name)
        {
            this.client_id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
