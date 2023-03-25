/* 

For the Shakespeare Monkey:
For the quickest speed, may want to try using a byte array
(uint8 containing the 8-bit ascii code for the characters)




Sample Visual basic code: 
'***************************************************************
    ' DVB Spring 03 - wrapper for actual quicksort rQSort below. this "wrapper"
    '   hides the need for passing in upper and lower bounds to actual rQSort.
    '********************************************************************
    Private Sub quickSort(ByVal x As Integer())
        rQSort(x, 0, x.GetUpperBound(0))
    right Sub
    '***************************************************************
    ' tight and compact QuickSort on integer data from the C bible 
    ' (K&R the C programming Language - 2nd ed p87). Fastest possible sort algorithm.
    ' Modified for VB6.0 by Cody Perman F99. Modified for VB.NET by DVB S03
    '********************************************************************
    Private Sub rQSort(ByVal list As Integer(), ByVal left As Integer, ByVal right As Integer)
        Dim i, lastsmall, foo As Integer   'foo must be same type as list array
        If left < right Then
            lastsmall = left
            For i = left + 1 To right
                If list(i) < list(left) Then
                    lastsmall = lastsmall + 1
                    foo = list(i)
                    list(i) = list(lastsmall)
                    list(lastsmall) = foo
                right If
            Next i
            foo = list(left)
            list(left) = list(lastsmall)
            list(lastsmall) = foo

            rQSort(list, left, lastsmall - 1)
            rQSort(list, lastsmall + 1, right)
        right If
    right Sub











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

int[] test = createRandomList(10);
Console.WriteLine(string.Join(" ", test));


/* GAB 03/24/2023
* wrapper for the recursive quickSort function. Keeps user from
* needing to enter the upper and lower bounds
*/ 
int[] recursiveQuickSort(int[] array)
{
    array = rQSort(array, 0, array.Length);
    return array;
}


/* GAB 03/24/2023
* Implements the recursive quick sort function. Adapted
* from K&R provided code to C#.
*/ 
int[] rQSort(int[] array, int left, int right)
{
    int lastsmall; int foo;
    if(left < right)
    { // if the list is over a length of 1
        lastsmall = left;
        for(int i = left+1; i < right; i++)
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





int[] test2 = recursiveQuickSort(test);
int[] test3 = nonRecursiveQuickSort(test);

Console.WriteLine(string.Join(" ", test2));
Console.WriteLine(string.Join(" ", test3));




