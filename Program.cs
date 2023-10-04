using Stapel;

class Program
{
    static void Main(string[] args)
    {
        // Testen met integers
        Stapel<int> intStack = new Stapel<int>();
        intStack.Opzetten(1);
        intStack.Opzetten(2);
        intStack.Opzetten(3);
        Console.WriteLine("Integer Stapel:");
        Console.WriteLine(intStack);
        int item1 = intStack.Afhalen();
        Console.WriteLine($"Afgehaald: {item1}");
        Console.WriteLine(intStack);
        intStack.Leegmaken();
        Console.WriteLine("Na leegmaken:");
        Console.WriteLine(intStack);


        // Testen met een zelfgemaakte klasse (bijvoorbeeld een eenvoudige Point-klasse)
//        Stapel<Point> pointStack = new Stapel<Point>();
//        pointStack.Opzetten(new Point(1, 2));
//        pointStack.Opzetten(new Point(3, 4));
//        pointStack.Opzetten(new Point(5, 6));
//        Console.WriteLine("\nPoint Stapel:");
//        Console.WriteLine(pointStack);
//        Point item3 = pointStack.Afhalen();
//        Console.WriteLine($"Afgehaald: {item3}");
//        Console.WriteLine(pointStack);
//        pointStack.Leegmaken();
//        Console.WriteLine("Na leegmaken:");
//        Console.WriteLine(pointStack);
//    }
//}

//public class Point
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }
}

