namespace algorithm_problems.leetcode
{
    public static class Core
    {
        public static string GetStringHashKey(string s)
        {
            var key = new char[26];
            foreach (var letter in s)
                key[letter - 'a']++;
            return new string(key);
        }
    }
}
