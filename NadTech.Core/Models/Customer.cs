using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadTech.Core.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public DateTime Age { get; set; }
        public Gender Gender { get; set; }
        public List<Address> Address { get; set; }
        public List<Order> Orders { get; set; }
    }
}
