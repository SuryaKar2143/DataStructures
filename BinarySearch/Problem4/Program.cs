using System;
namespace Problem4;
class Program
{
    public static void Main(string[] args)
    {
        
        
        double []array={1.1,65.3,93.9,55.5,3.5,6.9 };
        Array.Sort(array);
        double value=3.5;
        int index=Array.IndexOf(array,value);
        int beg,mid,end;
        BinarySearch(array,value);
        void BinarySearch(double [] arr,double val)
        {
            beg=0;
            end=arr.Length-1;
            while(beg<=end)
            {
                mid=(beg+end)/2;
                if(arr[mid]==val)
                {
                    Console.WriteLine("The value is present");
                    Console.WriteLine($"The index value of the array is {mid}");
                    break;
                }
                else
                {
                    if(index<mid)
                    {
                    end=mid-1;
                    continue; 
                    }
                    else if(index>mid)
                    {
                        beg=mid+1;
                        continue;
                    }
                }
                if(index==-1|| beg>end)
                {
                    Console.WriteLine("The value is not present in the array");
                }
            }
        }
    }
}