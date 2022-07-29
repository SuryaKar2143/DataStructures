using System;
namespace Problem4;
class Program
{
    public static void Main(string[] args)
    {
        //4.Problem
        double[]array={1.1,65.3,93.9,55.5,3.5,6.9 };
        double value=3.5;//value to search in the array
        int i=0;
        LinearSearch(array,value);
        void LinearSearch(double []arr,double val)
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