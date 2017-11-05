using System;

namespace SingletonApp
{
    /// <summary>
    /// Sealed restricts the inheritance
    /// </summary>
    public sealed class Singleton
    {
        private static int _counter;
        private static readonly object Synclock = new object();
        private static Singleton _instance;

//        public static Singleton GetInstance => _instance ?? (_instance = new Singleton()); //Not yet thread safe Singleton

        /// <summary>
        /// Thread safety in Singleton
        /// </summary>
        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Synclock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }
        
        /// <summary>
        /// Private constructor ensures that object is not
        /// instantiated other than with in the class itself
        /// </summary>
        private Singleton()
        {
            _counter++;
            Console.WriteLine($"ID {_counter} instance created");
        }

        public void WriteDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}