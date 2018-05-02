using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NYGift.Core.Class
{
    public abstract class Candy
    {
        public Candy(string candyname, double weightOfOne, int sugarContentinOne, string typeCandy )
        {
            CandyName = candyname;
            WeightOfOne = weightOfOne;
            SugarContentinOne = sugarContentinOne;
        }

        public string CandyName { get; set; }

        public double WeightOfOne { get; set; }

        public int SugarContentinOne { get; set; }

        public abstract string TypeCandy { get; }
               
    }
}
