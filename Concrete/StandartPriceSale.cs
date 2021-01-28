using Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Concrete
{
    class StandartPriceSale : SaleService
    {
        public StandartPriceSale(int initialDiscountRate = 0)
        {
            DiscountRate = initialDiscountRate;
        }
    }
}
