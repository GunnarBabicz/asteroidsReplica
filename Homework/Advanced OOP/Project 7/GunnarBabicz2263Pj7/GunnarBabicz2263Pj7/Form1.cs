using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace GunnarBabicz2263Pj7
{
    /* GAB 03/30/2023
     * Form 1 class creates a Windows Form with relevant functions to test
     * the given sorting algorithms.
     */
    public partial class Form1 : Form
    {
        // Initialization of the form
        public Form1(){InitializeComponent();}
        private void Form1_Load(object sender, EventArgs e){}

        // Creating instances of needed classes
        Random random = new Random();
        Stopwatch stopwatch = new Stopwatch();

        // Creating the arrays used for testing purposes. 
        int[] zeroArray = new int[0];
        int[] randomArray1 = new int[4];
        int[] randomArray2 = new int[8];



        // variables for monkey sim
        int this_guess = 0;
        int mostCharactersGuessed = 0;

        // ---------- HELPER FUNCTIONS ----------


        /* GAB 03/28/2023
         * Creates new random arrays for 
         * testing purposes */
        private void setRandomArrays() 
        {
            int randomLength = random.Next(8);
            randomArray1 = createRandomArray(randomLength);
            txtUnsortedRandom1.Text = formatArray(randomArray1);
            randomLength = random.Next(8); 
            randomArray2 = createRandomArray(randomLength);
            txtUnsortedRandom2.Text = formatArray(randomArray2);
        }

        /* GAB 03/28/2023
         * Formats an int array to be viewed by the user*/
        private string formatArray(int[] array)
        {
            return("[" + string.Join(", ", array) + "]");
        }

        /* GAB 03/29/2023
         * checks if the textbox input is a valid number */
        private bool isValidNumInput(string input)
        {
            if (input.Length > 0)
            {
                foreach (char c in input)
                {
                    if (!char.IsDigit(c))
                    {
                        Popup.Error("Please enter only digits");
                        return false;
                    }

                }

                if (int.Parse(input) <= 0)
                {
                    Popup.Error("Number must be greater than zero");
                    return false;
                }
                return true;
            }
            return false;
        }

        /* GAB 03/24/2023 - Creates a random int array of
        * given size for testing sorting functions. */
        int[] createRandomArray(int size)
        {
            int[] randArray = new int[size];
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = random.Next(0, size);
            }
            return randArray;
        }



        // ---------- SORTING FUNCTIONS ----------

        /* GAB 03/24/2023
       * wrapper for the recursive quickSort function. Keeps user from
       * needing to enter the upper and lower bounds */
        int[] recursiveQuickSort(int[] array)
        {
            return rQSort(array.ToArray(), 0, array.Length-1);
        }


        /* GAB 03/24/2023
        * Implements the recursive quick sort function. Adapted
        * from K&R provided code to C#. */
        int[] rQSort(int[] array, int left, int right)
        {
            int foo;
            if (left < right)
            { // if the list is over a length of 1
                int lastsmall = left;
                int pivot = array[left];
                for (int i = left + 1; i <= right; i++)
                {
                    if (array[i] < array[left])
                    { // if the value at i less than the value at left (pivot)
                        lastsmall++;
                        foo = array[i];
                        array[i] = array[lastsmall];
                        array[lastsmall] = foo;
                    }
                }
                foo = array[left];
                array[left] = array[lastsmall];
                array[lastsmall] = foo;

                rQSort(array, left, lastsmall - 1);
                rQSort(array, lastsmall + 1, right);
            }
            return array;
        }


        /* GAB 03/24/2023
        * Wrapper for the non recursive Quick Sort Function. */
        int[] nonRecursiveQuickSort(int[] array)
        {
            return nRQuickSort(array.ToArray());
        }

        /* GAB 03/24/2023
        * Implements a non recursive quick sort function. Taken from
        * note 7.3. Changed the stack length to scale directly off the list.
        * The length of leftRightStack being 1000 like in the sample code 
        * caused an out of index error. 
        * 
        * Through trial and error, I found making leftRightStack the length
        * of list.Length+6 produced no errors while minimizing the size of the
        * array. Tested for 10,000 iterations with an input array of 
        * length 10,000 without errors. Any number smaller produced errors. 
        * 
        */
        int[] nRQuickSort(int[] list)
        {
            int lastsmall, foo, left = 0, right = list.Length - 1;
            int[] leftRightStack = new int[list.Length + 6];
            int stackTop = -1; // index to top element in stack
            leftRightStack[++stackTop] = left; // push left then right.
            leftRightStack[++stackTop] = right;
            while (stackTop >= 0)
            {
                right = leftRightStack[stackTop--]; // pop right then left
                left = leftRightStack[stackTop--];
                if (left < right)
                {
                    lastsmall = left;
                    for (int i = left + 1; i <= right; i++)
                    {
                        if (list[i] < list[left])
                        {
                            lastsmall++;
                            foo = list[i];
                            list[i] = list[lastsmall];
                            list[lastsmall] = foo;
                        }
                    }
                    foo = list[left];
                    list[left] = list[lastsmall];
                    list[lastsmall] = foo;
                    // qSort(list, left, lastsmall - 1);
                    leftRightStack[++stackTop] = left;
                    leftRightStack[++stackTop] = lastsmall - 1;
                    // qSort(list, lastsmall + 1, right);
                    leftRightStack[++stackTop] = lastsmall + 1;
                    leftRightStack[++stackTop] = right;
                }
            }
            return list;
        }





        /* GAB 03/24/2023
        * Wrapper function for bubble sort */
        int[] bubbleSort(int[] array)
        {
            return bSort(array.ToArray(), array.Length);
        }

        /* GAB 03/24/2023
        * Implements a bubble sort function. Taken from
        * note 7.0 */
        int[] bSort(int[] array, int size)
        {
            int temp, i, bubblePass;
            for (i = 0; i < size - 1; i++)
            {
                for (bubblePass = 1; bubblePass < size; bubblePass++)
                {
                    if ((array[bubblePass - 1]) > (array[bubblePass]))
                    {
                        temp = array[bubblePass - 1];
                        array[bubblePass - 1] = array[bubblePass];
                        array[bubblePass] = temp;
                    }
                }
            }
            return array;
        }




        /* GAB 03/29/2023
         * Wrapper function for indexed quick sort */
        int[] indexedQuickSort(int[] array)
        {
            int[] index = new int[array.Length];
            for (int i = 0; i < array.Length; i++) { index[i] = i; }
            return indexedQSort(array.ToArray(), index, 0, array.Length);
        }

        /* GAB 03/29/2023
         * Implements an indexed quick sort */
        int[] indexedQSort(int[] array, int[] index, int left, int right)
        {
            int lastsmall, foo, j;
            if (left < right)
            { // if the list is over a length of 1
                lastsmall = left;
                for (j = left + 1; j < right; j++)
                {
                    if ((array[index[j]]) < (array[index[left]]))
                    { // if the value at i less than the value at left (pivot)
                        lastsmall = lastsmall + 1;
                        foo = index[j];
                        index[j] = index[lastsmall];
                        index[lastsmall] = foo;
                    }
                }
                foo = index[left];
                index[left] = index[lastsmall];
                index[lastsmall] = foo;

                index = indexedQSort(array, index, left, lastsmall);
                index = indexedQSort(array, index, lastsmall + 1, right);
            }
            return index;
        }



        // ---------- BUTTON PRESS FUNCTIONS ----------

        /* GAB 03/28/2023
         * Tests the recursive quick sort and shows results to user*/
        private void btnTestRQuickSort_Click(object sender, EventArgs e)
        {
            setRandomArrays();
            txtSortedRandom1.Text = formatArray(recursiveQuickSort(randomArray1));
            txtSortedRandom2.Text = formatArray(recursiveQuickSort(randomArray2));
        }

        /* GAB 03/28/2023
         * Tests the non recursive quick sort and shows results to user*/
        private void btnTestNRQuickSort_Click(object sender, EventArgs e)
        {
            setRandomArrays();
            txtSortedRandom1.Text = formatArray(nonRecursiveQuickSort(randomArray1));
            txtSortedRandom2.Text = formatArray(nonRecursiveQuickSort(randomArray2));
        }

        /* GAB 03/28/2023
         * Tests the bubble sort and shows result to user*/
        private void btnTestBubbleSort_Click(object sender, EventArgs e)
        {
            setRandomArrays();
            txtSortedRandom1.Text = formatArray(bubbleSort(randomArray1));
            txtSortedRandom2.Text = formatArray(bubbleSort(randomArray2));
        }

        /* GAB 03/28/2023
         * tests the indexed sort and shows result to user*/
        private void btnTestIndexedQuickSort_Click(object sender, EventArgs e)
        {
            setRandomArrays();
            txtSortedRandom1.Text = formatArray(indexedQuickSort(randomArray1));
            txtSortedRandom2.Text = formatArray(indexedQuickSort(randomArray2));
        }

        /* GAB 03/28/2023
         * Upon press of the "Run Speed Test" button, runs a speed test of the 
         * sorting algorithms on the same input array and displays the times. 
         */
        private void btnRunSpeedTest_Click(object sender, EventArgs e)
        {
            if (isValidNumInput(txtArrayLength.Text))
            {
                int[] testArray = createRandomArray(int.Parse(txtArrayLength.Text));

                stopwatch.Start();
                recursiveQuickSort(testArray);
                stopwatch.Stop();
                txtRecursiveQuickSortSpeed.Text = stopwatch.Elapsed.ToString();

                stopwatch.Restart();
                nonRecursiveQuickSort(testArray);
                stopwatch.Stop();
                txtNonRecursiveQuickSortSpeed.Text = stopwatch.Elapsed.ToString();


                stopwatch.Restart();
                bubbleSort(testArray);
                stopwatch.Stop();
                txtBubbleSortSpeed.Text = stopwatch.Elapsed.ToString();
            }
            else { txtArrayLength.Text = ""; }
        }

        /* GAB 03/29/2023
         * Upon press of the "Run Monkey Sim" button, 
         * runs a simulation of the 
         * "monkeys writing Shakespeare" problem
         * for the provided number of minutes. 
         */
        private void btnRunMonkeySim_Click(object sender, EventArgs e)
        {
            if (isValidNumInput(txtMonkeySimMinutes.Text))
            {
                int minutesToRun = (int.Parse(txtMonkeySimMinutes.Text) * 60);

                /* Converting the Shakespeare and the valid characters into byte arrays.
                 * Done within the function to allow to quick changes. */
                string Shakespeare = "now is the winter of our discontent made glorious summer by this";
                byte[] ShakespeareArray = Encoding.ASCII.GetBytes(Shakespeare);
                string validCharacters = "abcdefghijklmnopqrstuvwxyz ";
                byte[] validCharacterArray = Encoding.ASCII.GetBytes(validCharacters);

                stopwatch.Restart();
                while (stopwatch.Elapsed < TimeSpan.FromSeconds(minutesToRun))
                {
                    this_guess = 0;
                    for (int j = 0; j < 64; j++)
                    {
                        if (validCharacterArray[random.Next(27)] == ShakespeareArray[j])
                        {
                            this_guess += 1;
                        }
                    }
                    if (this_guess > mostCharactersGuessed)
                    {
                        mostCharactersGuessed = this_guess;
                    }
                }
                stopwatch.Stop();
                txtMonkeySimGuessesCorrect.Text = $"{mostCharactersGuessed} out of {ShakespeareArray.Length} ";
                txtMonkeySimTimeElapsed.Text = $"{stopwatch.Elapsed}";
            }
            else { txtMonkeySimMinutes.Text = ""; }
        }
    }
}