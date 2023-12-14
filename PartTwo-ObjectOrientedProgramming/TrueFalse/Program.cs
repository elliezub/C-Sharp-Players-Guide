
// Do not edit these lines
Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
string entry = Console.ReadLine();
Tools.SetUpInputStream(entry);

// Type your code below
string[] questions = new string[]
{
      "True or false: The Earth is flat.",
      "True or false: Water boils at 100 degrees Celsius at sea level.",
      "True or false: C# is a programming language.",
      "True or false: The sun rises in the west and sets in the east.",
      "True or false: Cats can fly."
};

bool[] answers = new bool[] { false, true, true, false, false };

bool[] responses = new bool[questions.Length];

if (questions.Length != answers.Length)
{
    Console.WriteLine("error! arrays not equal");
}

int askingIndex = 0;

foreach (string question in questions)
{
    string input;
    bool isBool = true;
    bool inputBool;

    Console.WriteLine(question);
    input = Console.ReadLine();

    isBool = Boolean.TryParse(input, out inputBool);

    while (!isBool)
    {
        Console.WriteLine("Please respond with true or false");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);
    }

    responses[askingIndex] = inputBool;
    askingIndex++;
}

int scoringIndex = 0;
int score = 0;

foreach (bool answer in answers)
{
    bool userResponse = responses[scoringIndex];
    Console.WriteLine($"{scoringIndex + 1}. Input: {userResponse} | Answer: {answer}");

    if (userResponse == answer)
    {
        score++;
    }

    scoringIndex++;
}

Console.WriteLine($"You got {score} out of {questions.Length} correct!");

