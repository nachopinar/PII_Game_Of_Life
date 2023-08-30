using System;

namespace PII_Game_Of_Life
{
    public class Board
    {
        public bool[,] GameBoard;

//CONSTRUCTOR 
        public Board(int width, int height)
        {
            this.GameBoard = new bool[width,height];
        }
    }
}


