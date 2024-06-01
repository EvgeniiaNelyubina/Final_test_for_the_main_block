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