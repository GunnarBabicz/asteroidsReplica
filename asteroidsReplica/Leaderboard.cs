using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms.VisualStyles;

namespace asteroids
{

    /* GAB 04/30/2023
    * Class for an individual row of Leaderboard stats */
    internal class LeaderRow
    {
        private int position;
        private string nickname;
        private int score;
        internal string rowString;
        internal string[] rowData;

        /* GAB 04/30/2023
        * Constructor for the Leader Row */
        public LeaderRow(string row)
        {
            rowString = row;
            rowData = rowString.Split(',');
            position = int.Parse(rowData[0]);
            nickname= rowData[1];
            score = int.Parse(rowData[2]);
        }

        /* GAB 04/30/2023
        * getter/setter for the position on the leaderboard */
        public int Position 
        
        {
            get{ return position; }
            set
            {
                position = value;
                updateRowString();
                
            }
        }

        /* GAB 04/30/2023
        * getter/setter for the player's chosen nickname */
        public string Nickname
        {
            get { return nickname; }
            set
            {
                nickname = value;
                updateRowString();
            }
        }


        /* GAB 04/30/2023
        * getter/setter for the player's score */
        public int Score
        {
            get { return score; }
            set 
            {
                score = value;
                updateRowString();
                
            }
        }


        /* GAB 04/30/2023
        * Returns a string representation of the Array */
        public string RowString 
        {
            get { return rowString; }
            set { rowString = value; }
        }

        /* GAB 04/30/2023
        * updates the rowString with current variables*/
        private void updateRowString() 
        {
            rowString = ($"{position},{nickname},{score}");
        }

        /* GAB 04/30/2023
        * Prints a formatted string representation of the row */
        public override string ToString()
        {
            return($"{Position}     {Nickname}     {Score}\n");
        }


    }

    /* GAB 04/30/2023
    * The leaderboard class is meant for checking and updating the high scores */
    internal class Leaderboard
    {
        internal LeaderRow[] leaderArray;
        internal LeaderRow[] newArray;
        internal string[] rawData;
        internal string filePath = @"..\..\..\Leaderboard.csv";
        internal int newScorePosition = 11;
        internal int newScoreIndex;
        internal int numberOfScores = 0;
        StreamWriter sw;

        string nickname;
        int newScore;
        public LeaderRow newScoreRow;



        /* GAB 04/30/2023
        * Constructor for the leaderboard class */
        public Leaderboard() 
        {
            try 
            {
                
                rawData = System.IO.File.ReadAllLines(filePath);
                numberOfScores = rawData.Length - 1;
                convertcsv();
                
            }
            catch(FileNotFoundException) 
            { // if a csv for the leaderboard is not present
                newScorePosition = 1;
                numberOfScores = 0;
            }
        }

        /* GAB 04/30/2023
        * Returns a string of the scores in a formatted string */
        public string readScores() 
        {
            string fm = "High Scores\n\n";

            if (numberOfScores < 10) { numberOfScores++; }

            for (int i = 0; i < numberOfScores && i < 10; i++) 
            {
                fm = fm + leaderArray[i].ToString();
            }          
            return fm;
        }




        /* GAB 04/30/2023
        * Saves the new leaderboard to the CSV */
        private void save() 
        {
            sw = new StreamWriter(filePath);
            sw.WriteLine("Position,Nickname,Score");
            for (int i = 0; i < numberOfScores+1 && i < 10; i++) 
            {
                sw.WriteLine(leaderArray[i].RowString);
            }
            sw.Flush();
            sw.Close();
        }

        /* GAB 04/30/2023
        * Converts the read info from the CSV to a list of LeaderRow objects */
        private void convertcsv() 
        {
            try
            {
                leaderArray = new LeaderRow[numberOfScores];
                for (int i = 1; i < rawData.Length; i++)
                { // converts the first 10 scores ignoring the header row
                    leaderArray[i - 1] = new LeaderRow(rawData[i]);
                }
            }

            catch (System.OverflowException) 
            {
                newScorePosition = 1;
                numberOfScores = 0;
            }
        }

        /* GAB 04/30/2023
         * Moves the LeaderRow objects currently on the Leaderboard
         * to make room for the new score */
        private void shiftPositions() 
        {
            newArray = new LeaderRow[10];

            for (int i = 0; i < newScorePosition && i < numberOfScores; i++) 
            {
                newArray[i] = new LeaderRow(leaderArray[i].RowString);
            }
            newArray[newScorePosition] = newScoreRow;
            newArray[newScorePosition].Position += 1;



            for (int i = newScorePosition; i < numberOfScores && i < 9; i++)
            {
                LeaderRow pain = leaderArray[i];
                newArray[i+1] = pain;
                newArray[i+1].Position += 1;
            }

            leaderArray = newArray;

        }

        /* GAB 04/30/2023
        * Determines whether the provided score is a high score */
        public bool highScore(int score) 
        {
            if (numberOfScores < 10) 
            { 
                newScorePosition = numberOfScores; 
            }

            newScore = score;
            for (int i = numberOfScores-1; i >= 0; i--) 
            {
                if (newScore > leaderArray[i].Score)
                {
                    newScorePosition = i;
                }
                else { break; }

                
            }

            if (newScorePosition < 11) 
            {
                
                return true; 
            }
            else { return false; }
        }

        /* GAB 04/30/2023
        * Collects the desired nickname from the user */
        public void recieve(string nickname) 
        {
            newScoreRow = new LeaderRow($"{newScorePosition},{nickname},{newScore}");
            shiftPositions();
            save();
        }
    }
}
