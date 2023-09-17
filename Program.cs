// See https://aka.ms/new-console-template for more information
using algorithm_problems.leetcode.Arrays_Hashing;

Console.WriteLine("Hello, World!");

//var strs = new String[] { "eat", "tea", "tan", "ate", "nat", "bat" };

//_49GroupAnagrams groupAnagrams = new _49GroupAnagrams();
//groupAnagrams.GroupAnagrams(strs);

//var nums = new int[] { 1, 1, 1, 2, 2, 3 };
//var k = 2;
//_347TopKFrequentElements topKFrequentElements = new _347TopKFrequentElements();
//topKFrequentElements.TopKFrequent(nums, k);

char[][] board = {
    //new char[ ] {'8','3','.','.','7','.','.','.','.'},
    new char[ ] {'5','3','.','.','7','.','.','.','.'},
    new char[ ] {'6','.','.','1','9','5','.','.','.'},
    new char[ ] {'.','9','8','.','.','.','.','6','.'},
    new char[ ] {'8','.','.','.','6','.','.','.','3'},
    new char[ ] {'4','.','.','8','.','3','.','.','1'},
    new char[ ] {'7','.','.','.','2','.','.','.','6'},
    new char[ ] {'.','6','.','.','.','.','2','8','.'},
    new char[ ] {'.','.','.','4','1','9','.','.','5'},
    new char[ ] {'.','.','.','.','8','.','.','7','9'}
};
_36ValidSudoku validSudoku = new _36ValidSudoku();
validSudoku.IsValidSudoku(board);

