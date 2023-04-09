using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj8a
{
    internal class Laser : Entity
    {


        public Laser(Settings gameSettings, int xFoo, int yFoo,
            int radiusFoo, int deltaXFoo, int deltaYFoo,
            Graphics gFoo) : base(gameSettings, xFoo, yFoo,
            radiusFoo, deltaXFoo, deltaYFoo,
            gFoo)
        { }



        internal override void updatePosition()
        { // only max speed for now, will eventually make speed increase incrementially

            drawThing();

            while (true) 
            {
                Thread.Sleep(33);
                eraseThing();
                findPoints(1, speed);
                origin = pointList[0];
                if ((origin.X > resolutionWidth)
                || (origin.X < 0) || (origin.Y < 0)
                    || (origin.Y > resolutionHeight))
                {
                    break;
                }
                else { drawThing(); }
            }
        }



        /* GAB 04/06/2023
         * Advances the movement of the laser by one
         * action. This makes the laser spawn out of the nose. 
         */
        internal void primeLaser()
        {
            for (int i = 0; i < 1; i++) 
            {
                findPoints(1, 25);
                origin = pointList[0];
            }
        }





        /*
        ((0 <= laser.X) && (laser.X <= gameSettingsFoo.ResolutionWidth)
                && (0 <= laser.Y) && (laser.Y <= gameSettingsFoo.ResolutionHeight)) 

        */



    }
}
