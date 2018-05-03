using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NYGift.Core.Enum;

namespace NYGift.Core.Class
{
    public class LollipopCandyCreator : Creator
    {
        public override Candy FactoryMethod(string candyname, double weightOfOne, string typeCandy,int sugarContentinOne,  Colour colour)
        {
            return new LollipopCandy(candyname, weightOfOne, typeCandy, sugarContentinOne, colour);
        }

        public override Candy FactoryMethod(string candyname, double weightOfOne,string typeCandy, int sugarContentinOne,  Taste taste)
        {
            throw new NotImplementedException();
        }

        public override Candy FactoryMethod(string candyname, double weightOfOne, string typeCandy,int sugarContentinOne,  Filling filling)
        {
            throw new NotImplementedException();
        }
    }
}
