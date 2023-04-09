using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj8a
{
    internal class Ship : Entity
    {
        // makes the engine flicker (visible every other frame)
        int engineStagger = 0;
        public Ship(Settings gameSettings, int xFoo, int yFoo,
            int radiusFoo, int deltaXFoo, int deltaYFoo,
            Graphics gFoo) : base(gameSettings, xFoo, yFoo, 
                radiusFoo, deltaXFoo, deltaYFoo,
            gFoo)
        { }


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
            updatePosition();
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
            eraseThing();
            validateAngle(degrees);
            drawThing();
        }



        public override void eraseThing()
        {
            drawLines(3, eraser);
        }




        /* GAB 04/06/2023
         * Specifically creates the spaceship shape
         */
        public override void drawLines(int numPoints, Pen penFoo)
        {// specifically for the spaceship

            g.DrawLine(penFoo, pointList[0], origin);
            g.DrawLine(penFoo, origin, pointList[1]);
            g.DrawLine(penFoo, pointList[1], pointList[2]);
            g.DrawLine(penFoo, pointList[2], pointList[0]);
        }


        /* taken from note 
         */
    }   
}
