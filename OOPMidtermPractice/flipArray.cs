
namespace OOPMidterm
{
    class flipArray
    {
        int[,] a = {{1,2,3},{4,5,6},{7,8,9}};


        public void flipDiag()
        {
            printArray();
            flipPrimaryDiagonal();
            printArray();
            flipSecondaryDiagonal();
            printArray();
        }
        private void printArray()
        {
            for(int i = 0; i < 3; i++ )
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void flipPrimaryDiagonal()
        {
            int[,] tempArray = new int[3,3];
            for(int i = 0; i < 3; i++ )
            {
            for(int j = 0; j < 3; j++)
                {
                    tempArray[i, j] = a[j, i];
                }
            }
            a = tempArray;
            tempArray.
        }

        public void flipSecondaryDiagonal()
        {
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    int temp = a[i, j];
                    a[i,j] = a[2-j,2-i];
                    a[2-j,2-i] = temp;
                }
            }
        }


    }
}


