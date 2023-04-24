﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj8b
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
            g.DrawEllipse(p, origin.X - radius, origin.Y - radius, radius, radius);
        }
        public override void eraseThing()
        { 
            g.DrawEllipse(eraser, origin.X - radius, origin.Y - radius, radius, radius);
        }

        public void move() 
        {
            updatePosition();
        }

        public void testAsteroid()
        {
            drawThing();

            // runs the demo asteroid for 3 seconds
            for (int i = 0; i < 300; i++)
            {
                updatePosition();
                Thread.Sleep(33);
            }
        }
    }
}
