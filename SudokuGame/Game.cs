using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuGame
{
    public class Game
    {
        public DateTime TimeStart { get; set; }
        public Sudoku sudoku { get; set; }

        public Game()
        {
            sudoku = new Sudoku();
        }

        public bool IsCompleted()
        {
            return true;
        }

        public bool isValid()
        {
            //test all columns
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!sudoku.IsInColummn(i, j+1)) return false;
                }
            }
            //test all rows
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!sudoku.IsInRow(i, j+1)) return false;
                }
            }
            //test all squares
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 9; k++)
                    {
                        if (!sudoku.IsInSquare(i,j,k+1)) return false;
                    }    
                }
                
            }
            // if none of the above returns false......
            return true;
        }

        public void Load()
        {
            /* just load something, later we going to use database and stuff
            sudoku.Numbers = new int[,]{    
                {0,0,6, 0,0,0, 0,0,4},
                {0,7,0, 9,0,0, 6,0,2},
                {4,8,0, 0,6,0, 0,3,9},
                
                {0,1,0, 7,2,5, 0,0,0},
                {0,3,7, 4,0,1, 9,2,0},
                {0,0,0, 6,3,9, 0,0,7},

                {7,9,0, 0,5,0, 0,0,6},
                {3,0,4, 0,0,6, 0,9,0},
                {2,0,0, 0,0,0, 5,0,0}
            };
            */
            sudoku.Numbers = new int[,]{    
                {9,2,6, 5,1,3, 7,8,4},
                {1,7,3, 9,4,8, 6,5,2},
                {4,8,5, 2,6,7, 1,3,9},
                
                {8,1,9, 7,2,5, 4,6,3},
                {6,3,7, 4,8,1, 9,2,5},
                {5,4,2, 6,3,9, 8,1,7},

                {7,9,1, 8,5,2, 3,4,6},
                {3,5,4, 1,7,6, 2,9,0},
                {2,6,8, 3,9,4, 5,0,0}
            };
        }

        public void Save()
        {

        }

        public void Hint()
        {
        }

        public void Clear()
        {
            //clear the sudoku (actually just load sudoku again :-)
        }
    }
}
