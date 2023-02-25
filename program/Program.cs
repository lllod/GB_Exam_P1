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

int FilteredArrayLength(string[] arr)
{
    int index = 0;
    foreach(string element in arr)
    {
        if(element.Length <= 3) index++;
    }
    return index;
}

string[] FilteredArray(string[] arr)
{
    string[] filteredArray = new string[(FilteredArrayLength(arr))];
    int index = 0;
    foreach(string element in arr)
    {
        if(element.Length <= 3) filteredArray[index++] = element;
    }
    return filteredArray;
}


string[] array = {"1233", "abc", "2", "???", "0)12", "-g", "gr"};
PrintArray(array);
PrintArray(FilteredArray(array));