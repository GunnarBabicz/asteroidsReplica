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

        // resolution of the window
        private int resolutionHeight;
        private int resolutionWidth;

        // colors and pen parameters
        private Color entityColor = Color.White;
        private Color backgroundColor = Color.Black;
        private int penWidth = 1;


        // gameplay variables (player viewable)
        internal int score = 0;
        private int level = 1;

        // instance of the player
        internal Ship player;


        // internal variables (not viewable)
        internal Asteroid[] spawnedAsteroids = new Asteroid[80];
        internal Laser[] spawnedLasers = new Laser[4];
        private int numberOfAsteroids = 0;
        private int numberOfLasers = 0;






        /* While these variables may not stay here,
         * they will be needed somewhere in the program.
         * Will remain here for now. 
         */


        /* GAB 04/07/2023
         *  Constructor if a resolution other than the standard 1080p is chosen */
        public GameParameters(int resolutionWidthFoo, int resolutionHeightFoo)
        {
            resolutionWidth = resolutionWidthFoo;
            resolutionHeight = resolutionHeightFoo;
        }

        // Constructor with the default resolution of 1080p
        public GameParameters()
        {
            resolutionWidth = 1920;
            resolutionHeight = 1080;
        }


        // getter and setter methods


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

        public void addAsteroid() { numberOfAsteroids++; }

        public void removeAsteroid() { numberOfAsteroids--; }

        public void addLaser() { numberOfLasers++; }

        public void removeLaser() { numberOfLasers--; }

    }
}
