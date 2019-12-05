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
            Console.WriteLine("test");

            Console.WriteLine("WELCOME TO FAMILY PLANNER ver 2.1");
            Console.WriteLine();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine();
            Console.WriteLine("1-Add new member");
            Console.WriteLine("2-Add new activity");
            Console.WriteLine("3-Add new reservationt");
            Console.WriteLine();
            Console.WriteLine("4-Print member list");
            Console.WriteLine("5-Print activity list");
            Console.WriteLine("6-Print reservation list");
            Console.WriteLine();
            Console.WriteLine("7-Search member");
            Console.WriteLine("8-Search activity");
            Console.WriteLine("9-Search reservation");
            Console.WriteLine();
            Console.WriteLine("10-Print family/member list");
            Console.WriteLine("11-Print activity list");
            Console.WriteLine("12-Print reservation list");

            Console.WriteLine();
            Console.WriteLine("0-Stop");
            Console.WriteLine();
            int numberAnswer;

                do

                {
                Console.WriteLine("Choose from main menu");
                    numberAnswer = int.Parse(Console.ReadLine());//need to pick up from main menu
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
            }
            } while (numberAnswer > 0);

        }
    }
}
