// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void PrintMyArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    Console.Write("[ ");
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count ++;
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"\b\b ] -> {count}");
}

Console.Write("Введите количество элементов массива:\t");
int elementsArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elementsArray];

PrintMyArray(array);