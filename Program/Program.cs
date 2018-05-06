using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NYGift.Core.Class;
using NYGift.Core.Interface;
using NYGift.Core.Enum;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

           IGift gift = new Gift();

            
            gift.Add(new ChocoCandy("Аленка", 50, "Шоколадная конфета", 10, NYGift.Core.Enum.Filling.Nuts));
            gift.Add(new ChocoCandy("Коммунарка", 20, "Шоколадная конфета", 15, NYGift.Core.Enum.Filling.Nuts));
            gift.Add(new JellyCandy("Maoam", 300, "Желейная конфета", 31, NYGift.Core.Enum.Taste.Grape));
            gift.Add(new JellyCandy("Maoam", 300, "Желейная конфета", 31, NYGift.Core.Enum.Taste.Cherry));
            gift.Add(new JellyCandy("Maoam", 300, "Желейная конфета", 31, NYGift.Core.Enum.Taste.Orange));
            gift.Add(new LollipopCandy("Взлетная", 15, "Леденец", 7, NYGift.Core.Enum.Colour.Red));

            Console.WriteLine("Детский подарок сформирован");
            Console.WriteLine();
            gift.GiftAll();

            Console.WriteLine();
            

            Console.WriteLine("Конфеты в подарке сортированные по имени: ");
            gift.SortByName();
            foreach (var i in gift.Items)
            {
                Console.WriteLine(" {0}, вес: {1}, вид: {2}, содержание сахара: {3},"
                    , i.CandyName, i.WeightOfOne, i.TypeCandy, i.SugarContentinOne);

            }

            Console.WriteLine("Вес подарка: {0}", gift.GiftWeight());
            Console.WriteLine();

            
            Console.WriteLine("Выбор кофет с содержанием сахара от 10 до 11 г: ");

            foreach (var items in gift.FindBySugarContain(10, 11))
            {

                Console.WriteLine("{0}, Содержание сахара: {1}", items.CandyName, items.SugarContentinOne);
            }
            Console.WriteLine();

                       
            Console.WriteLine("press a key...");
            Console.ReadKey();
        }
    }
}
