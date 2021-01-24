using System;
using System.Collections.Generic;
using System.Text;

namespace Work5
{
    class DiscountSale
    {
        public void Discountsale(Discount discount, SaleGame salegame, PlayerProp player)
        {
            Console.WriteLine(player.FirstName+ " " + salegame.GameName + " " + discount.DiscountRate + " bought with a discount" );
        }
    }
}
