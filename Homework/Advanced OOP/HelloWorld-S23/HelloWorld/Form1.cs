namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDoStuff_Click(object sender, EventArgs e)
        {
            TextBox1.BackColor = Color.Orange;
            TextBox1.Text = "Hello World";
        }
    }
}