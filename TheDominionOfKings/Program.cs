int calculateKingdomScore(int numberOfEstates, int numberOfDutchies, int numberOfProvinces)
{
    int totalEstates = numberOfEstates;
    int totalDutchies = numberOfDutchies * 3;
    int totalProvinces = numberOfProvinces * 6;

    return totalEstates + totalDutchies + totalProvinces;
}

Console.WriteLine(calculateKingdomScore(4, 3, 1));