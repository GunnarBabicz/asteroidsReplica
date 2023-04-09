using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunnarBabicz2263Pj8a
{
    /* GAB 04/07/2023
         * Creates Entity object */
    internal class Entity
    {
        // Initial variables
        internal Graphics g;
        internal Pen eraser;
        internal Pen p;
        int penWidth;
        public int x, y, radius, deltaX, deltaY;
        int xDir, yDir;
        Color backgroundColor;
        Color entityColor;
        internal int resolutionWidth, resolutionHeight;
        internal int angle = 0;
        internal int speed = 10;
        internal Point origin;
        internal Point result = new Point(0, 0);
        internal List<Point> pointList = new List<Point>();


        /* GAB 04/07/2023
         *  Constructor */
        public Entity(Settings gameSettings, int xFoo, int yFoo,
            int radiusFoo, int deltaXFoo, int deltaYFoo,
            Graphics gFoo)
        {

            // Screen resolution
            resolutionWidth = gameSettings.ResolutionWidth;
            resolutionHeight = gameSettings.ResolutionHeight;


            // entity colors and creation tools
            entityColor = gameSettings.EntityColor;
            backgroundColor = gameSettings.BackgroundColor;
            penWidth = gameSettings.PenWidth;
            g = gFoo;
            p = new Pen(entityColor, penWidth);
            eraser = new Pen(backgroundColor, penWidth);

            // initial coordinates size, and attitude of Entity
            x = yFoo; y = xFoo;

            origin = new Point(x, y);
            radius = radiusFoo;
            deltaX = deltaXFoo; deltaY = deltaYFoo;
            xDir = 1;
            yDir = 1;
        }


        // getter / setter methods

        /* GAB 04/07/2023
         * getter/setter for entity angle */
        public int Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        /* GAB 04/07/2023
         * getter/setter for entity speed */
        public int Speed 
        {
            get { return speed; }
            set { speed = value; }
        }

        /* GAB 04/07/2023
         * getter/setter for the position of X */
        public int xPos 
        {
            get { return origin.X; }
            set { origin.X = value; }
        }

        /* GAB 04/07/2023
         * getter/setter for the position of Y */
        public int yPos 
        {
            get { return origin.Y; }
            set { origin.Y = value; }
        }


        /* GAB 04/07/2023
         * Draws the Entity */
        public virtual void drawThing()
        { // draws a line as default
            drawVectorShape(2, p);
        }

        /* GAB 04/07/2023
         * Erases the drawn Entity */
        public virtual void eraseThing()
        { // subtracting, as the Graphics object draws the circle off center. 
            drawVectorShape(2, eraser);
        }


        /* GAB 04/07/2023
         *  Draws a n sided shape taking into account the
         *  vector the object already has.
         *  
         *  Adapted from note 8.0
         */
        public void drawVectorShape(int numPoints, Pen pls)
        {
            findPoints(numPoints, radius);
            drawLines(numPoints, pls);
        }


        /* GAB 04/07/2023
         *  Finds the angle in radians of points
         *  of a n sided object relative to the origin
         *  and if the object is already at an angle.
         *  
         *  Adapted from note 8.0.
         */
        public double findAngleRadians(int iterationNum, int numPoints) 
        {
            int degreesBetweenPoints = (360 / numPoints);
            int pointAngle = angle - (degreesBetweenPoints * iterationNum);
            if (pointAngle == 0) { return (2 * Math.PI); }
            else if (pointAngle < 0) { return (360 + pointAngle) * Math.PI / 180; }
            else { return pointAngle * Math.PI / 180; }
            
        }


        /* GAB 04/07/2023
         *  For a shape of n sides,
         *  finds the coordinates of where its points
         *  would be on a circle of radius r.
         *  Adapted from note 8.0
         */
        internal void findPoints(int numSides, int radiusFoo)
        {
            pointList.Clear(); //necessary, otherwise, the list won't start from scratch on the second try
            for (int i = 1; i <= numSides; i++)
            {
                result.X = origin.X + (int)Math.Round(radiusFoo * Math.Cos(findAngleRadians(i, numSides)));
                result.Y = origin.Y - (int)Math.Round(radiusFoo * Math.Sin(findAngleRadians(i, numSides)));
                if (!pointList.Contains(result))
                {
                    pointList.Add(result);
                }
            }
        }

        /* GAB 04/06/2023
         * Creates a polygonal shape
         */
        public virtual void drawLines(int numPoints, Pen pls)
        {// specifically for the spaceship
            for (int i = 0; i < numPoints; i++) 
            {
                if (i+1 < numPoints)
                { // if i is not on its last point
                    g.DrawLine(pls, pointList[i], pointList[i+1]);
                }
                else 
                {
                    g.DrawLine(pls, pointList[numPoints-1], pointList[0]);
                }
            
            }
        }


        /* GAB 04/07/2023
         *  Changes the origin of the entity based on its current movement.
            Adapted from Note 8.4 */
        internal virtual void updatePosition() 
        { // only max speed for now, will eventually make speed increase incrementially
            
            eraseThing();

            findPoints(1, speed);
            origin = pointList[0];

            if (origin.X > resolutionWidth) origin.X = 0;
            if (origin.X < 0) origin.X = resolutionWidth;

            if (origin.Y < 0) origin.Y = resolutionHeight;
            if (origin.Y > resolutionHeight) origin.Y = 0;

            drawThing();

        }







        /* Big Challenges:
         * 1. How to detect collision
         * 2. How to properly use threading 
         *    to simulate multiple graphics object
         * 3. How to rotate the ship while still having it properly rendered
         
         */






    }
}
