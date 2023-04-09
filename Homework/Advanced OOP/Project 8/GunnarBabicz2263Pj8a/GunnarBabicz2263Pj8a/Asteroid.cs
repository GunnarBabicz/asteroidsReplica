using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj8a
{
    internal class Asteroid : Entity
    {

        public Asteroid(Settings gameSettings, int xFoo, int yFoo,
            int radiusFoo, int deltaXFoo, int deltaYFoo,
            Graphics gFoo) : base(gameSettings, xFoo, yFoo,
            radiusFoo, deltaXFoo, deltaYFoo,
            gFoo)
        { }

        public override void drawThing()
        {
            g.DrawEllipse(p, origin.X - radius * 2, origin.Y - radius * 2, radius, radius);
        }
        public override void eraseThing()
        { 
            g.DrawEllipse(eraser, origin.X - radius * 2, origin.Y - radius * 2, radius, radius);
        }

        public void move() 
        {
            updatePosition();
        }

    }
}
