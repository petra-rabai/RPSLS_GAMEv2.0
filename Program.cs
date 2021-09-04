using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPSLS_GAME.GameUI;
using static RPSLS_GAME.GameData;
using static RPSLS_GAME.GameCore;

namespace RPSLS_GAME
{
    class Program
    {
        static void Main(string[] args)
        {
            GameInitialize();
            GetUserInput();
            PressedKeyValidation();
            GameLogic();
            SaveTheResult();

        }
    }
}
