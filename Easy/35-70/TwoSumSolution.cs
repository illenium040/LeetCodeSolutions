namespace LeetCodeSolutions.Easy._35_70
{
    /// <summary>
    /// Submission result
    //  Runtime  |  Memory | % best
    //  452 ms   |  29 MB  | 11
    /// </summary>
    class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return null;
        }
    }
}
