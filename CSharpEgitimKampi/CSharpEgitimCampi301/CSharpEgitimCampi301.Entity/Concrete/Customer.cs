using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimCampi301.Entity.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public bool Status { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public List<Order> Orders { get; set; }
    }
}
