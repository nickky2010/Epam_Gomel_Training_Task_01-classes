using System;
using System.Text;
using Task1.Models;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                TravelExpenses[] travelExpenses = new TravelExpenses[5]
                {
                new TravelExpenses{ Account = "Anton Slutsky", Transport = 50000, CountDays=5},
                new TravelExpenses{ Account = "Egor Makarov", Transport = 60000, CountDays=3},
                null,
                new TravelExpenses{ Account = "Pavel Pavlov", Transport = 100000, CountDays=10},
                new TravelExpenses(),
                };
                foreach (TravelExpenses item in travelExpenses)
                {
                    if (item != null)
                    {
                        item.Show();
                        Console.WriteLine();
                    }
                }
                travelExpenses[travelExpenses.Length - 1].Transport = 33333;
                Console.WriteLine("Duration = "+(travelExpenses[0].CountDays + travelExpenses[1].CountDays));
                foreach (TravelExpenses item in travelExpenses)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
