using System;

/* Create an application with a score, highscore and a highscorePlayer.
 Create a method which has two parameters, one for the score and one for the playerName.
When ever that method is called, it should be checked if the score of the player is higher than the highscore, if so, "New highscore is + " score" and in another line "New highscore holder is " + playerName - should be written onto the console, if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
Consider which variables are required globally and which ones locally. */

namespace IfChallenge2
{
    class Program
    {
        static int highscore = 51;
        static string highscorePlayer = "Adam";

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your score:");
            int score = int.Parse(Console.ReadLine());
            CheckHighscore(score, name);
        }

        static public void CheckHighscore(int playerScore, string playerName)
        {
            if (playerScore > highscore)
            {
                highscore = playerScore;
                highscorePlayer = playerName;
                Console.WriteLine("New highscore is {0}", highscore);
                Console.WriteLine("New highscore holder is {0}", highscorePlayer);
            }
            else
            {
                Console.WriteLine("The old highscore of {0} could not be beaten and is still held by {1}", highscore, highscorePlayer);
            }
        }
    }
}
