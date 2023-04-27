using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj8b
{

    /* GAB 04/25/2023
     * gameMaster is a class to handle background processes
     * such as scoring, level, and number of lives. */
    internal class gameMaster
    {
        internal int score = 0;
        private int level = 1;
        internal Asteroid[] spawnedAsteroids = new Asteroid[80];
        internal Laser[] spawnedLasers = new Laser[4];
        internal Ship player;

        private int numberOfAsteroids = 0;
        private int numberOfLasers = 0;



        public int NumberOfAsteroids
            {
                get { return numberOfAsteroids; }
                set { numberOfAsteroids = value; }
            }

        public int NumberOfLasers
        {
            get { return numberOfLasers; }
            set { numberOfLasers = value; }
        }


        public int canSpawnLaser() 
        { // checks if a laser can spawn and if so, returns the index of first open spot in array
            // checking the laser list for the first empty spot
            for (int i = 0; i < spawnedLasers.Length; i++)
            {
                if (spawnedLasers[i] != null)
                {
                    if (spawnedLasers[i].isAlive == false) { return i; }
                }
                else { return i; }
            }
            return -1;
        }



        public int canSpawnAsteroid() 
        {
            // checking the asteroid list for the first empty spot
            for (int i = 0; i < spawnedAsteroids.Length; i++)
            {
                if (spawnedAsteroids[i] != null)
                {
                    if (spawnedAsteroids[i].isAlive == false) { return i; }
                }
                else { return i; }
            }
            return -1;
        }


        /* GAB 04/25/2023
         * If asteroid has been hit by a laser, despawns.
         * Otherwise, updates its position.
         */




        public void asteroidHit() 
        {
            NumberOfAsteroids--;
            NumberOfLasers--;
            score += 100;
        }


        public void addPlayer(Ship p) 
        {
            player = p;
        }









    }
}
