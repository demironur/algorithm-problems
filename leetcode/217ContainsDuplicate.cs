namespace algorithm_problems.leetcode
{
    public class _217ContainsDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> numsHash = new HashSet<int>();

            foreach (var item in nums)
            {
                if (numsHash.Contains(item))
                    return true;
                else
                    numsHash.Add(item);
            }

            return false;
        }
    }
}
