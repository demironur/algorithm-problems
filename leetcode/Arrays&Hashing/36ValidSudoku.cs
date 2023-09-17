namespace algorithm_problems.leetcode.Arrays_Hashing
{
    public class _36ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            List<HashSet<char>> columnHash = new List<HashSet<char>>();
            List<HashSet<char>> rowHash = new List<HashSet<char>>();
            List<HashSet<char>> squareHash = new List<HashSet<char>>();

            for (int i = 0; i < board.Length; i++)
            {
                columnHash.Add(new HashSet<char>());
                rowHash.Add(new HashSet<char>());
                squareHash.Add(new HashSet<char>());
                //columnHash[i] = new HashSet<char>() { '0'};
                //rowHash[i] = new HashSet<char>() { '0' };
                //squareHash[i] = new HashSet<char>() { '0' };
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    char cell = board[i][j];

                    if (cell == '.')
                        continue;
                    int sIndex= 3 * (i/3) + j/3;

                    if (columnHash[i].Contains(cell) || rowHash[j].Contains(cell) || squareHash[sIndex].Contains(cell))
                    {
                        return false;
                    }
                    else
                    {
                        columnHash[i].Add(cell);
                        rowHash[j].Add(cell);
                        squareHash[sIndex].Add(cell);
                    }
                }
            }

            return true;
        }
    }
}
