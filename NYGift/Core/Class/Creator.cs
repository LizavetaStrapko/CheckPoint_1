using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NYGift.Core.Interface;
using NYGift.Core.Class;
using NYGift.Core.Enum;

namespace NYGift.Core.Class
{
    public abstract class Creator 
    {

        public abstract Candy FactoryMethod(string candyname, double weightOfOne, string typeCandy,
            int sugarContentinOne,  Filling filling);

        public abstract Candy FactoryMethod(string candyname, double weightOfOne,string typeCandy,
           int sugarContentinOne,  Taste taste);

        public abstract Candy FactoryMethod(string candyname, double weightOfOne,string typeCandy,
           int sugarContentinOne,  Colour colour);


        //public static void InfoGift(IGift gift)
        //{
        //    Console.WriteLine("Детский подарок: ");
        //    foreach (var i in gift.Items)
        //    {
        //             Console.WriteLine("Название конфеты : {0}, Вес: {1}, Вид конфеты: {2}, Содержание сахара: {3},"
        //            , i.CandyName, i.WeightOfOne, i.TypeCandy, i.SugarContentinOne);

        //             Console.WriteLine();

        //    }
        }
    }

