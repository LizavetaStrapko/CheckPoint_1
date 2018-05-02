using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NYGift.Core.Interface
{
    public interface ICandyItem
    {
        string CandyName { get; set; }
        double WeightOfOne { get; set; }
        int SugarContentinOne { get; set; }
        string TypeCandy { get; }
    }
}
