using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunnarBabicz2263Pj8b
{
    /* GAB 04/07/2023
         * Creates Entity object */
    internal class Entity
    {
        // Initial variables

        // 
        private GameParameters parameters;

        public bool isAlive;
        internal Graphics g;
        internal Pen eraser;
        internal Pen p;
        int penWidth;
        public int x, y, radius, deltaX, deltaY;
        Color backgroundColor;
        Color entityColor;
        internal int resolutionWidth, resolutionHeight;
        internal int angle = 0;
        internal int speed = 0;
        internal int maxSpeed = 30;
        internal int acceleration = 0;
        internal Point origin;
        public Point center;
        internal Point result = new Point(0, 0);
        internal List<Point> pointList = new List<Point>();


        /* GAB 04/07/2023
         *  Constructor */
        public Entity(GameParameters parametersFoo, int xFoo, int yFoo,
            int radiusFoo, int deltaXFoo, int deltaYFoo,
            Graphics gFoo)
        {
            parameters = parametersFoo;
            // Screen resolution
            resolutionWidth = parametersFoo.ResolutionWidth;
            resolutionHeight = parametersFoo.ResolutionHeight;


            // entity colors and creation tools
            entityColor = parametersFoo.EntityColor;
            backgroundColor = parametersFoo.BackgroundColor;
            penWidth = parametersFoo.PenWidth;
            g = gFoo;
            p = new Pen(entityColor, penWidth);
            eraser = new Pen(backgroundColor, penWidth);

            // initial coordinates size, and attitude of Entity
            x = yFoo; y = xFoo;

            origin = new Point(x, y);
            center = new Point (origin.X - radius, origin.Y - radius);
            radius = radiusFoo;
            deltaX = deltaXFoo; deltaY = deltaYFoo;
            isAlive= true;
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


        /* GAB 04/25/2023
         * If the entity is hit(killed) */

        public void Hit() 
        {
            isAlive = false;
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
         *  Finds the angle in degrees of points
         *  of a n sided object relative to the origin
         *  and if the object is already at an angle.
         *  
         *  
         *  
         *  Adapted from note 8.0.
         */
        public double findAngle(int iterationNum, int numPoints) 
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
         *  
         *  
         *  Adapted from note 8.0
         */
        public void findPoints(int numSides, int radiusFoo)
        {
            pointList.Clear(); 
            for (int i = 1; i <= numSides; i++)
            {
                result.X = origin.X + (int)Math.Round(radiusFoo * Math.Cos(findAngle(i, numSides)));
                result.Y = origin.Y - (int)Math.Round(radiusFoo * Math.Sin(findAngle(i, numSides)));
                if (!pointList.Contains(result))
                {
                    pointList.Add(result);
                }
            }
        }

        /* GAB 04/06/2023
         * Creates a polygonal shape
         */
        public virtual void drawLines(int numPoints, Pen p)
        {// specifically for the spaceship
            for (int i = 0; i < numPoints; i++) 
            {
                if (i+1 < numPoints)
                { // if i is not on its last point
                    g.DrawLine(p, pointList[i], pointList[i+1]);
                }
                else 
                {
                    g.DrawLine(p, pointList[numPoints-1], pointList[0]);
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

            if (origin.X > resolutionWidth + radius) origin.X = 0;
            if (radius + origin.X < 0) origin.X = resolutionWidth;

            if (radius + origin.Y < 0 ) origin.Y = resolutionHeight;
            if ( origin.Y > resolutionHeight + radius) origin.Y = 0;

            center = new Point (origin.X - radius, origin.Y - radius);
            acceleration = 0;
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
