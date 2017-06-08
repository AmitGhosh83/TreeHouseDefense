using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHouseDefense
{
    class Game
    {
        static void Main(string[] args)
        {

            Map map = new Map(8,5);
            Point point = new Point(2, 3);
            Point point1 = new Point(0, 5);

            bool IsOnMap = map.OnMap(new MapLocation(8,5));

            Console.WriteLine("{0}", IsOnMap);
            Console.WriteLine("{0}", point.DistanceTo(point1));
            Console.ReadKey();
        }
    }
}
