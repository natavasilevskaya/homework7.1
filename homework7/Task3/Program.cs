// Программа задает двумерный массив из целых чисел. Программа находит среднее арифметическое элементов в каждом столбце.

double [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) 
{
    double[,] newArray = new double[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue);
    return newArray;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

    Console.WriteLine();
    }
}

void Average(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {   double sum = 0;
        double average = 0;

        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
            average = sum / array.GetLength(1);
        } 
    Console.Write("{0,4:F1}",average);
    }
}



Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, 1, 9);
Show2dArray(myArray);
Console.WriteLine();
Average(myArray);

