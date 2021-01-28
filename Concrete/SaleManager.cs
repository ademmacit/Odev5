using Odev5.Abstract;
using Odev5.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Concrete
{
    class SaleManager : ISaleManager
    {
        SaleService _saleService;

        public SaleManager(SaleService saleService)
        {
            _saleService = saleService;
        }

        public void SellGame(Student student, Game game)
        {
            int discountedPrice =  _saleService.ApplyDiscount(game);
            Console.WriteLine(game.Name + " has been sold for " + discountedPrice);
        }
    }
}
