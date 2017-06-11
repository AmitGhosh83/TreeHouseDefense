using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHouseDefense
{
    class Level
    {
        public Tower[] towers { get; set; }

        private readonly Invader[] _invaders;

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        public bool Play()
        {
            int remainingInvaders = _invaders.Length;

            while(remainingInvaders>0)
            {
                foreach(Tower tower in towers)
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
                        remainingInvaders += 1;
                    }
                }
            }
            return true;
        }

    }
}
