using System.Media;

namespace GunnarBabicz2263Pj8b
{
    internal class Ship : Entity
    {

        // variables used for drawing the shape
        Point left;
        Point right;
        Point leftRear;
        Point rightRear;


        // variables to make the engine flicker (visible every other frame)
        bool exhaustStagger = true;
        bool exhaustDrawn = false;

        /* GAB 04/30/2023
        * Constructor for the ship class */
        public Ship(GameParameters gameSettings, int xFoo, int yFoo, int radiusFoo)
            : base(gameSettings, xFoo, yFoo, radiusFoo){}


        /* GAB 04/06/2023
         * Calls the method to draw the ship */
        public override void drawThing()
        { 
            drawVectorShape(3, p);
        }



        /* GAB 04/06/2023
         * Moves the ship forward. */
        public void moveForward()
        {
            acceleration = 1;
        }



        /* GAB 04/06/2023
         * Only allows a valid angle
         * (from 0 to 359) */
        private void validateAngle(int degrees) 
        {
            angle += degrees;

            if (angle >= 360) { angle -= 360; }
            else if (angle < 0) { angle += 360; }
                     
        }


        /* GAB 04/06/2023
         * Rotates the ship by a 
         * specified number of degrees */
        public void Rotate(int degrees) 
        {
            //eraseThing();
            validateAngle(degrees);
            //drawThing();
        }


        /* GAB 04/30/2023
        * Erases the ship */
        public override void eraseThing()
        {
            g.DrawLine(eraser, left, pointList[2]);
            g.DrawLine(eraser, right, pointList[2]);
            g.DrawLine(eraser, leftRear, rightRear);

            if (exhaustDrawn)
            {
                eraseExhaust();
                exhaustDrawn = false;
            }
        }




        /* GAB 04/28/2023
        * Creates the shape of the exhaust */
        private void exhaustLines(Pen penFoo) 
        {
            Point leftExhaust = Helpers.fractionOfDistanceFrom(leftRear, rightRear, 5);
            Point rightExhaust = Helpers.fractionOfDistanceFrom(rightRear, leftRear, 5);
            Point exhaustTip = Helpers.findMidpoint(left, right);

            Point totalChange = Helpers.coordinateChangesFrom(origin, exhaustTip);
            exhaustTip.X += totalChange.X; exhaustTip.Y += totalChange.Y;



            g.DrawLine(penFoo, leftExhaust, exhaustTip);
            g.DrawLine(penFoo, rightExhaust, exhaustTip);
        }

        /* GAB 04/30/2023
        * Calls the method to draw engine exhaust*/
        private void drawExhaust() { exhaustLines(p); }

        /* GAB 04/30/2023
        * calls the method to erase the ship exhaust */
        private void eraseExhaust() { exhaustLines(eraser); }


        /* GAB 04/06/2023
         * Creates the spaceship shape */
        public override void drawShape(int numPoints, Pen penFoo)
        {// specifically for the spaceship
            //pointList[2]: tip of the ship
            //pointList[1]: left 
            //pointList[0]: right

            left = Helpers.fractionOfDistanceFrom(pointList[1], pointList[0], 5);
            right = Helpers.fractionOfDistanceFrom(pointList[0], pointList[1], 5);

            // draws the sides of the ship
            g.DrawLine(penFoo, left, pointList[2]);
            g.DrawLine(penFoo, right, pointList[2]);

            leftRear = Helpers.fractionOfDistanceFrom(left, pointList[2], 5);
            rightRear = Helpers.fractionOfDistanceFrom(right, pointList[2], 5);

            pointList[1] = left;
            pointList[0] = right;

            // draws the back flat section of the ship
            g.DrawLine(penFoo, leftRear, rightRear);

        }

        /* GAB 04/30/2023
        * method for the thread to call */
        public void simulateShip() 
        {
            /* since updates are done with the timer,
             * no action is needed here other than to activate the thread */
            while (isAlive) {}
        }

        /* GAB 04/30/2023
        * Finds the position the ship will be in in the next frame */
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
            int proposedSpeed = Helpers.distanceBetween(old, pointList[0]);

            

            if (proposedSpeed <= maxSpeed)
            { // If the acceleration would make the speed over the max allowed, do not add.
                origin = pointList[0];
            }

            // saves the change in position for the next frame
            deltaX = (origin.X - old.X);
            deltaY = (origin.Y - old.Y);

            // checks if the ship is within the bounds of the screen
            if (origin.X > resolutionWidth + radius) origin.X = 0;
            if (radius + origin.X < 0) origin.X = resolutionWidth;

            if (radius + origin.Y < 0) origin.Y = resolutionHeight;
            if (origin.Y + 30 > resolutionHeight + radius) origin.Y = 0;
            
            drawThing();
            if (acceleration > 0)
            { // determines whether to draw the engine exhaust
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
    }   
}
