//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int CheckingForCorrectnes(string str)
{
    while (true)
    {
        Console.WriteLine(str);
        string num = Console.ReadLine();
        if (int.TryParse(num, out int number) == false)
            Console.WriteLine("Введено некорректное значение. Для работы программы введите целое число!!!");
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
void MultiplicationArray(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        int[,] arr = new int[array1.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1); k++)
                    arr[i, j] += array1[i, k] * array2[k, j];
            }
        }
        PrintArray(arr, "Произведение двух матриц равно:");
    }
    else Console.WriteLine("Такие матрицы нельзя перемножить, необходимо, чтобы число столбцов первой матрицы было равно числу строк второй матрицы!!!");
}
int firstDemension1 = CheckingForCorrectnes("Введите число строк m первой матрицы:");
int secondDemension1 = CheckingForCorrectnes("Введите число столбцов n первой матрицы:");
int firstDemension2 = CheckingForCorrectnes("Введите число строк m второй матрицы:");
int secondDemension2 = CheckingForCorrectnes("Введите число столбцов n второй матрицы:");
int[,] ArrayResult1 = Array(firstDemension1, secondDemension1);
PrintArray(ArrayResult1, "Первая матрица имеет вид:");
int[,] ArrayResult2 = Array(firstDemension2, secondDemension2);
PrintArray(ArrayResult2, "Вторая матрица имеет вид:");
MultiplicationArray(ArrayResult1, ArrayResult2);