using System;


namespace GeometricShapes;

public class AreaCalculator
{
    private readonly ILogger _logger; 

    public AreaCalculator (ILogger logger)
    {
        _logger = logger; 
    }

}
