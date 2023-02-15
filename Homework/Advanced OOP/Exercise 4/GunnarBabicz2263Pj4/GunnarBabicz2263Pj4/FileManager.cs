using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

/* Gunnar Babicz - 02/13/2023
* FileManager is a class for performing various file
* operations needed for the ROT13 decoder program. 
* 
*/
namespace GunnarBabicz2263Pj4
{
    class FileManager
    {

        /* Gunnar Babicz - 02/13/2023
         * class variables
         */
        private string outputDirectory = "";
        private string inputContents = "";
        private string outputContents = "";


        /* Gunnar Babicz - 02/13/2023
         * Getter/setter methods for the class variables
         */

        public string OutputDirectory 
        {
            get { return outputDirectory; }
            set { outputDirectory = value; }
        }

        public string InputContents 
        {
            get { return inputContents; }
            set { inputContents = value; }
        }

        public string OutputContents
        {
            get { return outputContents; }
            set { outputContents = value; }
        }


        /* Gunnar Babicz - 02/13/2023
         * Prompts the user for a txt file to open.
         */
        public static string OpenFile()
        {
            OpenFileDialog chooseFile = new OpenFileDialog();
            chooseFile.Title = "Select File";
            chooseFile.Filter = "Text|*.txt";
            chooseFile.ShowDialog();
            return chooseFile.FileName;
        }


        /* Gunnar Babicz - 02/13/2023
         * Prompts the user to select the save directory for the encoded file.
         * Error handling and DialogResult adapted from note 4.9
         */
        public void GetSaveDirectory() 
        {
            SaveFileDialog saveFile= new SaveFileDialog();
            saveFile.Title = "Save File";
            saveFile.Filter = "Text|*.txt";
            DialogResult result = saveFile.ShowDialog();

            if (saveFile.FileName != "")
            {
                outputDirectory = saveFile.FileName;
            }

            // if output directory is blank and user did not
            // press cancel, shows error message
            else if(result != DialogResult.Cancel)
            {
                Popup.Error("Invalid save directory");
            }
        }


        /* Gunnar Babicz - 02/13/2023
         * Creates the ROT13 encoded string of the input text file's contents
         */
        private void EncodeInputFile(string inputDirectory) 
        {
            Rot13DecoderRing Rot13 = new Rot13DecoderRing();
            try
            {
                inputContents = File.ReadAllText(inputDirectory);
                Rot13.Encode(inputContents);
                outputContents = Rot13.EncodedText;

                // collects desired save directory if file has at least one valid
                // character
                if (outputContents.Length > 0) { GetSaveDirectory(); }
                else { Popup.Error("Input file contains no valid characters"); }
                
            }
            catch (IOException)
            {
                Popup.Error("Error reading from the file");
            }
        }


        /* Gunnar Babicz 02-13-2023
         * Runs the methods needed to correctly save the encoded file
         */
        private void SaveEncodedFile(string inputDirectory) 
        {
            // encoding input file
            EncodeInputFile(inputDirectory);
            if ((outputDirectory != "" ) && (outputContents != ""))
            { // if the output contents and save directory are both valid
                try
                {
                    File.WriteAllText(outputDirectory, outputContents);
                    Popup.Info("Saved", "File saved");
                }
                catch (IOException) { Popup.Error("Unable to save file"); }
            }

        }


        /* Gunnar Babicz - 02/13/2023
         * Runs the methods needed when the save button is pressed
         */
        public void ConvertFile(string inputDirectory) 
        {

            // if the file exists 
            if (File.Exists(inputDirectory))
            {
                SaveEncodedFile(inputDirectory); 
            }

            // If the file does not exist
            else { Popup.Error("File not found. Please select a valid file"); }
        }
    }
}
