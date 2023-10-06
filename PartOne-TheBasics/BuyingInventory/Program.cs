Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");
int itemNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Whats your name? ");
string name = Console.ReadLine();

string item = itemNumber switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => "Invalid Choice"
};

double price = itemNumber switch
{
    1 => 10,
    2 => 15,
    3 => 25,
    4 => 1,
    5 => 20,
    6 => 200,
    7 => 1,
    _ => 0
};

// discounted inventory

if (name == "ellie")
    price /= 2;

Console.WriteLine($"The {item} cost {price} gold");

