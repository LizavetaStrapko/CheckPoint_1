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

            Creator[] creators = new Creator[3];
            creators[0] = new ChocoCandyCreator();
            creators[1] = new LollipopCandyCreator();
            creators[2] = new JellyCandyCreator();

            IGift gift = new Gift();

            foreach (Creator j in creators)
            {
                if (j is ChocoCandyCreator)
                {
                    gift.Add(j.FactoryMethod("Аленка", 50, "Шоколадная конфета", 10, NYGift.Core.Enum.Filling.Nuts));
                    gift.Add(j.FactoryMethod("Коммунарка", 20, "Шоколадная конфета", 15, NYGift.Core.Enum.Filling.Nuts));
                    
                }
                if (j is LollipopCandyCreator)
                {
                    gift.Add(j.FactoryMethod("Взлетная", 15, "Леденец", 7, NYGift.Core.Enum.Colour.Red));
                    gift.Add(j.FactoryMethod("Тутти-Фрутти", 17, "Леденец", 11, NYGift.Core.Enum.Colour.Blue));
                    gift.Add(j.FactoryMethod("Чупа чупс", 30, "Леденец", 10, NYGift.Core.Enum.Colour.Green));
                }

                if (j is JellyCandyCreator)
                {
                    gift.Add(j.FactoryMethod("Maoam", 300, "Желейная конфета", 31, NYGift.Core.Enum.Taste.Grape));
                    gift.Add(j.FactoryMethod("Maoam", 300, "Желейная конфета", 31, NYGift.Core.Enum.Taste.Cherry));
                    gift.Add(j.FactoryMethod("Maoam", 300, "Желейная конфета", 31, NYGift.Core.Enum.Taste.Orange));
                }
            }


            Console.WriteLine("Детский подарок сформирован");
            Console.WriteLine();
            gift.SortByName();

            Console.WriteLine("Конфеты в подарке сортированные по имени: ");
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
