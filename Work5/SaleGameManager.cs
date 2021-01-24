using System;
using System.Collections.Generic;
using System.Text;

namespace Work5
{
    class SaleGameManager: ISaleGameManager
    {
      
        public void Sale(SaleGame salegame, PlayerProp player)
        {
            Console.WriteLine(player.FirstName + " " + salegame.GameName + " " + salegame.price+ " " + "purchased");
        }

        
    }
}
