﻿namespace Microsoft.Win32
{
    public static class WH
    {
        /// <summary>
        /// Windows NT/2000/XP: Installs a hook procedure that monitors low-level mouse input events.
        /// </summary>
        public const int MOUSE_LL = 14;

        /// <summary>
        /// Windows NT/2000/XP: Installs a hook procedure that monitors low-level keyboard  input events.
        /// </summary>
        public const int KEYBOARD_LL = 13;

        /// <summary>
        /// Installs a hook procedure that monitors mouse messages. For more information, see the MouseProc hook procedure. 
        /// </summary>
        public const int MOUSE = 7;

        /// <summary>
        /// Installs a hook procedure that monitors keystroke messages. For more information, see the KeyboardProc hook procedure. 
        /// </summary>
        public const int KEYBOARD = 2;
    }
    public static class WM
    {
        /// <summary>
        /// The WM_MOUSEMOVE message is posted to a window when the cursor moves. 
        /// </summary>
        public const int MOUSEMOVE = 0x200;

        /// <summary>
        /// The WM_LBUTTONDOWN message is posted when the user presses the left mouse button 
        /// </summary>
        public const int LBUTTONDOWN = 0x201;

        /// <summary>
        /// The WM_RBUTTONDOWN message is posted when the user presses the right mouse button
        /// </summary>
        public const int RBUTTONDOWN = 0x204;

        /// <summary>
        /// The WM_MBUTTONDOWN message is posted when the user presses the middle mouse button 
        /// </summary>
        public const int MBUTTONDOWN = 0x207;

        /// <summary>
        /// The WM_LBUTTONUP message is posted when the user releases the left mouse button 
        /// </summary>
        public const int LBUTTONUP = 0x202;

        /// <summary>
        /// The WM_RBUTTONUP message is posted when the user releases the right mouse button 
        /// </summary>
        public const int RBUTTONUP = 0x205;

        /// <summary>
        /// The WM_MBUTTONUP message is posted when the user releases the middle mouse button 
        /// </summary>
        public const int MBUTTONUP = 0x208;

        /// <summary>
        /// The WM_LBUTTONDBLCLK message is posted when the user double-clicks the left mouse button 
        /// </summary>
        public const int LBUTTONDBLCLK = 0x203;

        /// <summary>
        /// The WM_RBUTTONDBLCLK message is posted when the user double-clicks the right mouse button 
        /// </summary>
        public const int RBUTTONDBLCLK = 0x206;

        /// <summary>
        /// The WM_RBUTTONDOWN message is posted when the user presses the right mouse button 
        /// </summary>
        public const int MBUTTONDBLCLK = 0x209;

        /// <summary>
        /// The WM_MOUSEWHEEL message is posted when the user presses the mouse wheel. 
        /// </summary>
        public const int MOUSEWHEEL = 0x020A;

        /// <summary>
        /// The WM_KEYDOWN message is posted to the window with the keyboard focus when a nonsystem 
        /// key is pressed. A nonsystem key is a key that is pressed when the ALT key is not pressed.
        /// </summary>
        public const int KEYDOWN = 0x100;

        /// <summary>
        /// The WM_KEYUP message is posted to the window with the keyboard focus when a nonsystem 
        /// key is released. A nonsystem key is a key that is pressed when the ALT key is not pressed, 
        /// or a keyboard key that is pressed when a window has the keyboard focus.
        /// </summary>
        public const int KEYUP = 0x101;

        /// <summary>
        /// The WM_SYSKEYDOWN message is posted to the window with the keyboard focus when the user 
        /// presses the F10 key (which activates the menu bar) or holds down the ALT key and then 
        /// presses another key. It also occurs when no window currently has the keyboard focus; 
        /// in this case, the WM_SYSKEYDOWN message is sent to the active window. The window that 
        /// receives the message can distinguish between these two contexts by checking the context 
        /// code in the lParam parameter. 
        /// </summary>
        public const int SYSKEYDOWN = 0x104;

        /// <summary>
        /// The WM_SYSKEYUP message is posted to the window with the keyboard focus when the user 
        /// releases a key that was pressed while the ALT key was held down. It also occurs when no 
        /// window currently has the keyboard focus; in this case, the WM_SYSKEYUP message is sent 
        /// to the active window. The window that receives the message can distinguish between 
        /// these two contexts by checking the context code in the lParam parameter. 
        /// </summary>
        public const int SYSKEYUP = 0x105;
    }
    public static class VK
    {
        public const byte SHIFT = 0x10;
        public const byte CAPITAL = 0x14;
        public const byte NUMLOCK = 0x90;

        public const byte CONTROL = 0x11;
    }
}