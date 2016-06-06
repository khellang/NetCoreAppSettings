using depb;
using System;

namespace depa
{
    public class DepAClass : IDepAClass
    {
        private readonly IDepBClass _depBClass;

        public DepAClass(IDepBClass depBClass)
        {
            _depBClass = depBClass;
        }

        public void DepAMethod(DepAConfiguration configuration)
        {
            Console.WriteLine("DepAMethod");
            Console.WriteLine(configuration.Logging.LogLevel.Microsoft);
            
            _depBClass.DoSomething(configuration.DepB);
        }
    }
}