namespace GunnarBabiczEx2
{
    public partial class Exercise2 : Form
    {
        public Exercise2()
        {
            InitializeComponent();
        }


        // --------------------------------- Common Methods --------------------------------

        private bool isPositiveInt(string input)
        { // returns true if the input string is an int
            if (int.TryParse(input, out int value) && value > 0) { return true; }
            return false;
        }





        // --------------------------------- Question Number 1 --------------------------------


        private void btnLeapYear_Click(object sender, EventArgs e)
        { // on button press, determines if the given year is a new year
            

            if (isPositiveInt(txtLeapYearIn.Text) == true || (txtLeapYearIn.Text == "0"))
            { // if the input is valid (either positive integer or text == "0")
                int yearEntered = int.Parse(txtLeapYearIn.Text);

                if ((yearEntered % 4 == 0) && (yearEntered % 100) != 0 || (yearEntered % 400 == 0))
                { // if the year entered is a leap year (year is divisible by 4 and NOT by 100, or year is divisible by 400)
                    lblNewYear.Text = ($"{yearEntered} is a leap year");
                }


                else
                { // if the year entered is not a leap year
                    lblNewYear.Text = ($"{yearEntered} is not a leap year");
                }
                return;
            }
            // if the input was invalid
            lblNewYear.Text = "Please enter a positive integer"; 
        }





        // --------------------------------- Question Number 4 --------------------------------

        private void btnFibonacci_Click(object sender, EventArgs e)
        {

            if (isPositiveInt(txtFibonacciIn.Text))
            {
                int input = int.Parse(txtFibonacciIn.Text);


                int first = 0, second = 1, sum = second;


                for (int j = 2; j <= input; j++)
                {
                    int tempSecond = second; //retains the value of the second number to reassign the first
                    second = (first + second);
                    sum += second;
                    first = tempSecond;

                }


                // updating the textbox and label for the final answer
                lblFibonacciOut.Text = ($"The sum of the first {input} Fibonacci" +
                    $" characters is:");
                txtFibonacciOut.Text = sum.ToString();

                return;
            }

            // if input was invalid
            txtFibonacciOut.Text = ("Please enter a positive integer");
            lblFibonacciOut.Text = ("The sum of the first n Fibonacci numbers is:");

        }





        // --------------------------------- Question 5 --------------------------------

        private void btnSquareCode_Click(object sender, EventArgs e)
        { // code that was provided
            string s = "";
            for (int r = 0; r < 10; r++)
            {
                for (int j = 0; j < 10; j++)
                    s += "*";
                s += "\r\n";
            }
            txtMultipleLineOut.Text = s;
        }





        // --------------------------------- Questions 6 & 7 --------------------------------

        private void makeTriangle(string leftString, string rightString, string input, bool isFromRight)
        { // Makes a triangle shape out of two defined characters for a number of lines defined by the user

            string output = ""; // creating string for the output

            if (isPositiveInt(input))
            { // ensures that the user input is a valid number


                int numRows = int.Parse(txtTriangleIn.Text);


                if (isFromRight == true)
                { // adds triangle body characters from the right
                    for (int i = 1; i <= numRows; i++)
                    {
                        for (int r = numRows - i; r > 0; r--)
                            output += rightString;
                        for (int l = 1; l <= i; l++)
                            output += leftString;
                        output += "\r\n";
                    }
                }


                else
                {
                    for (int i = 1; i <= numRows; i++)
                    { // adds triangle body characters from left
                        for (int l = 1; l <= i; l++)
                            output += leftString;
                        for (int r = numRows - i; r > 0; r--)
                            output += rightString;
                        output += "\r\n";
                    }
                }
                txtMultipleLineOut.Text = output; // setting the output equal to the final string
                return;
            }
            // if input was invalid
            output += "Please enter a positive integer";

        }



        //  ----- Calling the triangle method for both buttons -----

        private void btnFirstTriangle_Click(object sender, EventArgs e)
        { // makes a triangle biased to the left
            makeTriangle("*", " ", (txtTriangleIn.Text), false);
        }


        private void btnSecondTriangle_Click(object sender, EventArgs e)
        { // makes a triangle biased to the right
            makeTriangle("*", "-", (txtTriangleIn.Text), true);
        }





        // --------------------------------- Question Number 8 --------------------------------

        private void btnLettersofAlphabet_Click(object sender, EventArgs e)
        {
            if (isPositiveInt(txtLettersOfAlphabetIn.Text))
            {
                int numLetters = int.Parse(txtLettersOfAlphabetIn.Text);
                if ((numLetters > 0) && (numLetters < 27))
                { // if the input is in the range for the alphabet
                    string output = "";
                    char letter;

                    for (int i = 0; i < numLetters; i++)
                    { // adds the letters of the alphabet to the output 
                        letter = (char)((int)'a' + i);
                        output += letter;
                    }
                    txtLettersOfAlphabetIn.Text = output;
                    lblLettersOfAlphabetError.Text = "";
                    return;
                }
            }
            // if input was invalid
            lblLettersOfAlphabetError.Text = "Error: Input was not valid";
            txtLettersOfAlphabetIn.Text = "";
        }
    }
}