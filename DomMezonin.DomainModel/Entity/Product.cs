using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomMezonin.DomainModel.Entity
{
    public class Product : EntityBaseNamed
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Image Image { get; set; }
        public Category Category { get; set; }
        public string Color { get; set; }
        public AdditionalProductParams Params { get; set; }
    }
}
