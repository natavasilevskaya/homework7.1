// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int SecondDigit(int n1)
{
    int twodig = n1/10;
    int result = twodig % 10;
    return result;
}

int number;
Console.WriteLine("Input your number: ");
number = Convert.ToInt32(Console.ReadLine());
int result = SecondDigit(number);
Console.WriteLine("Second digit" + result);