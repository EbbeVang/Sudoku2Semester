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

        public void Load()
        {
            // just load something, later we going to use database and stuff
            sudoku.Numbers = new int[,]{    
                {0,0,6, 0,0,0, 0,0,4},
                {0,7,0, 9,0,0, 6,0,2},
                {4,8,0, 0,6,0, 0,3,9},
                
                {0,1,0, 7,2,5, 0,0,0},
                {0,3,7, 4,0,1, 9,2,0},
                {0,0,0, 6,3,9, 0,0,7},

                {7,9,0, 0,5,0, 0,8,6},
                {3,0,4, 0,0,6, 0,9,0},
                {2,0,0, 0,0,0, 5,0,0}
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
