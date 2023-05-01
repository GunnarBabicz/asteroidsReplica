using System.Drawing.Printing;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.Automation;
using System.Xml;

namespace GunnarBabicz2263Pj8b
{
    /* GAB 04/07/2023
     *  Creates the GUI for Asteroids. */
    public partial class Form1 : Form
    {
        // instance variables
        Leaderboard highScores;
        bool left, right, forward, shoot;
        SoundPlayer thrustSound = new SoundPlayer(@"..\..\..\sounds\thrust.wav");
        bool canFire = true;
        bool inPlay = false;
        Ship player;
        GameParameters parameters;
        public Graphics newGraphics() { return CreateGraphics(); }
        string oldInput;


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

            deactivateButton(btnMainMenu);
            lblScore.Hide();
            lblLives.Hide();
            lblLevel.Hide();
            txtNickname.Enabled= false;
            txtNickname.Hide();
            deactivateButton(btnNicknameEnter);
            lblScoreboard.Hide();



            parameters = new GameParameters(this.Size.Width, this.Size.Height);
            parameters.loadForm(this);
            player = GameEvent.spawnShip(parameters);
            pnlBorder.Width = parameters.Width;
            pnlBorder.Location = new Point(0, 0);
        }

        /* GAB 04/07/2023
         *  Activates when the play button is pressed */
        private void btnPlay_Click(object sender, MouseEventArgs e)
        {
            inPlay = true;
            // Loads the current game parameters into the event manager
            Event.gameStart(parameters);
            // hides the menu buttons
            hideMainMenu();
            player.drawThing();
            player.canCollide = true;
            lblScore.Show();
            lblLives.Show();
            lblLevel.Show();
            deactivateButton(btnNicknameEnter);

        }


        /* GAB 04/07/2023
         *  When a key is pressed while Asteroids is open */
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(player.canCollide)
            {
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
                    thrustSound.Play();
                }

                if (e.KeyCode == Keys.Space)
                { // to fire laser
                    shoot = true;
                }
            }   
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
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
                thrustSound.Stop();
            }

            if (e.KeyCode == Keys.Space)
            { // to fire laser
                shoot = false;
            }
        }





        // events that will be performed each tick
        private void tmrTickUpdate(object sender, EventArgs e)
        {

            if (parameters.lives > 0)
            { // if the game is paused. Will not currently work for asteroids
                player = Event.checkCollision(player, this.CreateGraphics());
            }


            if (parameters.lives > 0) 
            {
                player.drawThing();
                player.canCollide = true;

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

                player.updatePosition();
            }



                // updating the score
            lblScore.Text = ($"{parameters.score}");
            lblLives.Text = ($"Lives:{parameters.lives}");
            lblLevel.Text = ($"Level: {parameters.level}");


           if (parameters.numberOfAsteroids == 0 && inPlay)
            {
                parameters.level++;
                Event.nextLevel();
            }

            else if ((parameters.lives < 1) && (parameters.level > 0)) 
            {
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
            deactivateButton(btnNicknameEnter);
            lblScoreboard.Hide();
            txtNickname.Hide();
            showMainMenu();
        }

        private void txtNickname_TextChanged(object sender, EventArgs e)
        {
            string input = txtNickname.Text;
            if (input.Length > 3)
            {
                input = input.Substring(0,3);
            }

            string output = "";

            foreach (char c in input)
            {
                if (Char.IsLetter(c))
                {
                    output +=c;
                }
            }

            txtNickname.Text = output;
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
            parameters.level = 0;
            inPlay = false;
            lblLives.Hide();
            lblScore.Hide();
            lblLevel.Hide();
            lblTitle.Show();
            highScores = new Leaderboard();
            if (highScores.highScore(parameters.score))
            {
                txtNickname.Enabled = true;
                lblScoreboard.Text = "New High Score!\n\nEnter Nickname:";
                lblScoreboard.Show();
                lblScoreboard.SendToBack();
                oldInput = "";
                txtNickname.Show();
                txtNickname.BringToFront();
                btnNicknameEnter.BringToFront();
                activateButton(btnNicknameEnter);
            }
            else 
            {
                lblTitle.Text = "Game Over";
                lblTitle.Show();
                activateButton(btnMainMenu);
            }
        }



        private void btnNicknameEnter_Click(object sender, EventArgs e)
        {
            if (txtNickname.Text.Length == 3)
            {
                lblWarning.SendToBack();
                lblWarning.Hide();

                highScores.recieve(txtNickname.Text);
                lblScoreboard.Text = highScores.readScores();
                deactivateButton(btnNicknameEnter);
                txtNickname.Hide();
                txtNickname.Enabled = false;
                lblScoreboard.BringToFront();
                activateButton(btnMainMenu);
            }
            else 
            { 
                lblWarning.BringToFront();
                lblWarning.Text = "**Nickname needs to be 3 letters**";
                lblWarning.Show();
            }
            
        }



        private void hideMainMenu() 
        {
            lblTitle.Hide();
            deactivateButton(btnPlay);
            deactivateButton(btnMainMenu);
            deactivateButton(btnExit);
            deactivateButton(btnNicknameEnter);
            lblControls.Hide();
            lblWarning.Hide();
        }


        private void showMainMenu() 
        {
            lblWarning.Text = "** WARNING: This game includes " +
                "audio. Consider starting with low volume";
            lblTitle.Text = "Asteroids";
            lblTitle.Show();
            activateButton(btnPlay);
            activateButton(btnExit);
            lblControls.Show();
            lblWarning.Show();
        }



    }

}

