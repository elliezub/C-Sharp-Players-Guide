int[] artifactArray = new int[5];

for (int i = 0; i < artifactArray.Length; i++)
{
    Console.Write("Enter a number: ");
    int arrayItem = Convert.ToInt32(Console.ReadLine());
    artifactArray[i] = arrayItem;
}

// Console.Write("Please write the first number: ");
// int readResult = Convert.ToInt32(Console.ReadLine());
// artifactArray[0] = readResult;

// Console.Write("second number: ");
// readResult = Convert.ToInt32(Console.ReadLine());
// artifactArray[1] = readResult;

// Console.Write("third number: ");
// readResult = Convert.ToInt32(Console.ReadLine());
// artifactArray[2] = readResult;

// Console.Write("fourth number: ");
// readResult = Convert.ToInt32(Console.ReadLine());
// artifactArray[3] = readResult;

// Console.Write("fifth number: ");
// readResult = Convert.ToInt32(Console.ReadLine());
// artifactArray[4] = readResult;

Console.WriteLine("old array:");
foreach (int artifact in artifactArray)
{
    Console.WriteLine(artifact);
}

int[] newArray = new int[5];

Console.WriteLine("new array:");
for (int i = 0; i < artifactArray.Length; i++)
{
    newArray[i] = artifactArray[i];
    Console.WriteLine(newArray[i]);
}