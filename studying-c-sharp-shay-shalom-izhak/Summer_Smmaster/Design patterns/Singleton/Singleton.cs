using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Singleton
{
    public class Singleton
    {
        // Private static instance of the class
        private static Singleton _instance;

        // Lock synchronization object for thread safety
        private static readonly object _lock = new object();

        // Private constructor to prevent instance creation
        private Singleton()
        {
            Console.WriteLine("Singleton Instance created.");
        }

        // Public static method to get the single instance of the class
        public static Singleton Instance
        {
            get
            {
                // Double-check locking to ensure only one instance is created
                if (_instance == null)
                {
                    lock (_lock)
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

        // A method to demonstrate the singleton behavior
        public void ShowMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }
    }

    public class RunSingleton
    {
        public static void DemoMain()
        {
            // Attempt to create multiple instances
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;

            // Check if both instances are the same
            if (instance1 == instance2)
            {
                Console.WriteLine("Both instances are the same.");
            }

            // Use the singleton instance to perform an operation
            instance1.ShowMessage("Hello Singleton!");
        }
    }

}
