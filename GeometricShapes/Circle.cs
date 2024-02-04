namespace GeometricShapes
{
    // Single Responsibility Principle (SRP): Represents a circle
    public class Circle : Shape
    {
        // Liskov Substitution Principle (LSP): Specialized version of Shape
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Open/Closed Principle (OCP): Overrides the Area method for circle-specific calculation
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
