using System;

namespace Task3.Models
{
    class Purchase : IComparable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public DayWeek DayWeek { get; set; }

        public Purchase()
        {
            DayWeek = DayWeek.Monday;
        }
        public Purchase(string name, decimal price, int count, DayWeek dayWeek)
        {
            Name = name;
            Price = price;
            Count = count;
            DayWeek = dayWeek;
        }
        public decimal GetCost()
        {
            return (Price * Count);
        }
        public override string ToString()
        {
            return (Name+";"+Price+";"+Count+";"+DayWeek.ToString());
        }
        public int CompareTo(object obj)
        {
            Purchase p = obj as Purchase;
            if (p != null)
                return (GetCost().CompareTo(p.GetCost()));
            else
                throw new Exception("Unable to compare two objects");
        }
    }
}
