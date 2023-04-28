namespace GunnarBabicz2263Pj8b
{
    internal class Ship : Entity
    {
        Point left;
        Point right;

        Point leftRear;
        Point rightRear;
        // makes the engine flicker (visible every other frame)
        bool exhaustStagger = true;
        bool exhaustDrawn = false;



        public Ship(GameParameters gameSettings, int xFoo, int yFoo, int radiusFoo)
            : base(gameSettings, xFoo, yFoo, radiusFoo){}


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
            acceleration = 1;
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
            //eraseThing();
            validateAngle(degrees);
            //drawThing();
        }



        public override void eraseThing()
        {
            drawLines(3, eraser);
            if (exhaustDrawn)
            {
                eraseExhaust();
                exhaustDrawn = false;
            }
        }




        private void exhaustLines(Pen penFoo) 
        {
            Point leftExhaust = helpers.fractionOfDistanceFrom(leftRear, rightRear, 5);
            Point rightExhaust = helpers.fractionOfDistanceFrom(rightRear, leftRear, 5);
            Point exhaustTip = helpers.findMidpoint(pointList[0], pointList[1]);

            Point totalChange = helpers.coordinateChangesFrom(origin, exhaustTip);
            exhaustTip.X += totalChange.X; exhaustTip.Y += totalChange.Y;



            g.DrawLine(penFoo, leftExhaust, exhaustTip);
            g.DrawLine(penFoo, rightExhaust, exhaustTip);
        }

        private void drawExhaust() { exhaustLines(p); }
        private void eraseExhaust() { exhaustLines(eraser); }


        /* GAB 04/06/2023
         * Specifically creates the spaceship shape
         */
        public override void drawLines(int numPoints, Pen penFoo)
        {// specifically for the spaceship
            //pointList[2]: tip of the ship
            //pointList[1]: left 
            //pointList[0]: right

            left = helpers.fractionOfDistanceFrom(pointList[1], pointList[0], 5);
            right = helpers.fractionOfDistanceFrom(pointList[0], pointList[1], 5);

            //g.DrawLine(penFoo, left, pointList[1]);
            //g.DrawLine(penFoo, right, pointList[0]);


            // old inwards triangle
            //g.DrawLine(penFoo, pointList[0], origin);
            //g.DrawLine(penFoo, origin, pointList[1]);

            g.DrawLine(penFoo, left, pointList[2]);
            g.DrawLine(penFoo, right, pointList[2]);

            //g.DrawLine(penFoo, pointList[1], pointList[2]);
            //g.DrawLine(penFoo, pointList[2], pointList[0]);

            leftRear = helpers.fractionOfDistanceFrom(left, pointList[2], 5);
            rightRear = helpers.fractionOfDistanceFrom(right, pointList[2], 5);

            g.DrawLine(penFoo, leftRear, rightRear);


            // drawing circle inside for testing
        }

        // pointlist[2]: Point of the ship


        public void simulateShip() 
        {
            while (isAlive) 
            {
            
            }
        }


        internal override void updatePosition()
        { // only max speed for now, will eventually make speed increase incrementially

            eraseThing();

            // saves origin of ship before movement
            Point old = new Point(origin.X, origin.Y);


            // adding the speed already carried by the ship
            origin.X += deltaX;
            origin.Y += deltaY;


            // finds what the position of the ship would be with the added acceleration
            findPoints(1, acceleration);

            // If the acceleration would make the speed over the max allowed, do not add.
            if (helpers.distanceBetween(old, pointList[0]) <= maxSpeed)
            {
                origin = pointList[0];
            }



            deltaX = (origin.X - old.X);
            deltaY = (origin.Y - old.Y);



            if (origin.X > resolutionWidth + radius) origin.X = 0;
            if (radius + origin.X < 0) origin.X = resolutionWidth;

            if (radius + origin.Y < 0) origin.Y = resolutionHeight;
            if (origin.Y > resolutionHeight + radius) origin.Y = 0;

            center = new Point(origin.X - radius, origin.Y - radius);
            
            drawThing();
            if (acceleration > 0)
            {
                if (exhaustStagger == true)
                {
                    drawExhaust();
                    exhaustDrawn = true;
                    exhaustStagger = false;
                }
                else { exhaustStagger = true; }
            }
            else { exhaustStagger = true; }
            acceleration = 0;
        }

        /* taken from note 
         */
    }   
}
