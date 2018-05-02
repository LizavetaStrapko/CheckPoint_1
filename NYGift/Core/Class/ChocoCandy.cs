using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NYGift.Core.Enum;

namespace NYGift.Core.Class
{
    public class ChocoCandy: Candy
    {
               
        public Filling filling;

        public ChocoCandy(string candyname, double weightOfOne, string typeCandy, int sugarContentinOne, Filling filling)
            : base(candyname, weightOfOne, sugarContentinOne, typeCandy)
        {
        }

        public override string TypeCandy
        {
            get { string typeCandy;  return typeCandy = "Шоколадная конфета"; }
        }
                                
    }
}
