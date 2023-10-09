Console.OutputEncoding = System.Text.Encoding.UTF8; // use to get the emojis to show up in the terminal

Console.WriteLine("How are you feeling today?");

foreach (Mood mood in Enum.GetValues(typeof(Mood)))
{
    Console.WriteLine($"{(int)mood}. {mood}");
}

Console.Write("Enter the number corresponding to your mood: ");

string input = Console.ReadLine();

// instead of switch, you can use dictionaries!

Dictionary<string, Mood> moodMap = new Dictionary<string, Mood>
{
    { "1", Mood.Happy },
    { "2", Mood.Sad },
    { "3", Mood.Excited },
    { "4", Mood.Calm },
    { "5", Mood.Angry }
};

Dictionary<Mood, string> moodToEmoji = new Dictionary<Mood, string>
{
    { Mood.Happy, "\U0001F603" },      // 😃
    { Mood.Sad, "\U0001F61E" },        // 😞
    { Mood.Excited, "\U0001F604" },    // 😄
    { Mood.Calm, "\U0001F60C" },       // 😌
    { Mood.Angry, "\U0001F620" }       // 😠
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

Console.WriteLine("Press ENTER to exit.");
Console.ReadLine();

enum Mood { Happy = 1, Sad, Excited, Calm, Angry }

