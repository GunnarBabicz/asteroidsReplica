namespace GunnarBabiczEx2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Need to add logic to keep non AND accept integers
            
            
            
            int yearEntered = int.Parse(txtIn.Text);

            if ((yearEntered % 4 == 0) && (yearEntered % 100) != 0 || (yearEntered % 100 == 0) && (yearEntered % 400 == 0))
            { // if the year entered is a leap year
                lblOut.Text = ($"{yearEntered} is a leap year");
                lblOut.BackColor = Color.Green;
            }



            else 
            { // if the year entered is not a leap year
                lblOut.Text = ($"{yearEntered} is not a leap year");
                lblOut.BackColor= Color.Red;
            }

        }

        private void txtIn_TextChanged(object sender, EventArgs e)
        {

        }





    }
}