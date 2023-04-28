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
        
        public Asteroid(GameParameters parameters, int xFoo, int yFoo,
            int radiusFoo) : base(parameters, xFoo, yFoo,
            radiusFoo)
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

        public void levelBeginning() 
        {
            Thread.Sleep(1000);
            simulateAsteroid();
        }


    }
}
