namespace GeometricShapes
{
    // Single Responsibility Principle (SRP): Represents a rectangle
    public class Rectangle : Shape
    {
        // Liskov Substitution Principle (LSP): Specialized version of Shape
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Open/Closed Principle (OCP): Overrides the Area method for rectangle-specific calculation
        public override double Area()
        {
            return Width * Height;
        }
    }
}
