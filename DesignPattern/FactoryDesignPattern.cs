using System;

namespace ProblemSolving.DesignPattern
{
    //Related to object creation without exposing the creation logic to the client and uses the common interface.

    public class FactoryDesignPattern
    {
        public enum OMS
        {
            connexx,
            noah
        }
        public IApplication GetApplicationFactory(OMS oms)
        {
            switch (oms)
            {
                case OMS.connexx:
                    return new Connexx();
                case OMS.noah:
                    return new Noah();
            }

            return null;
        }
    }

    public interface IApplication
    {
        void Start();
        void Stop();
    }

    public class Connexx : IApplication
    {
        public void Start()
        {
            Console.WriteLine("Connexx Launched");
        }

        public void Stop()
        {
            Console.WriteLine("Connexx Closed");
        }
    }

    public class Noah : IApplication
    {
        public void Start()
        {
            Console.WriteLine("Noah Launhed");
        }

        public void Stop()
        {
            Console.WriteLine("Noah closed");
        }
    }

    public class Client
    {
        public static void Main(string[] args)
        {
            FactoryDesignPattern factory = new FactoryDesignPattern();
            var appliaction = factory.GetApplicationFactory(FactoryDesignPattern.OMS.noah);
            appliaction.Start();
            Console.ReadLine();
        }


    }
}
