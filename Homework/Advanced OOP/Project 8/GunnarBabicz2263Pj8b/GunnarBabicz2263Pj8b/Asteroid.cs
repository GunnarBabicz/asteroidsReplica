using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj8b
{
    /* GAB 04/30/2023
    * Creates an asteroid entity
    */
    internal class Asteroid : Entity
    {
        /* GAB 04/30/2023
        * Constructor */
        public Asteroid(GameParameters parameters, int xFoo, int yFoo,
            int radiusFoo) : base(parameters, xFoo, yFoo,
            radiusFoo)
        { }

        /* GAB 04/30/2023
        * Draws asteroid */
        public override void drawThing()
        {
            g.DrawEllipse(p, center.X, center.Y, radius*2, radius*2);
        }

        /* GAB 04/30/2023
        * erases asteroid */
        public override void eraseThing()
        { 
            g.DrawEllipse(eraser, center.X, center.Y, radius * 2, radius * 2);
        }


        /* GAB 04/30/2023
        * Method called by Thread */
        public void simulateAsteroid()
        {
            canCollide = true;
            while(isAlive && (parameters.lives > 0))
            {
                drawThing();
                updatePosition();
                Thread.Sleep(20);
            }
            eraseThing();
        }

        /* GAB 04/30/2023
        * Delays asteroids spawning at the beginning of a level by one second
        */
        public void levelBeginning() 
        {
            Thread.Sleep(1000);
            simulateAsteroid();
        }
    }
}
