using System;

namespace SudokuSolver {
  class Program {
    static void Main(string[] args) {
      int?[,] initialBoard = new int?[,] {
        { null,  7  , null,    9  , null,  4  ,    3  , null,  1   },
        { null,  3  , null,   null,  5  ,  7  ,   null, null, null },
        { null, null,  9  ,    6  ,  1  , null,   null,  8  , null },

        {  1  , null, null,   null,  3  ,  2  ,    9  , null,  6   },
        { null, null,  6  ,   null,  4  ,  5  ,    1  , null,  8   },
        {  2  ,  8  ,  4  ,   null, null, null,   null,  7  , null },

        {  4  , null,  5  ,   null,  7  ,  8  ,   null, null,  2   },
        { null, null,  3  ,   null, null, null,   null, null, null },
        {  9  , null, null,    5  ,  6  ,  1  ,    7  , null,  4   }
      };

      SudokuBoard board = new SudokuBoard(initialBoard);

      bool solved = SudokuSolver.Solve(board);
      Console.Write("This Sudoku is ... ");
      Console.WriteLine($"{(solved ? "SOLVED" : "UNSOLVABLE")}");
    }
  }
}
