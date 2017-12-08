using DomMezonin.DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomMezonin.DomainModel.Search
{
    public class ProductSearchParameters : SearchParameters
    {
        public List<long> VendorsIds { get; set; }
        public List<string> Sizes { get; set; }
        public List<string> Colors { get;set;}
        public List<long> CategoriesIds { get; set; }

    }
}
