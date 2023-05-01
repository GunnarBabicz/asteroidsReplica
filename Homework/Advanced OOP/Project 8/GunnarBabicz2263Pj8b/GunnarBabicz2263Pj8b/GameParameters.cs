using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj8b
{
    /* GAB 04/07/2023
     * Stores parameters that are used to 
     * define other classes. Meant to reduce clutter.
     */
    public class GameParameters
    {
        
        // instance of the form 1 object (used to make new Graphics objects)
        public Form1 f1;

        // resolution of the window
        private int resolutionHeight;
        private int resolutionWidth;

        // colors and pen parameters
        private Color entityColor = Color.White;
        private Color backgroundColor = Color.Black;
        private int penWidth = 1;


        // gameplay variables
        internal int score = 0;
        internal int level = 0;
        internal int lives = 0;

        // instance of the player
        internal Ship player;

        // internal variables (not viewable)
        internal Asteroid[] spawnedAsteroids = new Asteroid[80];
        internal Laser[] spawnedLasers = new Laser[4];
        internal int numberOfAsteroids = 0;
        internal int numberOfLasers = 0;
        internal bool inPlay = false;

        // used to scale entity size based on screen width
        internal int scale;
        internal int asteroidScale;

        /* GAB 04/07/2023
         *  Constructor if a resolution other than the standard 720p is chosen */
        public GameParameters(int resolutionWidthFoo, int resolutionHeightFoo)
        {
            resolutionWidth = resolutionWidthFoo;
            resolutionHeight = resolutionHeightFoo;
            defineScale();
        }


        /* GAB 04/30/2023
        * Creates an internal scale number used to size entities */
        private void defineScale() 
        {
            double rawNum = (resolutionWidth / 2560) * 50;
            scale = (int)Math.Round(rawNum);
            asteroidScale = (scale - 10);
            /* creates a size scaler for the entities based on the resolution width.
             * Adapted from the dev resolution of 2560x1440. */
        }


        // getter and setter methods
        public void loadForm(Form1 foo) { f1 = foo; }


        /* GAB 04/07/2023
         *  getter/setter for width of the screen*/
        public int Width
        {
            get { return resolutionWidth; }
            set { resolutionWidth = value; }
        }

        /* GAB 04/07/2023
         *  getter/setter for height of the screen */
        public int Height
        {
            get { return resolutionHeight; }
            set { resolutionHeight = value; }
        }

        /* GAB 04/07/2023
         *  getter/setter for color of Entities */
        public Color EntityColor
        {
            get { return entityColor; }
            set { entityColor = value; }
        }

        /* GAB 04/07/2023
         *  getter/setter for color of Background */
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }

        /* GAB 04/07/2023
         *  getter/setter for pen width */
        public int PenWidth
        {
            get { return penWidth; }
            set { penWidth = value; }
        }

        /* GAB 04/30/2023
        * Adds an asteroid to the list of Asteroid objects */
        internal void addAsteroid(int i, Asteroid Foo) 
        {
            spawnedAsteroids[i] = Foo;
            numberOfAsteroids++;
        }

        /* GAB 04/30/2023
        * Removes an asteroid from the list of asteroid objects
        * (allows it to be replaced and stops simulating) */
        public void removeAsteroid(int i) 
        {
            spawnedAsteroids[i].isAlive = false;
            numberOfAsteroids--; 
        }

        /* GAB 04/30/2023
        * Adds a laser to the list of laser objects */
        internal void addLaser(int i, Laser Foo) 
        {
            spawnedLasers[i] = Foo;
            numberOfLasers++; 
        }

        /* GAB 04/30/2023
        * Removes a laser from the list of laser objects
        * (allows it to be replaced and stops simualting) */
        public void removeLaser(int i) 
        {
            spawnedLasers[i].isAlive = false;
            numberOfLasers--; 
        }
    }
}
