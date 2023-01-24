namespace GunnarBabiczEx1
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

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string EnteredName = txtName.Text;
            txtName.Text = "Hello, " + EnteredName + "!";
        }
    }
}