namespace OOPMidterm
{
    class removeDuplicates
    {
        // output should be 

        public string remove(string input)
        {
            string notDupe = "";
            if((input.Substring(1)).Contains(input[0]))
            {
            }
            else{ notDupe = input[0].ToString(); }

            if(input.Length > 1)
            {
                return notDupe + remove(input.Substring(1));
            }
            else{return notDupe; }

        }
    }
}