// программа на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int number;

Console.WriteLine("Input number: ");
number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
{
    Console.Write(number + " is an even number!");
}
if (number == 13)
{
    Console.Write(number + " is an odd number! And it is Devil's number arrr!!!");
}
else
{
    Console.Write(number + " is an odd number!");
}
