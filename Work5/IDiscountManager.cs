using System;
using System.Collections.Generic;
using System.Text;

namespace Work5
{
    interface IDiscountManager
    {
        void Add(Discount discount);
        void Delete(Discount discount);
        void Update(Discount discount);
    }
}
