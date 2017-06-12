using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHouseDefense
{
    class Tower
    {
        private readonly MapLocation _location;
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = 0.75;
        private static Random _random= new Random();
        

        public Tower (MapLocation location)
        {
            if (location.X == 0 && location.Y == 2)
            {
                throw new OutOfBoundException();
            }
            else
                _location = location;
        }

        public bool IsSuccessfulShot( double _accuracy)
        {
            return _random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range) )
                {
                    if(IsSuccessfulShot(_accuracy))
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot at invader and hit the target");
                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Invader nuetralized");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Missed the invader");
                    }
                    
                    break;

                }
            }

            //for(int i=0; i< invaders.Length; i++)
            //{
            //    if (invaders[i].IsActive && _location.InRangeOf(invaders[i].Location,_range))
            //    {
            //        invaders[i].DecreaseHealth(_power);
            //        break;                        
            //    }
            //}

        }
    }
}
