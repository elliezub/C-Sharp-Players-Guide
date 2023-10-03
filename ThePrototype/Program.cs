int secretNumber = -1;

while (secretNumber < 0 || secretNumber > 100) 
{
    Console.Write("User 1, please enter a number between 0 and 100: ");
    bool isValidInput = Int32.TryParse(Console.ReadLine(), out secretNumber);

    if (!isValidInput || secretNumber < 0 || secretNumber > 100)
    {
        Console.WriteLine("Invalid input. please enter a number between 0 and 100");
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }

    Console.Clear();
}

int guess;

Console.WriteLine("User 2, guess the number, its between 0 and 100.");

do
{
    Console.Write("What is your next guess? ");
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess > 100 || guess < 0)
        Console.WriteLine("Your guess is invalid, it needs to be between 0 and 100.");
    else if (guess > secretNumber)
        Console.WriteLine($"{guess} is too high");
    else if (guess < secretNumber)
        Console.WriteLine($"{guess} is too low");
    else Console.WriteLine("You guessed the number!");

} while (guess != secretNumber);
