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

        public double WeightOfOne { get; protected set; }

        public int SugarContentinOne { get; protected set; }

        public string TypeCandy { get; set; }

        public override string ToString()
        {
           return string.Format("{0}, Вес: {1}, Вид: {2}, Содержание сахара: {3}",
                               CandyName, WeightOfOne, TypeCandy, SugarContentinOne);
        }
    }
}
