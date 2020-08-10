using System;

namespace EDC.DesignPattern.FactoryMethod.v1
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("File Logger...");
        }
    }
}