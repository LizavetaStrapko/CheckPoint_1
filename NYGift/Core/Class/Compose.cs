using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NYGift.Core.Interface;
using NYGift.Core.Class;

namespace NYGift.Core.Class
{
    public class Compose 
    {
        public static void InfoGift(IGift gift)
        {
            Console.WriteLine("Детский подарок: ");
            foreach (var i in gift.Items)
            {
                     Console.WriteLine("Название конфеты : {0}, Вес: {1}, Вид конфеты: {2}, Содержание сахара: {3},"
                    , i.CandyName, i.WeightOfOne, i.TypeCandy, i.SugarContentinOne);

                     Console.WriteLine();

            }
        }
    }
}
