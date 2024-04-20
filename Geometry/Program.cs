using GeometricShapesLibrary; 

class Program
{
    static void Main(string[] args)
    {
        double squareArea = GeometricShapes.SquareArea(5);
        double rectangleArea = GeometricShapes.RectangleArea(4, 6);
        double triangleArea = GeometricShapes.TriangleArea(3, 4);

        Console.WriteLine("Square area: " + squareArea);
        Console.WriteLine("Rectangle area: " + rectangleArea);
        Console.WriteLine("Triangle area: " + triangleArea);

        Console.ReadLine();
    }
}