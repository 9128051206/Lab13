using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Тевосяна", 50, 20, 7);
            MultiBuilding multiBuilding = new MultiBuilding("Ленина", 40, 60, 5, 2);
            Console.WriteLine(multiBuilding.Print());
            Console.WriteLine(building.Print());
            Console.ReadKey();
        }
    }
}
