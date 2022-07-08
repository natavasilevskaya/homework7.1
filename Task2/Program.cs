// программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int n1, n2, n3;

Console.WriteLine("Imput number1: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput number2: ");
n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput number3: ");
n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (n2 > max) max = n2;
if (n3 > max) max = n3;
Console.Write("Max number is " + max);
