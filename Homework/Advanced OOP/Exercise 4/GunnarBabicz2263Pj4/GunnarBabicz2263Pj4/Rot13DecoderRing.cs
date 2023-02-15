using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Gunnar Babicz - 02/13/2023
 * This program encodes user input using the ROT13
 * character substitution function. 
 * Source of the ROT13 function: https://en.wikipedia.org/wiki/ROT13
*/
namespace GunnarBabicz2263Pj4
{
    
    class Rot13DecoderRing
    {
        // class variables
        private string clearText = "";
        private string encodedText = "";



        /* Gunnar Babicz - 02/13/2023
         * Getter/Setter methods for the class variables
         */
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


        /* Gunnar Babicz - 02/13/2023
         * Formats the input string to only allow accepted values.
         */
        public void canonicalizeString(string input) 
        {
            input.ToLower();
            clearText = new string(input.Where(c => Char.IsLetter(c) || c == ' ').ToArray());
        }


        /* Gunnar Babicz - 02/13/2023
         * Performs the ROT13 encryption method on input character.
         */
        private char rot13Char(char unconverted) 
        {
            int ascii = unconverted;
            if (ascii == 32) { return unconverted; }
            ascii = (((ascii - 84) % 26) + 97);

            char converted = Convert.ToChar(ascii);

            return converted;

        }

        /* Gunnar Babicz - 02/13/2023
         * Runs methods needed to fully complete ROT13 encryption of input string. 
         */
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
