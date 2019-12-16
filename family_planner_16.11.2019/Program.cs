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
            string answer=" ";  // added just to check main menu
            mainMenu1.PrintMainMenu(answer);

           



        }
    }
}
