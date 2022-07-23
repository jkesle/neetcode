using System;
using System.Linq;

namespace neetcode.ArraysAndHashing.ValidSudoku
{
    public class Solution
    {
        private Dictionary<int, HashSet<char>> rowSets = new Dictionary<int, HashSet<char>>();
        private Dictionary<int, HashSet<char>> colSets = new Dictionary<int, HashSet<char>>();
        private Dictionary<string, HashSet<char>> subSquareSets = new Dictionary<string, HashSet<char>>();

        public bool ValidSudoku(char[][] board)
        {
            InitMaps(ref rowSets, ref colSets, ref subSquareSets);

            for (var i = 0; i < 9; i++)
            {
                for (var j = 0; j < 9; j++)
                {
                    var c = board[i][j];
                    if (c == '.')
                    {
                        continue;
                    }

                    if (!rowSets[i].Add(c) || !colSets[j].Add(c) || !subSquareSets[$"{(int)i/3}{(int)j/3}"].Add(c))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void InitMaps(ref Dictionary<int, HashSet<char>> rowMap, ref Dictionary<int, HashSet<char>> colMap, ref Dictionary<string, HashSet<char>> squareMap)
        {
            for (var i = 0; i < 9; i++)
            {
                rowMap.Add(i, new HashSet<char>());
                colMap.Add(i, new HashSet<char>());
                squareMap.Add($"{(int)i / 3}{i % 3}", new HashSet<char>());
            }
        }

    }
}
// Time: 73%, Space: 59%