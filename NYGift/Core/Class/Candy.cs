using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NYGift.Core.Class
{
    public abstract class Candy
    {
        public Candy(string candyname, double weightOfOne, string typeCandy, int sugarContentinOne)
        {
            CandyName = candyname;
            WeightOfOne = weightOfOne;
            SugarContentinOne = sugarContentinOne;
            TypeCandy = typeCandy;
        }

        public string CandyName { get; set; }

        public double WeightOfOne { get; set; }

        public int SugarContentinOne { get; set; }

        public string TypeCandy { get; set; }

        
    }
}
