using Prefixsum;
int[] nums = new int[4] { 2, 3, 0, 5};
PrefixSum product1 = new PrefixSum();
var result = product1.Sum(nums);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}


