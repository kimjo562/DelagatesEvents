using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard
{
    class Program
    {
        static bool KeyboardUpdate = false;

        static void ListenforQuit(char key)
        {
            if (key == ' ')
            {
                KeyboardUpdate = true;
            }
        }

        static void Main(string[] args)
        {
            ConsoleKeyEventPublisher consoleKeyEventPublisher = new ConsoleKeyEventPublisher();
            consoleKeyEventPublisher.Subscribe(ListenforQuit);
        
            while(KeyboardUpdate == false)
            {
                consoleKeyEventPublisher.Update();
            }

        }
    }
}
