using System;

class Program
{
    static void Main(string[] args)
    {
        // Read in the coordinates of the 3 points
        Console.Write("Enter coordinate x of dot A: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Enter coordinate y of dot A: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter coordinate x of dot B: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Enter coordinate y of dot B: ");
        double y2 = double.Parse(Console.ReadLine());

        Console.Write("Enter coordinate x of dot C: ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("Enter coordinate y of dot C: ");
        double y3 = double.Parse(Console.ReadLine());

        // Calculate the lengths of the sides
        double sideA = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double sideB = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        double sideC = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

        // Print the lengths of the sides
        Console.WriteLine($"Side A: {sideA}");
        Console.WriteLine($"Side B: {sideB}");
        Console.WriteLine($"Side C: {sideC}");

        // Check if the triangle is equilateral
        bool isEquilateral = sideA == sideB && sideB == sideC;
        Console.WriteLine($"Is the triangle equilateral? {isEquilateral}");

        // Check if the triangle is isosceles
        bool isIsosceles = sideA == sideB || sideB == sideC || sideC == sideA;
        Console.WriteLine($"Is the triangle isosceles? {isIsosceles}");

        // Check if the triangle is right-angled
        double delta = 0.0001; // Adjust the delta value as needed
        bool isRight = Math.Abs(sideA * sideA + sideB * sideB - sideC * sideC) <= delta
                      || Math.Abs(sideB * sideB + sideC * sideC - sideA * sideA) <= delta
                      || Math.Abs(sideC * sideC + sideA * sideA - sideB * sideB) <= delta;
        Console.WriteLine($"Is the triangle right-angled? {isRight}");

        // Calculate and print the perimeter of the triangle
        double perimeter = sideA + sideB + sideC;
        Console.WriteLine($"Perimeter: {perimeter}");

        // Print even numbers from 0 to the value of the perimeter
        Console.WriteLine("Even numbers from 0 to the perimeter:");
        for (int i = 0; i <= perimeter; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}