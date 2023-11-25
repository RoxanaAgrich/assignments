namespace Prefixsum
{
    public class PrefixSum
    {
        public int[] Sum(int[] nums)
        {
            int length = nums.Length;
            int[] left = new int[length];
            left[0] = 1;
            int[] right = new int[length];
            right[length-1] = 1;
            int[] product = new int[length];
            for (int i = 1 ; i < length; i++)
            {
                left[i] = nums[i-1] * left[i - 1];
            }
            for (int i = length - 2; i > -1; i--)
            {
                right[i] = nums[i+1] * right[i +1];
            }
            for (int i = 0; i < length; i++)
            {
                product[i] = left[i ] * right[i ];
            }
            return product;
        }
    }
}
