using System.Drawing.Printing;

namespace GunnarBabicz2263Pj8b
{
    /* GAB 04/07/2023
     *  Creates the GUI for Asteroids. */
    public partial class Form1 : Form
    {
        // instance variables


        // if the game is being played
        bool inPlay = false;

        Ship player;

        // game parameters
        Settings gameSettings;





        /* maybe give the objects an index? This could be used to
         * specifically despawn them if a list is the decided upon choice
         * to manage classes of entities. May just be able to despawn them
         * through no longer taking action on them. Could be useful for acting on
         * gamewide events (player dies) or there may be a simpler method that just halts
         * all threads. 
         * 
         * 
         * What would be the best way to implement a tick timer? Do we want this tick timer to 
         * be the same as the frames per second? Could potentially change functions on entities
         * to only run once instead of using a while loop
         */

        // list of all the asteroid objects
        Asteroid[] asteroids;

        // list of all the laser objects
        Laser[] lasers;




        /* GAB 04/07/2023
         *  Initializes the form */
        public Form1()
        {
            InitializeComponent();
        }


        /* GAB 04/07/2023
         *  Runs on Form start */
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            gameSettings = new Settings(this.Size.Width, this.Size.Height);
            player = Event.spawnShip(gameSettings, this.CreateGraphics());
        }

        /* GAB 04/07/2023
         *  Activates when the play button is pressed */
        private void btnPlay_Click(object sender, EventArgs e)
        {

            //deactivateButton(btnPlay);
            lblAsteroidsTitle.Hide();

            // renders the player's ship
            player.drawThing();

            // telling KeyPress the game is being played
            inPlay = true;

            Asteroid asteroid = Event.spawnAsteroid(gameSettings, this.CreateGraphics());
            Thread asteroidThread = new Thread(asteroid.testAsteroid);
            asteroidThread.Start();
        }


        /* GAB 04/07/2023
         *  When a key is pressed while Asteroids is open */
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(inPlay) 
            { // will only run if game is currently being played
                if (e.KeyChar == 'a')
                { // to rotate left
                    player.Rotate(10);
                    Thread.Sleep(10);
                }
                if (e.KeyChar == 'd')
                { // to rotate right
                    player.Rotate(-10);
                    Thread.Sleep(10); // about 30.3 FPS
                }

                if (e.KeyChar == 'w')
                { // to move forward
                    player.moveForward();
                    Thread.Sleep(10);
                }

                if (e.KeyChar == ' ')
                { // to fire laser
                    Laser laser = Event.createLaser(gameSettings, this.CreateGraphics(), player);
                    Thread laserThread = new Thread(laser.simulateLaser);
                    laserThread.Start();
                }

                if (e.KeyChar == 'p')
                { // pause menu

                }
            }
        }

        /*
         * Gunnar Babicz 04/05/2023
         * If the user presses the exit button
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /* GAB 04/06/2023
         * Hides and disables the button provided */
        public void deactivateButton(Button foo) 
        {
            foo.Hide();
            foo.Enabled = false;
        }

        /* GAB 04/06/2023
         * Shows and activates the button provided */
        public void activateButton(Button foo) 
        {
            foo.Show();
            foo.Enabled = true;
        }






        /* GAB 04/07/2023
         *  Creates a random asteroid that moves for 3 seconds.
         *  For testing purposes.
         */
        private void btnTestAsteroid_Click(object sender, EventArgs e)
        {
            inPlay = false;
            Settings gameSettings = new Settings(this.Size.Width, this.Size.Height);

            /*
            // despawning any extra objects
            if (player != null) { Event.despawn(player); }
            if (demoAsteroid != null) { Event.despawn(demoAsteroid); }
            */
            Asteroid asteroid = Event.spawnAsteroid(gameSettings, this.CreateGraphics());
            Thread asteroidThread = new Thread(asteroid.testAsteroid);
            asteroidThread.Start();
        }
    }
}