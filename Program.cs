// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;

class Program
{
    static string[] FilterStrings(string[] array)
    {
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

         string[] filteredArray = new string[count];
        int index = 0;

        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                filteredArray[index] = str;
                index++;
            }
        }

        return filteredArray;
    }

     static void Main(string[] args)
    {
        Console.Write("Введите количество строк в массиве: ");
        int n = int.Parse(Console.ReadLine());

        string[] inputArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите строку {0}: ", i + 1);
            inputArray[i] = Console.ReadLine();
        }

        string[] filteredArray = FilterStrings(inputArray);

        Console.WriteLine("Отфильтрованный массив:");
        if (filteredArray.Length == 0)
        {
            Console.WriteLine("Таких строк в массиве не найдено");
        }
        else
        {
            foreach (string str in filteredArray)
            {
                Console.WriteLine(str);
            }
        }
    }
}