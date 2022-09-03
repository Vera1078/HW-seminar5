// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] RandomArray (int number)
{

int[] array = new int[number];

    for (int i = 0; i < array.Length; i++)
    {           
        array[i] = new Random().Next(100, 1000);        
    }
        Console.WriteLine($"Массив: {String.Join(", ", array)}");
    
    return array;
 }

 void CounterOfElements (int[] array)
 {

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
        count++;
        }
 }

Console.WriteLine($"Количество четных элементов = {count}");
}

CounterOfElements(RandomArray(10));

