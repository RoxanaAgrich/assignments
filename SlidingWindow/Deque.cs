using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindow
{
    public class Deque
    {
        public Array[] WindowSliding(int[] nums ,int k)
        {
            int n = nums.Length;
            int index = 0;
            int[] arr = new int[n];
            for ( int i=0; i<n; i++)
            {
                for  (int j=i; j < k; j++)
                {
                    int max = nums[j];
                    if (arr[j]> nums[max])
                    {
                        arr[max] = arr[i];
                    }
                    arr[index++]= arr[max];
                }
            }

            return arr;
        } 
    }
}
