void PrintArray(string[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}
string[] str = { "hello", "2", "world", ":-)" };
var result = new string[str.Length];
var realSize = 0;