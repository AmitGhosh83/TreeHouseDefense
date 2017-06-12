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
                Path path = new Path(
                                     new[] 
                                        {
                                            new MapLocation(0, 2, map),
                                            new MapLocation(1, 2, map),
                                            new MapLocation(2, 2, map),
                                            new MapLocation(3, 2, map),
                                            new MapLocation(4, 2, map),
                                            new MapLocation(5, 2, map),
                                            new MapLocation(6, 2, map),
                                            new MapLocation(7, 2, map),
                                            
                                        }
                                   );

                Invader[] invaders = {
                                        new Invader(path),
                                        new Invader(path),
                                        new Invader(path),
                                        new Invader(path),

                                     };

                Level level = new Level(invaders);

                Tower[] towers = {
                                    new Tower(new MapLocation(1,3,map)),
                                    new Tower(new MapLocation(2,3,map)),
                                    new Tower(new MapLocation(3,3,map)),
                                    new Tower(new MapLocation(5,3,map)),

                                };
                level.Towers = towers;
                bool PlayerWon = level.Play();

                Console.WriteLine("Player " + (PlayerWon? "Won" : "Lost"));
                Console.ReadKey();

            }

           
            catch (OutOfBoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (TreeHouseDefenseException)
            {
                Console.WriteLine("Unhandled TreeHouseDefenseException");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception"+ ex);
                Console.ReadKey();
            }
         
        }
    }
}
