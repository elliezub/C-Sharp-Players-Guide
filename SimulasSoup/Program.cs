// first attempt
// (FoodType type, MainIngredient ingredient, Seasoning seasoning) soup = GetSoup(); // i know i dont have a get soup method

// Console.Write("Pick a type (soup, stew or gumbo): ");
// FoodType = Console.ReadLine();

// Console.Write("Pick a main ingredient (mushrooms, chicken, carrots, or potatoes): ");
// MainIngredient = Console.ReadLine();

// Console.Write("Pick a seasoning (spicy, salty, or sweet): ");
// Seasoning = Console.ReadLine();

// Console.WriteLine($"Your soup is: {soup}")
// enum Seasoning { spicy, salty, sweet }
// enum MainIngredient { mushrooms, chicken, carrots, potatoes }
// enum FoodType { soup, stew, gumbo }


//second attempt -- no tuples

FoodType currentFoodType = FoodType.soup;
MainIngredient currentMainIngredient = MainIngredient.mushrooms;
Seasoning currentSeasoning = Seasoning.spicy;
string choice;

Console.WriteLine(currentFoodType);

while (true)
{
    Console.Write("Pick a type (soup, stew or gumbo): ");
    choice = Console.ReadLine();
    
    switch (choice)
    {
        case "soup":
            currentFoodType = FoodType.soup;
            break;
        case "stew":
            currentFoodType = FoodType.stew;
            break;
        case "gumbo":
            currentFoodType = FoodType.gumbo;
            break;
    }

    Console.Write("Pick a main ingredient (mushrooms, chicken, carrots, or potatoes): ");
    choice = Console.ReadLine();
    
    switch (choice)
    {
        case "mushrooms":
            currentMainIngredient = MainIngredient.mushrooms;
            break;
        case "chicken":
            currentMainIngredient = MainIngredient.chicken;
            break;
        case "carrots":
            currentMainIngredient = MainIngredient.carrots;
            break;
        case "potatoes":
            currentMainIngredient = MainIngredient.potatoes;
            break;
    }

    Console.Write("Pick a seasoning (spicy, salty, or sweet):  ");
    choice = Console.ReadLine();
    
    switch (choice)
    {
        case "spicy":
            currentSeasoning = Seasoning.spicy;
            break;
        case "salty":
            currentSeasoning = Seasoning.salty;
            break;
        case "sweet":
            currentSeasoning = Seasoning.sweet;
            break;
    }

    Console.WriteLine($"your soup: {currentSeasoning} {currentMainIngredient} {currentFoodType}");

}

enum Seasoning { spicy, salty, sweet }
enum MainIngredient { mushrooms, chicken, carrots, potatoes }
enum FoodType { soup, stew, gumbo }