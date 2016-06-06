using System;

namespace depb
{
    public class DepBClass : IDepBClass
    {
        public void DoSomething(DepBConfiguration configuration)
        {
            Console.WriteLine("DepBMethod");
            Console.WriteLine(configuration.Smtp.Server);
            Console.WriteLine(configuration.Blah);
        }
    }
}