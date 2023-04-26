using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj8b
{
    /* GAB 04/05/2023
     * Event is a class to handle events such as spawning
     * Will likely split into smaller classes
     */
    internal class Event
    {
        gameMaster Zeus;
        Random random = new Random();

        /* GAB 04/07/2023
         *  Creates a new Ship object in the center of the screen */
        public static Ship spawnShip(Settings gameSettingsFoo, Graphics g) 
        {   // known bug: Will not support odd numbered screen sizes.
            int centerWidth = gameSettingsFoo.ResolutionHeight / 2;
            int centerHeight = gameSettingsFoo.ResolutionWidth / 2;
            return new Ship(gameSettingsFoo, centerWidth, centerHeight, 30, 0, 0, g);
        }


        public void newGame() 
        {
            Zeus = new gameMaster();
        }

        public int Score 
        {
            get { return Zeus.score; }
        }

        /*GAB 04/06/2023
         * Spawns an asteroid with random size, location, and velocity.
         * Work in progress. */
        public void spawnAsteroid(Settings gameSettingsFoo, Graphics g) 
        { // spawns a astroid with random values

            int index = Zeus.canSpawnAsteroid();
            if (index >= 0)
            { /* spawns an asteroid with random size, location, and speed if spawn cap
               * has not been reached */
                int xPos = random.Next(0, gameSettingsFoo.ResolutionWidth);
                int yPos = random.Next(0, gameSettingsFoo.ResolutionHeight);
                int radius = random.Next(30, 80);
                Asteroid asteroid = new Asteroid(gameSettingsFoo,
                    xPos, yPos, radius, 0, 0, g);
                asteroid.Angle = random.Next(0, 35) * 10;
                asteroid.speed = random.Next(5, 12);

                Zeus.spawnedAsteroids[index] = asteroid;
                Zeus.NumberOfAsteroids++;

                Thread asteroidThread = new Thread(asteroid.testAsteroid);
                asteroidThread.Start();
            }
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
        public void fireLaser(Settings gameSettingsFoo, Graphics g, Ship vessel)
        {
            int index = Zeus.canSpawnLaser();
            if (index >= 0) 
            {
                Laser laser = new Laser(gameSettingsFoo,
                vessel.yPos, vessel.xPos, 5, 0, 0, g);
                laser.Angle = vessel.Angle;
                laser.Speed = 40;

                Zeus.spawnedLasers[index] = laser;
                Zeus.NumberOfLasers++;

                Thread laserThread = new Thread(laser.simulateLaser);
                laserThread.Start();
                // starts the threads
            }
        }

        public void checkHits() 
        {
            int asteroidsChecked = 0;
            int asteroidsAlive = Zeus.NumberOfAsteroids;

            while (asteroidsChecked < asteroidsAlive) 
            {
                for (int i = 0; i < Zeus.spawnedAsteroids.Length; i++)
                {
                    if (Zeus.spawnedAsteroids[i] != null)
                    {
                        if (Zeus.spawnedAsteroids[i].isAlive == true)
                        {
                            asteroidsChecked++;
                            for (int j = 0; j < Zeus.spawnedLasers.Length; j++)
                            {
                                if (Zeus.spawnedLasers[j] != null)
                                {
                                    if (Zeus.spawnedLasers[j].isAlive == true)
                                    {
                                        Point ast = Zeus.spawnedAsteroids[i].origin;
                                        Point las = Zeus.spawnedLasers[j].origin;
                                        
                                        if (Zeus.spawnedAsteroids[i].radius > helpers.distanceBetween(ast, las))
                                        {
                                            Zeus.spawnedAsteroids[i].Hit();
                                            Zeus.spawnedLasers[j].Hit();
                                            Zeus.asteroidHit();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }       
        }


        public void checkCollision() 
        {
            if (Zeus.NumberOfLasers > 0) { checkHits(); }
        }



    }

    

}