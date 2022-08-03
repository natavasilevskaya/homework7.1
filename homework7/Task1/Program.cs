// Задать двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] FillArrayDouble (int rows, int columns, int m, int n)
{
    Random random = new Random();
    double[,] newArray = new double[rows,columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            newArray[i, j] = random.NextDouble() * 99;

    }
    return newArray;
    }


void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write( "{0,5:F1}", array[i, j]);

    Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = FillArrayDouble(m, n, 1, 9);
Show2dArray(myArray);


