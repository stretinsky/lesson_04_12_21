using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork__12;

namespace Homework_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Buildings buildings = new Buildings();
            buildings.builds.AddRange(new List<Building>
            {
                new Building(),
                new Building(12,23,123,4),
                new Building(4,32,12,75),
                new Building(23,44,16,54)
            });

            Console.WriteLine(buildings[31]);
        }
    }
}
