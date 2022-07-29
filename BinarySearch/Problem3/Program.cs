using System;
namespace Problem3;
class Program
{
    public static void Main(string[] args)
    {

        char []array={'c','a','f','b','k','h','j','l','i','z','t','m','p','l','d' };
        char value='m';
        Array.Sort(array);
        int index=Array.IndexOf(array,value);
        int beg,mid,end;
        BinarySearch(array,value);
        void BinarySearch(char []arr,char val)
        {
            beg=0;
            end=arr.Length-1;
            while(beg<=end)
            {
                mid=(beg+end)/2;
                if(array[mid]==val)
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