
char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

Console.WriteLine("enter a message that you want to encrypt:");
string message = Console.ReadLine();

char[] secretMessage = message.ToCharArray();

char[] encryptedMessage = new char[secretMessage.Length];

for (int i = 0; i < secretMessage.Length; i++)
{
    char secretChar = secretMessage[i];
    int indexOfChar = Array.IndexOf(alphabet, secretChar);

    int newCharIndex = (3 + indexOfChar) % 26;
    char newChar = alphabet[newCharIndex];

    encryptedMessage[i] = newChar;
}

string newMessage = String.Join("", encryptedMessage);
Console.WriteLine(newMessage);

