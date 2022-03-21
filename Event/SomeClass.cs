using System;

namespace Event_Delegate
{
    class SomeClass
    {
        public event EventHandler<char> OneKeyPressed;

        public void Run()
        {
            var inputStr = Console.ReadKey().KeyChar;
            while (inputStr != 'c')
            {
                OneKeyPressed?.Invoke(this, inputStr);

                inputStr = Console.ReadKey().KeyChar; 
            }
        }
    }
}
