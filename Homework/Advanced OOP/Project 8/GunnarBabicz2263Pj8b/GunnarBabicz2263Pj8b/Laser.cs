using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj8b
{
    internal class Laser : Entity
    {
        internal Point oldPos;
        public Laser(GameParameters gameSettings, int xFoo, int yFoo,
            int radiusFoo) : base(gameSettings, xFoo, yFoo,
            radiusFoo){}


        /* GAB 04/16/2023
         * updates the position of the laser constantly
         * unless it collides with an asteroid or 
         * 
         */
        internal override void updatePosition()
        {
            createLine(eraser);
            oldPos = origin;
            findPoints(1, speed);
            origin = new Point(pointList[0].X, pointList[0].Y);
            if ((origin.X > resolutionWidth)
            || (origin.X < 0) || (origin.Y < 0)
                || (origin.Y > resolutionHeight))
            {
                isAlive = false;
            }
            else { createLine(p); }
            Thread.Sleep(20);

        }



        /* GAB 04/06/2023
         * Advances the movement of the laser by one
         * action. This makes the laser spawn out of the nose. of
         * the ship and not inside of the ship
         */
        internal void primeLaser()
        {
            oldPos = new Point(origin.X, origin.Y);
            findPoints(1, (parameters.scale));
            origin = new Point (pointList[0].X, pointList[0].Y);
            createLine(p);
        }


        public void simulateLaser() 
        {
            primeLaser();
            canCollide = true;
            while (isAlive) { updatePosition(); }
            createLine(eraser);
        }


        public void createLine(Pen penFoo) 
        {

            g.DrawLine(penFoo, origin, oldPos);
        }








        /*
        ((0 <= laser.X) && (laser.X <= gameSettingsFoo.ResolutionWidth)
                && (0 <= laser.Y) && (laser.Y <= gameSettingsFoo.ResolutionHeight)) 

        */



    }
}
