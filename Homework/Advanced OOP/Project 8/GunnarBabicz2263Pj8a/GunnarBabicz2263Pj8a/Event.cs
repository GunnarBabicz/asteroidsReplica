using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj8a
{
    /* GAB 04/05/2023
     * Handles game events that need to be preformed.
     * Will likely split into smaller classes
     */
    internal class Event
    {


        /* GAB 04/07/2023
         *  Creates a new Ship object in the center of the screen */
        public static Ship spawnShip(Settings gameSettingsFoo, Graphics g) 
        {   // known bug: Will not support odd numbered screen sizes.
            int centerWidth = gameSettingsFoo.ResolutionHeight / 2;
            int centerHeight = gameSettingsFoo.ResolutionWidth / 2;
            return new Ship(gameSettingsFoo, centerWidth, centerHeight, 14, 0, 0, g);
        }

        /*GAB 04/06/2023
         * Spawns an asteroid with random size, location, and velocity.
         * Work in progress. */
        public static Asteroid spawnAsteroid(Settings gameSettingsFoo, Graphics g) 
        { // spawns a astroid with random values
            Random random = new Random();
            int xPos = random.Next(0, gameSettingsFoo.ResolutionWidth);
            int yPos = random.Next(0, gameSettingsFoo.ResolutionHeight);
            int radius = random.Next(30, 80);
            Asteroid asteroid = new Asteroid(gameSettingsFoo,
                xPos, yPos, radius, 0, 0, g);
            asteroid.Angle= random.Next(0, 35) * 10;
            asteroid.speed = random.Next(5, 12);
            return asteroid;
        }

        /* GAB 04/07/2023
         *  erases an entity from both the screen and memory */
        public static void despawn(Entity entityFoo) 
        {
            entityFoo.eraseThing();
            entityFoo = null;
        }


        /* GAB 04/07/2023
         *  If the player is hit by an asteroid */
        public void shipHit()
        {
            // if(shipLives > 0) respawn
            // else{ gameOver()}
        }

        /* GAB 04/07/2023
         *  Creates a new Laser object */
        public static void createLaser(Settings gameSettingsFoo, Graphics g, Ship vessel)
        {
            //Settings gameSettings = new Settings(width, height);
            Laser laser = new Laser(gameSettingsFoo,
                vessel.yPos, vessel.xPos, 5, 0, 0, g);
            laser.Angle = vessel.Angle;
            laser.Speed = 30;
            laser.primeLaser();
            laser.updatePosition();
            despawn(laser);
        }

        /* GAB 04/07/2023
         *  If an asteroid is hit by a laser */
        public void asteroidHit() { }

        /* GAB 04/07/2023
         *  If the player runs out of lives */
        public void gameOver() { }
    }
}