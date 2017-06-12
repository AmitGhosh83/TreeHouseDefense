using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHouseDefense
{
    class Level
    {
        public Tower[] Towers { get; set; }

        private readonly Invader[] _invaders;

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        // Returns True if Player Wins, False otherwise

        public bool Play()
        {
            int remainingInvaders = _invaders.Length;

            while(remainingInvaders>0)
            {
                foreach(Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                remainingInvaders = 0;
                foreach(Invader invader in _invaders)
                {
                    if(invader.IsActive)
                    {
                        invader.Move();
                        if(invader.HasScored)
                        {
                            return false;
                        }
                        remainingInvaders ++;
                    }
                }
            }
            return true;
        }

    }
}
