using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj4
{
    class FileManager
    {
        private string outputDirectory;
        private string inputContents;
        private string outputContents;

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

        public void OpenFile() 
        {
            
        }



        public void GetSaveDirectory() 
        {
            SaveFileDialog saveFile= new SaveFileDialog();
            saveFile.Title = "Save File";
            saveFile.Filter = "Text File (*.txt)|*.txt";
            saveFile.ShowDialog();

            outputDirectory = saveFile.FileName;

        }


        public void SaveEncodedFile(string fileDirectory) 
        {
            Rot13DecoderRing Rot13 = new Rot13DecoderRing();

            // file contents saved to a string
            inputContents = File.ReadAllText(fileDirectory);
            
            // file is encoded
            Rot13.Encode(inputContents);
            
            // encoded string defined
            outputContents = Rot13.EncodedText;
            
            GetSaveDirectory();

            if (outputDirectory != "") 
            { // if the save directory is empty, does not attempt to save file
                File.WriteAllText(outputDirectory, outputContents);
            }



        }



    }
}
