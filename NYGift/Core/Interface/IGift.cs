using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NYGift.Core.Class;


namespace NYGift.Core.Interface
{
    public interface IGift
    {
        IEnumerable<Candy> Items { get; }
        void Add(Candy candy);
        void SortByName();
        IEnumerable<Candy> FindBySugarContain(int min, int max);
        double GiftWeight();
        void GiftAll();
    }
}
