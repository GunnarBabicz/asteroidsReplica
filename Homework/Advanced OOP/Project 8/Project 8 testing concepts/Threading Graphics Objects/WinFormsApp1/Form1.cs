namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public int desiredFramerate;
        public int framerate;
        bool isRunning;
        public int numEntities;
        Random random;




        private void Form1_Load(object sender, EventArgs e)
        {
            desiredFramerate = 60;
            framerate = Convert.ToInt32(1000 / desiredFramerate);
            isRunning = true;
            numEntities = 0;
            random = new Random();
        }


        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Creates a bouncing ball and then moves the next one 
         * a row further down. Meant to test running multiple graphics objects.
         */
        private void createBouncy() 
        {
            int width = 50;
            int height = random.Next(2, 49) * 20;
            int distance = -5;
            while (isRunning)
            {
                this.CreateGraphics().DrawEllipse(new Pen(Brushes.Blue, 1), new Rectangle(width, height, 10, 10));
                Thread.Sleep(framerate);
                this.CreateGraphics().DrawEllipse(new Pen(Brushes.White, 1), new Rectangle(width, height, 10, 10));
                if (width > 1000 || width < 0) { distance *= -1; }
                width += distance;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            isRunning= false;
            Application.Exit();
        }

        private void btnNewThread_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(createBouncy);
            thread.Start();
            numEntities++;
            lblnumEntities.Text = ($"Number of Entities: {numEntities}");
        }
    }
}