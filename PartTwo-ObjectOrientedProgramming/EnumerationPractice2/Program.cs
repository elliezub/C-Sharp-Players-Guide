
do
{
    Console.WriteLine("Whats the weather like outside? ");

    foreach (Weather weather in Enum.GetValues(typeof(Weather)))
    {
        Console.WriteLine($"{(int)weather}. {weather}");
    }
    Console.Write("Enter a number corresponding to the current weather: ");

    string input = Console.ReadLine();

    if (int.TryParse(input, out int choice) && Enum.IsDefined(typeof(Weather), choice))
    {
        switch ((Weather)choice)
        {
            case Weather.Sunny:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Go to the beach!");
                Console.ResetColor();
                break;
            case Weather.Rainy:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Bring an umbrella if you're going out, otherwise stay inside!");
                Console.ResetColor();
                break;
            case Weather.Cloudy:
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Do whatever you want!");
                Console.ResetColor();
                break;
            case Weather.Snowy:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Go sledding!");
                Console.ResetColor();
                break;
            case Weather.Windy:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Go to the park and fly a kite!");
                Console.ResetColor();
                break;
            default:
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Please enter a valid input");
                Console.ResetColor();
                break;
        }
    }
    else
    {   
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("invalid input");
        Console.ResetColor();
    }

    Console.WriteLine();

} while (true);


enum Weather { Sunny = 1, Rainy, Cloudy, Snowy, Windy }
