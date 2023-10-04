int AskForNumber(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

AskForNumber("give me a number!");

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < max && number > min)
            return number;
        else 
           Console.WriteLine($"invalid input, enter a number between {min} and {max}");
    }
}

AskForNumberInRange("give me a number", 1, 234);

