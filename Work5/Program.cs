using System;

namespace Work5
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerProp player1 = new PlayerProp();
            player1.Id = 1234567;
            player1.FirstName = "Tümer";
            player1.LastName = "Altunbaş";
            player1.Birth = 1999;
            PlayerProp player2 = new PlayerProp();
            player2.Id = 7851234;
            player2.FirstName = "Engin";
            player2.LastName = "Demiroğ";
            player2.Birth = 1999;
            PlayerProp player3 = new PlayerProp();
            player3.Id = 3952368;
            player3.FirstName = "Berkay";
            player3.LastName = "Bilgin";
            player3.Birth = 1999;

            IPlayerManager playerManager = new PlayerManager();
            playerManager.Register(player1);
            playerManager.Delete(player2);
            playerManager.Update(player3);

            SaleGame salegame = new SaleGame();
            salegame.GameName = "CS:GO";
            salegame.price = 24.99;
            ISaleGameManager saleGameManager = new SaleGameManager();
            saleGameManager.Sale(salegame, player3);

            Discount discount1 = new Discount();
            discount1.DiscountRate = "%30";
            Discount discount2 = new Discount();
            discount2.DiscountRate = "%50";
            Discount discount3 = new Discount();
            discount3.DiscountRate = "%70";

            IDiscountManager discountManager = new DiscountManager();
            discountManager.Add(discount1);
            discountManager.Delete(discount2);
            discountManager.Update(discount3);

            DiscountSale discountSale = new DiscountSale();
            discountSale.Discountsale(discount2, salegame, player1);

            IVerification discountManager1 = new Verification();
            discountManager1.Verify(player1);



           
        }
    }
}
