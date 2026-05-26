class Assignment4
{
    public static void Main(string[] args)
    {
        int sum;
        double average;

        Console.WriteLine("Sum and Average Calculator Program 3 Numbers");

        Console.Write("Enter Your First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Your Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Your Third Number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        sum = num1 + num2 + num3;
        average = sum / 3;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
    }
}
