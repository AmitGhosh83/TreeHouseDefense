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

        public Tower (MapLocation location)
        {
            if (location.X == 0 && location.Y == 2)
            {
                throw new OutOfBoundException();
            }
            else
                _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    invader.DecreaseHealth(_power);
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
