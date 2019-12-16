using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_planner_16._11._2019
{
    class RESERVATION : ACTIVITY //just to check how it works
    {
        

        public MEMBER member;
        public ACTIVITY activity; //added 30.11.2019



        public RESERVATION(string reservationtName) : base(reservationtName) 
            //reservMemberName and reservActivityName can be added to constructor
        {

             
        }
    }
}
