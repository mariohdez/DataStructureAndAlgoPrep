using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week1
{
    public class KClosestSln
    {
        public int[][] KClosest(int[][] points, int k)
        {
            List<Point> pointList = new List<Point>();
            for (int i = 0; i < points.Length; ++i)
            {
                pointList.Add(new Point(points[i][0], points[i][1]));
            }

            pointList.Sort(new PointComparer());

            var res = new int[k][];

            for (int i = 0; i < k; ++i)
            {
                res[i] = new int[2] { pointList[i].X, pointList[i].Y };
            }

            return res;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    public class PointComparer : IComparer<Point>
    {
        public int Compare(Point p1, Point p2)
        {
            int p1Distance = (p1.X * p1.X) + (p1.Y * p1.Y);
            int p2Distance = (p2.X * p2.X) + (p2.Y * p2.Y);

            return p1Distance - p2Distance;
        }
    }
}
