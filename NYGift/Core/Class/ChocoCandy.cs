using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NYGift.Core.Enum;
using NYGift.Core.Interface;
using NYGift.Core.Class;


namespace NYGift.Core.Class
{
    public class ChocoCandy: Candy
    {
               
        public Filling filling;
        
        public ChocoCandy(string candyname, double weightOfOne, string typeCandy, int sugarContentinOne, Filling filling)
            : base(candyname, weightOfOne,typeCandy, sugarContentinOne)
        {
        }

        public override Candy create(string candyname, double weightOfOne, string typeCandy, int sugarContentinOne)
        {
            return new ChocoCandy(candyname, weightOfOne, typeCandy, sugarContentinOne, filling);
        }
    }
}
