using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    class Input
    {
        // Loaf list of available keyboard buttons.
        private static Hashtable keyTable = new Hashtable();

        // Check if a particular button is pressed.
        public static bool KeyPressed(Keys key)
        {
            if(keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        // Detect if a keyboard button is pressed.
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
