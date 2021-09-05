using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP_Object_Approach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Please Enter Your ID Number :");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("===============================================================");
            Console.WriteLine();
            Console.Write("Please Enter Your Name :");
            string Name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("===============================================================");
            Console.WriteLine();
            Console.Write("Please Enter Your DateOfBirth :");
            string DateOfBirth = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("===============================================================");
            Console.WriteLine();
            Console.Write("You have the following designations: \n HeadMaster => 1,\n AssistanceHeadMaster => 2,\n AssistanceTeacher => 3, \n Teacher => 4\nEnter option: ");
            Designation d = (Designation)int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("===============================================================");
            Console.WriteLine();
            Console.Write("Please Enter Your JoinDate :");
            string JoinDate = Console.ReadLine();

            Console.WriteLine("\n==========OUTPUT==========");
            Console.WriteLine("ID: "+ID);
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Date of birth: "+DateOfBirth);
            Console.WriteLine("Designation: "+d);
            Console.WriteLine("Join Date: "+JoinDate);
            Console.ReadKey();
        }
        
    }
}
