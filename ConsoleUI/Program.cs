using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string workedCompany;
            int i;
            double timeWorked, totalTimeLogged;;
            List<TimeSheetEntry> entryLists = new List<TimeSheetEntry>();
            Console.Write("Enter what you did: ");
            workedCompany = Console.ReadLine();
            Console.Write("How long did you do it for: ");
            bool temp=double.TryParse(Console.ReadLine(),out timeWorked);
            while(!temp)
            {
                System.Console.WriteLine("Invalid Input");
                temp=double.TryParse(Console.ReadLine(),out timeWorked);
            }
           // timeWorked = int.Parse(Console.ReadLine());
            TimeSheetEntry entry = new TimeSheetEntry();
            entry.HoursWorked = timeWorked;
            entry.WorkDone = workedCompany;
            entryLists.Add(entry);
            Console.Write("Do you want to enter more time:");
            string choice =Console.ReadLine();
            while (choice == "yes")
            {
                Console.Write("Enter what you did: ");
                workedCompany = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                //timeWorked = int.Parse(Console.ReadLine());
                temp=double.TryParse(Console.ReadLine(),out timeWorked);
                while(!temp)
                {
                System.Console.WriteLine("Invalid Input");
                temp=double.TryParse(Console.ReadLine(),out timeWorked);
                 }
                entry=new TimeSheetEntry();
                entry.HoursWorked = timeWorked;
                entry.WorkDone = workedCompany;
                entryLists.Add(entry);
                Console.Write("Do you want to enter more time:");
                choice = Console.ReadLine().ToLower();
            } 
            totalTimeLogged = 0;
            for (i = 0; i < entryLists.Count; i++)
            {
                if (entryLists[i].WorkDone.Contains("Acme"))
                {
                    totalTimeLogged += entryLists[i].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + totalTimeLogged * 150 + " for the hours worked.");
            totalTimeLogged=0;
            for (i = 0; i < entryLists.Count; i++)
            {
                if (entryLists[i].WorkDone.Contains("ABC"))
                {
                    totalTimeLogged += entryLists[i].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + totalTimeLogged * 125 + " for the hours worked.");
            totalTimeLogged=0;
            for (i = 0; i < entryLists.Count; i++)
            {
                totalTimeLogged += entryLists[i].HoursWorked;
            }
            if (totalTimeLogged > 40)
            {
                Console.WriteLine("You will get paid $" + (((totalTimeLogged-40) * 15)+(40*10) )+ " for your work.");
            }
            else
            {
                Console.WriteLine("You will get paid $" + totalTimeLogged * 10 + " for your time.");
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public double HoursWorked;
    }
}
