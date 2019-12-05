using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_planner_16._11._2019
{
    class Program
    {
        static void Main(string[] args)

            //Should this database command be on own class as method what you could - so main would be shorter and more readable?




        { //Connecting data base
          // Specify connection options and open an connection
          /*
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;User Id=postgres;" +
                                    "Password=Kuunari77!!Kuunari77!!;Database=planner;");
            conn.Open();

            // Define a query
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.members", conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            // Read all rows and output the first column in each row
            while (dr.Read())
                Console.Write("{0}\n", dr.ToString());

            // Close connection
            conn.Close();
*/
            MainMenu mainMenu1 = new MainMenu();
            string answer=" ";  //just added to check main menu
            mainMenu1.PrintMainMenu(answer);

            //FAMILY myFamily = new FAMILY();        5.12
            //myFamily.AddMember();         5.12
            //myFamily.PrintMembers();      5.12
            // myFamily.AddMember();
            //   myFamily.SearchMember();
            //   myFamily.SearchMember();

            //  myFamily.PrintMembers();
            // Console.ReadLine();
            // myFamily.SearchMember();

            //ADD list of activities

           // ACTIVITTIES_LIST myActivitiesList = new ACTIVITTIES_LIST();

           //myActivitiesList.AddPosition(); //chech date input, it can parse time to date.. tryparse to some format, and print to string.
           // Console.ReadLine();
            
            // myActivitiesList.AddPosition();
           //  Console.ReadLine();
           //myActivitiesList.PrintPositions();
            //Console.ReadLine();
          //  myActivitiesList.SearchPositionsByName();
            

           //  RESERVATIONS_LIST myReservationList = new RESERVATIONS_LIST(myFamily,myActivitiesList);
           // myReservationList.AddPosition();
           //// Console.ReadLine();
           // //   myReservationList.SearchPositionsByName();
           // //  myReservationList.SearchPositionsByName();
           //   Console.ReadLine();
           //// myReservationList.PrintPositions();



        }
    }
}
