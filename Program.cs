// See https://aka.ms/new-console-template for more information
using algorithm_problems.leetcode.Arrays_Hashing;

Console.WriteLine("Hello, World!");

//var strs = new String[] { "eat", "tea", "tan", "ate", "nat", "bat" };

//_49GroupAnagrams groupAnagrams = new _49GroupAnagrams();
//groupAnagrams.GroupAnagrams(strs);

var nums = new int[] { 1, 1, 1, 2, 2, 3 };
var k = 2;
_347TopKFrequentElements topKFrequentElements = new _347TopKFrequentElements();
topKFrequentElements.TopKFrequent(nums, k);

