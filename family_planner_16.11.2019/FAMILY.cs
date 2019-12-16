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

        public void AddMemberForTests() //this dates is for Test only  and it can be activates from Main menu pressing 13
        {

        MEMBER forTest1 = new MEMBER("Maria");
           
            forTest1._memberAge = 35;
            forTest1._isitAdult = true;
            FamilyList.Add(forTest1);

        MEMBER forTest2 = new MEMBER("Robinson");
           
            forTest2._memberAge = 4;
            forTest2._isitAdult = false;
            
            FamilyList.Add(forTest2);
        }
      

        public void AddMember() //Adding member from Console
        {

            Console.WriteLine("Give Member Name");
            string name = Console.ReadLine();
            
            while (string.IsNullOrEmpty(name)) //checking if name is not 0 string.IsNullOrEmpty(name)
            {
                Console.WriteLine("Give Member Name again"); //checking if 0
                name = Console.ReadLine();

                
            }

            MEMBER k = new MEMBER(name);
            Console.WriteLine("Give Member Age");
            int age;
            string response = Console.ReadLine();

            while (!int.TryParse(response, out age)) //try to get out 0 value
              {
               Console.WriteLine("Please renter member age");
               response = Console.ReadLine();

              }
              Console.WriteLine("ok!");
            while (age < 0)
            {
                Console.WriteLine("Please renter age, give positive number");
                response = Console.ReadLine();

                while (!int.TryParse(response, out age))
                {
                    Console.WriteLine("Please renter Main Menu number");
                    response = Console.ReadLine();

                }

            }

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
            _isitAdultFamily = k._isitAdult;


            FamilyList.Add(k);

        }

        public void PrintMembers()

        {
            Console.WriteLine();
            Console.WriteLine("There are all members:");
            Console.WriteLine();
            
            foreach (var item in FamilyList)
            {
                Console.WriteLine($"{item._memberID}. {item._memberName}, {item._memberAge} years old.");
            }
            Console.ReadLine();
        
        }
        
        //This method need to change later !
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
                        Console.ReadLine();
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
        public MEMBER SearchMembeAddToResevation(string _memberName)//Search if member founded //VOID changed to MEMBER
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
        
    

