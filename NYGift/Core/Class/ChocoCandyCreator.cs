using NYGift.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NYGift.Core.Class
{
    public class ChocoCandyCreator : Creator
    {
        public override Candy FactoryMethod(string candyname, double weightOfOne, string typeCandy,int sugarContentinOne,  Colour colour)
        {
            throw new NotImplementedException();
        }

        public override Candy FactoryMethod(string candyname, double weightOfOne, string typeCandy,int sugarContentinOne,  Taste taste)
        {
            throw new NotImplementedException();
        }

        public override Candy FactoryMethod(string candyname, double weightOfOne, string typeCandy,int sugarContentinOne,  Filling filling)
        {
            return new ChocoCandy(candyname, weightOfOne, typeCandy, sugarContentinOne, filling);
        }
    }
}
