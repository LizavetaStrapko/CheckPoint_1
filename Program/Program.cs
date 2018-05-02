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
            List<ChocoCandy> chocoCandy = new List<ChocoCandy>();
            chocoCandy.Add(new ChocoCandy("Аленка", 50, "Шоколадная конфета", 10, NYGift.Core.Enum.Filling.Nuts));
            chocoCandy.Add(new ChocoCandy("Коммунарка", 20, "Шоколадная конфета", 15, NYGift.Core.Enum.Filling.Nuts));
            chocoCandy.Add(new ChocoCandy("Спартак", 100, "Шоколадная конфета", 18, NYGift.Core.Enum.Filling.Caramel));
            chocoCandy.Add(new ChocoCandy("Рошен", 70, "Шоколадная конфета", 11, NYGift.Core.Enum.Filling.Nougat));

            List<JellyCandy> jellyCandy = new List<JellyCandy>();
            jellyCandy.Add(new JellyCandy("HARIBO", 200, "Желейная конфета", 16, NYGift.Core.Enum.Taste.Cherry));
            jellyCandy.Add(new JellyCandy("Chamallow", 100, "Желейная конфета", 21, NYGift.Core.Enum.Taste.Cherry));
            jellyCandy.Add(new JellyCandy("Maoam", 300, "Желейная конфета", 31, NYGift.Core.Enum.Taste.Grape));
            jellyCandy.Add(new JellyCandy("Maoam", 300, "Желейная конфета", 31, NYGift.Core.Enum.Taste.Cherry));
            jellyCandy.Add(new JellyCandy("Maoam", 300, "Желейная конфета", 31, NYGift.Core.Enum.Taste.Orange));


            List<LollipopCandy> lollipopCandy = new List<LollipopCandy>();
            lollipopCandy.Add(new LollipopCandy("Рокс", 20, "Леденец", 9, NYGift.Core.Enum.Colour.Blue));
            lollipopCandy.Add(new LollipopCandy("Тутти-Фрутти", 17, "Леденец", 11, NYGift.Core.Enum.Colour.Blue));
            lollipopCandy.Add(new LollipopCandy("Чупа чупс", 30, "Леденец", 10, NYGift.Core.Enum.Colour.Green));
            lollipopCandy.Add(new LollipopCandy("Взлетная", 15, "Леденец", 7, NYGift.Core.Enum.Colour.Red));
            
            List<Candy> allcandies = new List<Candy>();
            NYGift.Core.Interface.IGift gift = new Gift();

            allcandies.AddRange(chocoCandy);
            allcandies.AddRange(jellyCandy);
            allcandies.AddRange(lollipopCandy);

            gift.Add(new ChocoCandy("Аленка", 50, "Шоколадная конфета", 10, NYGift.Core.Enum.Filling.Nuts));
            gift.Add(new ChocoCandy("Коммунарка", 20, "Шоколадная конфета", 15, NYGift.Core.Enum.Filling.Nuts));
            gift.Add(new JellyCandy("Maoam", 300, "Желейная конфета", 31, NYGift.Core.Enum.Taste.Grape));
            gift.Add(new JellyCandy("Maoam", 300, "Желейная конфета", 31, NYGift.Core.Enum.Taste.Cherry));
            gift.Add(new JellyCandy("Maoam", 300, "Желейная конфета", 31, NYGift.Core.Enum.Taste.Orange));
            gift.Add(new LollipopCandy("Взлетная", 15, "Леденец", 7, NYGift.Core.Enum.Colour.Red));


            Console.WriteLine();
            gift.SortByName();
            Compose.InfoGift(gift);
            Console.WriteLine();

            foreach (var items in gift.FindBySugarContain(5, 11))
            {
                Console.WriteLine("Название конфеты: {0}, Содержание сахара: {1}", items.CandyName, items.SugarContentinOne);
            }
            Console.WriteLine();

            Console.WriteLine("Вес подарка: {0}", gift.GiftWeight());
            
            Console.WriteLine("press a key...");
            Console.ReadKey();
        }
    }
}
