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

        public bool IsInRow(int row, int value)
        {
            for (int i = 0; i < 9; i++)
            {
                if (Numbers[row, i] ==value) return true;
            }
            return false;
        }

        public bool IsInColummn(int column, int value)
        {
            for (int i = 0; i < 9; i++)
            {
                if (Numbers[i, column] == value) return true;
                //else return false;
            }
            // if none are true
            return false;
        }

        public bool IsInSquare(int x, int y, int value)
        {
            x *= 3;
            y *= 3; 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Numbers[y + i, x + j] == value) return true;
                }
            }
            return false;
        }
    }
}
