using System;

public abstract class Shape
{
    public abstract double GetArea();

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"This is a generic shape with an area of: {GetArea()}");
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

public interface IMovable
{
    void Move();
}

public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Demonstrating Shapes ---");
        
        Circle myCircle = new Circle(5);
        myCircle.DisplayShapeInfo();

        Rectangle myRectangle = new Rectangle(10, 4);
        myRectangle.DisplayShapeInfo();

        Console.WriteLine(); 

        Console.WriteLine("--- Demonstrating Movable Objects ---");
        
        Car myCar = new Car();
        myCar.Move();

        Bicycle myBicycle = new Bicycle();
        myBicycle.Move();
    }
}