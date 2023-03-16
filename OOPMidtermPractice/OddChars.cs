namespace OOPMidterm
{
    class OddChars
    {
        public string strOddCharacters(string input, string output = "")
        {
            int length = input.Length;
            if(length == 0) { return output;}
            else if(length == 1)
            {
                output = input[0].ToString() + output;
                return output;
            }

            else
            {
                if(input.Length % 2 != 0)
                {
                   output = input[length - 1].ToString() + output;    
                }
                input = input.Remove(length-1);
                return strOddCharacters(input, output);
            }

            
        }
    }
}