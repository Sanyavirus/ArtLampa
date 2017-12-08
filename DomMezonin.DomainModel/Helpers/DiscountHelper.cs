using DomMezonin.DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomMezonin.DomainModel.Helpers
{
    public class DiscountHelper
    {
        public static decimal AcceptDiscount(Product product)
        {
            if (product.Discount != null)
            {
                return product.Price * product.Discount.PriceFactor;
            }

            return product.Price;
        }
    }
}
