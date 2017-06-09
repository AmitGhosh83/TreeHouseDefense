using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHouseDefense
{
    class Invader
    {
        private int _pathStep = 0;
        private Path _path;
        public int Health { get; set; } = 2; // We could have done it in Constructor itself

        public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
        }
        
        public Invader(Path path)
        {
            _path = path;
            //Health = 2;
        }

        public bool HasScored
        {
           get
           {
                return _pathStep >= _path.Length;
           }
        }

        public bool IsNeutralized
        {
            get
            {
                return Health <= 0; 
            }
        }

        public bool IsActive => !IsNeutralized || !HasScored;
      
        public void Move()=> _pathStep += 1;

        public void DecreaseHealth(int factor) => Health -=  factor;
    
      
    }
}
