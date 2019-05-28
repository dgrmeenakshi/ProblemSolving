using System;

namespace ProblemSolving.DesignPattern
{
    public class Singleton
    {
        private static int _counter;
        private static readonly object Obj = new object();
        /*
        * Private constructor ensures that object is not
        * instantiated other than with in the class itself
        */
        private Singleton()
        {
            _counter++;
            Console.WriteLine("Only " + _counter + " Instance is created");
        }
        private static Singleton _instance;
        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         * Made it static so it could be used because Singleton class object creation not possible using new Operator
         */
        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Obj)// it's a keyword which ensures one thread is executing a piece of code at one time. 
                    {
                        if (_instance == null)
                            _instance = new Singleton();
                    }
                }
                return _instance;
            }
        }
        /*
         * Public method which can be invoked through the singleton instance
         */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

}

