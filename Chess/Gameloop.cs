using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public static class Gameloop
    {
        public static void Start()
        {
            // Init board
            Board gameBoard = new Board();

            // Create players?
            
            //
            // while (true) 
            {
                // white moves
                gameBoard.displayBoard();

                // black moves
                gameBoard.displayBoard();

                // Checkmate or resigning break the loop

            }

            // Insert data to DB
        }
    }
}
