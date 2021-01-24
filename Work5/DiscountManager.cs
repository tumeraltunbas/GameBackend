using System;
using System.Collections.Generic;
using System.Text;

namespace Work5
{
    class DiscountManager: IDiscountManager 
    {
        public void Add(Discount discount)
        {
            Console.WriteLine(discount.DiscountRate + " " + "discount added");
        }
        public void Delete(Discount discount)
        {
            Console.WriteLine(discount.DiscountRate+ " " + "discount deleted");
        }
        public void Update(Discount discount)
        {
            Console.WriteLine(discount.DiscountRate+ " " + "discount updated");
        }


    }
}
