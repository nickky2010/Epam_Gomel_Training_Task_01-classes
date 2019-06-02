using System;
using System.Text;

namespace Task1.Models
{
    class TravelExpenses
    {
        public const decimal rate = 25000m;
        public string Account { get; set; }
        public decimal Transport { get; set; }
        public int CountDays { get; set; }
        StringBuilder builder;

        public TravelExpenses()
        {
            Account = null;
            builder = new StringBuilder();
        }
        public TravelExpenses(string account, decimal transport, int countDays)
        {
            Account = account;
            Transport = transport;
            CountDays = countDays;
            builder = new StringBuilder();
        }
        public void Show()
        {
            Console.WriteLine("rate = "+rate);
            Console.WriteLine("account = "+Account);
            Console.WriteLine("transport = "+Transport);
            Console.WriteLine("countDays = "+CountDays);
            Console.WriteLine("total = "+GetTotal());
        }
        public decimal GetTotal()
        {
            return (Transport + CountDays * rate);
        }
        public override string ToString()
        {
            return (builder.Clear().Append(rate).Append(";").Append(Account).Append(";")
                .Append(Transport).Append(";").Append(CountDays).Append(";").Append(GetTotal()).ToString());
        }
    }
}
