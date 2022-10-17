Console.WriteLine("Введите номер задачи от 1 до 3:");
string problem = Console.ReadLine()!;

switch (problem)
{   case "1":
    // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    // Напишите программу, которая покажет количество чётных чисел в массиве.
    // [345, 897, 568, 234] -> 2
    Console.WriteLine("Задание 1;");
    int[] Arrat = GetArray(10,100,999);
    Console.WriteLine($"[{String.Join(",", Arrat)}]");
    Fit(Arrat);
    void Fit(int[] array)
    {   
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0){
            result++;}
        }
        if (result % 10 == 1)
        {
            Console.WriteLine($"В Массиве {result} четных числе");
        }
        if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
        {
            Console.WriteLine($"В Массиве {result} четных числе");
        }
        else{ Console.WriteLine($"В Массиве {result} четных числе");}
    }
    break;
    case "2":
    // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    // [3, 7, 23, 12] -> 19
    // [-4, -6, 89, 6] -> 0
    Console.WriteLine("Задание 2;");
    int[] Arr = GetArray(10,-100,100);
    Console.WriteLine($"[{String.Join(",", Arr)}]");
    SumArr(Arr);
    void SumArr(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                result += array[i];
            }
        }
        Console.WriteLine($"Сумма четных элементов равна {result}");
    }

    break;  
    // Задача 38: Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, 
    // с дробными не работаем). Найдите разницу между максимальным и минимальным элементов массива.
    // [3 7 22 2 78] -> 76 
    case "3":
    Console.WriteLine("Задание 3;");
    int[] Arrs = GetArray(10,0,100);
    Console.WriteLine($"[{String.Join(",", Arrs)}]");
    Raznst(Arrs);
    void Raznst(int[] array)
    {
        int min = array[0];
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>max) max = array[i];
            
            if (array[i]< min) min = array[i];
        }
        Console.WriteLine($"Разница между минимальным и максимальным значениями в массиве равна {max - min}");
    }
    break;
}

// Метод заполнения массива
int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        
    }
    return res;
}
