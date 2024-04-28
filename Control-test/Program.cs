using System;

class Program
{
    static void Main()
    {
        string[] sourceArray = { "Hello", "2", "world", ":-)" };
        string[] resultArray = new string[sourceArray.Length];
        
        int resultIndex = 0;
        foreach (var item in sourceArray)
        {
            if (item.Length <= 3)
            {
                resultArray[resultIndex++] = item;
            }
        }

        // Обрезаем результирующий массив до фактического размера с результатами
        Array.Resize(ref resultArray, resultIndex);

        // Вывод результирующего массива
        Console.WriteLine("[" + string.Join(", ", sourceArray) + "] → [" + string.Join(", ", resultArray) + "]");
    }
}
