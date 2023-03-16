namespace OOPMidterm
{
    class removeDuplicates
    {
        // output should be 

        public string remove(string input, string output = "")
        {
            if(input == ""){return "";}
            string currentCharacter = input[0].ToString();
            if(input.Length > 1)
            {
                if(output.Contains(currentCharacter) == false){output += currentCharacter;}
                return remove(input.Substring(1), output); 
            }

            else
            {
                if(output.Contains(currentCharacter) == false){output += currentCharacter;}
                return output; 
            }
        }


        public string recursion(string s, int i = 0, int j = 1)
        {
            if(j>=s.Length) 
            {
                if(i == s.Length) {return s;}
                i += 1;
                j = i + 1;
                return recursion(s, i, j);
            }

            if(s[i] == s[j])
            {
                s = s.Remove(j,1); //remove
            }
            else{j += 1;}
            return recursion(s, i, j); // then start again
        }
    }
}



// expected output: "abcefgs"