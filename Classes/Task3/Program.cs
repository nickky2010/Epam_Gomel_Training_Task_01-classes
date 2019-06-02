using System;
using System.Text;
using Task3.Models;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Purchase[] purchases = new Purchase[5]
                {
                new Purchase{ Name = "Sugar", Price = 1.52m, Count = 4, DayWeek = DayWeek.Friday },
                new Purchase{ Name = "Tea", Price = 4.33m, Count = 2, DayWeek = DayWeek.Monday },
                new Purchase{ Name = "Cofe", Price = 10.78m, Count = 1, DayWeek = DayWeek.Tuesday },
                new Purchase{ Name = "Milk", Price = 1.22m, Count = 7, DayWeek = DayWeek.Thursday },
                new Purchase{ Name = "Bread", Price = 0.82m, Count = 2, DayWeek = DayWeek.Saturday }
                };
                foreach (Purchase item in purchases)
                {
                    Console.WriteLine(item);
                }
                decimal sumPrice = purchases[0].GetCost();
                Purchase maxP = purchases[0];

                for (int i = 1; i < purchases.Length; i++)
                {
                    decimal costPurchases = purchases[i].GetCost();
                    if (costPurchases > maxP.GetCost())
                    {
                        maxP = purchases[i];
                    }
                    sumPrice += costPurchases;
                }
                Console.WriteLine("\nAverage cost of all purchases = "+(sumPrice / purchases.Length));
                Console.WriteLine("Day of maximum price purchases = "+maxP.DayWeek.ToString()+"\n");
                Array.Sort(purchases);
                foreach (Purchase item in purchases)
                {
                    Console.WriteLine(item);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
