for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0  && i % 5 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{i}: Electric and Fire");
    }
    else if (i % 3 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}: Fire");
    }
    else if (i % 5 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{i}: Electric");
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine($"{i}: Normal");
    }
}
