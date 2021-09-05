using System;
using System.IO;
using static RPSLS_GAME.GameData;
using static RPSLS_GAME.GameUI;

namespace RPSLS_GAME
{
    public class GameCore
    {

        public static char GetUserInput()
        {
            ConsoleKeyInfo Hitkey = Console.ReadKey();
            userPressedkey = Char.Parse(Hitkey.Key.ToString());
            return userPressedkey;

        }

        public static char GetMachineInput()
        {
            char[] items = { 'P', 'S', 'R', 'L', 'V' };
            Random choose = new Random();
            int choose_helper = choose.Next(items.Length);
            machinePressedkey = items[choose_helper];
            return machinePressedkey;
        }

        public static char PressedKeyValidation()
        {
            while ((userPressedkey != 'H') && (userPressedkey != 'Q') && (userPressedkey != 'B') && (userPressedkey != 'E'))
            {
                GameMenu();
                userPressedkey = GetUserInput();
            }

            switch (userPressedkey)
            {
                case 'H':
                    Help();
                    break;
                case 'Q':
                    Environment.Exit(0);
                    break;
                case 'B':
                    GameInitialize();
                    break;
                case 'E':
                    GameStart();
                    break;
                default:
                    break;
            }

            return userPressedkey;
        }

        public static char CheckChoosedUserIdentity()
        {
            while ((userPressedkey != 'P') && (userPressedkey != 'S') && (userPressedkey != 'R') && (userPressedkey != 'L') && (userPressedkey != 'V'))
            {
                GameStart();
                userPressedkey = GetUserInput();
            }

            return userPressedkey;
        }

        public static void GameLogic()
        {
            userPressedkey = GetUserInput();
            machinePressedkey = GetMachineInput();
            CheckIdentities();
            DefineChoosedOption();
            GameResult();
        }
        public static void CheckIdentities()
        {
            userPressedkey = CheckChoosedUserIdentity();
            if (userPressedkey == machinePressedkey)
            {
                IdentitiesEqual();
                userPressedkey = GetUserInput();
                userPressedkey = CheckChoosedUserIdentity();
                machinePressedkey = GetMachineInput();

            }

            if ((userPressedkey == 'S' && machinePressedkey == 'P') || (userPressedkey == 'L' && machinePressedkey == 'P')
                || (userPressedkey == 'P' && machinePressedkey == 'R') || (userPressedkey == 'V' && machinePressedkey == 'R')
                || (userPressedkey == 'R' && machinePressedkey == 'L') || (userPressedkey == 'S' && machinePressedkey == 'L')
                || (userPressedkey == 'L' && machinePressedkey == 'V') || (userPressedkey == 'P' && machinePressedkey == 'V')
                || (userPressedkey == 'V' && machinePressedkey == 'S') || (userPressedkey == 'R' && machinePressedkey == 'S'))
            {
                userPoint++;
            }
            else
            {
                machinePoint++;
            }
        }

        public static void DefineChoosedOption()
        {
            switch (machinePressedkey)
            {
                case 'P':
                    machineChoosedOption = "Paper";
                    break;
                case 'S':
                    machineChoosedOption = "Scissor";
                    break;
                case 'R':
                    machineChoosedOption = "Rock";
                    break;
                case 'L':
                    machineChoosedOption = "Lizard";
                    break;
                case 'V':
                    machineChoosedOption = "Spock";
                    break;
                default:
                    break;
            }

            switch (userPressedkey)
            {
                case 'P':
                    userChoosedOption = "Paper";
                    break;
                case 'S':
                    userChoosedOption = "Scissor";
                    break;
                case 'R':
                    userChoosedOption = "Rock";
                    break;
                case 'L':
                    userChoosedOption = "Lizard";
                    break;
                case 'V':
                    userChoosedOption = "Spock";
                    break;
                default:
                    break;
            }

        }

        public static void SaveTheResult()
        {
            Console.WriteLine("Add your name: ");
            userName = Console.ReadLine();
            string timestamp = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
            string savedresult;
            string Gameresult = "\n" + "Username: " + userName + " \n" + "Choosed option by the User: " + userChoosedOption + "\n"
                + "Choosed option by the Machine: " + machineChoosedOption + "\n";
            savedresult = "\n" + timestamp + Gameresult;
            File.AppendAllText("GameResult.txt", savedresult);
        }

        public static void GameFinalize()
        {
            FinishOrRestart();
            userPressedkey = GetUserInput();
            userPressedkey = PressedKeyValidation();
        }

    }
}
