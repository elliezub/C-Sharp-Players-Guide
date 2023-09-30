// All 14 types of variables
bool lovesCats = true;
string catName = "Fluffy";
byte catLives = 9; //8 bit unsigned integer
short catLength = 54; //16-bit signed integer
int catWhiskerCount = 24; // 32-bit signed integer
long totalCatHairs = 6349523509834L; //64-bit signed integer
sbyte catMood = 5; //8-bit signed integer
ushort whiskerLengthInMm = 100; //16-bit unsigned integer
uint catClawsCount = 20; //32-bit unsigned integer
ulong catHeartbeatsSinceBirth = 102431403243L; // 64-bit unsigned integer
char favoriteLetter = 'M'; //16-bit unicode
float catJumpHeightMeters = 1.5f; // 32-bit single-precision floating point
double catSpeedMph = 15.34;// 64-bit double precision floating point type
decimal catWeightInKg = 6.5m;// 128-bit decimal value

Console.WriteLine($"Do you love cats? {lovesCats}. Let's talk about {catName}!");
Console.WriteLine($"{catName} has {catLives} lives left, is {catLength} cm long, and weighs {catWeightInKg} kg.");
Console.WriteLine($"With {catWhiskerCount} whiskers that are {whiskerLengthInMm} mm long, and a total of {totalCatHairs} hairs, {catName} is quite unique.");
Console.WriteLine($"Her mood index is {catMood}, and she has {catClawsCount} sharp claws.");
Console.WriteLine($"Since her birth, her heart has beaten {catHeartbeatsSinceBirth} times.");
Console.WriteLine($"{catName}'s favorite letter is '{favoriteLetter}', she can jump {catJumpHeightMeters} meters high, and her top speed is {catSpeedMph} mph.");
// Signed:
// Can represent both negative and positive numbers (including zero).
// If you have an n-bit signed number, one bit is used for the sign 
// (typically the most significant bit). A 0 in the sign bit indicates a positive number, 
// while a 1 indicates a negative number.
// Because one bit is used for the sign, the range of the number is divided to accommodate 
// both negative and positive values.

// Unsigned:
// Can represent only non-negative numbers (from 0 upwards).
// All bits are used to represent the value of the number. This means an unsigned type can 
// represent larger positive numbers than its corresponding signed type, but it cannot represent 
// negative numbers.

// Use signed types when you need to represent negative values.
// Use unsigned types when you only need to represent positive values, 
// and you can benefit from the extended range of positive values offered by the type.