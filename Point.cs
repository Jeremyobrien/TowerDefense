using System;

namespace TowerDefense
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
            //Clear first writing of code before refactor
            //int xDiff = X - x;
            //int yDiff = Y - y;

            //int xDiffSquared = xDiff * xDiff;
            //int yDiffSquared = yDiff * yDiff;

            //return (int) Math.Sqrt(xDiffSquared + yDiffSquared);

            return (int) Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}