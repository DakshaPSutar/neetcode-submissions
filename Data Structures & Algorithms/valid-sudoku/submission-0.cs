public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char> inp = new HashSet<char>();
            for (int row = 0; row < 9; row++)
            {
                HashSet<char> rowSet = new HashSet<char>();
                for(int i=0; i < 9; i++)
                {
                    if (rowSet.Contains(board[row][i]))
                    {
                        return false;
                    }

                    if (board[row][i] != '.')
                    {
                        rowSet.Add(board[row][i]);
                    }
                }
            }


            for (int col = 0; col < 9; col++)
            {
                HashSet<char> colSet = new HashSet<char>();
                for (int i = 0; i < 9; i++)
                {
                    if (colSet.Contains(board[i][col]))
                    {
                        return false;
                    }

                    if (board[i][col] != '.')
                    {
                        colSet.Add(board[i][col]);
                    }
                }
            }


            for (int col = 0; col < 9; col++)
            {
                HashSet<char> colSet = new HashSet<char>();
                for (int i = 0; i < 9; i++)
                {
                    if (colSet.Contains(board[i][col]))
                    {
                        return false;
                    }

                    if (board[i][col] != '.')
                    {
                        colSet.Add(board[i][col]);
                    }
                }
            }

            for (int square = 0; square < 9; square++)
            {
                HashSet<char> seen = new HashSet<char>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int row = (square / 3) * 3 + i;
                        int col = (square % 3) * 3 + j;
                        if (board[row][col] == '.') continue;
                        if (seen.Contains(board[row][col])) return false;
                        seen.Add(board[row][col]);
                    }
                }
            }

            return true;


        
        
    }
}
