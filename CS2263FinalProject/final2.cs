namespace final
{
    public class final2
    {

        /*
        Write a C# RECURSIVE method(no loops) countEven that 
        accepts a two dimensional array of integers and returns
         a count of the number of integers in that array that 
         are even. Do not use any loops (for, while, until) or
          gotos. You may write recursive functions that are 
          called by your countEven recursive function.
        */

        public static int countEven(int[,] input, int count = 0, int outer = 0, int inner = 0)
        {
            if(outer >= input.GetLength(0)) { return count; }
            if(inner >= input.GetLength(1)) 
            { 
                outer = outer + 1;
                return (countEven(input, count, outer)); 
            }
            if(input[outer,inner] % 2 == 0){ count = count + 1; }
            inner = inner + 1;
            return(countEven(input, count, outer, inner));
        }

    }

}