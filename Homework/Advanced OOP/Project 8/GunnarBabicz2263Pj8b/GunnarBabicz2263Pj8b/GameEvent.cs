using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
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

        // The entities are made smaller or larger based on the resolution

        public void gameStart(GameParameters foo) 
        {
            para = foo;
            para.lives = 3;
        }



        /* GAB 04/07/2023
         *  Creates a new Ship object in the center of the screen */
        public static Ship spawnShip(GameParameters gameSettingsFoo) 
        {   // known bug: Will not support odd numbered screen sizes.
            int centerHeight = gameSettingsFoo.Height / 2;
            int centerWidth = gameSettingsFoo.Width / 2;
            return new Ship(gameSettingsFoo, centerWidth, centerHeight, gameSettingsFoo.scale);
        }


        public void loadParameters(GameParameters foo) { para = foo; }

        public int Score 
        {
            get { return para.score; }
        }

        /*GAB 04/06/2023
         * Spawns an asteroid with random size, location, and velocity.
         * Work in progress. */
        public void spawnRandomAsteroid() 
        { // spawns a astroid with random values

            int index = helpers.firstValid(para.spawnedAsteroids);
            if (index >= 0)
            { /* spawns an asteroid with random size, location, and speed if spawn cap
               * has not been reached */

                // this block of code keeps asteroids from spawning on top of the player
                int positiveOrNegative = random.Next(2);
                if (positiveOrNegative == 0) { positiveOrNegative = 1; }
                else { positiveOrNegative = -1; }
                int xPos = (para.Width/2 + (random.Next(para.scale*3, para.Width/2)*positiveOrNegative));
                int yPos = (para.Height + (random.Next(para.scale*3, para.Height/2)*positiveOrNegative));


                int radius = random.Next(1, 4) * (para.scale-10);
                Asteroid asteroid = new Asteroid(para,
                    xPos, yPos, radius);
                asteroid.Angle = random.Next(0, 35) * 10;
                asteroid.speed = random.Next(4, 6) + para.level;

                para.addAsteroid(index, asteroid);

                Thread asteroidThread = new Thread(asteroid.levelBeginning);
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
                vessel.xPos, vessel.yPos, 5);
                laser.Angle = vessel.Angle;
                laser.Speed = 50;

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
                    Asteroid astrd = para.spawnedAsteroids[i];
                    for (int j = 0; j < para.spawnedLasers.Length; j++)
                    { // for each laser in the array
                        if (helpers.entityIsAlive(para.spawnedLasers[j]))
                        { // if the laser should be checked
                            Laser lsr = para.spawnedLasers[j];
                            if (helpers.circlePointCollision(astrd, lsr))
                            { // if the two collided
                                para.score += 100;
                                if(astrd.radius > (para.scale - 10)) 
                                {
                                    asteroidSplit(astrd);
                                }
                                
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
                        return (playerHit(player));
                    }
                }
            }
            return player;
        }


        // if the player is hit
        private Ship playerHit(Ship player) 
        {
            player.canCollide = false;
            player.eraseThing();
            Thread.Sleep(1000);
            Ship newPlayer = spawnShip(para);
            while (helpers.closestAsteroid(newPlayer, para) < (newPlayer.radius * 6)) { Thread.Sleep(20); }
            para.lives--;
            return newPlayer;
        }



        private void asteroidSplit(Asteroid ast)
        {
            int multiplier = 1;

            for (int i = 0; i < 2; i++) 
            {
                int index = helpers.firstValid(para.spawnedAsteroids);
                if (index >= 0)
                { // if the spawn cap for asteroids has not been reached

                    Asteroid asteroid = new Asteroid(para, ast.origin.X, ast.origin.Y, ast.radius - (para.scale - 10));

                    asteroid.Angle = (ast.angle + (random.Next(5, 20) * multiplier));
                    multiplier = -1;
                    asteroid.speed = ast.speed + 2;

                    para.addAsteroid(index, asteroid);
                    Thread asteroidThread = new Thread(asteroid.simulateAsteroid);
                    asteroidThread.Start();
                }
            }      
        }


        internal void nextLevel() 
        { // generates the asteroids for each level. Gets progressively harder.
            for (int i = 0; i < 20; i++) 
            {
                spawnRandomAsteroid();
            }
        }

    }
}