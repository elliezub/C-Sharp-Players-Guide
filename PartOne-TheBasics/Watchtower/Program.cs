Console.WriteLine("please enter x and y coordinate values so we can determine the enemy location:");
Console.Write("X:");
int xValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int yValue = Convert.ToInt32(Console.ReadLine());

if (yValue > 0)
{
    if (xValue < 0)
        Console.WriteLine("the enemy is in the northwest");
    else if (xValue == 0)
        Console.WriteLine("the enemy is in the north");
    else 
        Console.WriteLine("the enemy is in the northeast");
}
else if (yValue == 0)
{
    if (xValue < 0)
        Console.WriteLine("the enemy is in the west");
    else if (xValue == 0)
        Console.WriteLine("the enemy is here!");
    else
        Console.WriteLine("The enemy is in the east");
}
else
{
    if (xValue < 0)
        Console.WriteLine("the enemy is in the southwest");
    else if (xValue == 0)
        Console.WriteLine("the enemy is in the south");
    else
        Console.WriteLine("The enemy is in the southeast");
}