namespace OOPMidterm
{
    class run
    {
        static void Main(string[] args)
        {
            // Question 1
            //codeDisplay Q1 = new codeDisplay();
            //Q1.Click();

            // Question 2
            removeDuplicates Q2 = new removeDuplicates();
            string test = Q2.remove("abbcefgaafs");
            Console.WriteLine(test);


            // Question 4
            //flipArray Q4 = new flipArray();
            //Q4.flipDiag();
        }
    }
}