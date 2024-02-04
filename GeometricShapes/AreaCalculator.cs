using System;


namespace GeometricShapes;

public class AreaCalculator
{
    private readonly ILogger _logger; 

    public AreaCalculator (ILogger logger)
    {
        _logger = logger; 
    }

    public double CalculateTotalArea(Shape[] shapes)
    {
        double totalArea = 0;

        foreach (var shape in shapes)
        {
            totalArea += shape.Area();
        }

        _logger.Log($"Total Area: {totalArea}")

    }
}
