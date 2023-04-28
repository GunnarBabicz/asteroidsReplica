using System.Drawing.Printing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.Automation;

namespace GunnarBabicz2263Pj8b
{
    /* GAB 04/07/2023
     *  Creates the GUI for Asteroids. */
    public partial class Form1 : Form
    {
        // instance variables

        
        
        // if the game is being played


        // the controls for the ship
        bool left, right, forward, shoot;


        // keeps the player from spamming lasers
        bool canFire = true;
        bool waitIsOver = false;

        Ship player;


        GameParameters parameters;
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



        // Creates a Graphics object for the form
        public Graphics newGraphics() { return CreateGraphics(); }


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

            lblSubtitle.Hide();
            this.KeyPreview = true;

            // need to define the parameters for each class that will use them

            deactivateButton(btnMainMenu);
            lblScore.Hide();
            lblLives.Hide();
            lblLevel.Hide();

            parameters = new GameParameters(this.Size.Width, this.Size.Height);
            parameters.loadForm(this);
            player = GameEvent.spawnShip(parameters);
        }

        /* GAB 04/07/2023
         *  Activates when the play button is pressed */
        private void btnPlay_Click(object sender, MouseEventArgs e)
        {
            // Loads the current game parameters into the event manager
            Event.gameStart(parameters);
            // hides the menu buttons
            deactivateButton(btnPlay);
            lblTitle.Hide();
            // renders the player's ship
            player.drawThing();
            player.canCollide = true;
            // telling KeyPress the game is being played

            lblScore.Show();
            lblLives.Show();
            lblLevel.Show();

            
        }


        /* GAB 04/07/2023
         *  When a key is pressed while Asteroids is open
         *
         *  All that needs done is to change the method of input 
         */
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (parameters.lives > 0 && (player.canCollide))
            { // will only run if game is currently being played
                if (e.KeyCode == Keys.A)
                { // to rotate left
                    left = true;
                }
                if (e.KeyCode == Keys.D)
                { // to rotate right
                    right = true;
                }

                if (e.KeyCode == Keys.W)
                { // to move forward
                    forward = true;
                }

                if (e.KeyCode == Keys.Space)
                { // to fire laser
                    shoot = true;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (parameters.lives > 0 && player.canCollide)
                { // will only run if game is currently being played
                    if (e.KeyCode == Keys.A)
                    { // to rotate left
                        left = false;
                    }

                    if (e.KeyCode == Keys.D)
                    { // to rotate right
                        right = false;
                    }

                    if (e.KeyCode == Keys.W)
                    { // to move forward
                        forward = false;
                    }

                    if (e.KeyCode == Keys.Space)
                    { // to fire laser
                        shoot = false;
                    }

                    if (e.KeyCode == Keys.P)
                    { // pause menu

                    }
                }
            }
        }





        // events that will be performed each tick
        private void tmrTickUpdate(object sender, EventArgs e)
        {

            if (parameters.lives > 0)
            { // if the game is paused. Will not currently work for asteroids

                
                player = Event.checkCollision(player, this.CreateGraphics());
                player.drawThing();
                player.canCollide = true;

                /* Player movement and actions */
                if (left == true) { player.Rotate(10); }
                if (right == true) { player.Rotate(-10); }
                if (forward == true) { player.moveForward(); }
                if ((shoot == true) && (canFire == true))
                {
                    Event.fireLaser(CreateGraphics(), player);

                    /* disables the laser from firing again and
                     * creates a thread for its timer */
                    canFire = false;
                    Thread laserBuffer = new Thread(fireDelay);
                    laserBuffer.Start();
                }


                /* Testing for collisions */

                player.updatePosition();

                // updating the score
                lblScore.Text = ($"Score: {parameters.score}");
                lblLives.Text = ($"Lives:{parameters.lives}");
                lblLevel.Text = ($"Level: {parameters.level}");


                if ((parameters.numberOfAsteroids == 0))
                {
                    parameters.level++;
                    Event.nextLevel();
                }


            }
            else if ((parameters.lives < 1) && (parameters.level > 0)) 
            {
                player.eraseThing();
                gameOver();
            }
        }


        /*
        * Gunnar Babicz 04/05/2023
        * If the user presses the exit button
        */
        private void btnExit_Click(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        /* GAB 04/06/2023
         * Shows and activates the button provided */
        public void activateButton(Button foo) 
        {
            foo.Show();
            foo.Enabled = true;
        }


        /* GAB 04/06/2023
        * Hides and disables the button provided */
        public void deactivateButton(Button foo)
        {
            foo.Hide();
            foo.Enabled = false;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            parameters = new GameParameters(this.Size.Width, this.Size.Height);
            parameters.loadForm(this);
            deactivateButton(btnMainMenu);
            activateButton(btnPlay);
            lblSubtitle.Hide();
            lblTitle.Text = "Asteroids";
        }


        /*
         * Delays the lasers to keep the player
         * from spamming. */
        public void fireDelay() 
        {
            Thread.Sleep(150);
            canFire= true;
        }



        private void gameOver() 
        {

            lblLives.Hide();
            lblScore.Hide();
            lblLevel.Hide();
            lblTitle.Text = "Game Over";
            lblSubtitle.Text = $"Score: {parameters.score}";
            lblSubtitle.Show();
            lblTitle.Show();
            activateButton(btnMainMenu);
        }


    }
}