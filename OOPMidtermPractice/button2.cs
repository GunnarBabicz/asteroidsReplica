namespace OOPMidterm
{
    class button2
    {

        public void button2_Click()
        {
            Console.WriteLine(goo("abcedfg") + " " + goo(""));
        }
        public string goo(string s)
        {
            return (s.Length <= 1) ? s : goo(s.Substring(1)) + s.ElementAt(0);

            // Since this method uses recursion, inverts the list


        }

    }
}