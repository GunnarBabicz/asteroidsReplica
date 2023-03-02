namespace OOPMidterm
{
    class codeDisplay
    {





    /* final output: "43-42--W-3 2 1 0" 
    Steps:

    1. A new Class3 is created
    2. In creating a Class3, a Class1 is created with a list of Class3=2 objects of length 2
    3. list consists of two integers 42 and 43
    4. w.zoo() is run
    5. First iteration of foreach returns 42- (s = 42 + "-" + "")
    6. Second iteration of foreach returns 43-42- (s = 43 + "-" + "42-")
    7. "-W" is added to the output string resulting in the current output "43-42--W-"
    8. w.boo(3) is run (the one in Class3, there is one in Class2 to mislead)
    9. w.boo returns "3 2 1 0"
    10. Final string is put together as "43-42--W-3 2 1 0"
    */

        public void Click()
        {
            Class3 w = new Class3();
            Console.WriteLine(w.zoo() + "-W-" + w.boo(3));
        }
        internal class Class3: Class1
        {
            public Class3() : base(2) { }
            public string zoo()
            {
                string s = "";
                foreach (Class2 foo in p) s = foo.c + "-" + s;
                return s;
            }
            public string boo(int n)
            {
                if (n <= 0) return "0";
                return n.ToString() + " " + boo(n - 1);
            }
        }

        internal class Class1
        {
            public List<Class2> p;
            public Class1() : this(2) { }
            public Class1(int size)
            {
                p = new List<Class2>();
                for (int i = 0; i < size; i++)
                {
                    p.Add(new Class2());
                    p[i].c = (i + 42);
                }
            }
        }

        internal class Class2
        {
            public int c;
            public Class2() { }
            public string boo(int n)
            {
                if (n <= 0) return "0";
                return boo(n - 1) + n.ToString();
            }
        }
    }
}