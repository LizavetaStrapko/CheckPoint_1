using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NYGift.Core.Class
{
    public class Gift : Interface.IGift
    {


        public ICollection<Candy> items;

        public Gift()
        {
            items = new List<Candy>();
        }

        public void Add(Candy candy)
        {
            items.Add(candy);
        }

        public void Delete(Candy candy)
        {
            items.Remove(candy);
        }

        public void GiftAll()
        {
            foreach (var item in this.items)
            { item.ToString(); }
        }

        public double GiftWeight()
        {
           return items.Sum(x => x.WeightOfOne); 
        }

        public void SortByName()
        {
            items = items.OrderBy(x => x.CandyName).ToList();
        }

        public IEnumerable<Candy> FindBySugarContain(int min, int max)
        {
            return items.Where(x => (x.SugarContentinOne >= min) && (x.SugarContentinOne <= max)).ToList();
        }

        public IEnumerable<Candy> Items
        {
            get { return items; }
        }

       
    }
}

        