//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// функции
int Promt(string msg)
{
    System.Console.Write(msg + "-> ");
    return int.Parse(Console.ReadLine());
}

double[,] CreateArray(int lenghtStr, int lenghtCol)
{
    double[,] array = new double[lenghtStr, lenghtCol];
    Random rnd = new Random();
       for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = Convert.ToDouble(rnd.Next(-1000, 1000))/100;
        }
    }
    return array;
}

void PrintArray(double[,] array)
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

// Задаем размер массива
int lenStr = Promt("Введите количество строк");
int lenCol = Promt("Введите количество столбцов");
// Создаем двумерный массив
double[,] Array = CreateArray(lenStr, lenCol);
// выводим двумерный массив
PrintArray(Array);









