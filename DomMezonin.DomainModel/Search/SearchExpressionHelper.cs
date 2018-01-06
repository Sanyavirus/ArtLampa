using DomMezonin.DomainModel.Entity;
using System;
using System.Linq.Expressions;

namespace DomMezonin.DomainModel.Search
{
    public class SearchExpressionHelper
    {
        public Expression<Func<Product, bool>> GenerateProductExpressionQuery(ProductSearchParameters psp)
        {
            Expression<Func<Product, bool>> result = null;
            Func<Product, bool> temp = null;

            if (psp.dateFrom != null)
            {
                result = p => p.DateAdd >= psp.dateFrom;
            }

            if (psp.dateTo != null)
            {
                temp = p => temp(p) || p.DateAdd <= psp.dateTo; 
            }

            return result;
        }




    }
}
