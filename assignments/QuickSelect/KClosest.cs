using System;
namespace assignments.QuickSelect
{

    public class Solution
    {
        readonly Random rand = new Random();
        public Solution()
        {
            Random rand = new Random();
        }
        public int[][] KClosest(int[][] points, int k)
        {
            int n = points.Length;
            int[] Distance = new int[n];
            for (int i = 0; i < n; i++)
            {
                Distance[i] = Calculate(points[i]);
            }
            Sortvalue(Distance, 0, n);
            int y = 0;
            int[][] Array = new int[k][];
            for (int i = 0; i < n; i++)
            {
                if (Calculate(points[i]) < Distance[k - 1])
                {
                    Array[y++] = points[i];
                }
            }
            return Array;

        }
        private int Sortvalue(int[] distance, int left, int right)
        {
            int pivotIndex = rand.Next(left, right);
            pivotIndex = Partition(distance, left, right, pivotIndex);
            if (right == left)
            {
                return 0;
            }
            if (pivotIndex < right)
            {
                return Sortvalue(distance, pivotIndex + 1, right);
            }
            else if (pivotIndex > left)
            {
                return Sortvalue(distance, 0, pivotIndex - 1);
            }
            return 0;
        }
        private int Partition(int[] distance, int right, int left, int pivotIndex)
        {
            int j = left;
            Swap(distance, pivotIndex, right);
            for (int i = 0; i < right; i++)
            {
                if (distance[i] < distance[right])
                {
                    Swap(distance, i, j++);
                }
            }
            return j;
        }
        private void Swap(int[] distance, int a, int b)
        {
            int swap = distance[a];
            distance[a] = distance[b];
            distance[b] = swap;
        }
        private int Calculate(int[] points)
        {
            return points[0] * points[0] + points[1] * points[1];
        }


    }

}