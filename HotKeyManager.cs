using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MediaSessionHotKey
{
    internal class HotKeyManager
    {
        // Import the user32.dll
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // Define modifier constants
        public const uint MOD_CONTROL = 0x0002;
        public const uint MOD_SHIFT = 0x0004;
        public const uint MOD_ALT = 0x0001;
        public const uint MOD_WIN = 0x0008;

        // Method to register your hotkey
        public static void RegisterSystemHotKey(IntPtr hWnd, Keys modifier, Keys key, int HOTKEY_ID)
        {
            // The modifiers are bit fields, so you can OR them together if you have multiple modifiers.
            uint modifiers = 0;
            if (modifier.HasFlag(Keys.Alt))
                modifiers |= MOD_ALT;
            if (modifier.HasFlag(Keys.Control))
                modifiers |= MOD_CONTROL;
            if (modifier.HasFlag(Keys.Shift))
                modifiers |= MOD_SHIFT;
            if (modifier.HasFlag(Keys.LWin))
                modifiers |= MOD_WIN;
            if (modifier.HasFlag(Keys.RWin))
                modifiers |= MOD_WIN;

            // Register the hotkey
            bool result = RegisterHotKey(hWnd, HOTKEY_ID, modifiers, (uint)key);
            if (!result) { Console.WriteLine($"Error registering hotkey. {modifier} + {key}"); }
        }

        // Method to unregister your hotkey
        public static void UnregisterSystemHotKey(IntPtr hWnd, int HOTKEY_ID)
        {
            UnregisterHotKey(hWnd, HOTKEY_ID);
        }
    }
}
