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
            : base(candyname, weightOfOne, typeCandy, sugarContentinOne)
        {
        }

        public override string ToString()
        {
            return string.Format("{0}, Вес: {1}, Вид: {2}, Сахара: {3}, Особенность: {4}",
                            CandyName, WeightOfOne, TypeCandy, SugarContentinOne, taste);

        }
    }
        
}
