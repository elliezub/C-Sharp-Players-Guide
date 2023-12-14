makeArrow();

void makeArrow()
{
    string[] validArrowheads = { "steel", "wood", "obsidian" };
    string arrowHeadChoice = "";
    while (!validArrowheads.Contains(arrowHeadChoice.ToLower()))
    {
        Console.WriteLine("Choose a type of arrowhead (steel, wood, or obsidian):");
        arrowHeadChoice = Console.ReadLine();
        if (!validArrowheads.Contains(arrowHeadChoice.ToLower()))
        {
            Console.WriteLine("Invalid choice. Please select from steel, wood, or obsidian.");
        }
    }

    string[] validFletchings = { "plastic", "turkey feathers", "goose feathers" };
    string fletchingChoice = "";
    while (!validFletchings.Contains(fletchingChoice.ToLower()))
    {
        Console.WriteLine("Choose a type of fletching (plastic, turkey feathers, or goose feathers):");
        fletchingChoice = Console.ReadLine();
        if (!validFletchings.Contains(fletchingChoice.ToLower()))
        {
            Console.WriteLine("Invalid choice. Please select from plastic, turkey feathers, or goose feathers.");
        }
    }

    int lengthChoice = 0;
    while (lengthChoice < 60 || lengthChoice > 100)
    {
        Console.WriteLine("Choose a length between 60 and 100 (in cm):");
        if (!int.TryParse(Console.ReadLine(), out lengthChoice) || lengthChoice < 60 || lengthChoice > 100)
        {
            Console.WriteLine("Invalid input. Please enter a number between 60 and 100.");
            lengthChoice = 0; 
        }
    }

    Arrow yourArrow = new Arrow(arrowHeadChoice, fletchingChoice, lengthChoice);

    float totalCost = yourArrow.GetCost();
    Console.WriteLine($"Your arrow is made of {arrowHeadChoice} and {fletchingChoice}, and it is {lengthChoice} cm long.");
    Console.WriteLine($"The total cost of your arrow is: {totalCost} gold.");
}


public class Arrow
{
    public string ArrowHead { get; set; }
    public string Fletching { get; set; }
    public int Length { get; set; }

    public Arrow(string arrowHead, string fletching, int length)
    {
        ArrowHead = arrowHead;
        Fletching = fletching;
        Length = length;
    }

    // need get cost to return the total cost
    // steel = 10 gold, wood = 3 gold, obsidian = 5 gold
    // plastic = 10 gold, turkey feathers = 5 gold, goose feathers = 3 gold
    // also add .05 gold per cm of length
    public float GetCost()
    {
        float cost = 0f;

        // Cost of arrowheads
        switch (ArrowHead.ToLower()) // Use ToLower to ensure consistent comparison
        {
            case "steel":
                cost += 10f;
                break;
            case "wood":
                cost += 3f;
                break;
            case "obsidian":
                cost += 5f;
                break;
        }

        // Cost of fletching
        switch (Fletching.ToLower()) // Use ToLower to ensure consistent comparison
        {
            case "plastic":
                cost += 10f;
                break;
            case "turkey feathers":
                cost += 5f;
                break;
            case "goose feathers":
                cost += 3f;
                break;
        }

        // Cost of length (0.05 gold per cm, Length is in inches so convert to cm)
        cost += Length * 0.05f;

        return cost;
    }

}


