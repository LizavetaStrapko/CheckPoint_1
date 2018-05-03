using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NYGift.Core.Enum;

namespace NYGift.Core.Class
{
    public class JellyCandyCreator : Creator
    {
        public override Candy FactoryMethod(string candyname, double weightOfOne, string typeCandy, int sugarContentinOne, Colour colour)
        {
            throw new NotImplementedException();
        }

        public override Candy FactoryMethod(string candyname, double weightOfOne, string typeCandy, int sugarContentinOne, Taste taste)
        {
            return new JellyCandy(candyname, weightOfOne, typeCandy, sugarContentinOne, taste);
        }

        public override Candy FactoryMethod(string candyname, double weightOfOne, string typeCandy, int sugarContentinOne, Filling filling)
        {
            throw new NotImplementedException();
        }
    }
}
