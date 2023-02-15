using static System.Windows.Forms.LinkLabel;


/* Gunnar Babicz - 02/13/2023
* GUI interface for user to encode entered text
* or txt file using ROT13.
*/
namespace GunnarBabicz2263Pj4
{
    public partial class Form1 : Form
    {
        /* Gunnar Babicz - 02/13/2023
         * Initializes form
         */
        public Form1()
        {
            InitializeComponent();
        }

  
        /* Gunnar Babicz - 02/13/2023
         * On button click, prompts the user for a .txt file to open.
         */
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            string fileChosen = FileManager.OpenFile();
            txtFileChosen.Text = fileChosen;
        }

        /* Gunnar Babicz - 02/13/2023
         * On button click, clears the contents of the FileChosen textbox. 
         */
        private void btnClearFile_Click(object sender, EventArgs e)
        {
            txtFileChosen.Text = "";
        }


        /* Gunnar Babicz - 02/13/2023
         * On button click, encodes string in txtIn with ROT13
         */
        private void btnRot13Run_Click(object sender, EventArgs e)
        {
            Rot13DecoderRing Rot13 = new Rot13DecoderRing();
            Rot13.Encode(txtIn.Text);
            txtIn.Text = "";
            txtIn.Text = Rot13.EncodedText;         
        }

        /* Gunnar Babicz - 02/13/2023
         * On button click, saves a ROT13 encoded version of the user defined file
         */
        private void btnSaveEncodedFile_Click(object sender, EventArgs e)
        {
            // creating an instance of the FileManager object
            FileManager explorer = new FileManager();

            // saving the encoded file
            explorer.ConvertFile(txtFileChosen.Text);


        }

        /* Gunnar Babicz - 02/13/2023
         * any methods that are done immediately
         * upon the form loading (unused)
         */
        private void Form1_Load(object sender, EventArgs e){}
    }
}