void Recursion(int number)
{
    int newNum = number--;
    Console.WriteLine(newNum);
    if (newNum != 1)
        Recursion(number);
}

Recursion(10);