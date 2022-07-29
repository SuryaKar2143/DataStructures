using System;
namespace Problem1;
class Program
{
    public static void Main(string[] args)
    {
        //Linear Search Program
        //1.Problem
        int []array={45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        //The value to search in the array
        int value= 66,i=0;
        LinearSearch(array,value);
        void LinearSearch(int []arr,int val)
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
                Console.WriteLine("The value is not found in the list");
            }
        }
    }
}