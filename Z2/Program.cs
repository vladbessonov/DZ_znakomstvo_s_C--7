// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Ответ:
// 1, 7 -> такого числа в массиве нет
// 1, 1 - > 1

// Функции
int Promt(string msg)
{
    System.Console.Write(msg + "-> ");
    return int.Parse(Console.ReadLine());
}

int[,] CreateArray(int lenghtStr, int lenghtCol)
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

void PrintArray(int[,] array)
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
// Задаем позицию элемента
int Str = Promt("Введите номер строки");
int Col = Promt("Введите номер столбца");
// Создаем двумерный массив
int[,] Array = CreateArray(lenStr, lenCol);
// выводим двумерный массив
PrintArray(Array);

if (Str < 1 || Str > lenStr || Col < 1 || Col > lenCol)
{
    Console.WriteLine($"({Str}, {Col}) -> Такого элемента в массиве нет");
}
else
{
    Console.WriteLine($"Значение элемента {Str} строки и {Col} столбца равно {Array[Str-1,Col-1]}");
}












