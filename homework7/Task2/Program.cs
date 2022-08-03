//Программа на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет

int [,] CreateRandom2dArray() 
{
    int n = 4;
    int m = 5;
    Random random = new Random();
    int[,] newArray = new int[n,m]; 

    for(int i = 0; i < newArray.GetLength(0); i++)
        for(int j = 0; j < newArray.GetLength(1)-1; j++) 
            newArray[i,j] = random.Next(1,99);
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) 
            Console.Write( array[i, j] + " ");

    Console.WriteLine();
    }
}


void FindElement (int[,] array, int m, int n)
{
    if (n < 0 | n > array.GetLength(0) - 1 | m< 0 | m > array.GetLength(1) - 1)
    {
        Console.WriteLine("Element is not exist");
    }
    else
    {
        Console.WriteLine(array[n, m]);
    }
Console.ReadLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();

Console.Write("Input row ");
int n = Convert.ToInt32(Console.ReadLine())-1;
Console.Write("Input tabble ");
int m = Convert.ToInt32(Console.ReadLine())-1;

FindElement(myArray, n, m);
