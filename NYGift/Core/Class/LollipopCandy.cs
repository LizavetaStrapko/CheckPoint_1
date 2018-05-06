using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NYGift.Core.Enum;

namespace NYGift.Core.Class
{
    public class LollipopCandy : Candy
    {
        public Colour colour;

        public LollipopCandy(string candyname, double weightOfOne, string typeCandy, int sugarContentinOne, Colour colour)
            : base(candyname, weightOfOne, typeCandy, sugarContentinOne)
        {
        }
        public override Candy create(string candyname, double weightOfOne, string typeCandy, int sugarContentinOne)
        {
            return new LollipopCandy(candyname, weightOfOne, typeCandy, sugarContentinOne, colour);
        }
    }
}
