using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asteroids
{
    /* GAB 04/30/2023
    * The Laser class is for showing the laser fired by the Ship */
    internal class Laser : Entity
    {
        internal Point oldPos;

        /* GAB 04/30/2023
        * Constructor for the laser class */
        public Laser(GameParameters gameSettings, int xFoo, int yFoo,
            int radiusFoo) : base(gameSettings, xFoo, yFoo,
            radiusFoo){}

        /* GAB 04/16/2023
         * updates the position of the laser unless it
         * collides with an asteroid or leaves the screen */
        internal override void updatePosition()
        {
            eraseThing();
            oldPos = origin;
            findPoints(1, speed);
            origin = new Point(pointList[0].X, pointList[0].Y);

            /* if the laser goes outside of the bounds of the screen,
             * stop simulating. */
            if ((origin.X > resolutionWidth)
            || (origin.X < 0)
            || (origin.Y < 0)
            || (origin.Y > resolutionHeight))
            {
                isAlive = false;
            }
            else { drawThing(); }
            Thread.Sleep(20);
            drawThing();
        }

        /* GAB 04/06/2023
         * Advances the movement of the laser by one
         * action. This makes the laser spawn out of the nose. of
         * the ship and not inside of the ship */
        internal void primeLaser()
        {
            oldPos = new Point(origin.X, origin.Y);
            findPoints(1, (parameters.scale));
            origin = new Point (pointList[0].X, pointList[0].Y);
            drawLines(p);
        }

        /* GAB 04/30/2023
        * Method that is called by the threading class */
        public void simulateLaser() 
        {
            primeLaser();
            canCollide = true;
            while (isAlive) { updatePosition(); }
            eraseThing();
        }

        /* GAB 04/30/2023
        * Draws the laser */
        public override void drawThing()
        {
            drawLines(p);
        }

        /* GAB 04/30/2023
        * Erases the laser */
        public override void eraseThing()
        {
            drawLines(eraser);
        }

        /* GAB 04/30/2023
        * Method for finding the lines needed to draw/erase */
        public void drawLines(Pen penFoo) 
        {
            g.DrawLine(penFoo, origin, oldPos);
        }
    }
}
