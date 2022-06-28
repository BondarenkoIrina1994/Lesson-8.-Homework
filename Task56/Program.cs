//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int CheckingForCorrectnes(string str)
{
    while (true)
    {
        Console.WriteLine(str);
        string num = Console.ReadLine();
        if (int.TryParse(num, out int number) == false)
            Console.WriteLine("Вы ввели не число. Для корректной работы программы введите число!!!");
        else
        {
            if (number <= 0)
                Console.WriteLine("Необходимо ввести число больше ноля!!!");
            else
                return number;
        }
    }
}
int[,] Array(int firstDemension, int secondDemension)
{
    int[,] array = new int[firstDemension, secondDemension];
    Random rnd = new Random();
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemension; j++)
            array[i, j] = rnd.Next(0, 101);
    }
    return array;
}
void PrintArray(int[,] array, string str)
{
    Console.WriteLine(str);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");
            else
                Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void MinSumElement(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            sum[i] += array[i, k];
        }
    }
    int min = sum[0];
    int ii = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] <= min)
        {
            min = sum[i];
            ii = i;
        }
    }
    Console.Write($"{ii + 1}-я строка: ");
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[ii, j]} ");
    Console.Write($"имеет наименьшую сумму элементов равную {min}");
}
int firstDemension = CheckingForCorrectnes("Введите число строк m двумерного массива:");
int secondDemension = CheckingForCorrectnes("Введите число столбцов n двумерного массива:");
int[,] ArrayResult = Array(firstDemension, secondDemension);
PrintArray(ArrayResult, "Массив имеет следующий вид:");
MinSumElement(ArrayResult);