Console.WriteLine("enter number: ");
string number = Console.ReadLine();
// 0 1 2 3 4
void Pali(string number)
{
    if (number[0] == number [4] && number[1] == number[3]) 
    {
        Console.WriteLine($"Your number {number} is palindrome!");
    }
    else Console.WriteLine($"Your number {number} is not palindrome!");
}

if (number.Length == 5)
{
    Pali(number);
}
else Console.WriteLine("enter five-digit number");

