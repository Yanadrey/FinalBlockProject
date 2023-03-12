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

int CountLessFourSimbolsElements(string[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            result++;
    return result;
}

// string[] LessFourSimbolsArray(string[] array)
// {
//     string[] newArray = new string[];

//     for (int i = 0; i < array.Length; i++)
//     {

//     }
// }

string[] myArray = InputArray("Введите строки через запятую и пробел: ");
PrintArray(myArray);

int sizeNewArray = CountLessFourSimbolsElements(myArray);
System.Console.WriteLine(sizeNewArray);
