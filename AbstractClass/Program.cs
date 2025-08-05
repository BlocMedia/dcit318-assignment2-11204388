using System;

public abstract class Shape
{
   
    public abstract double GetArea();

    public void DisplayShapeInfo()
    {
        Console.WriteLine("This is a generic shape.");
    }
}
 
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be a positive value.");
        }
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        if (length <= 0 || width <= 0)
        {
            throw new ArgumentException("Length and Width must be positive values.");
        }
        Length = length;
        Width = width;
    }

    public override double GetArea()
    {
        return Length * Width;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculating Areas of Shapes using Abstract Classes!\n");

        try
        {
            Circle myCircle = new Circle(5.0); // Radius 5
            Rectangle myRectangle = new Rectangle(4.0, 6.0); // Length 4, Width 6

            Console.WriteLine($"Circle with radius {myCircle.Radius:F2} has an area of: {myCircle.GetArea():F2}");
            Console.WriteLine($"Rectangle with length {myRectangle.Length:F2} and width {myRectangle.Width:F2} has an area of: {myRectangle.GetArea():F2}");

            Console.WriteLine("\n--- Demonstrating Polymorphism ---");
            Shape shape1 = myCircle;
            Shape shape2 = myRectangle;

            Console.WriteLine($"Area of shape1 (which is a Circle): {shape1.GetArea():F2}");
            Console.WriteLine($"Area of shape2 (which is a Rectangle): {shape2.GetArea():F2}");
            
            shape1.DisplayShapeInfo();

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey(); 
    }
}
