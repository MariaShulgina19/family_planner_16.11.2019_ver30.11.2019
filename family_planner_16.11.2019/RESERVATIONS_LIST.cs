using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_planner_16._11._2019
{
    class RESERVATIONS_LIST :ACTIVITTIES_LIST
    {
        
        
        public FAMILY _familyTest { get; set; }//added 29.11.2019 to try add name from famaly list
        public ACTIVITTIES_LIST _activity_listTest { get; set; }
        private List<RESERVATION> ResevationList = new List<RESERVATION>();// family created as a list of members

        //constructor combines two classes Family and Activity
        public RESERVATIONS_LIST( FAMILY family, ACTIVITTIES_LIST activityList) //new 29.11.2019 added family name to constructor
        {
            _familyTest = family;
            _activity_listTest = activityList; //new 30.11.2019

        }
        // ADDING New activities fot test only, and it activated with 13
        override public void AddPositionForTest()  
        {

          
            RESERVATION ResforTest1 = new RESERVATION("SPORT1");

            ResforTest1.member = _familyTest.SearchMembeAddToResevation("Maria");

            ResforTest1.activity = _activity_listTest.SearchPositionsByNameToAddToReservation("RUN");

            ResevationList.Add(ResforTest1);



            RESERVATION ResforTest2 = new RESERVATION("SPORT2");

            ResforTest2.member = _familyTest.SearchMembeAddToResevation("Maria");

            ResforTest2.activity = _activity_listTest.SearchPositionsByNameToAddToReservation("SKI");

            ResevationList.Add(ResforTest2);


            RESERVATION ResforTest3 = new RESERVATION("SPORT3");

            ResforTest3.member = _familyTest.SearchMembeAddToResevation("Robinson");

            ResforTest3.activity = _activity_listTest.SearchPositionsByNameToAddToReservation("DANCE");

            ResevationList.Add(ResforTest3);

        }
        override public void AddPosition() // need to override to connect member and activity
        {
            //_familyTest.PrintMembers(); it was fot test only
            Console.WriteLine("Give Reservation Name");//check if it exist in list
            string name = Console.ReadLine();
            //creating new list
            RESERVATION k = new RESERVATION(name);

            //need to pick uo from memberlist oilio all data for this member
            MEMBER member = null;
            Console.WriteLine("Give Member Name");

            //string somename = ""; //check what is this
            while ( member == null )
            {
               
                member = _familyTest.SearchMembeAddToResevation(Console.ReadLine());
              
            }
            

            k.member = member;
            Console.WriteLine("Search completed");
          
            Console.ReadLine();

    

            Console.WriteLine("Now printing all activities");
            _activity_listTest.PrintPositions();
            //AddActivitytoReservation()
            ACTIVITY activity = null;
            string someactivity = "";
            while (activity == null)
            {
                Console.WriteLine("Give Activity Name");
                someactivity = Console.ReadLine();
                //While loop löytyykö _familyTest oliosta somename
                Console.WriteLine("Starting search");

                activity = _activity_listTest.SearchPositionsByNameToAddToReservation(someactivity);
            }

            k.activity = activity;
            k.member = member;
            Console.WriteLine("Search completed");
            
           
            Console.ReadLine();


            
            Console.WriteLine($"Reservation for {k.member._memberName} created. Member is {k.member._memberAge} years old." +
                $"for {k.activity._activityName} Date: {k.activity._activityDay.ToShortDateString()}");
            Console.ReadLine();
            ResevationList.Add(k);

        }


        override public void PrintPositions() //PrintActivities added 16.12

        {
            Console.WriteLine();
            Console.WriteLine("Here is all reservations:");

            Console.WriteLine();
            foreach (var item in ResevationList)
            {
                Console.WriteLine($"Reservation for {item.member._memberName}"+
                    $"\n - {item.activity._activityName}, {item.activity._activityDay.ToShortDateString()} from {item.activity._acticityStartTime.ToShortTimeString()} to {item.activity._acticityEndTime.ToShortTimeString()} .");
            }

            Console.WriteLine();
            Console.ReadLine();


           //Add search method in reservation
        }


    }
}


