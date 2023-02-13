// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 
// 4,6; 5,6; 3,6; 3.


// Функции
int Promt(string msg) // ввод данных
{
    System.Console.Write(msg + "-> ");
    return int.Parse(Console.ReadLine());
}

int[,] CreateArray(int lenghtStr, int lenghtCol) // создание массива
{
    int[,] array = new int[lenghtStr, lenghtCol];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array) // вывод массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] FindAverage(int[,] array) // среднее арифметическое элементов в каждом столбце
{
    double[] avg = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            avg[j] += array[i, j];
        }
    }
    for (int i = 0; i < avg.Length; i++)
    {
        avg[i] /= array.GetLength(0);
    }
    return avg;
}

// Задаем размер массива
int lenStr = Promt("Введите количество строк");
int lenCol = Promt("Введите количество столбцов");

// Создаем двумерный массив
int[,] Array = CreateArray(lenStr, lenCol);

// выводим двумерный массив
PrintArray(Array);

// вычисляем среднее арифметическое каждого столбца
double[] Avg = FindAverage(Array);

// выводим среднее арифметическое каждого столбца массива
Console.WriteLine("Среднее арифметическое каждого столбца:");
for (int i = 0; i < Avg.Length; i++)
{
    Console.Write($"{Avg[i]:F1}; ");
}







