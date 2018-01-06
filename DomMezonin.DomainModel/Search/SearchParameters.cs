using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomMezonin.DomainModel.Search
{
    public class SearchParameters
    {
        public DateTime dateFrom { get; set; }
        public DateTime dateTo { get; set; }
        public string Name { get; set; }

    }
}
