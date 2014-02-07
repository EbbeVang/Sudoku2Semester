using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    //changed by filip
    // dear teacher couldn't this be much better?
    class Program
    {
        static void Main(string[] args)
        {
            SudokuGame.Game s = new SudokuGame.Game();
            s.Load();

            s.sudoku.AddNumbers(0, 0, 1); //x,y,value;
            s.sudoku.AddNumbers(1, 0, 2); 
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(s.sudoku.Numbers[i, j]);
                }

                Console.WriteLine();
            }

          // costa

            Console.WriteLine("get[1,0]: " + s.sudoku.GetNumber(1, 0));

            Console.WriteLine("testing validation");
            Console.WriteLine("#6 in row0: " + s.sudoku.IsInRow(0,6));
            Console.WriteLine("#6 in row1: " + s.sudoku.IsInRow(1,6));
            Console.WriteLine("#6 in row2: " + s.sudoku.IsInRow(2,6));
            Console.WriteLine("#6 in row3: " + s.sudoku.IsInRow(3,6));

            //test colummns
            Console.WriteLine("#1 in column0: " + s.sudoku.IsInColummn(0,1));
            Console.WriteLine("#1 in column0: " + s.sudoku.IsInColummn(1,1));
            Console.WriteLine("#1 in column0: " + s.sudoku.IsInColummn(2,1));

            //test squares
            Console.WriteLine("#1 in square 0,0: " + s.sudoku.IsInSquare(0,0,1));
            Console.WriteLine("#1 in square 1,0: " + s.sudoku.IsInSquare(0,1,1));
            Console.WriteLine("#1 in square 2,0: " + s.sudoku.IsInSquare(0,2,1));

            Console.WriteLine("#1 in square 1,1: " + s.sudoku.IsInSquare(1, 1, 1));
            Console.WriteLine("#1 in square 2,2: " + s.sudoku.IsInSquare(2, 2, 1));
           
        }
    }
}
