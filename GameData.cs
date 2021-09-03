using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME
{
    public class GameData
    {
        private static char userPressedkey;

        public static char UserPressedkey { get => userPressedkey; set => userPressedkey = value; }

        public static void GetData()
        {
           // WaitForUser();
            GetUserInput();

        }

        public static void StoreData()
        {

        }

        

        public static char GetUserInput()
        {
            ConsoleKeyInfo Hitkey = Console.ReadKey();
            userPressedkey = Char.Parse(Hitkey.Key.ToString());
            return userPressedkey;

        }
          
    
    }
}
