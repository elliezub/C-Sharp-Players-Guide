Console.Title = "The Defense Of Consolas";

Console.Write("Target row? ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Target column? ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Deploy to:");

Console.WriteLine($"({row}, {column - 1})");
Console.WriteLine($"({row - 1}, {column})");
Console.WriteLine($"({row}, {column + 1})");
Console.WriteLine($"({row + 1}, {column})");

