using static System.Windows.Forms.LinkLabel;

namespace GunnarBabicz2263Pj4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();
            chooseFile.Title = "Select File";
            chooseFile.Filter = "Text|*.txt|All|*.*";
            chooseFile.ShowDialog();
            txtFileChosen.Text = chooseFile.FileName;
        }

        private void btnClearFile_Click(object sender, EventArgs e)
        {
            txtFileChosen.Text = "";
        }

        private void btnRot13Run_Click(object sender, EventArgs e)
        {
            Rot13DecoderRing Rot13 = new Rot13DecoderRing();
            Rot13.Encode(txtIn.Text);
            txtIn.Text = "";
            txtIn.Text = Rot13.EncodedText;         
        }

        private void btnSaveEncodedFile_Click(object sender, EventArgs e)
        {
            // creating an instance of the FileManager object
            FileManager explorer = new FileManager();

            // saving the encoded file
            explorer.SaveEncodedFile(txtFileChosen.Text);

            if (explorer.OutputDirectory != "")
            { // if the file is saved successfully
                txtFileChosen.Text = "File saved";
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}