Console.WriteLine("How are you feeling today?");

foreach (Mood mood in Enum.GetValues(typeof(Mood)))
{
    Console.WriteLine($"{(int)mood}. {mood}");
}

Console.Write("Enter the number corresponding to your mood: ");

string input = Console.ReadLine();

// switch (input) // this seems excessive?
// {
//     case "1":
//         Console.WriteLine($"You're feeling {Mood.Happy}")
//  // continue with switch
// }

Dictionary<string, Mood> moodMap = new Dictionary<string, Mood>
{
    {"1", Mood.Happy },
    {"2", Mood.Sad },
    { "3", Mood.Excited },
    { "4", Mood.Calm },
    { "5", Mood.Angry }
};

Dictionary<Mood, string> moodToEmoji = new Dictionary<Mood, string>
{
    {Mood.Happy, "😃" },
    {Mood.Sad, "😞" },
    {Mood.Excited, "😄" },
    {Mood.Calm, "😌" },
    {Mood.Angry, "😠" }
};

if (moodMap.TryGetValue(input, out Mood selectedMood))
{
    string selectedEmoji = moodToEmoji[selectedMood];    
    Console.WriteLine($"You're feeling {selectedMood} {selectedEmoji}");
}
else
{
    Console.WriteLine("Invalid selection. please enter a valid number");
}


enum Mood { Happy = 1, Sad, Excited, Calm, Angry }
