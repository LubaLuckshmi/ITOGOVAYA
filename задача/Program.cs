// Написать программу, которая из имеющегося массива строк формирует массив
//  из строк, длина которых меньше либо равна 3 символа. 
//  Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте
// выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ".-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"7]
// ["Russia", "Denmark", "Kazan"] -> []

string[] array = { "hello", "2", "world", ".-)", "123", "привет", "эхо"};
PrintArray(array);
string[] array3Char = Array3Char(array);
Console.WriteLine();
PrintArray(array3Char);

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

string[] Array3Char(string[] array)
{
    int count = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    string[] finalArray = new string[count];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <=3 )
        {
            finalArray[index] = array[j];
            index++;
        }
    }
    return finalArray;
}
