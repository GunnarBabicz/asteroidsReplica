using System.Drawing.Printing;

namespace GunnarBabicz2263Pj8a
{
    /* GAB 04/07/2023
     *  Creates the GUI for Asteroids. */
    public partial class Form1 : Form
    {
        // instance variables
        Graphics g;
        bool inPlay = false;
        Ship player;
        Asteroid demoAsteroid;
        Settings gameSettings;




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
            g = this.CreateGraphics();
            g.Clear(this.BackColor);
            gameSettings = new Settings(this.Size.Width, this.Size.Height);
        }

        /* GAB 04/07/2023
         *  Activates when the play button is pressed */
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (demoAsteroid != null) 
            { // removes Asteroid object from screen if present
                demoAsteroid.eraseThing();
                demoAsteroid = null;
            }
            
            
            //deactivateButton(btnPlay);
            lblAsteroidsTitle.Hide();


            // Creating the game parameters based on the given settings
            Settings gameSettings = new Settings(this.Size.Width, this.Size.Height);
            // spawns a new ship if there is none
            if (player == null)
            {
                player = Event.spawnShip(gameSettings, g);
            }

            player.drawThing();

            // telling KeyPress the game is being played
            inPlay = true;
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
                    Thread.Sleep(33);
                }
                if (e.KeyChar == 'd')
                { // to rotate right
                    player.Rotate(-10);
                    Thread.Sleep(33); // about 30.3 FPS
                }

                if (e.KeyChar == 'w')
                { // to move forward
                    player.moveForward();
                    Thread.Sleep(33);
                }

                if (e.KeyChar == ' ')
                { // to fire laser
                    Event.createLaser(gameSettings, g, player);
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

            // despawning any extra objects
            if (player != null) { Event.despawn(player); }
            if (demoAsteroid != null) { Event.despawn(demoAsteroid); }


            demoAsteroid = Event.spawnAsteroid(gameSettings, g);
            demoAsteroid.drawThing();


            // runs the demo asteroid for 3 seconds
            for (int i = 0; i < 90; i++) 
            {
                demoAsteroid.updatePosition();
                Thread.Sleep(33);
            }
        }
    }
}