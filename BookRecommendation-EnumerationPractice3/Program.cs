
do
{
    Console.WriteLine("Heres a list of genres:");

    foreach (BookGenre genre in Enum.GetValues(typeof(BookGenre)))
    {
        Console.WriteLine($"{(int)genre}. {genre}");
    }

    Console.Write("Enter a number for a book suggestion: ");

    int input;
    bool isNumber = int.TryParse( Console.ReadLine(), out input );

    if (isNumber && Enum.IsDefined(typeof(BookGenre), input))
    {
        BookGenre currentGenre = (BookGenre)input;

        string result = currentGenre switch
        {
            BookGenre.Mystery => "The Alienist",
            BookGenre.Fantasy => "The Harry Potter series",
            BookGenre.ScienceFiction => "Journey to the Center of the Earth",
            BookGenre.SelfHelp => "Atmoic Habits",
            _ => "no recommendation found"
        };

        Console.WriteLine(result);
    }
    else
        Console.WriteLine("invalid input");

    Console.WriteLine();

} while (true);

enum BookGenre { Mystery = 1, Fantasy, ScienceFiction, SelfHelp }
