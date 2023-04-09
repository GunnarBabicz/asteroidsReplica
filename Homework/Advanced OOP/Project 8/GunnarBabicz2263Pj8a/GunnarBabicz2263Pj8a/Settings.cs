using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj8a
{
    /* GAB 04/07/2023
     * Stores parameters that are used to 
     * define other classes. Meant to reduce clutter.
     */
    internal class Settings
    {
        // class variables 
        private int resolutionHeight;
        private int resolutionWidth;
        private Color entityColor = Color.White;
        private Color backgroundColor = Color.Black;
        private int penWidth = 1;

        /* While these variables may not stay here,
         * they will be needed somewhere in the program.
         * Will remain here for now. 
         */
        public int score;
        public int shipLives;
        public int numberAsteroids;



        /* GAB 04/07/2023
         *  Constructor */
        public Settings(int resolutionWidthFoo, int resolutionHeightFoo)
        {
            resolutionWidth = resolutionWidthFoo;
            resolutionHeight = resolutionHeightFoo;
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

    }
}
