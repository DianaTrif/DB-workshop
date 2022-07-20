using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_workshop
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Placed { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}

