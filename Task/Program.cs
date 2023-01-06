// // Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из 
// строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите массив через пробел: ");
string[] array = Console.ReadLine().Split().ToArray();

string[] SortArray (string[] arr1){
    string[] tempArr = new string[arr1.Length];
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            tempArr[count] = arr1[i];
            count++;
        }
    }
    return tempArr;
}

void PrintArray (string[] arr){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
