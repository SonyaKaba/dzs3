Console.WriteLine("enter number: ");
int number = int.Parse(Console.ReadLine());

void CubeMe (int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write(Math.Pow(i, 3));
        Console.WriteLine();
    }
}

CubeMe(number);
