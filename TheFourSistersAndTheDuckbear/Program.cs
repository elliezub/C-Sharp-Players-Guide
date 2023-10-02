int remainder;
int eggsForEachSister;

string remainingEggs(int eggs)
{
    remainder = eggs % 4;
    eggsForEachSister = (eggs - remainder)/4;
    return $"if there are {eggs} eggs each sister gets {eggsForEachSister} eggs and the duckbear gets {remainder} eggs";
}

Console.WriteLine(remainingEggs(23));
Console.WriteLine("Number of total eggs where the duckbear gets more eggs:");

for (int i = 0; i < 20; i++)
{
    remainingEggs(i);
    if (remainder > eggsForEachSister)
        Console.WriteLine(i);
}