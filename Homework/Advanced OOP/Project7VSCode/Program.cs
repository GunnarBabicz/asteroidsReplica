/* 

For the Shakespeare Monkey:
For the quickest speed, may want to try using a byte array
(uint8 containing the 8-bit ascii code for the characters)

*/


/* GAB 03/24/2023 - Creates a random int array of
* given size for testing. 
*/ 
Random random = new Random();
int[] createRandomList(int size)
{
    int[] randArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        randArray[i] = random.Next(0, 100);
    }
    return randArray;
}




/* GAB 03/24/2023
* wrapper for the recursive quickSort function. Keeps user from
* needing to enter the upper and lower bounds
*/ 
int[] recursiveQuickSort(int[] array)
{
    return rQSort(array, 0, array.Length);
}


/* GAB 03/24/2023
* Implements the recursive quick sort function. Adapted
* from K&R provided code to C#.
*/ 
int[] rQSort(int[] array, int left, int right)
{
    int lastsmall, foo, i;
    if(left < right)
    { // if the list is over a length of 1
        lastsmall = left;
        for(i = left+1; i < right; i++)
        {
            if(array[i] < array[left])
            { // if the value at i less than the value at left (pivot)
                lastsmall = lastsmall+1;
                foo = array[i];
                array[i] = array[lastsmall];
                array[lastsmall] = foo;
            }
        }
        foo = array[left];
        array[left] = array[lastsmall];
        array[lastsmall] = foo;

        array = rQSort(array, left, lastsmall);
        array = rQSort(array, lastsmall + 1, right);
    }
    return array;
}


/* GAB 03/24/2023
* Implements a non recursive quick sort function. Taken from
* note 7.3
*/ 
int[] nonRecursiveQuickSort(int[] list)
{
    int lastsmall, foo, left = 0, right = list.Length - 1;
    int[] leftRightStack = new int[1000];
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
* Wrapper function to keep user from needed to enter additional arguments
*/ 
int[] bubbleSort(int[] array)
{
    return bSort(array, array.Length);
}



/* GAB 03/24/2023
* Implements a bubble sort function. Taken from
* note 7.0
*/ 
int[] bSort(int[] array, int size)
{
    int temp, i, bubblePass;
    for(i = 0; i < size-1; i++)
    {
        for(bubblePass = 1; bubblePass < size; bubblePass++)
        {
            if((array[bubblePass - 1]) > (array[bubblePass]))
            {
                temp = array[bubblePass - 1];
                array[bubblePass - 1] = array[bubblePass];
                array[bubblePass] = temp;
            }
        }
    }

    return array;
}


int[] indexedQuickSort(int[] array)
{
    int[] index = new int[array.Length];
	for(int i=0;i<array.Length;i++) { index[i]=i; }
    return indexedQSort(array, index, 0, array.Length);
}





int[] indexedQSort(int[] array, int[]index, int left, int right)
{
    int lastsmall, foo, j;
    if(left < right)
    { // if the list is over a length of 1
        lastsmall = left;
        for(j = left+1; j < right; j++)
        {
            if((array[index[j]]) < (array[index[left]]))
            { // if the value at i less than the value at left (pivot)
                lastsmall = lastsmall+1;
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



// TESTING 


int[] test = createRandomList(10);
int[] test2 = recursiveQuickSort(test.ToArray());
int[] test3 = nonRecursiveQuickSort(test.ToArray());
int[] test4 = bubbleSort(test.ToArray());
int[] test5 = indexedQuickSort(test.ToArray());


Console.WriteLine("Before: " + string.Join(" ", test));
Console.WriteLine("\nRecursive Quick Sort: " + string.Join(" ", test2));
Console.WriteLine("\nNon Recursive Quick Sort: " + string.Join(" ", test3));
Console.WriteLine("\nBubble Sort: " + string.Join(" ", test4));
Console.WriteLine("\nIndexed Quick Sort: " + string.Join(" ", test5));

Console.WriteLine("\nStill original: " + string.Join(" ", test));
