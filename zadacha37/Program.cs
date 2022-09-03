// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Введите элементы массива через пробел: ");

string elements = Console.ReadLine();
int[] MyArray = NewArray(elements);

Console.WriteLine(String.Join(" ", ResultArray(MyArray)));


int[] NewArray(string stringArray)
{
    string[] numbers = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numbers.Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        result[i] = int.Parse(numbers[i]);
    }
    return result;
}


int[] ResultArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) 
    {
        size++;
    }

    int[] result = new int[size];

    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 == 1) 
    {
    result[size-1] = array[array.Length / 2];
    }
    return result;
}
