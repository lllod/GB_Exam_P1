/*
Написать программу, которая из имеюшегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/

void PrintArray(string[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

string[] FilteredArray(string[] arr)
{
    int filteredArrayLength = (from element in arr where element.Length <= 3 select element).Count();
    string[] filteredArray = new string[filteredArrayLength];
    int index = 0;
    foreach(string element in arr)
    {
        if(element.Length <= 3) filteredArray[index++] = element;
    }
    return filteredArray;
}


string[] array = {"hello", "2", "world", ":-)"};
// string[] array = {"Russia", "Denmark", "Kazan"};
// string[] array = {"1234", "1567", "-2", "computer science"};
System.Console.Write("Изначальный массив: ");
PrintArray(array);
System.Console.Write("Отфильтрованный массив: ");
PrintArray(FilteredArray(array));