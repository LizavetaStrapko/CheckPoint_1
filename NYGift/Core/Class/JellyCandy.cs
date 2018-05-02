using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NYGift.Core.Enum;

namespace NYGift.Core.Class
{
    public class JellyCandy : Candy
    {
        public Taste taste;

        public JellyCandy (string candyname, double weightOfOne, string typeCandy, int sugarContentinOne, Taste taste)
            : base(candyname, weightOfOne, sugarContentinOne, typeCandy)
        {
        }

        public override string TypeCandy
        {
            get { return "Желейная конфета"; }
        }

        public string Variety
        {
            get { return taste.ToString(); }
        }
    }
        
}
