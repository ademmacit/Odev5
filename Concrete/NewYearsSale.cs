using Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Concrete
{
    class NewYearsSale : SaleService
    {
        public NewYearsSale (int initialDiscountRate = 10)
        {
            DiscountRate = initialDiscountRate;
        }
    }
}
