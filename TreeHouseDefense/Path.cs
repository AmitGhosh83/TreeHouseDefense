using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHouseDefense
{
    class Path
    {
        private MapLocation[] _path;
        private int pathstep;
        public int Length
        {
            get
            {
                return _path.Length;
            }
        }

        public Path(MapLocation[] path)
        {
            _path = path;
            
        }

        public MapLocation GetLocationAt(int pathstep)
        {
           return (pathstep < _path.Length) ? _path[pathstep] : null;
        }

        //public bool OnPath(MapLocation[] maplocations)
        //{
        //    for (int i=0; i<_path.Length; i++)
        //    {
        //        MapLocation maplocation = maplocations[i]; 
        //        if (i.X = point.X && i.Y == point.Y)
        //            return true;
        //        else
        //            return false;
        //        MapLocation[i]
        //    }
            
        
    }
}
