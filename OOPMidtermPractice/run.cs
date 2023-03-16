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
            //string test = Q2.remove("abbcefgaafs");
            string testQ2 = Q2.remove("");
            //Console.WriteLine(testQ2);



            //Question 3
            //button2 Q3 = new button2();
            //Q3.button2_Click();

            // Question 4
            //flipArray Q4 = new flipArray();
            //Q4.flipDiag();


            // Question 5
            OddChars Q5 = new OddChars();
            string Q5test = Q5.strOddCharacters("abcdefg");
            Console.WriteLine(Q5test);

            //Console.WriteLine(Q5test.GetType());
        }
    }
}