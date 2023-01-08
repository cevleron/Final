string[] array = new string[] { "hello", "2", "world", ":-)" };
string[] array2 = new string[array.Length];

void NewMassive(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
NewMassive(array, array2);
PrintArray(array2);