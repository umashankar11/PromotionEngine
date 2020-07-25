using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineBusiness
{
   public interface IPromotionEngine
    {
        double GetOrderPrice(SKUCart Cart);
    }
}
