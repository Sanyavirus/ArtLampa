using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomMezonin.DomainModel.Entity
{
    public class Category : EntityBaseNamed
    {
        public string Description { get; set; }
        public Image Image { get; set; }
        public Category ParentCategory { get; set; }
        public List<Product> Products { get; set; }
    }
}
