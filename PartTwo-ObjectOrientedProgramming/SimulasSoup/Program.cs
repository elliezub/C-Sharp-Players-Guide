// first attempt
// (FoodType type, MainIngredient ingredient, Seasoning seasoning) soup = GetSoup();

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

// FoodType currentFoodType = FoodType.soup;
// MainIngredient currentMainIngredient = MainIngredient.mushrooms;
// Seasoning currentSeasoning = Seasoning.spicy;
// string choice;

// Console.WriteLine(currentFoodType);

// while (true)
// {
//     Console.Write("Pick a type (soup, stew or gumbo): ");
//     choice = Console.ReadLine();
    
//     switch (choice)
//     {
//         case "soup":
//             currentFoodType = FoodType.soup;
//             break;
//         case "stew":
//             currentFoodType = FoodType.stew;
//             break;
//         case "gumbo":
//             currentFoodType = FoodType.gumbo;
//             break;
//     }

//     Console.Write("Pick a main ingredient (mushrooms, chicken, carrots, or potatoes): ");
//     choice = Console.ReadLine();
    
//     switch (choice)
//     {
//         case "mushrooms":
//             currentMainIngredient = MainIngredient.mushrooms;
//             break;
//         case "chicken":
//             currentMainIngredient = MainIngredient.chicken;
//             break;
//         case "carrots":
//             currentMainIngredient = MainIngredient.carrots;
//             break;
//         case "potatoes":
//             currentMainIngredient = MainIngredient.potatoes;
//             break;
//     }

//     Console.Write("Pick a seasoning (spicy, salty, or sweet):  ");
//     choice = Console.ReadLine();
    
//     switch (choice)
//     {
//         case "spicy":
//             currentSeasoning = Seasoning.spicy;
//             break;
//         case "salty":
//             currentSeasoning = Seasoning.salty;
//             break;
//         case "sweet":
//             currentSeasoning = Seasoning.sweet;
//             break;
//     }

//     Console.WriteLine($"your soup: {currentSeasoning} {currentMainIngredient} {currentFoodType}");

// }

// enum Seasoning { spicy, salty, sweet }
// enum MainIngredient { mushrooms, chicken, carrots, potatoes }
// enum FoodType { soup, stew, gumbo }


// ------------------------------------------------------------------------------------
// third attempt with tuples + enumeration

(FoodType, MainIngredient, Seasoning) soup = GetSoup();
Console.WriteLine($"Your soup: {soup.Item3} {soup.Item2} {soup.Item1}");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

(FoodType, MainIngredient, Seasoning) GetSoup()
{
    FoodType type = GetFoodType();
    MainIngredient ingredient = GetMainIngredient();
    Seasoning seasoning = GetSeasoning();
    return (type, ingredient, seasoning);
}

FoodType GetFoodType()
{
    Console.Write("Pick a type (soup, stew or gumbo): ");
    string choice = Console.ReadLine();
    
    switch (choice)
    {
        case "soup":
            return FoodType.Soup;
        case "stew":
            return FoodType.Stew;
        case "gumbo":
            return FoodType.Gumbo;
        default:
            Console.WriteLine("Invalid choice. Please enter soup, stew, or gumbo.");
            return GetFoodType();
    }
}

MainIngredient GetMainIngredient()
{
    Console.Write("Pick a main ingredient (mushrooms, chicken, carrots, or potatoes): ");
    string choice = Console.ReadLine();
    
    switch (choice)
    {
        case "mushrooms":
            return MainIngredient.Mushrooms;
        case "chicken":
            return MainIngredient.Chicken;
        case "carrots":
            return MainIngredient.Carrots;
        case "potatoes":
            return MainIngredient.Potatoes;
        default:
            Console.WriteLine("Invalid choice. Please enter mushrooms, chicken, carrots, or potatoes.");
            return GetMainIngredient(); 
    }
}

Seasoning GetSeasoning()
{
    Console.Write("Pick a seasoning (spicy, salty, or sweet):  ");
    string choice = Console.ReadLine();
    
    switch (choice)
    {
        case "spicy":
            return Seasoning.Spicy;
        case "salty":
            return Seasoning.Salty;
        case "sweet":
            return Seasoning.Sweet;
        default:
            Console.WriteLine("Invalid choice. Please enter spicy, salty, or sweet.");
            return GetSeasoning(); 
    }
}

enum Seasoning { Spicy, Salty, Sweet }
enum MainIngredient { Mushrooms, Chicken, Carrots, Potatoes }
enum FoodType { Soup, Stew, Gumbo }