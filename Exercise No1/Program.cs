using ExerciseNo1.Classes;

namespace ExerciseNo1 
{
// Unit tests
class Program
{
    static void Main()
    {
        // Circle
        Circle circle = new Circle(5);
        Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

        // Triangle
        Triangle triangle = new Triangle(3, 4, 5);
        Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");
        Console.WriteLine($"Is Triangle Right-Angled: {triangle.IsRightAngled()}");

        // Rectangle (added as another shape)
        Rectangle rectangle = new Rectangle(4, 6);
        Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
    }
}
}