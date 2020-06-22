using System;

namespace creational_patterns
{
    public class Singleton
    {
        private static Singleton _instance;

        private static object lockObject = new object();

        protected Singleton()
        {

        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                lock (lockObject)
                {
                    if(_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }
}
