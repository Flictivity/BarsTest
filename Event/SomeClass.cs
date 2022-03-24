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
                OneKeyPressed?.Invoke(this, inputCh);

                inputCh = Console.ReadKey().KeyChar; 
            }
        }
    }
}
