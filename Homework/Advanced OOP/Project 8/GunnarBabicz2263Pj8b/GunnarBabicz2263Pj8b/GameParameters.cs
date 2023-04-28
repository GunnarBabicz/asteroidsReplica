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
        // class variables 
        
        // instance of the form 1 object (used to make new Graphics objects)

        public Form1 f1;

        // resolution of the window
        private int resolutionHeight;
        private int resolutionWidth;

        // colors and pen parameters
        private Color entityColor = Color.White;
        private Color backgroundColor = Color.Black;
        private int penWidth = 1;


        // gameplay variables (player viewable)
        internal int score = 0;
        internal int level = 1;
        internal int lives = 3;


        // instance of the player
        internal Ship player;


        // internal variables (not viewable)
        internal Asteroid[] spawnedAsteroids = new Asteroid[80];
        internal Laser[] spawnedLasers = new Laser[4];
        internal int numberOfAsteroids = 0;
        internal int numberOfLasers = 0;






        /* While these variables may not stay here,
         * they will be needed somewhere in the program.
         * Will remain here for now. 
         */


        /* GAB 04/07/2023
         *  Constructor if a resolution other than the standard 720p is chosen */
        public GameParameters(int resolutionWidthFoo, int resolutionHeightFoo)
        {
            resolutionWidth = resolutionWidthFoo;
            resolutionHeight = resolutionHeightFoo;
        }

        // Constructor with the default resolution of 720p
        public GameParameters()
        {
            resolutionWidth = 1280;
            resolutionHeight = 720;
        }


        // getter and setter methods

        public void loadForm(Form1 foo) { f1 = foo; }


        /* GAB 04/07/2023
         *  getter/setter for width of the screen*/
        public int ResolutionWidth
        {
            get { return resolutionWidth; }
            set { resolutionWidth = value; }
        }

        /* GAB 04/07/2023
         *  getter/setter for height of the screen */
        public int ResolutionHeight
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



        internal void addAsteroid(int i, Asteroid Foo) 
        {
            spawnedAsteroids[i] = Foo;
            numberOfAsteroids++;
        }

        public void removeAsteroid(int i) 
        {
            spawnedAsteroids[i].isAlive = false;
            numberOfAsteroids--; 
        }

        internal void addLaser(int i, Laser Foo) 
        {
            spawnedLasers[i] = Foo;
            numberOfLasers++; 
        }

        public void removeLaser(int i) 
        {
            spawnedLasers[i].isAlive = false;
            numberOfLasers--; 
        }

    }
}
