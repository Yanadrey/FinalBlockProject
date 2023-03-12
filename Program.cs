// Написать программу, которая из имеющегося массива строк формирует массив
// из строк, длина которых меньше либо равна три символа.

string[] InputArray(string text)
{
    System.Console.Write(text);
    var array = Array.ConvertAll(Console.ReadLine().Split(", "), Convert.ToString);
    return array;
}

void PrintArray(string[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}

string[] myArray = InputArray("Введите строки через запятую и пробел: ");
PrintArray(myArray);
