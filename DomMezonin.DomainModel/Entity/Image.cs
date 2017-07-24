using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomMezonin.DomainModel.Entity
{
    public class Image : EntityBase
    {
        public string Path { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
