using System;

namespace GeometricShapes.Logger
{
    // Single Responsibility Principle (SRP): Console logging implementation
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Log] {message}");
        }
    }
}
