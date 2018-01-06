 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomMezonin.DomainModel.Entity
{
    public class OrderDetails
    {
        public Product Product { get; set; }
        public int Count { get; set; }
        public decimal Amount { get; set; }
    }
}
