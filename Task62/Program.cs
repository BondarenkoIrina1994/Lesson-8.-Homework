//Заполните спирально массив 4 на 4.

void SpiralElements(int[,] arr)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= arr.GetLength(0) * arr.GetLength(1))
    {
        arr[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < arr.GetLength(1) - 1)
            j++;
        else
        if (i < j && i + j >= arr.GetLength(0) - 1)
            i++;
        else
        if (i >= j && i + j > arr.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    PrintArray(arr, "Спирально заполненная матрица имеет вид:");
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
int firstDemension = 4;
int secondDemension = 4;
int[,] Array = new int[firstDemension, secondDemension];
SpiralElements(Array);
