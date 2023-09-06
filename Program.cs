Console.WriteLine("Введите текстовый массив (допускается использование буквенных и числовых символов):");
Console.WriteLine("Пример массива: 257, 45, hello, world, res, 456");
Console.WriteLine("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine());
string[] array1 = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write("Введите элемент массива: ");
    string result = Console.ReadLine();
    array1[i] = result;
}
Console.WriteLine();
Console.Write("Введенный массив: [");
Console.Write(string.Join(",", array1));
Console.Write("]");
string[] array2 = new string[array1.Length];
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}
SecondArray(array1, array2);
Console.WriteLine();
Console.Write("Полученный массив:");
PrintArray(array2);