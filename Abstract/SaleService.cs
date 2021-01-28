using Odev5.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Abstract
{
    abstract class SaleService
    {
        public int DiscountRate { get; set; }

        virtual public int ApplyDiscount(Game game)
        {
            double gamePrice = Convert.ToDouble(game.Price);
            double discountRate = 1.0-(Convert.ToDouble(DiscountRate) / 100.0);
            return Convert.ToInt32(gamePrice * discountRate);
        }

    }
}
