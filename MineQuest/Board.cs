using System;
namespace MineQuest
{
    public class Board 
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Board(int width, int height)
        {
            Width = width;
            Height = height;
        }

        //check if a point is on the board

        public bool OnBoard(Point point)
        {
            return  point.X >= 0 && point.X < Width &&
                    point.Y >= 0 && point.Y < Height;
        }
    }
}
