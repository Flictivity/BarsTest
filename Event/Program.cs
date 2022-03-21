using System;

namespace Event_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeClass test = new SomeClass();

            test.OneKeyPressed += Print;
            test.Run();
        }

        private static void Print(object sender, char ch)
        {
            Console.WriteLine(ch);
        }
    }
}
