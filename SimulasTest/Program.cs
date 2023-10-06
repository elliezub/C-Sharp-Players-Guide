// ENUMERATION

ChestState current = ChestState.Locked;

while (true)
{
    string currentState = current.ToString().ToLower();

    Console.Write($"The chest is {currentState}, what do you want to do? ");

    string choice = (Console.ReadLine()).ToLower();

    if (current == ChestState.Open && choice == "close") current = ChestState.Closed;
    if (current == ChestState.Closed && choice == "lock") current = ChestState.Locked;
    if (current == ChestState.Locked && choice == "unlock") current = ChestState.Unlocked;
    if (current == ChestState.Unlocked && choice == "open") current = ChestState.Open;

}

enum ChestState { Open, Closed, Locked, Unlocked }