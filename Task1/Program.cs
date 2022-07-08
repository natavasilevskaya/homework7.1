// программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int n1, n2;

Console.WriteLine("Imput number1: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Imput number2: ");
n2 = Convert.ToInt32(Console.ReadLine());

int max = n1;
int min = n2;

if (n2>max) 
{
    max = n2;
    min = n1;
}

Console.WriteLine("Max number is " + max);
Console.WriteLine("Min number is " + min);