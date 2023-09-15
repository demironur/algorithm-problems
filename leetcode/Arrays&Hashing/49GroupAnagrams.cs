namespace algorithm_problems.leetcode.Arrays_Hashing
{
    public class _49GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var groupedStrings = new Dictionary<string, IList<string>>() { };

            for (int i = 0; i < strs.Length; i++)
            {
                var key = Core.GetStringHashKey(strs[i]);

                if (!groupedStrings.ContainsKey(key))
                    groupedStrings.Add(key, new List<string>() { strs[i] });
                else
                    groupedStrings[key].Add(strs[i]);
            }

            return groupedStrings.Values.ToList();
        }
    }
}
