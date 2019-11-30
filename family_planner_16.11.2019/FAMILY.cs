using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_planner_16._11._2019
{
    class FAMILY
    {
        //Class Family is kind of list of members
        public List<MEMBER> FamilyList = new List<MEMBER>();// family created as a list of members

        //copied from Member
        public int _memberIDFamily { get; set; }
        public string _memberNameFamily { get; set; }

        public int _memberAgeFamily { get; set; }  // later age can be change to date of bith
        public bool _isitAdultFamily { get; set; }
        

        //test method to get values from search

        public FAMILY() // ctr
        {
            //AddMember();
        }

      

        public void AddMember()
        {
           
           

            Console.WriteLine("Give Member Name");
            string name =Console.ReadLine();
            MEMBER k = new MEMBER(name); //Maat[i] pick up i 
                                         //getting member id

            Console.WriteLine("Give Member Age");
            int age;
            string response = Console.ReadLine();

            while (!int.TryParse(response, out age)) //try to get out 0 value
              {
               Console.WriteLine("Please renter member age");
               response = Console.ReadLine();

              }
              Console.WriteLine("ok!");

            k._memberAge = age;
            //cheking if member is an Adult

            Console.WriteLine();
            Console.WriteLine("New Member " +name+  "! " + name+" is " +k._memberAge+  " years old. Member id is " + k._memberID + ".");
            Console.WriteLine();
            if (age > 15)
            {
                k._isitAdult = true;
                Console.WriteLine("Member is an Adult");
            }
            else
            {
                k._isitAdult = false;
                Console.WriteLine("Member is a Kid");
            }

            //giving same date to this class
            _memberIDFamily = k._memberID;
            _memberNameFamily = k._memberName;
            _memberNameFamily = k._memberName;
            _isitAdultFamily = k._isitAdult;


            FamilyList.Add(k);

        }

        public void PrintMembers()

        {
            Console.WriteLine();
            Console.WriteLine("Here is all members");
            Console.WriteLine();
            foreach (var item in FamilyList)
            {
                Console.WriteLine($"{item._memberID}. {item._memberName}, {item._memberAge} yers old.");
            }
        
        
        }

        //This SearchMemer metod can ve changed later
        public void SearchMember()   //try cach or like this New PARAMETS public void SearchMember(string _memberName)
        {
            Console.WriteLine("Will try to search member");
            Console.WriteLine("Give member name:");
            int mom = 0;
            while (mom<1)
            { 
            string searchMemberName = Console.ReadLine();
                foreach (var item in FamilyList)
                {
                    if (item._memberName == searchMemberName)
                    {
                       
                        // founded
                        Console.WriteLine(item._memberName + " founded!");
                        //print out age?

                        searchMemberName = item._memberName;
                       

                           mom = 2;
                        //added 19.11.2019 to check if can be called from another class

                        _memberIDFamily = item._memberID;
                        _memberNameFamily = item._memberName;
                        _memberNameFamily = item._memberName;
                        _isitAdultFamily = item._isitAdult;
                        break;
                    }
                }

                if (mom<1)

                {
                    Console.WriteLine();
                    Console.WriteLine(searchMemberName + " not founded! \nALL members:\n  "); //founded need to stop
                    
                    PrintMembers();
                    Console.WriteLine("Give member name:");

                }
                                    
               
             }
        }
        public MEMBER SearchMembeAddToResevation(string _memberName)//Search if member Loyty //VOID changed to MEMBER
        {             
                string searchMemberName = _memberName; 
                foreach (var item in FamilyList)
                {
                    if (item._memberName == searchMemberName)
                    {

                        Console.WriteLine(item._memberName + " founded!");
                                      
                         return item;

                                             
                    }
                }
                Console.WriteLine("Name not founded, try again, give member Name");
                return null;
        }

    }


}
        
    

