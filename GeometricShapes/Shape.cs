// Shape.cs
using System;

namespace GeometricShapes
{
    // Single Responsibility Principle (SRP): Represents a geometric shape
    public abstract class Shape
    {
        // Open/Closed Principle (OCP): Encapsulates the area calculation, open for extension
        public abstract double Area();
    }
}
