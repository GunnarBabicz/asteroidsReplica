using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj8b
{
    internal class Asteroid : Entity
    {
        
        public Asteroid(GameParameters gameSettings, int xFoo, int yFoo,
            int radiusFoo, int deltaXFoo, int deltaYFoo,
            Graphics gFoo) : base(gameSettings, xFoo, yFoo,
            radiusFoo, deltaXFoo, deltaYFoo,
            gFoo)
        { }

        public override void drawThing()
        {
            g.DrawEllipse(p, center.X, center.Y, radius*2, radius*2);
        }
        public override void eraseThing()
        { 
            g.DrawEllipse(eraser, center.X, center.Y, radius * 2, radius * 2);
        }

        public void move() 
        {
            updatePosition();
        }

        public void testAsteroid()
        {
            while(isAlive)
            {
                drawThing();
                updatePosition();
                Thread.Sleep(20);
            }
            eraseThing();
          
        }
    }
}
