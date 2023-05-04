namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] theArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }};
            Console.WriteLine("Question 1:");
            Console.WriteLine(final1.button2_Click());
            Console.WriteLine((int)('c'));

            Console.WriteLine("\nQuestion 2:");
            Console.WriteLine(final2.countEven(theArray));
            Console.WriteLine();

            Console.WriteLine("\nQuestion 3:");
            Console.WriteLine(final3.identicalRows(theArray));

            Console.WriteLine("\nQuestion 4:");
            Console.WriteLine(final4.button1_Click());

			string test = "abcde";
			int hmm = test.Length;

        }
        
    }
}

/*

&(x) points to address of x
int* defines as a pointer

#include <iostream>
using namespace std;
int main() {
	int *p3 = new int[2];
	*p3 = 1; // sets the first element to 1
	p3++; // increments to next element
	*p3 = 2; // sets second element equal to 2
	p3--; // returns to first element
	cout << p3[0] << " " << p3[1] << endl; // prints "1 2"
	cout << *p3+2 << " " << *(p3+1) + 1 << endl; prints "3 3"
	return 0;
}

#include <iostream>
#include <string>
using namespace std;
int main()
{
	int *t = new int[5];  // array of length 5
	int *h = t;   //h points to first element of t
	int **u = &h; //u points to h
	int r = 3;    //r = 3
	int *y = &r;  // y points to r
	for(int i=0;i<5;i++) t[i]=i*2; // 
	for(int i=0;i<5;i++)
		cout << *(*u+i) <<" " << t[i] << endl; // since t points to the first element, adding i to the pointer will move it to next element.
	delete t;

	return 0;
}

Output will be:

0 0
2 2
4 4 
6 6
8 8





*/