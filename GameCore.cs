using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            userPressedkey = GetUserInput();
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

            while ((userPressedkey != 'P') && (userPressedkey != 'S') && (userPressedkey != 'R') && (userPressedkey != 'L') && (userPressedkey != 'V'))
            {
                GameIdentities();
                userPressedkey = GetUserInput();
            }
            return userPressedkey;
        }
        public static void GameLogic()
        {
            userPressedkey = GetUserInput();
            machinePressedkey = GetMachineInput();
            userPressedkey = PressedKeyValidation();
            CheckIdentities();

        }
        public static void CheckIdentities()
        {
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

        public static string DefineChoosedOption(userChoosedOption,machineChoosedOption)
        {

            return userChoosedOption, machineChoosedOption;
        }

    }
}
