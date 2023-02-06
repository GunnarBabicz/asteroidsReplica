using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj4
{
    class Rot13DecoderRing
    {
        private string clearText;
        private string encodedText;


        public string ClearText 
        {
            get { return clearText; }
            set { clearText = value; }
        }

        public string EncodedText 
        {
            get { return encodedText; }
            set { encodedText = value; }
        }


        public void canonicalizeString(string input) 
        {
            input.ToLower();
            clearText = new string(input.Where(c => Char.IsLetter(c) || c == ' ').ToArray());
        }



        private char rot13Char(char unconverted) 
        {
            int ascii = unconverted;
            if (ascii == 32) { return unconverted; }
            ascii = (((ascii - 84) % 26) + 97);

            char converted = Convert.ToChar(ascii);

            return converted;

        }

        public void Encode(string input) 
        {
            canonicalizeString(input);
            foreach (char c in clearText) 
            {
                encodedText += rot13Char(c);
            }
        }



    }
}
