using System;

namespace SingletonApp
{
    class NotSingleton
    {
        private static int _couter;

        public NotSingleton()
        {
            _couter++;
            Console.WriteLine($"ID {_couter} instance created");
        }

        public void WriteDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}