using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nonRecursiveQuickSort_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /***************************************************************
   dvb S17 - non recursive Quick Sort based on C bible (K&R the C programming
   Language - 2nd ed p87). left and right initialized to 0 and length-1. 
   stackTop index to top element in leftRightStack. Thus for "push", increment
   and then access (leftRightStack[++stackTop]) and for "pop" access then
   decrement (leftRightStack[stackTop--]);
   ********************************************************************/
        public void nonRecursiveQuickSort(int[] list)
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
        }
        private void btnStuff_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
                int fooSize = 20;
            int[] foo = new int[fooSize];
            for (int i = 0; i < fooSize; i++) foo[i] = rng.Next(1, 101);           
           nonRecursiveQuickSort(foo);
            string s = "";
            for( int i=0;i<foo.Length;i++) s += foo[i].ToString() + " ";
            MessageBox.Show(s);
        }
    }
}
