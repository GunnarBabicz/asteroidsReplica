using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace asteroids
{
    /* GAB 04/25/2023
     * Collection of misc functions that are used throughout the program */
    internal class Helpers
    {
        /* GAB 04/30/2023 
         * Finds the distance between two points */
        internal static int distanceBetween(Point a, Point b) 
        {
            int x = Math.Abs(a.X - b.X);
            x = x * x;
            int y = (Math.Abs(a.Y - b.Y));
            y = y * y;
            int distance = (int)Math.Floor(Math.Sqrt(x + y));
            return distance;
        }
        /* GAB 04/30/2023 
         * given two points, finds the halfway point between them */
        public static Point findMidpoint(Point a, Point b) 
        {
            return new Point(((a.X + b.X) / 2), ((a.Y + b.Y) / 2));
        }



        /* GAB 04/30/2023
         * Finds the point 1 / denominator of the way between point A and point B.
         * For example, 3 would be the point 1/3 of the way from A to B.
         */ 
        public static Point fractionOfDistanceFrom(Point a, Point b, int denominator) 
        {
            int deltaX = (b.X - a.X);
            int deltaY = (b.Y - a.Y);
            double rawX = (a.X + (deltaX / 5));
            double rawY = (a.Y + (deltaY / 5));

            int roundedX = (int)Math.Round(rawX);
            int roundedY = (int)Math.Round(rawY);

            return new Point(roundedX, roundedY);
        }

        /* GAB 04/27/2023
         * Check a list of entities and returns the first valid
         * index in the array that a new entity can be added. If
         * there is no valid place, the function will return -1
         */
        public static int firstValid(Entity[] arrayFoo)
        {
            for (int i = 0; i < arrayFoo.Length; i++)
            {
                if (entityIsReplaceable(arrayFoo[i])) { return i; }
            }
            return -1;
        }


        /* GAB 04/30/2023 
         * Determines if an entity can be overwritten by another (dead or null) */
        public static bool entityIsReplaceable(Entity entityFoo) 
        {
            if (entityFoo != null)
            { // if the entity is both not null and alive
                if (entityFoo.isAlive == true) { return false; }
            }
            // if the entity is either null or dead
            return true;
        }

        /* GAB 04/30/2023 
         * Determines if an entity is alive
         */
        public static bool entityIsAlive(Entity entityFoo) 
        {
            if (entityFoo != null)
            { // if the entity is both not null and alive
                if ((entityFoo.isAlive == true) && (entityFoo.canCollide == true)) { return true; }
            }
            // if the entity is either null or dead
            return false;
        }

        /* GAB 04/30/2023
         * Given a circular and point hitbox, returns a bool if the two collide. 
         */
        public static bool circlePointCollision(Entity circleFoo, Entity pointFoo)
        {
            Point foo = circleFoo.origin;
            Point bar = pointFoo.origin;
            if (circleFoo.radius > distanceBetween(foo, bar)) { return true; }
            return false;
        }

        /* GAB 04/30/2023 
         * Checks if the palyer ship collides with a given asteroid */
        public static bool checkShipCollision(Ship player, Asteroid asteroid)
        {
            for (int i = 0; i < 3; i++)
            {
                Point ast = asteroid.origin;
                Point shp = player.pointList[i];
                if (asteroid.radius > Helpers.distanceBetween(ast, shp)) { return true; }
            }
            return false;
        }

        /* GAB 04/30/2023 
         * Returns the distance from the player position to the closest asteroid */
        public static int closestAsteroid(Ship player, GameParameters gp) 
        {
            int closestDistance = gp.Width;
            for (int i = 0; i < gp.spawnedAsteroids.Length; i++) 
            {
                if (Helpers.entityIsAlive(gp.spawnedAsteroids[i])) 
                {
                    int currentDistance = distanceBetween(gp.spawnedAsteroids[i].origin, player.origin);
                    if (currentDistance < closestDistance)
                    {
                        closestDistance = currentDistance;
                    }
                }
            }
            return closestDistance;
        }

        /* GAB 04/30/2023 
         * Given two points A and B, returns the change in X and Y 
         * needed to go from point A to point B */
        public static Point coordinateChangesFrom(Point a, Point b) 
        {
            return new Point(b.X - a.X, b.Y - a.Y);
        }
    }
}
