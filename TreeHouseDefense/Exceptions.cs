using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHouseDefense
{

     class TreeHouseDefenseException : Exception
    {
        public TreeHouseDefenseException()
        {

        }
        public TreeHouseDefenseException(string message): base(message)
        {

        }

    }

    class OutOfBoundException : TreeHouseDefenseException
    {
        public OutOfBoundException()
            {
            }
        public OutOfBoundException(string message) : base(message)
        {


        }
    }
}
