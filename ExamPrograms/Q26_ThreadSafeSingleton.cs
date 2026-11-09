using System;
using System.Threading.Tasks;

namespace Q26_ThreadSafeSingleton
{
    class Singleton
    {
        private static Singleton instance;                 // the one and only object
        private static readonly object padlock = new object();
        public static int CreatedCount = 0;

        private Singleton()                                // private: nobody outside can use "new"
        {
            CreatedCount++;
        }

        public static Singleton GetInstance()
        {
            lock (padlock)                                 // only one thread at a time can enter
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // 20 threads ask for the instance at the same time
            Parallel.For(0, 20, i => Singleton.GetInstance());
            Console.WriteLine("20 threads asked for the instance");
            Console.WriteLine("Constructor ran " + Singleton.CreatedCount + " time(s)");

            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            Console.WriteLine("s1 and s2 are the same object: " + (s1 == s2));
        }
    }
}
