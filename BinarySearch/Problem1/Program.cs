using System;
namespace Problem1;
class Program
{
    public static void Main(string[] args)
    {
        
        
        int []array={45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        int value=66;
        int k;
        Array.Sort(array);
        int beg,mid,end;
        BinarySearch(array,value);
        void BinarySearch(int []arr,int val)
        {
            beg=arr[0];
            end=arr[arr.Length-1];
            while(beg<=end)
            {
                mid=(beg+end)/2;
                if(mid==val)
                {
                    Console.WriteLine("The value is found ");
                    for(k=0;k<arr.Length;k++)
                    {
                        if(arr[k]==mid)
                        {
                            Console.WriteLine($"The index value of the element is {k}");

                            break;
                        }
                    }break;
                }
                else
                {
                    if(val<mid)
                    {
                        end=end-1;
                        continue;
                    }
                    else if(val>mid)
                    {
                        beg=mid+1;
                        continue;
                    }
                }
            }
            if(beg>end)
            {
                Console.WriteLine("The value is not present in the array");
            }
        } 
    }
}