using System;
using System.Text;




namespace final 
{
    /*
    Write a C# function that accepts a 2-dimensional array of integers b
     and returns true if and only if b contains at least 2 rows that are
     identical, i.e., have the same values in the same positions.
    */




    public class final3
    {
        public static bool identicalRows(int[,] input)
        {
            int outerLength = input.GetLength(0);
            int innerLength = input.GetLength(1);

            HashSet<string> seenRows = new HashSet<string>();
            for(int i = 0; i < outerLength; i++)
            {
                string builder = ""; // could use a stringbuilder but for simplicity I am using a string to show it is doable without an object
                for(int j = 0; j < innerLength; j++)
                {
                    builder = builder + (input[i,j].ToString()) + ",";
                }
                if (seenRows.Contains(builder)) {return true; }
                seenRows.Add(builder);
            }
            return false; 
        }
        
    }

}