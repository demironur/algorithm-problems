namespace algorithm_problems.leetcode
{
    public class _1TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var numsDic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (numsDic.ContainsKey(diff))
                    return new int[] { i, numsDic[diff] };

                numsDic[nums[i]] = i;
            }

            return null;
        }
    }
}
