using System.Text;
using System.Diagnostics;




/* 

For the Shakespeare Monkey:
For the quickest speed, may want to try using a byte array
(uint8 containing the 8-bit ascii code for the characters)

*/


/* GAB 03/24/2023 - Creates a random int array of
* given size for testing. 
*/ 


/* GAB 03/24/2023
* wrapper for the recursive quickSort function. Keeps user from
* needing to enter the upper and lower bounds
*/ 



/* GAB 03/24/2023
* Implements the recursive quick sort function. Adapted
* from K&R provided code to C#.
*/ 


/* GAB 03/24/2023
* Implements a non recursive quick sort function. Taken from
* note 7.3
*/ 

int[] nonRecursiveQuickSort(int[] array)
{
    return nRQuickSort(array.ToArray());
}


int[] nRQuickSort(int[] list)
{
    int lastsmall, foo, left = 0, right = list.Length - 1;
    int[] leftRightStack = new int[(list.Length + 6)];
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
    return bSort(array.ToArray(), array.Length);
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
    return indexedQSort(array.ToArray(), index, 0, array.Length);
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






//int[] test2 = recursiveQuickSort(test);

//int[] test4 = bubbleSort(test);
//int[] test5 = indexedQuickSort(test);



int[] recursiveQuickSort(int[] array)
{
    return rQSort(array.ToArray(), 0, array.Length-1);
}

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

        rQSort(array, left, lastsmall-1);
        rQSort(array, lastsmall + 1, right);
    }
    return array;
}


void Swap(int[] a, int i, int j)
{
    int t = a[i];
    a[i] = a[j];
    a[j] = t;
}

int Partition(int[] a, int l, int r)
{
    int ndx = l;
    int pivot = a[l];
    for (int i = l+1; i <=r; i++)
    {
        if(a[i]<pivot)
        {
            ndx++;
            Swap(a,ndx,i);
        }
    }
    Swap(a, ndx, l);
    return ndx;
}

int[] quickSort(int[] a, int l, int r)
{
    if(l<r)
    {
        var pi = Partition(a, l, r);
        quickSort(a, l, pi - 1);
        quickSort(a, pi+1, r);
    }
    return a;
}


int[] qS(int[]a)
{
    return(quickSort(a.ToArray(), 0, a.Length-1));
}


Random random = new Random(10);


int[] createRandomArray(int size)
{
    int[] randArray = new int[size];
    for (int i = 0; i < randArray.Length; i++)
    {
        randArray[i] = random.Next(0, 100);
    }
    return randArray;
}


int[] test = createRandomArray(10000000);

string testBeardSort()
{
    for(int i = 0; i < 1; i++)
    {
        int[] sorted = recursiveQuickSort(test);
        for(int j = 0; j < 9; j++)
        {
            if(sorted[j] > sorted[j+1]){return "Test Failed"; }
        }
    }
    return "Test Passed";
}

string testWebSort()
{
    for(int i = 0; i < 1; i++)
    {
        int[] sorted = qS(test);
        for(int j = 0; j < 9; j++)
        {
            if(sorted[j] > sorted[j+1]){return "Test Failed"; }
        }
    }
    return "Test Passed";
}


//Console.WriteLine($"Beard: {testBeardSort()}");
Console.WriteLine($"Web: {testWebSort()}");




