namespace final
{
    public class final4
    {
        public static string button1_Click()
        {
            List<BooClass> d = new List<BooClass>(); // creates an empty list of BooClass objects
            d.Add(new BooClass()); // since no int is given, the default value of 4 is given
            d.Add(new BooClass(0)); // should be 0++ = 1; from BooClass constructor
            d.Add(new BooClass(1)); // should be 1++ = 2; from BooClass constructor
            int n = 0;
            foreach (BooClass p in d) // for each BooClass in the list
                n += p.xyzzy(n+1); // xyzzy returns itself due to the override. 4 + 1 + 2 = 7
            return (n.ToString()); // should be 7 as a string
        }

        internal class FooClass
        {
            protected int x;
            public int y;
            public FooClass() : this(3) { }
            public FooClass(int z) { x = y; y = z + 1; }
            public virtual int xyzzy(int a) { return x+y+a; }
        }

        internal class BooClass: FooClass
        {
            public BooClass() : this(4) { }
            public BooClass(int z) : base(z) { x++; }
            public override int  xyzzy(int a) { return a; }
        }
    }
}
