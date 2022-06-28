
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
void DecreaseElement(int[,] array)
{
    int arr;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = 1; j < array.GetLength(1) - k; j++)
            {
                if (array[i, j - 1] < array[i, j])
                {
                    arr = array[i, j - 1];
                    array[i, j - 1] = array[i, j];
                    array[i, j] = arr;
                }

            }

        }
    }
    PrintArray(array,"Массив, элементы строк которого убывают, имеет вид:");
}
int firstDemension = CheckingForCorrectnes("Введите число строк m двумерного массива:");
int secondDemension = CheckingForCorrectnes("Введите число столбцов n двумерного массива:");
int[,] ArrayResult = Array(firstDemension, secondDemension);
PrintArray(ArrayResult, "Массив имеет следующий вид:");
DecreaseElement(ArrayResult);