using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj8b
{
    /* GAB 04/25/2023
     * 
     * Collection of misc functions that are used throughout the program
     */
    internal class helpers
    {

        internal static int distanceBetween(Point a, Point b) 
        {
            int x = Math.Abs(a.X - b.X);
            x = x * x;
            int y = (Math.Abs(a.Y - b.Y)) ^ 2;
            y = y * y;
            int distance = (int)Math.Floor(Math.Sqrt(x + y));
            return distance;
        }

        /*
         * Given an origin and two acting vectors, returns a list 
         * containing the angle and speed that is the result of both
         * vectors. 
         */
        public static Point combinedVector(Point a, Point b) 
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        /* GAB 04/25/2023
         * Given a 
         * 
         */
        // public int findVector(Point origin, Point Vector, Point angle)


        // given two points, finds 
        public static int findMovementAngle(Point a, Point b) 
        {
            int deltaX = (a.X - b.X);
            int deltaY = (a.Y - b.Y);
            int quadrant = findQuadrant(deltaX, deltaY);

            deltaX = Math.Abs(deltaX);
            deltaY = Math.Abs(deltaY);


            int angle = (int)Math.Round(Math.Atan(deltaX / deltaY));

            return (angle + (quadrant*90));
        }

        // since angle eq uses abs value, this accounts for any offset
        private static int findQuadrant(int deltaX, int deltaY) 
        {
            if (deltaX > 0 && deltaY >= 0) { return 1; }
            if (deltaX <= 0 && deltaY > 0) { return 3; }
            if (deltaX < 0 && deltaY <= 0) { return 2; }
            return 4;

        }

        // given two points, find a halfway point between the two 
        public static Point findMidpoint(Point a, Point b) 
        {
            return new Point(((a.X + b.X) / 2), ((a.Y + b.Y) / 2));
        }


    }
}
