// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



static void RealNambersArray()
{
    // случайное количество элементов массива
    int n = new Random().Next(1, 10);   

    double[] array = new double[n];
    double max = double.MinValue;
    double min = double.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().NextDouble();

            if (array[i] < min) 
            {
            min = array[i];
            }
            if (array[i] > max) 
            {
            max = array[i];
            }

        }
        System.Console.WriteLine($"[{String.Join(", ", array)}] -> {max - min}");
}
RealNambersArray();
