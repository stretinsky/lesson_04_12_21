using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13
{
    class Buildings
    {
        public List<Building> builds = new List<Building>();

        public Building this[int index]
        {
            get
            {
                return builds[index];
            }
        }


    }
}
