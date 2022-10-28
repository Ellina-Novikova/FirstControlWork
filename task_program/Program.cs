// 
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}



void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



int CountStringsInArray(string[] arr, int limit)
{
   int count = 0;
   for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= limit) count++;
    }
    return count; 
} 

string[] GetArrayOfLimitStrings(string[] arr, int limit)
{
    string[] array = new string[CountStringsInArray(arr, limit)];
    int j = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= limit)
        {
            array[j] = arr[i];
            j++;
        }
    }
    return array; 
}


// КОД ОСНОВНОЙ ПРОГРАММЫ

string[] array1 = {"Раз", "два", "три", "четыре", "пять", "я", "иду", "тебя", "искать!"};
int limit = GetNumberFromConsole("Максимальное количество символов в строке? = ");
Console.WriteLine("Задан массив строк");
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Новый массив строк");
PrintArray(GetArrayOfLimitStrings(array1, limit));
