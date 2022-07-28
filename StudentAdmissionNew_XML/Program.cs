using System;
using System.IO;

namespace StudentAdmissionNew;
class program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFile();
        //Operation.DefaultMethod();
        Operation.MainMenu();
        Files.WriteToFile();
        
    }  
}