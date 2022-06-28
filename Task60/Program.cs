//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

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
int[,,] RandomArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    Random rnd = new Random();
    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int k = 0; k < z; k++)
            {
                int value = 0;
                bool uniquevalue = false;
                while (!uniquevalue)
                {
                    value = rnd.Next(10, 100);
                    uniquevalue = IsUnique(value, array);
                }
                array[i, j, k] = value;
            }
    return array;
}
bool IsUnique(int value, int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (value == array[i, j, k])
                    return false;
            }

        }
    }
    return true;
}
void PrintArray(int[,,] array, string str)
{
    Console.WriteLine(str);
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"[{i},{j},{k}] = {array[i, j, k]}\n");

}
int firstDemension = CheckingForCorrectnes("Введите размерность 1-го измерения трехмерного массива:");
int secondDemension = CheckingForCorrectnes("Введите размерность 2-го измерения трехмерного массива:");
int threeDemension = CheckingForCorrectnes("Введите размерность 3-го измерения трехмерного массива:");
if (firstDemension * secondDemension * threeDemension > 90)
    Console.WriteLine("Количество уникальных значений массива не может быть больше 90!");
else
{
    int[,,] ArrayResult = RandomArray(firstDemension, secondDemension, threeDemension);
    PrintArray(ArrayResult, "Элементы матрицы имеют вид:");
}

