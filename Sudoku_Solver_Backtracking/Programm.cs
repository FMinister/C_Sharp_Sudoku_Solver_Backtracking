using System;
using System.Collections.Generic;

namespace Sudoku_Solver_Backtracking
{
    public static class Programm
    {
        public static void Main()
        {
            List<List<int>> sudoku = new List<List<int>>();
            sudoku.Add(new List<int> { 5, 0, 1, 0, 7, 0, 3, 9, 0 });
            sudoku.Add(new List<int> { 3, 0, 0, 1, 0, 0, 2, 0, 0 });
            sudoku.Add(new List<int> { 0, 0, 2, 6, 5, 0, 0, 7, 1 });
            sudoku.Add(new List<int> { 1, 6, 4, 9, 3, 0, 0, 0, 0 });
            sudoku.Add(new List<int> { 0, 0, 0, 4, 0, 0, 0, 1, 0 });
            sudoku.Add(new List<int> { 0, 0, 0, 0, 6, 1, 0, 3, 0 });
            sudoku.Add(new List<int> { 0, 3, 0, 0, 0, 4, 9, 0, 8 });
            sudoku.Add(new List<int> { 0, 0, 5, 0, 0, 8, 1, 4, 3 });
            sudoku.Add(new List<int> { 0, 1, 8, 0, 0, 0, 5, 2, 0 });

            bool solved = Solver.SolveSudoku(sudoku);

            Console.WriteLine(solved);
        }
    }
}
