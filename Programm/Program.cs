// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//   либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//    лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.Clear();
Console.Write($"Из имеющегося массива строк сформировать новый массив из строк,\nдлина которых меньше, либо равна 3 символам \n\n");
//string[] array1 = new string[4] { "Hello", "2", "world", ":-)" };
string[] array1 = new string[4] { "1234", "1567", "-2", "computer science" };
//string[] array1 = new string[3] { "Russia", "Denmark", "Kazan" };
string str = string.Join(" ", array1);
Console.Write($"Исходные данные \t");
Console.WriteLine(str);
Console.Write($"Результат \t");
string[] array2 = new string[array1.Length];
int count = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[count] = array1[i];
        Console.Write(array2[count]);
        count++;
    }
}
