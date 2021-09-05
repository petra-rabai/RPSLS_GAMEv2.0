using static RPSLS_GAME.GameCore;
using static RPSLS_GAME.GameUI;

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
            GameFinalize();
        }
    }
}
