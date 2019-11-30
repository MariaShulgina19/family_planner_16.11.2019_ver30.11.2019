using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_planner_16._11._2019
{
    class COMMENTS
    {
        /*
         1. Class Reservation perintaa class Activities:Activities can be abstract class(may be no cuz here is lists)
         2. Checking if name already exists
         public string Name
{
get { return _name + "-kissa"; }
set {
if ( value.Equals("Musti"))
{
throw new ArgumentException("Invalid name!");
}
_name = value;
}
}



         /*linking member to reservation, need to seach member from family.list
            FAMILY testFamily = new FAMILY();

        //try search

        testFamily.PrintMembers(); //could not print directly all members

            Console.WriteLine("Give member name:");
            int mom = 0;
            while (mom<1)
            { 
            string searchMemberName = Console.ReadLine();

               
                foreach (var item in testFamily.FamilyList)
                {
                    if (item._memberName == searchMemberName)
                    {
                       
                        // founded
                        Console.WriteLine(item._memberName + " founded!");
                        //print out age?

                        searchMemberName = item._memberName;
                        searchMemberName = k._reservationMemberName;
                        
                         mom = 2;
                       break;
                    }
}

                if (mom<1)

                {
                    Console.WriteLine();
                    Console.WriteLine(searchMemberName + " not founded! \nALL members:\n  "); //founded need to stop
                    testFamily.PrintMembers();
                    Console.WriteLine("Give member name:");

                }
                                    
               
             }

       

    /*FROM RESERVATION_LIST
            //SearchPositionsByName();instead of real search
            

            //adding date from activities
            Console.WriteLine("Give Activity Name");
            //search in activity_list and giving date to reservdates and so on
            string responseActivityName = Console.ReadLine();
int lon = 0;
             while (lon > 0) 
                {
              

                foreach (var item in ActivitiesList)
                    if (item._activityName == responseActivityName)
                    {
                        //founded
                        Console.WriteLine(item._activityName + " founded!");

                        responseActivityName = item._activityName;
                        lon = 1;
                        k._activityName= item._activityName;
                        k._activityDay = item._activityDay;
                        k._acticityStartTime = item._acticityStartTime;
                        k._acticityEndTime = item._acticityEndTime;

                        //add all date from activity to reservation
                    }
                    else
                    {
                        Console.WriteLine(responseActivityName + " not founded!");
                        Console.WriteLine("here is all activities names");
                        PrintPositions();
Console.WriteLine("Give Activity Name"); //some way to come out from loop in do not remeber activity names

                    }
                }


            



            Console.WriteLine();
            Console.WriteLine("New " + k.GiveClassName() + " " + name + " created! " + " at " + k._activityDay.ToShortDateString() + " from- " + k._acticityStartTime.ToShortTimeString() + "; to- " + k._acticityEndTime.ToShortTimeString() + ";");
            //Console.WriteLine($"Duration is {k._activityDuration};"); //it gives 0


            ResevationList.Add(k);
            */


          
    }
}
