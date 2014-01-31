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

            Console.WriteLine("get[1,0]: " + s.sudoku.GetNumber(1, 0));

            Console.WriteLine("testing validation");
            Console.WriteLine("#6 in row0: " + s.sudoku.IsInRow(0,3,6));
            Console.WriteLine("#6 in row1: " + s.sudoku.IsInRow(1, 3, 6));
            Console.WriteLine("#6 in row2: " + s.sudoku.IsInRow(2, 3, 6));
            Console.WriteLine("#6 in row3: " + s.sudoku.IsInRow(3, 4, 6));
            
        }
    }
}
