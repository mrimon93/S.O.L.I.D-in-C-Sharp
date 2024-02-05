using System;

namespace GeometricShapes.Logger;
{ 
    public class ConsoleLogger
    {
        public class ConsoleLogger : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine($"[Log] {message}")
            }
        }

    }


}


