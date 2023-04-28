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
    internal class GameEvent
    {

        private GameParameters para;
        Random random = new Random();



        public void gameStart(GameParameters foo) 
        {
            para= foo;
        }



        /* GAB 04/07/2023
         *  Creates a new Ship object in the center of the screen */
        public static Ship spawnShip(GameParameters gameSettingsFoo) 
        {   // known bug: Will not support odd numbered screen sizes.
            int centerWidth = gameSettingsFoo.ResolutionHeight / 2;
            int centerHeight = gameSettingsFoo.ResolutionWidth / 2;
            return new Ship(gameSettingsFoo, centerWidth, centerHeight, 30, 0, 0, g);
        }


        public void loadParameters(GameParameters foo) { para = foo; }

        public int Score 
        {
            get { return para.score; }
        }

        /*GAB 04/06/2023
         * Spawns an asteroid with random size, location, and velocity.
         * Work in progress. */
        public void spawnRandomAsteroid(Graphics g) 
        { // spawns a astroid with random values

            int index = helpers.firstValid(para.spawnedAsteroids);
            if (index >= 0)
            { /* spawns an asteroid with random size, location, and speed if spawn cap
               * has not been reached */
                int xPos = random.Next(0, para.ResolutionWidth);
                int yPos = random.Next(0, para.ResolutionHeight);
                int radius = random.Next(30, 80);
                Asteroid asteroid = new Asteroid(para,
                    xPos, yPos, radius, 0, 0, g);
                asteroid.Angle = random.Next(0, 35) * 10;
                asteroid.speed = random.Next(5, 12);

                para.spawnedAsteroids[index] = asteroid;

                Thread asteroidThread = new Thread(asteroid.testAsteroid);
                asteroidThread.Start();
            }
        }


        /* GAB 04/07/2023
         *  Creates a new Laser object */
        public void fireLaser(Graphics g, Ship vessel)
        {
            int i = helpers.firstValid(para.spawnedLasers);
            if (i >= 0) 
            { // if a laser is able to be spawned
                Laser laser = new Laser(para,
                vessel.yPos, vessel.xPos, 5, 0, 0, g);
                laser.Angle = vessel.Angle;
                laser.Speed = 40;

                para.addLaser(i, laser);
                Thread laserThread = new Thread(laser.simulateLaser);
                laserThread.Start();
                // starts the threads
            }
        }

        public void checkHits()
        {
            for (int i = 0; i < para.spawnedAsteroids.Length; i++)
            { // for each asteroid in the array
                if (helpers.entityIsAlive(para.spawnedAsteroids[i]))
                { // if the asteroid should be checked
                    for (int j = 0; j < para.spawnedLasers.Length; j++)
                    { // for each laser in the array
                        if (helpers.entityIsAlive(para.spawnedLasers[j]))
                        { // if the laser should be checked
                            if (helpers.circlePointCollision(para.spawnedAsteroids[i], para.spawnedLasers[j]))
                            { // if the two collided
                                laserHit(i, j);
                            }
                        }
                    }
                }
            }
        }



        private void laserHit(int asteroidIndex, int laserIndex)
        { // if a laser and asteroid collide
            para.removeAsteroid(asteroidIndex);
            para.removeLaser(laserIndex);
        }





        public Ship checkCollision(Ship player, Graphics g) 
        {
            if (para.numberOfLasers > 0) { checkHits(); }
            return checkShipCollision(player, g);
        }


        private Ship checkShipCollision(Ship player, Graphics g) 
        {

            for (int i = 0; i < para.spawnedAsteroids.Length; i++)
            { // for each asteroid in the array
                if (helpers.entityIsAlive(para.spawnedAsteroids[i])) 
                { // if the asteroid should be checked
                    if (helpers.checkShipCollision(player, para.spawnedAsteroids[i]))
                    {
                        return (playerHit(player, g));
                    }
                }
            }
            return player;
        }


        // if the player is hit
        private Ship playerHit(Ship player, Graphics g) 
        {
            player.eraseThing();
            Thread.Sleep(1000);
            Ship newPlayer = spawnShip(para);
            newPlayer.drawThing();
            return newPlayer;
        }
    


    }

}