// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] RandomArray (int number)
{

int[] array = new int[number];

    for (int i = 0; i < array.Length; i++)
    {           
        array[i] = new Random().Next(-100, 100);        
    }
        Console.WriteLine($"Массив: {String.Join(", ", array)}");
    
    return array;
 }

void SumOfElements (int[] array)
 {

    int sum = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0) sum += array[i];
        
    }

Console.WriteLine($"Сумма элементов нечетных позиций = {sum}");
}

SumOfElements(RandomArray(10));
