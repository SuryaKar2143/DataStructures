using System;
namespace Problem3;
class Program
{
    public static void Main(string[] args)
    {
        //3.Problem
        char []array={'c','a','f','b','k','h','j','l','i','z','t','m','p','l','d' };
        char value='m';//value to search in the array
        int i=0;
        LinearSearch(array,value);
        void LinearSearch(char[]arr,char val)
        {
            while(i<arr.Length)
            {
                if(arr[i]==val)
                {
                    Console.WriteLine("The value is present in the array");
                    Console.WriteLine($"The index value of the element is {i}");
                    break;
                }
                i++;
            }
            if(i==arr.Length)
            {
                Console.WriteLine("The value is not present in the array");
            }
        }
    }
}