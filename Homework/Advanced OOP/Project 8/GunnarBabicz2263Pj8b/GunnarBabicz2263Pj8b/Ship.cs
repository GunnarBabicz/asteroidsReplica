using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj8b
{
    internal class Ship : Entity
    {
        // makes the engine flicker (visible every other frame)
        bool exhaustStagger = true;
        bool exhaustDrawn = false;



        public Ship(GameParameters gameSettings, int xFoo, int yFoo, int radiusFoo)
            : base(gameSettings, xFoo, yFoo, radiusFoo){}


        /* GAB 04/06/2023
         * Draws the ship 
         */
        public override void drawThing()
        { 
            drawVectorShape(3, p);
        }



        /* GAB 04/06/2023
         * Moves the ship forward. For now,
         * only constant velocity.
         */


        public void moveForward()
        {
            acceleration = 1;
        }



        /* GAB 04/06/2023
         * Only allows a valid angle
         * (from 0 to 359)
         */
        private void validateAngle(int degrees) 
        {
            angle += degrees;

            if (angle >= 360) { angle -= 360; }
            else if (angle < 0) { angle += 360; }
                     
        }


        /* GAB 04/06/2023
         * Rotates the ship by a 
         * specified number of degrees
         */
        public void Rotate(int degrees) 
        {
            //eraseThing();
            validateAngle(degrees);
            //drawThing();
        }



        public override void eraseThing()
        {
            drawLines(3, eraser);
            if (exhaustDrawn)
            {
                eraseExhaust();
                exhaustDrawn = false;
            }
        }




        private void exhaustLines(Pen penFoo) 
        {
            Point a = helpers.findMidpoint(pointList[0], origin);
            Point b = helpers.findMidpoint(pointList[1], origin);
            Point c = helpers.findMidpoint(pointList[0], pointList[1]);

            Point d = new Point(origin.X - c.X, origin.Y - c.Y);
            d.X = d.X * -1; d.Y= d.Y * -1;
            c.X = c.X + d.X; c.Y = c.Y + d.Y;



            g.DrawLine(penFoo, a, c);
            g.DrawLine(penFoo, b, c);
        }

        private void drawExhaust() { exhaustLines(p); }
        private void eraseExhaust() { exhaustLines(eraser); }


        /* GAB 04/06/2023
         * Specifically creates the spaceship shape
         */
        public override void drawLines(int numPoints, Pen penFoo)
        {// specifically for the spaceship

            g.DrawLine(penFoo, pointList[0], origin);
            g.DrawLine(penFoo, origin, pointList[1]);
            g.DrawLine(penFoo, pointList[1], pointList[2]);
            g.DrawLine(penFoo, pointList[2], pointList[0]);


            // drawing circle inside for testing
        }

        // pointlist[2]: Point of the ship


        public void simulateShip() 
        {
            while (isAlive) 
            {
            
            }
        }


        internal override void updatePosition()
        { // only max speed for now, will eventually make speed increase incrementially

            eraseThing();

            // saves origin of ship before movement
            Point old = new Point(origin.X, origin.Y);


            // adding the speed already carried by the ship
            origin.X += deltaX;
            origin.Y += deltaY;


            // finds what the position of the ship would be with the added acceleration
            findPoints(1, acceleration);

            // If the acceleration would make the speed over the max allowed, do not add.
            if (helpers.distanceBetween(old, pointList[0]) <= maxSpeed)
            {
                origin = pointList[0];
            }



            deltaX = (origin.X - old.X);
            deltaY = (origin.Y - old.Y);



            if (origin.X > resolutionWidth + radius) origin.X = 0;
            if (radius + origin.X < 0) origin.X = resolutionWidth;

            if (radius + origin.Y < 0) origin.Y = resolutionHeight;
            if (origin.Y > resolutionHeight + radius) origin.Y = 0;

            center = new Point(origin.X - radius, origin.Y - radius);
            
            drawThing();
            if (acceleration > 0)
            {
                if (exhaustStagger == true)
                {
                    drawExhaust();
                    exhaustDrawn = true;
                    exhaustStagger = false;
                }
                else { exhaustStagger = true; }
            }
            else { exhaustStagger = true; }
            acceleration = 0;
        }

        /* taken from note 
         */
    }   
}
