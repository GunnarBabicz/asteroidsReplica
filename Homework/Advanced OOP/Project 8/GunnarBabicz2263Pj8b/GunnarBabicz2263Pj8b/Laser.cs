using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj8b
{
    internal class Laser : Entity
    {


        public Laser(Settings gameSettings, int xFoo, int yFoo,
            int radiusFoo, int deltaXFoo, int deltaYFoo,
            Graphics gFoo) : base(gameSettings, xFoo, yFoo,
            radiusFoo, deltaXFoo, deltaYFoo,
            gFoo)
        { }





        /* GAB 04/16/2023
         * updates the position of the laser constantly
         * unless it collides with an asteroid or 
         * 
         */
        internal override void updatePosition()
        { 

            drawThing();

            while (isAlive) 
            {
                Thread.Sleep(10);
                eraseThing();
                findPoints(1, speed);
                origin = pointList[0];



                if ((origin.X > resolutionWidth)
                || (origin.X < 0) || (origin.Y < 0)
                    || (origin.Y > resolutionHeight) /*or collides with asteroid*/ )
                {
                    isAlive = false;
                }
                else { drawThing(); }
            }
        }



        /* GAB 04/06/2023
         * Advances the movement of the laser by one
         * action. This makes the laser spawn out of the nose. of
         * the ship and not inside of the ship
         */
        internal void primeLaser()
        {
            findPoints(1, 25);
            origin = pointList[0];
        }


        public void simulateLaser() 
        {
            primeLaser();
            updatePosition();
        }




        /*
        ((0 <= laser.X) && (laser.X <= gameSettingsFoo.ResolutionWidth)
                && (0 <= laser.Y) && (laser.Y <= gameSettingsFoo.ResolutionHeight)) 

        */



    }
}
