using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPSLS_GAME.GameData;

namespace RPSLS_GAME
{
    
    public class GameUI
    {
        public static void GameInitialize()
        {
            Console.Clear();
            Console.Title = "RPSLS GAME";
            Console.WriteLine("Welcome to the RPSLS Game\n" + "Rock, Paper, Scissor, Lizard, Spock\n"
                + "If you need to read the game rules hit the H key\n"
                + "Hit the E key to start the game or hit the Q key to quit the game\n"
                + "If you want to go back to the main screen hit the B key\n");
            WaitForUser();
        }

        public static void WaitForUser()
        {
            Console.WriteLine("Wait for user input: ");
            Console.Beep();
        }

        public static void Help()
        {
            Console.Clear();
            Console.WriteLine("The Game rules: ");
            Console.WriteLine("Scissors cuts Paper\n" + "Paper covers Rock\n" + "Rock crushes Lizard\n" + "Lizard poisons Spock\n"
                + "Spock smashes Scissors\n" + "Scissors decapitates Lizard\n" + "Lizard eats Paper\n" + "Paper disproves Spock\n"
                + "Spock vaporizes Rock\n" + "Rock crushes Scissors\n" + "\n" + "If you want to go back to the main screen hit the B key\n"
                + "If you want to quit the game hit the Q key\n");
            WaitForUser();
        }

        public static void GameStart()
        {
            Console.Clear();
            Console.WriteLine("Choose an item: \n" + "Paper - P\n" + "Scissor - S\n"
                + "Rock - R\n" + "Lizard - L\n" + "Spock -V\n");
            WaitForUser();
        }

        public static void GameMenu()
        {
            Console.Clear();
            Console.WriteLine("Please hit a valid key: \n" + "Valid keys are: \n" + "H - Help\n" + "E - Start the Game \n" +
                "Q - Quit the Game\n" + "B - Back to the Main screen\n");
            WaitForUser();
        }

        public static void IdentitiesEqual()
        {
            Console.Clear();
            Console.WriteLine("Both identities are equal\n Please choose again: ");
            WaitForUser();
        }

        public static void GameFinalize()
        {
            Console.Clear();
            if (userPoint > machinePoint)
            {
                Console.WriteLine("You are WIN! :)\n" + "You are choosed the: " + userChoosedOption + "\n"
                    + "The machine choosed the: " + machineChoosedOption);
            }
            else
            {
                Console.WriteLine("You are LOSE! :(\n" + "You are choosed the: " + userChoosedOption + "\n"
                    + "The machine choosed the: " + machineChoosedOption);
            }

            Console.WriteLine("\n" + "If you want a new game hit the E key \n" + "If you want to quit hit the Q key\n");
            WaitForUser();
        }

    }
}
