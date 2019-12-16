using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_planner_16._11._2019
{
    class MainMenu
    {
        public string answer{ get; set; }

        // public MainMenu(string _answer)
        public MainMenu()
        {
          //_answer = answer;
              
        }

        public void PrintMainMenu(string _answer)

        {
            FAMILY myFamily = new FAMILY();
            ACTIVITTIES_LIST myActivitiesList = new ACTIVITTIES_LIST();
            RESERVATIONS_LIST myReservationList = new RESERVATIONS_LIST(myFamily, myActivitiesList);
            
            int numberAnswer;
             //trycach

            do

                {
                
                Console.Clear();
                Console.WriteLine("WELCOME TO FAMILY PLANNER ver 2.1");
                Console.WriteLine();
                Console.WriteLine("MAIN MENU");
                Console.WriteLine();
                Console.WriteLine("13-Activate data for test");
                Console.WriteLine();
                Console.WriteLine("1-Add new member");
                Console.WriteLine("2-Add new activity");
                Console.WriteLine("3-Add new reservation");
                Console.WriteLine();
                Console.WriteLine("4-Print member list");
                Console.WriteLine("5-Print activity list");
                Console.WriteLine("6-Print reservation list");
                Console.WriteLine();
                Console.WriteLine("7-Search member");
                Console.WriteLine("8-Search activity");
                Console.WriteLine("9-Search reservation");
                Console.WriteLine();
                //RESERVE
                //Console.WriteLine("10-DELETE family/member ");
                //Console.WriteLine("11-DELETE activity ");
                //Console.WriteLine("12-DELETE reservation ");

               // Console.WriteLine("13-Activate data for test");

                Console.WriteLine();
                Console.WriteLine("0-Stop");
                Console.WriteLine();
                Console.WriteLine("Choose from main menu");
                string answer = Console.ReadLine();

                //need to pick up from main menu // ADD  try catch exeption
                while (!int.TryParse(answer, out numberAnswer) )
                {
                    Console.WriteLine("Please renter Main Menu number");
                    answer=Console.ReadLine();

                }

                while (numberAnswer < 0)
                {
                    Console.WriteLine("Please renter Main Menu number, give positive number");
                    answer = Console.ReadLine();

                    while (!int.TryParse(answer, out numberAnswer))
                    {
                        Console.WriteLine("Please renter Main Menu number");
                        answer = Console.ReadLine();

                    }

                }


                switch (numberAnswer)


                    {
                        case 1:
                            Console.WriteLine("Adding new member"); // asked here methods from 
                            myFamily.AddMember();
                            break;


                        case 2:
                            Console.WriteLine("Adding new activity"); // asked here methods from 
                            myActivitiesList.AddPosition();

                            break;

                        case 3:
                            Console.WriteLine("Adding new reservaton"); // asked here methods from 
                            myReservationList.AddPosition();

                            break;

                        case 4:
                            Console.WriteLine("Print member list"); //Printing all data from list

                            myFamily.PrintMembers();

                            break;
                        case 5:
                            Console.WriteLine("Print activity list"); // Printing all data from list

                            myActivitiesList.PrintPositions();
                            break;
                        case 6:
                            Console.WriteLine("Print reservation list"); // Printing all data from list

                            myReservationList.PrintPositions();
                            Console.ReadLine();

                            break;
                        case 7:
                            Console.WriteLine("Search member"); // asked here methods from 

                            myFamily.SearchMember();

                            break;
                        case 8:
                            Console.WriteLine("Search activity"); // asked here methods from 
                            myActivitiesList.SearchPositionsByName();

                            break;
                        case 9:
                            Console.WriteLine("Search reservation"); // asked here methods from 
                            myReservationList.SearchPositionsByName();

                            break;
                        //RESERVE
                        //case 10:
                        //    Console.WriteLine(""); // asked here methods from 


                        //    break;
                        //case 11:
                        //    Console.WriteLine(""); // asked here methods from 


                        //    break;
                        //case 12:
                        //    Console.WriteLine(""); // asked here methods from 


                        //    break;

                        case 13:
                            Console.WriteLine("Activating data for test"); // Adding dates for test
                            myFamily.AddMemberForTests();
                            myActivitiesList.AddPositionForTest();
                            myReservationList.AddPositionForTest();
                            Console.WriteLine("Data have been activated");
                            Console.ReadLine();
                            break;
                        case 0:
                            Console.WriteLine("STOP"); // asked here methods from 
                             Console.ReadLine();


                            break;
                    }
                



               
            } while (numberAnswer > 0);

        }
    }
}
