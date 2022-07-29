using System;
namespace Problem2;
class Program
{
    public static void Main(string[] args)
    {
        //2.Problem
        string [] array={"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063","SF3089","SF3062","SF3092"};
        string value="SF3067";//The value to search in the array
        int i=0;
        LinearSearch(array,value);
        void LinearSearch(string[]arr,string val)
        {
            while(i<arr.Length)
            {
                if(arr[i]==val)
                {
                    Console.WriteLine("The value is present in the array");
                    Console.WriteLine($"The index value of the element is {i}");
                    break;
                }i++;
            } 
            if(i==arr.Length)
            {
                Console.WriteLine("The value is not present in the array");
            }
        }
    
    }
}