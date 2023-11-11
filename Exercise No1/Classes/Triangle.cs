namespace ExerciseNo1.Classes 
{
    public class Triangle : IShape
    {
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculateArea()
    {
        // Using Heron's formula for the area of a triangle
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsRightAngled()
    {
        // Check if the triangle is right-angled using the Pythagorean theorem
        return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
               Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2) ||
               Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2);
    }
    }
}