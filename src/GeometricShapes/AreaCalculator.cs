using System;

namespace GeometricShapes
{
    // Single Responsibility Principle (SRP): Calculates total area of shapes
    public class AreaCalculator
    {
        private readonly ILogger _logger;

        // Dependency Inversion Principle (DIP): Logger dependency injection through constructor
        public AreaCalculator(ILogger logger)
        {
            _logger = logger;
        }

        public double CalculateTotalArea(Shape[] shapes)
        {
            double totalArea = 0;

            foreach (var shape in shapes)
            {
                // Open/Closed Principle (OCP): Utilizes the Area method without modification
                totalArea += shape.Area();
            }

            // Single Responsibility Principle (SRP): Logging responsibility delegated to Logger
            _logger.Log($"Total Area: {totalArea}");

            return totalArea;
        }
    }
}
