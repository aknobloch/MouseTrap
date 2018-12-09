using System;
using System.Runtime.InteropServices;

namespace MouseTrap
{
    class Runner
    {
        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);

        static void Main(string[] args)
        {
            SetCursorPos(Int32.MaxValue, Int32.MaxValue);
        }
    }
}
