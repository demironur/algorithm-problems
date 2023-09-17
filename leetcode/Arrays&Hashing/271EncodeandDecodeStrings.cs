namespace algorithm_problems.leetcode.Arrays_Hashing
{
    //https://www.lintcode.com/problem/659/
    public class _271EncodeandDecodeStrings
    {
        public string encode(List<string> strs)
        {
            return string.Concat(strs.SelectMany(s => $"{s.Length}#{s}"));
        }

        public List<string> decode(string str)
        {
            List<string> result = new();
            bool eol = false;
            string text = String.Empty;
            //result = str.Split('☼').ToList();

            foreach (var i in str)
            {
                if (i == ';' && eol)
                {
                    result.Add(text);
                    text = String.Empty;
                    eol = false;
                }
                else
                {
                    text += i;
                    eol = true;
                }
            }

            return result;
        }
    }
}