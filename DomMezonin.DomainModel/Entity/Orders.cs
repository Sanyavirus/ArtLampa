using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomMezonin.DomainModel.Entity
{
    public class Orders  :  EntityBase
    {
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderPayDate { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public bool IsOrderPayed { get; set; }
        public PayMethod PayMethod { get; set; }
        public decimal TotalAmount { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string PostIndex { get; set; }
        
    }
}
