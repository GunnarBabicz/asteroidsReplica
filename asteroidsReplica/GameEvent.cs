using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace asteroids
{
    /* GAB 04/05/2023
     * GameEvent is a class to handle cases such as spawning entities and checking for hits*/
    internal class GameEvent
    {
        // Directory for sound files used
        SoundPlayer laserSound = new SoundPlayer(@"..\..\..\sounds\shoot.wav");
        SoundPlayer asteroidHitSound = new SoundPlayer(@"..\..\..\sounds\asteroidHit.wav");
        SoundPlayer shipKilled = new SoundPlayer(@"..\..\..\sounds\shipKilled.wav");
        private GameParameters para;
        Random random = new Random();

        /* GAB 04/30/2023
        * Run on game start to reset game stats */
        public void gameStart(GameParameters foo) 
        {
            para = foo;
            para.lives = 3;
            para.score = 0;
        }

        /* GAB 04/07/2023
         *  Creates a new Ship object in the center of the screen */
        public static Ship spawnShip(GameParameters gameSettingsFoo) 
        {   // known bug: Will not support odd numbered screen sizes.
            int centerHeight = gameSettingsFoo.Height / 2;
            int centerWidth = gameSettingsFoo.Width / 2;
            return new Ship(gameSettingsFoo, centerWidth, centerHeight, gameSettingsFoo.scale);
        }

        /* GAB 04/06/2023
         * Spawns an asteroid with random size, location, and velocity.
         * Work in progress. */
        public void spawnRandomAsteroid() 
        { // spawns a astroid with random values

            int index = Helpers.firstValid(para.spawnedAsteroids);
            if (index >= 0)
            { /* spawns an asteroid with random size, location, and speed if spawn cap
               * has not been reached */

                // this block of code keeps asteroids from spawning on top of the player
                int positiveOrNegative = random.Next(2);
                if (positiveOrNegative == 0) { positiveOrNegative = 1; }
                else { positiveOrNegative = -1; }
                int xPos = (para.Width/2 + (random.Next(para.scale*3, para.Width/2)*positiveOrNegative));
                int yPos = (para.Height/2 + (random.Next(para.scale*3, para.Height/2)*positiveOrNegative));


                int radius = 3 * para.asteroidScale;
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
            int i = Helpers.firstValid(para.spawnedLasers);
            if (i >= 0) 
            { // if a laser is able to be spawned
                Laser laser = new Laser(para,
                vessel.xPos, vessel.yPos, 5);
                laser.Angle = vessel.Angle;
                laser.Speed = 50;
                laserSound.Play();
                para.addLaser(i, laser);
                Thread laserThread = new Thread(laser.simulateLaser);
                laserThread.Start();
                // starts the threads
            }
        }

        /* GAB 04/30/2023
        * Checks for ship and laser collisions */
        public Ship checkCollision(Ship player, Graphics g)
        {
            if (para.numberOfLasers > 0) { checkAsteroidCollision(); }
            return checkShipCollision(player, g);
        }

        /* GAB 04/30/2023
        * Checks for collisions between any lasers and asteroids */
        public void checkAsteroidCollision()
        {
            for (int i = 0; i < para.spawnedAsteroids.Length; i++)
            { // for each asteroid in the array
                if (Helpers.entityIsAlive(para.spawnedAsteroids[i]))
                { // if the asteroid should be checked
                    Asteroid astrd = para.spawnedAsteroids[i];
                    for (int j = 0; j < para.spawnedLasers.Length; j++)
                    { // for each laser in the array
                        if (Helpers.entityIsAlive(para.spawnedLasers[j]))
                        { // if the laser should be checked
                            Laser lsr = para.spawnedLasers[j];
                            if (Helpers.circlePointCollision(astrd, lsr))
                            { // if the two collided
                                para.score += determineScore(astrd);
                                asteroidHitSound.Play();
                                if(astrd.radius >= para.asteroidScale*2) 
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

        /* GAB 04/30/2023
        * Splits a larger asteroid into two smaller asteroids */
        private void asteroidSplit(Asteroid ast)
        {
            int multiplier = 1;

            for (int i = 0; i < 2; i++)
            {
                int index = Helpers.firstValid(para.spawnedAsteroids);
                if (index >= 0)
                { // if the spawn cap for asteroids has not been reached

                    Asteroid asteroid = new Asteroid(para, ast.origin.X, ast.origin.Y, ast.radius - para.asteroidScale);

                    // adds a new random angle
                    int angleChange = (random.Next(-180, 181));
                    asteroid.Angle = (ast.angle + (random.Next(0, 360)));
                    while (asteroid.Angle > 359) { asteroid.Angle -= 360; }
                    while (asteroid.Angle < 0) { asteroid.Angle += 360; }



                    // either adds or reduces speed from asteroid
                    asteroid.Speed = ast.speed + getNewSpeed(angleChange);

                    // keep the asteroid at a minimum speed of 2
                    while (asteroid.speed < 2) { asteroid.speed++; }

                    para.addAsteroid(index, asteroid);
                    Thread asteroidThread = new Thread(asteroid.simulateAsteroid);
                    asteroidThread.Start();
                }
            }
        }

        /* GAB 04/30/2023
        * If a laser hits an asteroid */
        private void laserHit(int asteroidIndex, int laserIndex)
        { // if a laser and asteroid collide
            para.removeAsteroid(asteroidIndex);
            para.removeLaser(laserIndex);
        }

        /* GAB 04/30/2023
        * Adds to player score based on the size of the asteroid */
        public int determineScore(Asteroid foo)
        {
            if (foo.radius == (para.asteroidScale * 3)) { return 20; }
            if (foo.radius == (para.asteroidScale * 2)) { return 50; }
            return 100;
        }

        /* GAB 04/30/2023
        * Checks if the player has been hit by any asteroids */
        private Ship checkShipCollision(Ship player, Graphics g) 
        {
            for (int i = 0; i < para.spawnedAsteroids.Length; i++)
            { // for each asteroid in the array
                if (Helpers.entityIsAlive(para.spawnedAsteroids[i])) 
                { // if the asteroid should be checked
                    if (Helpers.checkShipCollision(player, para.spawnedAsteroids[i]))
                    {
                        shipKilled.Play();
                        return (playerHit(player));
                    }
                }
            }
            return player;
        }

        /* GAB 04/30/2023
        * If the player is hit by an asteroid */
        private Ship playerHit(Ship player) 
        {
            player.canCollide = false;
            player.eraseThing();
            Thread.Sleep(1000);
            Ship newPlayer = spawnShip(para);

            // keeps the player from spawning inside an asteroid
            while (Helpers.closestAsteroid(newPlayer, para) < (newPlayer.radius * 4)) { Thread.Sleep(20); }
            para.lives--;
            return newPlayer;
        }

        /* GAB 04/30/2023
        * Advances the game to the next level */
        internal void nextLevel() 
        { // generates the asteroids for each level. Gets progressively harder.
            for (int i = 0; i < para.level + 5; i++) 
            {
                spawnRandomAsteroid();
            }
        }

        /* GAB 04/30/2023
        * Creates a speed for child asteroids based on angle of departure */
        internal int getNewSpeed(int angleChange) 
        {
            angleChange = Math.Abs(angleChange);
            if (angleChange > 120) { return -2; }
            if (angleChange > 60) { return -1; }
            if (angleChange > 30) { return 1; }
            { return 2; }
        }
    }
}