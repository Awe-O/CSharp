using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var ketler = new Items(
                1, "Ketler", 2499.00m);
            var vacuumCleaner = new Items(
                2, "Vaccum cleaner", 15999.00m);
            var iron = new Items(
                5, "Iron", 999.00m);
            var microwave = new Items(
                10, "Microwave", 4499.00m, true, 3);
            var laptop = new Items(
                6, "Laptop", 49999.00m, 
                false, 0, "The best laptop ever!", "black");
            var hairDyier = new Items(
                9, "Hair dryer", 1499.00m,
                true, 10, "Your hair always should be dry!", "red");

            var itemsInStock = new List<object>
            { ketler, vacuumCleaner, iron, microwave, laptop, hairDyier };


            Console.WriteLine($"Items in stock now = {itemsInStock.Count}. \r\n" +
                $"Items: {ketler.Name}, {vacuumCleaner.Name}, {iron.Name}, {microwave.Name}, {laptop.Name}, {hairDyier.Name}.");

        }
    }
}
