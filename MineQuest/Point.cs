using System;
namespace MineQuest
{
    public class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2));
        }

        public bool InRangeOf(int x, int y, int range)
        {
            return DistanceTo(x, y) <= range;
        }
    }
} 
