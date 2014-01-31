using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SudokuGame
{
    public class Sudoku
    {
        public int[,] Numbers { get; set; }
        public bool Finish { get; set; }

        public int[,] GetView()
        {
            return Numbers;
        }

        public void AddNumbers(int x, int y, int value)
        {
            Numbers[y, x] = value;
            // check if any numbers left, set finish to true
        }

        public bool Validate()
        {
            //ohhhh no
            return true;
        }

        public int GetNumber(int x, int y)
        {
            return Numbers[y, x];
        }

        public bool IsInRow(int x, int y, int value)
        {
            for (int i = 0; i < 9; i++)
            {
                if (Numbers[i, y] ==value) return true;
            }
            return false;
        }

        public bool IsInColummn(int x, int y, int value)
        {
            for (int i = 0; i < 9; i++)
            {
                if (Numbers[x, i] == value) return true;
            }
            return true;
        }

        public bool IsInSquare(int x, int y, int value)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    x = (int) (3/x);
                    y = (int) (3/y);
                    if (Numbers[y + i, x + j] == value) return true;
                }
            }
            return false;
        }
    }
}
