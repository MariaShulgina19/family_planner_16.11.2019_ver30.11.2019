using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_planner_16._11._2019
{
    class ACTIVITTIES_LIST
    {

        //Class ACTIVITIES_LIST is a of list of activities
        public List<ACTIVITY> ActivitiesList = new List<ACTIVITY>();// family created as a list of members public
        

        //perus constructor
        public ACTIVITTIES_LIST() // ctr
        {
            //AddMember();
        }

        //method Adding new activity


        virtual public void AddPositionForTest()  // ADDING New activities fot test
        {
            ACTIVITY forTest1 = new ACTIVITY("RUN");
            forTest1._activityDay = DateTime.Parse("20.12");
            forTest1._acticityStartTime= DateTime.Parse("11:10");
            forTest1._acticityEndTime = DateTime.Parse("12:10");

            ActivitiesList.Add(forTest1);

            ACTIVITY forTest2 = new ACTIVITY("SKI");
            forTest2._activityDay = DateTime.Parse("22.12");
            forTest2._acticityStartTime = DateTime.Parse("13:00");
            forTest2._acticityEndTime = DateTime.Parse("14:00");

            ActivitiesList.Add(forTest2);

            ACTIVITY forTest3 = new ACTIVITY("DANCE");
            forTest3._activityDay = DateTime.Parse("24.12");
            forTest3._acticityStartTime = DateTime.Parse("10:00");
            forTest3._acticityEndTime = DateTime.Parse("11:00");

            ActivitiesList.Add(forTest3);






        }
        virtual public void AddPosition()  // virtual added that it can be if nedded override
            //can be divided to create position and to add time there
        {



            Console.WriteLine("Give Activity Name");
            string name = Console.ReadLine();
            ACTIVITY k = new ACTIVITY(name); 

            //adding date
            Console.WriteLine("Add new activity Day: in format DD.MM");
            DateTime date;

            string response = Console.ReadLine();

                    while (!DateTime.TryParse(response, out date))   //try to get out 0 value
                        {
                            Console.WriteLine("Please renter date in right forma DD.MM");
                            response = Console.ReadLine();
               
                        }
                    while (response.Contains(":")) //if entered Time format ex 11:45
                        {
                            Console.WriteLine("Please renter date in right forma DD.MM \n (please use . insread of : ) ");
                            response = Console.ReadLine();

                        }
            Console.WriteLine("ok!");

            k._activityDay = date;

            //adding start time

            Console.WriteLine("Add new  Start Time: in format HH:mm ");
            DateTime startTime;

            string response2 = Console.ReadLine();

                        while (!DateTime.TryParse(response2, out startTime)) //try to get out 0 value
                        {
                            Console.WriteLine("Please renter time in right forma HH:mm");
                            response2 = Console.ReadLine();

                        }

                        while (response2.Contains(".")) //if entered Time format ex 11:45
                        {
                            Console.WriteLine("Please renter time in right forma HH:mm \n (please use : insread of . ) ");
                            response2 = Console.ReadLine();

                        }
            Console.WriteLine("ok!");
            k._acticityStartTime = startTime;



            //adding end time

            Console.WriteLine("Add new  End Time: in format HH:mm ");
            DateTime endTime;

            string response3 = Console.ReadLine();

                        while (!DateTime.TryParse(response3, out endTime)) //try to get out 0 value
                        {
                            Console.WriteLine("Please renter time in right forma HH:mm");
                            response3 = Console.ReadLine();

                        }
                        while (response3.Contains(".")) //if entered Time format ex 11:45
                        {
                            Console.WriteLine("Please renter Time in right forma HH:mm \n (please use : insread of . ) ");
                            response3 = Console.ReadLine();

                        }


            Console.WriteLine("ok!");
            k._acticityEndTime= endTime;
            Console.WriteLine();
            Console.WriteLine("New "  + " " + name + " created! " + " at " + k._activityDay.ToShortDateString() + " from- "+ k._acticityStartTime.ToShortTimeString()  + "; to- "+k._acticityEndTime.ToShortTimeString()+";");
            //Console.WriteLine($"Duration is {k._activityDuration};"); //it gives 0
            
               

            ActivitiesList.Add(k);
        }
        //Metod to print all activities

        virtual public void PrintPositions() //PrintActivities

        {
            Console.WriteLine();
            Console.WriteLine("Here is all positions:");
            
            Console.WriteLine();
                foreach (var item in ActivitiesList)
                {
                    Console.WriteLine($"{item._activityID}- {item._activityName}, {item._activityDay.ToShortDateString()} from {item._acticityStartTime.ToShortTimeString()} to {item._acticityEndTime.ToShortTimeString()} .");
                }

            Console.WriteLine();
            Console.ReadLine();

        }

        //Searching in the list by name. Can be added  seach by date and time to check afterwords if time is busy
        public void SearchPositionsByName()  
        {
            Console.WriteLine("Will try to search activity");
            Console.WriteLine("Give activity name:");

            int mom = 0;
            while (mom < 1)
            {
                string positionName = Console.ReadLine();
            foreach (var item in ActivitiesList)
            {
                if (item._activityName == positionName)
                {
                    //founded
                    Console.WriteLine(item._activityName + " founded!");

                    positionName = item._activityName;
                        mom = 2;
                        Console.ReadLine();
                        break;

                 }
             }
                if (mom < 1)

                {
                    Console.WriteLine(positionName + " not founded!");
                    PrintPositions();
                    Console.WriteLine("Give new name:");


                }

            }
        }
        public ACTIVITY SearchPositionsByNameToAddToReservation(string _activityName)
        {
            //Console.WriteLine("Will try to search activity"); //Can be added later
            //Console.WriteLine("Give activity name:");


            string positionName = _activityName;
            
            foreach (var item in ActivitiesList)
                {
                    if (item._activityName == positionName)
                    {
                        //founded
                        Console.WriteLine(item._activityName + " founded!");

                    return item;

                    }
                }
          
            return null;
        }


        }
}
