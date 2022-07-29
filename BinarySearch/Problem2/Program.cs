using System;
namespace Problem2;
class Program
{
    public static void Main(string[] args)
    {
        string []array={"SF3023","SF3021","SF3067","SF3043","SF3053","SF3032","SF3063","SF3089","SF3062","SF3092"};
        string value="SF3067";
        Array.Sort(array);
        int index=Array.IndexOf(array,value);
        int beg,mid,end;
        BinarySearch(array,value);
        void BinarySearch(string []arr,string val)
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