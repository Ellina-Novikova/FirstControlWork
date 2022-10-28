int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    int n = Convert.ToInt32(Console.ReadLine());
    while (n < 1) n = GetNumberFromConsole(text);
    return n;
}

string GetStringFromConsole(string text)
{
    Console.WriteLine(text);
    return Console.ReadLine();
}

bool Choice(string text)
{
    Console.WriteLine();
    Console.WriteLine(text);
    Console.WriteLine("ДА - введите 1");
    Console.WriteLine("НЕТ - введите 0");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n == 1) return true;
    if (n == 0) return false;
    else return Choice(text);        
}

void FillArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = GetStringFromConsole($"Введите {i + 1}-ю строку:");
    }
    Console.WriteLine();
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
  string[] array = {"Раз", "два", "три", "четыре", "пять", "я", "иду", "тебя", "искать!"}; 
  if (!Choice("Использовать заданный массив?"))
    {
        array = new string[GetNumberFromConsole("Введите количество элементов в массиве")];
        FillArray(array);
    }
Console.WriteLine();  
Console.WriteLine("Задан массив строк");
PrintArray(array);
Console.WriteLine();
int limit = GetNumberFromConsole("Максимальное количество символов в строке? = ");
Console.WriteLine();
Console.WriteLine("Новый массив строк");
PrintArray(GetArrayOfLimitStrings(array, limit));
