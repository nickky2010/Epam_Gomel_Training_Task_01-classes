using System;
using Task2.Models;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HomogeneousObject homogeneousObject = new HomogeneousObject("wire", new PhysicalMaterial("steel", 7850d), 0.03);
                Console.WriteLine(homogeneousObject);
                homogeneousObject.PhysicalMaterial = new PhysicalMaterial("cuprum", 8500d);
                Console.WriteLine(homogeneousObject.GetMass());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
