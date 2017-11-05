using System;
using System.Threading.Tasks;

namespace SingletonApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Not Singleton Pattern

            //            NotSingleton fromUserA = new NotSingleton();
            //            fromUserA.WriteDetails("From User A");
            //
            //            NotSingleton fromUserB = new NotSingleton();
            //            fromUserB.WriteDetails("From User B");
            //
            //            Console.ReadLine();

            #endregion Not Singleton Pattern

            #region Singleton Pattern But Not Yet Thread Safe

            /*
             * Assuming Singleton is created from UserA class
             * we refer to the GetInstance property from the Singleton class
             */
            //            Singleton fromUserA = Singleton.GetInstance;
            //            fromUserA.WriteDetails("From User A");

            /*
             * Assuming Singleton is created from UserB class
             * we refer to the GetInstance property from the Singleton class
             */
            //            Singleton fromUserB = Singleton.GetInstance;
            //            fromUserB.WriteDetails("From User B");
            //
            //            Console.ReadLine();

            #endregion Singleton Pattern

            
            Parallel.Invoke(
                WriteUserADetails,
                WriteUserBDetails
                ); //Invokes the methods as actions.

            Console.ReadLine();
        }
        private static void WriteUserADetails()
        {
            /*
             * Assuming Singleton is created from UserA class
             * we refer to the GetInstance property from the Singleton class
             */
            Singleton fromUserA = Singleton.GetInstance;
            fromUserA.WriteDetails("From User A");
        }
        private static void WriteUserBDetails()
        {
            /*
             * Assuming Singleton is created from UserB class
             * we refer to the GetInstance property from the Singleton class
             */
            Singleton fromUserB = Singleton.GetInstance;
            fromUserB.WriteDetails("From User B");
        }


    }
}