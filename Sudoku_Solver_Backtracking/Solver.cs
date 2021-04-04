using System;
using System.Collections.Generic;

namespace Sudoku_Solver_Backtracking
{
    public static class Solver
    {
        public static bool SolveSudoku(List<List<int>> sudoku)
        {
            Tuple<int, int> rowAndCol;
            rowAndCol = findNextEmpty(sudoku);

            if (rowAndCol.Item1 == -1)
            {
                printSudoku(sudoku);
                return true;
            }

            for (int guess = 1; guess < 10; guess++)
            {
                if (guessIsValid(sudoku, guess, rowAndCol))
                {
                    sudoku[rowAndCol.Item1][rowAndCol.Item2] = guess;
                    if (SolveSudoku(sudoku))
                    {
                        return true;
                    }
                }

                sudoku[rowAndCol.Item1][rowAndCol.Item2] = 0;
            }

            return false;
        }

        private static void printSudoku(List<List<int>> sudoku)
        {
            for (int row = 0; row < 9; row++)
            {
                string text = "";
                for (int col = 0; col < 9; col++)
                {
                    text = text + sudoku[row][col] + " ";
                }

                Console.WriteLine(text);
            }
        }

        private static Tuple<int, int> findNextEmpty(List<List<int>> sudoku)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (sudoku[row][col] == 0)
                    {
                        return new Tuple<int, int>(row, col);
                    }
                }
            }

            return new Tuple<int, int>(-1, -1);
        }

        private static bool guessIsValid(List<List<int>> sudoku, int guess, Tuple<int, int> rowAndCol)
        {
            List<int> rowValues = sudoku[rowAndCol.Item1];
            if (rowValues.Contains(guess))
            {
                return false;
            }

            List<int> columnValues = new List<int>();
            for (int row = 0; row < 9; row++)
            {
                columnValues.Add(sudoku[row][rowAndCol.Item2]);
            }
            if (columnValues.Contains(guess))
            {
                return false;
            }

            int rowStart = (rowAndCol.Item1 / 3) * 3;
            int colStart = (rowAndCol.Item2 / 3) * 3;
            for (int r = rowStart; r < rowStart + 3; r++)
            {
                for (int c = colStart; c < colStart + 3; c++)
                {
                    if (guess == sudoku[r][c])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
