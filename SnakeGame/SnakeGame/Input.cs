using System.Collections;
using System.Windows.Forms;

namespace SnakeGame
{
    class Input
    {
        // List og available Keyboard Buttons
        private static Hashtable keyTable = new Hashtable();

        // Check to see if a particular button is pressed.
        public static bool KeyPressed(Keys key)
        {
            if(keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        // Detect if a keyboard button is pressed
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
