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

            try
            {
                MapLocation maplocation = new MapLocation(20, 15, map);
            }

           
            catch (OutOfBoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (TreeHouseDefenseException)
            {
                Console.WriteLine("Unhandled TreeHouseDefenseException");
            }
            catch (Exception )
            {
                Console.WriteLine("Unhandled Exception");
            }
         
        }
    }
}
