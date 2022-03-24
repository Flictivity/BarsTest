using System;

namespace Event_Delegate
{
    class SomeClass
    {
        public event EventHandler<char> OneKeyPressed;

        public void Run()
        {
            var inputCh = Console.ReadKey().KeyChar;
            while (inputCh != 'c')
            {
                OneKeyPressed?.Invoke(this, inputStr);

                inputCh = Console.ReadKey().KeyChar; 
            }
        }
    }
}
