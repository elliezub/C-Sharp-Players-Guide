using System.Runtime.CompilerServices;

int manticoreDistance = 0;
StartGame();

void StartGame()
{
    GetManticoreDistance();
    Console.Clear();
    StartBattle();
}

void GetManticoreDistance()
{
    bool validInput = false;

    do
    {
        Console.Write("Player 1, how far away from the city do you want to store the Manticore (from 1-100)? ");

        try
        {
            bool isNumber = int.TryParse(Console.ReadLine(), out int readResult);

            if (isNumber && readResult <= 100 && readResult > 0)
            {
                manticoreDistance = readResult;
                validInput = true;
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 100");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occured: {e.Message}");
        }

    } while (!validInput);
}

void StartBattle()
{
    int manticoreHealth = 10;
    int cityHealth = 15;
    //int roundNumber = 1;
    int damage = 1;
    bool gameEnded = false;

    Console.WriteLine("Player 2, it's your turn");

    do
    {
        for (int roundNumber = 1; roundNumber <= 15; roundNumber++)
        {
            Console.WriteLine($"STATUS: Round: {roundNumber} City {cityHealth}/15 Manticore: {manticoreHealth}/10");

            if (roundNumber % 5 == 0 && roundNumber % 3 == 0)
            {
                damage = 10;
            }
            else if (roundNumber % 5 == 0 || roundNumber % 3 == 0)
            {
                damage = 3;
            }
            else
                damage = 1;

            Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

            bool validInput = false;

            do
            {
                Console.Write("Enter descired cannon range: ");
                try
                {
                    bool isNumber = int.TryParse(Console.ReadLine(), out int readResult);
                    if (isNumber && readResult <= 100 && readResult > 0)
                    {
                        if (readResult == manticoreDistance)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("This round was a DIRECT HIT!");
                            Console.ResetColor();
                            manticoreHealth -= damage;
                        }
                        else if (readResult > manticoreDistance)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That round OVERSHOT the target.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("That round FELL SHORT of the target");
                            Console.ResetColor();
                        }

                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer between 1 and 100");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"An error occured: {e.Message}");
                }
            } while (!validInput);

            if (cityHealth <= 0)
            {
                gameEnded = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The city of Consolas has been destroyed!");
                break;
            }
            else if (manticoreHealth > 0)
            {
                cityHealth--;
            }
            else if (manticoreHealth <= 0)
            {
                gameEnded = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
                break;
            }

        }

    } while (!gameEnded);
}

