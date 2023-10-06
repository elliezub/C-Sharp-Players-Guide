int calculateKingdomScore(int numberOfEstates, int numberOfDutchies, int numberOfProvinces)
{
    int totalEstates = numberOfEstates;
    int totalDutchies = numberOfDutchies * 3;
    int totalProvinces = numberOfProvinces * 6;

    return totalEstates + totalDutchies + totalProvinces;
}
Console.BackgroundColor = ConsoleColor.Yellow; // makes the text background yellow
Console.Clear(); // wipes out all on screen text and changes entire bg color
Console.WriteLine(calculateKingdomScore(4, 3, 1));


// unrelated note on incrementing after vs before
int x = 5;
int y = x++;

Console.WriteLine(y);
Console.WriteLine(x);