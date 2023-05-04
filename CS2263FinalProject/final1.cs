namespace final
{
    public class final1
    {
        public static string button2_Click() 
        {
            const int aSize = 3; // aSize is set to 3
            int[] a = new int[aSize]; // new int array of size 3 is made
            a[0] = 2; a[1] = 3; a[2] = 4; // [2, 3, 4]
            return zoo(a, 1); // invokes zoo method with arguments (a, 1)
        }

        public static string zoo(int[] a, int index)  
        {
            if (index >= a.Length) return ""; // 1 is less than the length of array a, so method will not be called
            return ((char)((int)('c') + a[index])).ToString() + zoo(a, index + 1);

            /*
                1. Converting char c to an int gives its ascii value
                2. first iteration adds 3 to the ascii (f)
                3. second iteration adds 4 to the ascii (g)

                'fg' is what is returned
            */
        }
    }
}